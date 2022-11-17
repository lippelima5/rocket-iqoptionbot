using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using RocketBuy.Models;
using Newtonsoft.Json;

namespace RocketBuy
{
    public class Base
    {
        public static string APP_NAME { set; get; }
        public static string APP_VERSION { set; get; }
        public static bool INICIADO { set; get; }
        public static string CREDENCIAIS_FILE { set; get; }
        public static List<Conta> CONTAS { set; get; }
        public static List<Paridade> PARIDADES { set; get; }
        public static List<Log> LOGS { set; get; }


        public static void LoadConfig()
        {
            CONTAS = new List<Conta>();
            PARIDADES = new List<Paridade>();
            LOGS = new List<Log>();

            APP_NAME = ConfigurationManager.AppSettings["APP_NAME"];
            APP_VERSION = ConfigurationManager.AppSettings["APP_VERSION"];


            string PARIDADES_FILE = @"paridades.txt";
            if (File.Exists(PARIDADES_FILE))
            {
                string[] lines = File.ReadAllLines(PARIDADES_FILE);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line) && line.Length > 0)
                    {
                        PARIDADES.Add(new Paridade
                        {
                            Par = line,
                        });
                        
                    }

                }
            }
            else
            {
                File.Create(CREDENCIAIS_FILE).Dispose();
            }


            CREDENCIAIS_FILE = @"credenciais.txt";

            if (File.Exists(CREDENCIAIS_FILE))
            {
                string[] lines = File.ReadAllLines(CREDENCIAIS_FILE);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line) && line.Length > 0)
                    {
                        var credencial = line.Split(";");
                        if (credencial.Length > 0)
                        {
                            
                            CONTAS.Add(new Conta
                            {
                                Email = credencial[0],
                                Senha = credencial[1],
                                Entrada = Convert.ToInt32(credencial[2]),
                                OperarReal = credencial[3].ToLower() == "true"
                            });
                            Console.WriteLine(credencial[0] + " contas encontradas e preparadas");
                        }
                    }
                }
            }
            else
            {
                File.Create(CREDENCIAIS_FILE).Dispose();
            }
        }
    }
}

using RocketBuy;
using RocketBuy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RocketBuy
{
    public partial class F_GERENCIAR : Form
    {
        public F_GERENCIAR()
        {
            InitializeComponent();
        }

        private void F_ADD_Load(object sender, EventArgs e)
        {
            LoadDados();
        }

        public void LoadDados()
        {
            T_EMAIL.Clear();
            T_SENHA.Clear();
            T_VALOR.Value = 2;
            C_REAL.Checked = false;

            var source = new BindingSource(Base.CONTAS, null);
            G_CONTAS.DataSource = source;
        }

        private void B_SALVAR_Click(object sender, EventArgs e)
        {
            string path = Base.CREDENCIAIS_FILE;
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, false);
            foreach (var item in Base.CONTAS)
            {
                tw.WriteLine(item.Email + ";" + item.Senha + ";" + item.Entrada + ";" + item.OperarReal);
            }
            tw.Close();


            this.Close();
        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(T_EMAIL.Text))
            {
                if (!string.IsNullOrWhiteSpace(T_SENHA.Text))
                {
                    Base.CONTAS.Add(new Conta
                    {
                        Email = T_EMAIL.Text,
                        Senha = T_SENHA.Text,
                        Entrada = (int)T_VALOR.Value,
                        OperarReal = C_REAL.Checked
                    });

                    LoadDados();
                }
                else
                {
                    MessageBox.Show("Senha inválido!", "Inválido");
                }
            }
            else
            {
                MessageBox.Show("Email inválido!", "Inválido");
            }
        }

        private void B_REMOVER_Click(object sender, EventArgs e)
        {
            if (G_CONTAS.SelectedCells.Count > 0)
            {
                int selectedrowindex = G_CONTAS.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = G_CONTAS.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Email"].Value);

                if (Base.CONTAS.Exists(x => x.Email == cellValue))
                {
                    Base.CONTAS.RemoveAt(Base.CONTAS.FindIndex(a => a.Email == cellValue));
                    LoadDados();
                }
                else
                {
                    MessageBox.Show("Email não existe na lista, salve e reinicie o sistema.");
                }

            }
            else
            {
                MessageBox.Show("Selecione uma conta para remover.","Nada para remover");
            }
        }
    }
}

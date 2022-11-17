using RocketBuy.Models;
using IqOptionApiDotNet.Models.DigitalOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IqOptionApiDotNet;
using IqOptionApiDotNet.Models;
using Newtonsoft.Json;

namespace RocketBuy
{
    public partial class F_MAIN : Form
    {
        List<Task> Tasks = new List<Task>();


        public F_MAIN()
        {
            InitializeComponent();
        }

        private void F_MAIN_Load(object sender, EventArgs e)
        {

            LoadFields();

        }

        bool PrepararCompra(OrderDirection Direction)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(L_PARIDADES.Text.ToString()))
                {
                    ActivePair Active = (ActivePair)Enum.Parse(typeof(ActivePair), L_PARIDADES.Text.ToString());


                    if (!string.IsNullOrWhiteSpace(L_TIMEFRAME.Text.ToString()))
                    {
                        string timeFrame = L_TIMEFRAME.Text;
                        if (R_BINARIA.Checked)
                        {

                            foreach (Conta conta in Base.CONTAS)
                            {
                                Tasks.Add(Task.Run(() => Comprar(1, Active, Direction, timeFrame, conta)));
                            }
                            return true;

                        }
                        else if (R_DIGITAL.Checked)
                        {
                            foreach (Conta conta in Base.CONTAS)
                            {
                                Tasks.Add(Task.Run(() => Comprar(2, Active, Direction, timeFrame, conta)));
                            }

                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Você não selecionou o modo de operação");

                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Você não selecionou o TimeFrame");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Você não selecionou a paridade");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        async void Comprar(int modo, ActivePair Active, OrderDirection Direction, string TimeFrame, Conta conta)
        {



            if (modo == 1)
            {
                //M1
                //M5
                //M15
                DateTimeOffset exp = DateTimeOffset.Now;
                bool entrar = false;

                if (TimeFrame == "M1")
                {
                    exp = exp.AddMinutes(1).AddSeconds(-exp.Second);
                    entrar = true;
                }
                else if (TimeFrame == "M5")
                {
                    exp = exp.AddMinutes(5).AddSeconds(-exp.Second);
                    entrar = true;
                }
                else if (TimeFrame == "M15")
                {
                    exp = exp.AddMinutes(15).AddSeconds(-exp.Second);
                    entrar = true;
                }
                else
                {
                    entrar = false;
                }

                if (entrar)
                {
                    if (conta.OperarReal)
                    {
                        conta.Client.WsClient.Profile.BalanceId = conta.Client.WsClient.Profile.Balances.First(x => x.Type == BalanceType.Real).Id;
                    }
                    else
                    {
                        conta.Client.WsClient.Profile.BalanceId = conta.Client.WsClient.Profile.Balances.First(x => x.Type == BalanceType.Practice).Id;
                    }

                    string requestId = Guid.NewGuid().ToString().Replace("-", string.Empty);
                    var result = await conta.Client.BuyAsync(requestId, Active, conta.Entrada, Direction, exp);


                    Base.LOGS.Add(new Log
                    {
                        Hora = DateTime.Now,
                        IdOrEmail = conta.Email,
                        Titulo = "Compra",
                        Message = "Binária Result",
                        BinaryResult = result
                    });
                }



            }
            else
            {
                DigitalOptionsExpiryDuration exp = default;
                bool entrar = false;

                if (TimeFrame == "M1")
                {
                    exp = DigitalOptionsExpiryDuration.M1;
                    entrar = true;
                }
                else if (TimeFrame == "M5")
                {
                    exp = DigitalOptionsExpiryDuration.M5;
                    entrar = true;
                }
                else if (TimeFrame == "M15")
                {
                    exp = DigitalOptionsExpiryDuration.M15;
                    entrar = false;
                    Base.LOGS.Add(new Log
                    {
                        Hora = DateTime.Now,
                        IdOrEmail = conta.Email,
                        Titulo = "Digital Error",
                        Message = "M15 buy erro in Digital",
                    });
                }
                else
                {
                    exp = DigitalOptionsExpiryDuration.M1;
                    entrar = false;
                }

                if (entrar)
                {
                    string requestId = Guid.NewGuid().ToString().Replace("-", string.Empty);
                    var result = await conta.Client.PlaceDigitalOptions(requestId, Active, Direction, exp, conta.Entrada);

                    Base.LOGS.Add(new Log
                    {
                        Hora = DateTime.Now,
                        IdOrEmail = conta.Email,
                        Titulo = "Compra",
                        Message = "Digital Result",
                        DigitalResult = result
                    });
                }

            }
        }

        void Iniciar()
        {

            B_ADD_CONTA.Enabled = false;
            T_OP_STATUS.Text = "Status: Iniciando";
            MessageBox.Show("O sistema está iniciando as contas para começar o processo, por favor aguarde finalizar!", "Aguarde");

            IniciarContas();


            T_OP_STATUS.Text = "Status: Iniciado, Pronto para comprar!";
            B_INICIAR.Text = "Finalizar";
            groupBox1.Enabled = true;
            contador = 0; // reseta o contador para ele aguardar 10 segundos para limpar os textos

        }

        void Finalizar()
        {
            B_ADD_CONTA.Enabled = true;
            T_OP_STATUS.Text = "Status: Finalizado";
            B_INICIAR.Text = "Iniciar";
            groupBox1.Enabled = false;
            Base.INICIADO = false;
            contador = 0; // reseta o contador para ele aguardar 10 segundos para limpar os textos
        }


        void IniciarContas()
        {
            Base.LOGS.Add(new Log
            {
                Hora = DateTime.Now,
                IdOrEmail = "",
                Titulo = "Iniciando",
                Message = "Sistema está iniciando todas as contas.",
            });
            string requestId = "";

            //realiza o preenchumento das credenciais
            for (int i = 0; i < Base.CONTAS.Count; i++)
            {
                Base.CONTAS[i].Client = new IqOptionApiDotNetClient(Base.CONTAS[i].Email, Base.CONTAS[i].Senha);
            }

            foreach (Conta conta in Base.CONTAS)
            {
                try
                {
                    Task.WaitAll(conta.Client.ConnectAsync());

                    requestId = Guid.NewGuid().ToString().Replace("-", string.Empty);

                    if (conta.OperarReal)
                    {
                        conta.Client.WsClient.Profile.BalanceId = conta.Client.WsClient.Profile.Balances.First(x => x.Type == BalanceType.Real).Id;
                    }
                    else
                    {
                        conta.Client.WsClient.Profile.BalanceId = conta.Client.WsClient.Profile.Balances.First(x => x.Type == BalanceType.Practice).Id;
                    }

                    Base.LOGS.Add(new Log
                    {
                        Hora = DateTime.Now,
                        IdOrEmail = conta.Email,
                        Titulo = "Iniciado",
                        Message = "Conta iniciada",
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error");
                }

            }

            Base.LOGS.Add(new Log
            {
                Hora = DateTime.Now,
                IdOrEmail = "",
                Titulo = "Iniciado",
                Message = "Processo de inicialização finalizada",
            });

            Base.INICIADO = true;
        }

        void FinalizarContas()
        {
            MessageBox.Show("Finalizando contas, por favor, aguarde!", "Aguarde");


            foreach (Conta conta in Base.CONTAS)
            {
                try
                {
                    conta.Client.WsClient.WebSocketClient.Close();

                    conta.Client.WsClient.Dispose();
                    conta.Client.Dispose();
                    conta.Client = null;

                    foreach (var item in Tasks)
                    {
                        item.Dispose();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Desconection Error");
                }

            }

            Base.INICIADO = true;
        }

        void LoadFields()
        {
            Finalizar();
            Base.LoadConfig();

            this.Text = Base.APP_NAME + " - " + Base.APP_VERSION;

            foreach (Paridade par in Base.PARIDADES)
            {
                L_PARIDADES.Items.Add(par.Par);
            }


            var source = new BindingSource(Base.CONTAS.Select(o => new ContaPublic
            {
                Email = o.Email,
                Entrada = o.Entrada,
                OperarReal = o.OperarReal
            }), null);
            G_CONTAS.DataSource = source;
            T_STATUS.Text = "";
        }

        void LimparTextos()
        {
            T_STATUS.Text = "";
            T_OP_STATUS.Text = Base.INICIADO ? "Status: Iniciado, Pronto para comprar!" : "Status: Finalizado, Pressione iniciar para começar!";
        }

        private void B_ADD_CONTA_Click(object sender, EventArgs e)
        {
            F_GERENCIAR _ADD = new F_GERENCIAR();
            _ADD.ShowDialog();

            LoadFields();
        }

        private void B_INICIAR_Click(object sender, EventArgs e)
        {
            if (Base.INICIADO)
            {
                FinalizarContas();
                Finalizar();

            }
            else
            {
                Iniciar();
            }
        }

        private void B_CALL_Click(object sender, EventArgs e)
        {
            if (Base.INICIADO)
            {
                if (PrepararCompra(OrderDirection.Call))
                {

                    T_STATUS.Text = "Ordem CALL enviada as " + DateTime.Now;
                }
                else
                {
                    T_STATUS.Text = "Ordem não enviada!";
                }
            }
            else
            {
                MessageBox.Show("Sistema iniciando");
            }

        }

        private void B_PUT_Click(object sender, EventArgs e)
        {
            if (Base.INICIADO)
            {
                if (PrepararCompra(OrderDirection.Put))
                {

                    T_STATUS.Text = "Ordem PUT enviada as " + DateTime.Now;
                }
                else
                {
                    T_STATUS.Text = "Ordem não enviada!";
                }
            }
            else
            {
                MessageBox.Show("Sistema iniciando");
            }
        }

        private void T_STATUS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void B_LOGS_Click(object sender, EventArgs e)
        {
            F_LOG f_LOG = new F_LOG();

            f_LOG.ShowDialog();
        }

        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (dt.Second % 10 == 0 && contador > 9)
            {
                //resetar a cada 5 segundos
                LimparTextos();
            }

            T_HORA.Text = dt.ToLongTimeString();
            contador++;
        }

        private void C_MODO_CheckedChanged(object sender, EventArgs e)
        {
            if (C_MODO.Checked)
            {

                this.Opacity = 0.3;
            }
            else
            {

                this.Opacity = 1;
            }
        }


    }
}

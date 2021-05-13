using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace AtivarKeysWeb
{
    public partial class FormWeb : System.Windows.Forms.Form
    {
        public FormWeb()
        {
            InitializeComponent();

        }
        public static IWebDriver driver = new ChromeDriver(@".\");
        static Thread Login;
        static Thread Ler;
        static bool Parar = false;

        static string[] erros =
        {
            "Houve muitas tentativas de ativação realizadas a partir desta conta ou endereço IP. Por favor, aguarde e tente usar o seu código de produto novamente mais tarde.",
            "O código de produto inserido já foi ativado por uma outra conta Steam, não podendo ser usado novamente. Por favor, entre em contato com a loja da qual adquiriu o código para assistência.",
            "Esta conta Steam já possui o(s) produto(s) contido(s) nesta oferta. Para acessá-los, abra a biblioteca no cliente Steam."
        };
        private static string usuario;
        private static string senha;
        private static string sGuard;
        private static int minutos = 0;
        private static int segundos = 0;
        private static int qtdkeys = 0;
        private static int qtdkeysAt = 0;
        private static int qtdkeysNat = 0;

        private void START_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            sGuard = txtGuard.Text;
            Login = new Thread(new ThreadStart(LogarSteam));
            Login.Start();

        }

        private void BTN_START_KEYS_Click(object sender, EventArgs e)
        {
            BTN_START_KEYS.Visible = false;
            BTN_STOP_KEYS.Visible = true;
            Parar = false;
            Ler = new Thread(new ThreadStart(LerKeys));
            Ler.Start();

        }

        public static void GravarLog(string Linha)
        {
            if (!File.Exists(@".\log.txt"))
            {
                var oTxt = File.CreateText("Log.txt");
                oTxt.Close();
            }

            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine("[{0}] - {1}", DateTime.Today.ToLongDateString(), Linha);
            }

            //using (StreamReader r = File.OpenText("log.txt"))
            //{
            //    DumpLog(r);
            //}
        }
        public static void LerKeys()
        {
            if (File.Exists(@".\keys.txt"))
            {


                var Arq_Keys = File.OpenText(@".\keys.txt").ReadToEnd();
                var Linha = Arq_Keys.Split(new[] { "\r\n" }, StringSplitOptions.None);

                qtdkeys = Linha.Length;
                foreach (string Li in Linha)
                {

                    string aErro = string.Empty;
                    do
                    {
                        if (aErro == erros[0])
                        {
                            for (minutos = 0; minutos < 40; minutos++)
                            {
                                for (segundos = 0; segundos <= 60; segundos++)
                                {
                                    Thread.Sleep(1000);
                                    if (Parar) break;
                                }
                                if (Parar) break;
                            }
                        }

                        aErro = Ativar(Li);
                    } while (aErro == erros[0] && !Parar);
                    if (aErro == erros[1])
                    {
                        GravarLog("Key: " + Li.Replace("\r", "") + " - Já Ativado");
                        //oTxt.WriteLine("Key: {0} - Já Ativado", Li);
                        qtdkeysNat = qtdkeysNat + 1;
                        for (minutos = 0; minutos < 5; minutos++)
                        {
                            for (segundos = 0; segundos <= 60; segundos++)
                            {
                                Thread.Sleep(1000);
                                if (Parar) break;
                            }
                            if (Parar) break;
                        }

                    }
                    else if (aErro == "Sucesso")
                    {
                        GravarLog("Key: " + Li.Replace("\r", "") + " - Ativado");
                        //oTxt.WriteLine("Key: {0} - Ativado", Li);
                        qtdkeysAt = qtdkeysAt + 1;
                        for (minutos = 0; minutos < 5; minutos++)
                        {
                            for (segundos = 0; segundos <= 60; segundos++)
                            {
                                Thread.Sleep(1000);
                                if (Parar) break;
                            }
                            if (Parar) break;
                        }

                    }
                    else if (aErro == "Deslogado")
                    {
                        GravarLog("Key: " + Li.Replace("\r", "") + " - Deslogado");
                        Parar = true;
                        //oTxt.WriteLine("Key: {0} - Ativado", Li);
                        qtdkeysAt = qtdkeysAt + 1;
                        for (minutos = 0; minutos < 5; minutos++)
                        {
                            for (segundos = 0; segundos <= 60; segundos++)
                            {
                                Thread.Sleep(1000);
                                if (Parar) break;
                            }
                            if (Parar) break;
                        }

                    }
                    else if (aErro == erros[2])
                    {
                        GravarLog("Key: " + Li.Replace("\r", "") + " - já possui o produto");
                        //oTxt.WriteLine("Key: {0} - já possui o produto", Li);
                        qtdkeysNat = qtdkeysNat + 1;
                        for (minutos = 0; minutos < 5; minutos++)
                        {
                            for (segundos = 0; segundos <= 60; segundos++)
                            {
                                Thread.Sleep(1000);
                                if (Parar) break;
                            }
                            if (Parar) break;
                        }
                    }
                    else
                    {
                        GravarLog("Key: " + Li.Replace("\r", "") + " - outro Problema");
                        //oTxt.WriteLine("Key: {0} - outro Problema", Li);
                        qtdkeysNat = qtdkeysNat + 1;
                        for (minutos = 0; minutos < 5; minutos++)
                        {
                            for (segundos = 0; segundos <= 60; segundos++)
                            {
                                Thread.Sleep(1000);
                                if (Parar) break;
                            }
                            if (Parar) break;
                        }
                    }


                    if (Parar)
                    {
                        break;
                    }

                }


            }
            Ler.Abort();
        }
        public static void LogarSteam()
        {
            driver.Navigate().GoToUrl("https://store.steampowered.com/login/");

            if (driver.Title.Equals("Iniciar sessão"))
            {
                //login
                driver.FindElement(By.Id("input_username")).SendKeys(usuario);
                driver.FindElement(By.Id("input_password")).SendKeys(senha);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                driver.FindElement(By.TagName("button")).Click();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                if (!string.IsNullOrWhiteSpace(sGuard) && !string.IsNullOrEmpty(sGuard))
                {
                    //steam Guard
                    Thread.Sleep(5000);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                    driver.FindElement(By.Id("twofactorcode_entry")).SendKeys(sGuard);
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                    Thread.Sleep(2000);
                    driver.FindElement(By.XPath("//*[@id='twofactorcode_entry']")).Click();
                }
            }
            //twofactorcode_entry 
            Login.Abort();
        }
        public static string Ativar(string key)
        {
            driver.Navigate().GoToUrl("https://store.steampowered.com/account/registerkey?key=" + key);

            if (driver.Title.Equals("Ativar um produto no Steam"))
            {
                if (!driver.FindElement(By.Id("accept_ssa")).Selected)
                {
                    driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                    driver.FindElement(By.Id("accept_ssa")).Click();
                }
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
                driver.FindElement(By.Id("register_btn")).Click();
                Thread.Sleep(5000);
                foreach (string texto in erros)
                {
                    if (driver.FindElement(By.Id("error_display")).Text.Equals(texto))
                    {
                        return driver.FindElement(By.Id("error_display")).Text;
                    }
                }
                return "Sucesso";
            }
            else
            {
                return "Deslogado";
            }
        }

        private void FormWeb_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            driver.Quit();
            try
            {
                Ler.Abort();
                Login.Abort();
            }
            catch
            {

            }


        }

        private void BTN_STOP_KEYS_Click(object sender, EventArgs e)
        {
            Parar = true;
            BTN_START_KEYS.Visible = true;
            BTN_STOP_KEYS.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = minutos + ":" + segundos;
            lblQtdKeys.Text = "Keys: " + qtdkeys;
            lblAtivados.Text = "Ativados: " + qtdkeysAt;
            lblNOK.Text = "Não Ativado: " + qtdkeysNat;
        }


        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        private void FormWeb_Load(object sender, EventArgs e)
        {
            
        }
    }
}

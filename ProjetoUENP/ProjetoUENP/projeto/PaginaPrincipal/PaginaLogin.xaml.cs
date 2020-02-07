using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Connectivity;
using ProjetoUENP.projeto.PaginaUsuarios.Alunos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace ProjetoUENP.projeto.PaginaPrincipal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaLogin : ContentPage
	{
        public PaginaLogin()
        {
            InitializeComponent();
        }

        internal Aluno Aluno { get; private set; }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async void FazerLogin(object sender, EventArgs args)
        {
            WebClient wc = new WebClient();
            try
            {
                string nomeDigitado = Login.Text.Replace(" ", "_");
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/LoginAluno/" + nomeDigitado + "/.json");
                //Aluno aluno = new Aluno();
                if (resultado == "null")
                {
                    await DisplayAlert("Atenção", "Usuário ou senha incorreta", "OK");
                }
                else
                {
                    Aluno = JsonConvert.DeserializeObject<Aluno>(resultado);
                    if (Aluno.primeiro == "1")
                    {
                        if (Senha.Text == Aluno.Nascimento)
                        {
                            Aluno.nome_s = Login.Text;
                            await Navigation.PushAsync(new Cadastro.Cadastro());
                        }
                        else
                        {
                            await DisplayAlert("Atenção", "Senha incorreta", "OK");
                        }

                    }
                    else
                    {
                        using (MD5 md5Hash = MD5.Create())
                        {

                            if (VerifyMd5Hash(md5Hash, Senha.Text, Aluno.senha))
                            {
                                
                                Aluno.nome_s = Login.Text;
                                Aluno.RA_s = Aluno.RA;
                                Aluno.curso_s = Aluno.curso;
                                Aluno.turno_s = Aluno.turno;
                                Aluno.Nascimento_s = Aluno.Nascimento;
                                Aluno.campus_s = Aluno.campus;
                                //Aluno.curso_s = aluno.curso;
                                //Aluno.curso_s = aluno.curso;
                                await Navigation.PushAsync(new PaginaUsuarios.Alunos.MenuAlunos());

                            }
                            else
                            {
                                await DisplayAlert("Atenção", "Senha incorreta", "Ok");
                            }
                        }
                    }
                }

            }
            catch
            {
                if (CrossConnectivity.Current.IsConnected == false)
                {
                    Label Label = new Label { Text = "Aparelho não conectado a internet, verifique a conexão" };

                }

            }
        }
    }
}
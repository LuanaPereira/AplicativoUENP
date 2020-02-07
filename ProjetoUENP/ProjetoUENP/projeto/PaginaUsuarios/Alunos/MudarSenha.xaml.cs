using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoUENP.projeto.PaginaUsuarios.Alunos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MudarSenha : ContentPage
	{
		public MudarSenha ()
		{
			InitializeComponent ();
		}

        private async void FazerCadastro(object sender, EventArgs args)
        {
            try
            {
                string[] vetor = new string[2];
                WebClient wc = new WebClient();
                Aluno aluno = new Aluno();
                string nome = Aluno.nome_s.Replace(" ", "_");
                String resultado = wc.DownloadString("https://app-uenp.firebaseio.com/LoginAluno/" + nome + "/.json");
                aluno = JsonConvert.DeserializeObject<Aluno>(resultado);
                if (NovaSenha.Text == ConfNovaSenha.Text)
                {
                    using (MD5 md5Hash = MD5.Create())
                    {
                        string hash = GetMd5Hash(md5Hash, NovaSenha.Text);
                        aluno.senha = hash;
                    }

                    string alunoJson = JsonConvert.SerializeObject(aluno);

                    var request = WebRequest.CreateHttp("https://app-uenp.firebaseio.com/LoginAluno/" + nome + ".json");
                    request.Method = "PUT";
                    request.ContentType = "application/json";
                    var buffer = Encoding.UTF8.GetBytes(alunoJson);
                    request.ContentLength = buffer.Length;
                    request.GetRequestStream().Write(buffer, 0, buffer.Length);
                    var response = request.GetResponse();
                    alunoJson = (new StreamReader(response.GetResponseStream())).ReadToEnd();


                    await Navigation.PopToRootAsync();
                }
                else
                {
                    await DisplayAlert("Atenção", "Senhas diferente", "Ok");
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
    }
}
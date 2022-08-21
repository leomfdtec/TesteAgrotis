using RestSharp.Serialization.Json;
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Agrotis
{
    public static class VariaveisGlobais
    {
        public static string LocalBancoDados = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "DataBase.db; Version=3; FailIfMissing=True;datetimeformat=CurrentCulture";
    }

    public class SQLIteDBConnection
    {
        System.Data.SQLite.SQLiteConnection SqlConn = new System.Data.SQLite.SQLiteConnection()
        {
            ConnectionString = VariaveisGlobais.LocalBancoDados
        };

        public SQLiteConnection AbrirConexao()
        {
            if(SqlConn.State == System.Data.ConnectionState.Closed)
            {
                SqlConn.Open();
            }
            return SqlConn;
        }

        public SQLiteConnection FecharConexao()
        {
            if (SqlConn.State == System.Data.ConnectionState.Open)
            {
                SqlConn.Close();
            }
            return SqlConn;
        }
    }

    public class Ferramentas
    {
        public enum Operacao
        {
            Null,
            NovoRegistro,
            EditarRegistro,
            Resetar,
            ResetarDataGrid
        }
        public class DadosCEP
        {
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string UF { get; set; }
            public string Unidade { get; set; }
            public string IBGE { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
        }


        public static void PesquisaCep(string CEP, ref DadosCEP dadosCep)
        {
            if (CEP.Length <= 8)
            {
                RestSharp.IRestResponse restResponse = new RestSharp.RestClient(
                    string.Format("https://viacep.com.br/ws/{0}/json/", CEP)).Execute(
                    new RestSharp.RestRequest(RestSharp.Method.GET));

                if (restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Ocorreu um problema com a requisição: " + restResponse.Content, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dadosCep = new JsonDeserializer().Deserialize<DadosCEP>(restResponse);

                    if(dadosCep.CEP == null || dadosCep.Logradouro == null || dadosCep.Complemento == null || dadosCep.Bairro == null || dadosCep.UF == null || dadosCep.Localidade == null)
                    {
                        throw new System.Exception("Erro ao localizar o CEP");
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;

namespace Agrotis
{
    public class Clientes
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string IBGE { get; set; }
    }
    public class ClsClientes
    {
        SQLIteDBConnection sqlConn = new SQLIteDBConnection();

        #region SELECT

        public DataTable FiltrarClientes(string Filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter()
                {
                    SelectCommand = new System.Data.SQLite.SQLiteCommand($"SELECT Cod, Nome FROM tblClientes WHERE Nome LIKE '%{Filtro}%'", sqlConn.AbrirConexao())
                };

                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }


        public DataTable CarregarClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter()
                {
                    SelectCommand = new System.Data.SQLite.SQLiteCommand("SELECT Cod, Nome FROM tblClientes", sqlConn.AbrirConexao())
                };

                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);
            }
            return dt;
        }

        public Clientes CarregarClientes(string CodCliente)
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = $"SELECT Nome, Telefone, CEP, Logradouro, Numero, Complemento, Bairro, Cidade, UF, IBGE FROM tblClientes WHERE Cod={CodCliente}";
                    sqlcmd.CommandType = CommandType.Text;
                    SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        return new Clientes()
                        {
                            Cod = int.Parse(CodCliente),
                            Nome = sqlReader.GetValue(0).ToString(),
                            Telefone = sqlReader.GetValue(1).ToString(),
                            CEP = sqlReader.GetValue(2).ToString(),
                            Logradouro = sqlReader.GetValue(3).ToString(),
                            Numero = sqlReader.GetValue(4).ToString(),
                            Complemento = sqlReader.GetValue(5).ToString(),
                            Bairro = sqlReader.GetValue(6).ToString(),
                            Cidade = sqlReader.GetValue(7).ToString(),
                            UF = sqlReader.GetValue(8).ToString(),
                            IBGE = sqlReader.GetValue(9).ToString()
                        };
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
        public int ProximoCodigoCliente()
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = $"SELECT Cod FROM tblClientes  WHERE Cod = (SELECT MAX(Cod)  FROM tblClientes)";
                    sqlcmd.CommandType = CommandType.Text;
                    SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        return int.Parse(sqlReader.GetValue(0).ToString()) + 1;
                    }
                    return 1;
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion SELECT

        #region INSERT
        public void SalvarNovoRegistro(Clientes clientes)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (clientes.Nome.Length == 0) { sb.Append("Nome").Append(Environment.NewLine); }
                if (clientes.Telefone.Length == 0) { sb.Append("Telefone").Append(Environment.NewLine); }
                if (clientes.CEP.Length == 0) { sb.Append("Endereço").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("INSERT INTO tblClientes (Nome, Telefone, CEP, Logradouro, Numero, Complemento, Bairro, Cidade, UF, IBGE) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                        clientes.Nome,
                        clientes.Telefone,
                        clientes.CEP,
                        clientes.Logradouro,
                        clientes.Numero,
                        clientes.Complemento,
                        clientes.Bairro,
                        clientes.Cidade,
                        clientes.UF,
                        clientes.IBGE);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion INSERT

        #region UPDATE
        public void EditarRegistro(Clientes clientes)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (clientes.Nome.Length == 0) { sb.Append("Nome").Append(Environment.NewLine); }
                if (clientes.Telefone.Length == 0) { sb.Append("Telefone").Append(Environment.NewLine); }
                if (clientes.CEP.Length == 0) { sb.Append("Endereço").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("UPDATE tblClientes SET Nome='{1}', Telefone='{2}', CEP='{3}', Logradouro='{4}', Numero='{5}', Complemento='{6}', Bairro='{7}', Cidade='{8}', UF='{9}', IBGE='{10}' WHERE Cod={0}",
                        clientes.Cod,
                        clientes.Nome,
                        clientes.Telefone,
                        clientes.CEP,
                        clientes.Logradouro,
                        clientes.Numero,
                        clientes.Complemento,
                        clientes.Bairro,
                        clientes.Cidade,
                        clientes.UF,
                        clientes.IBGE);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion UPDATE

        #region DELETE
        public void DeletarRegistro(string CodCliente)
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("DELETE FROM tblClientes WHERE Cod={0}", CodCliente);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion DELETE

    }
}

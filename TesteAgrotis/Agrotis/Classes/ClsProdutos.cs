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
    public class Produto
    {
        public string Cod { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Quantidade { get; set; }
        public int Peso { get; set; }
        public int Preco { get; set; }
    }
    public class ClsProdutos
    {
        SQLIteDBConnection sqlConn = new SQLIteDBConnection();

        #region SELECT
        public DataTable FiltrarProdutos(string Nome)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter()
                {
                    SelectCommand = new System.Data.SQLite.SQLiteCommand($"SELECT Cod, Nome FROM tblProdutos WHERE Nome LIKE '%{Nome}%'", sqlConn.AbrirConexao())
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


        public DataTable CarregarProdutos()
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter()
                {
                    SelectCommand = new System.Data.SQLite.SQLiteCommand("SELECT Cod, Nome FROM tblProdutos", sqlConn.AbrirConexao())
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

        public Produto CarregarProdutos(string CodProdutos)
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = $"SELECT Nome, Descricao, Peso, Preco FROM tblProdutos WHERE Cod={CodProdutos}";
                    sqlcmd.CommandType = CommandType.Text;
                    SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        return new Produto()
                        {
                            Cod = CodProdutos,
                            Nome = sqlReader.GetValue(0).ToString(),
                            Descricao = sqlReader.GetValue(1).ToString(),
                            Peso = int.Parse(sqlReader.GetValue(2).ToString()),
                            Preco = int.Parse(sqlReader.GetValue(3).ToString())
                        };
                    }
                }
            }
            catch (Exception ex)
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
                    sqlcmd.CommandText = $"SELECT Cod FROM tblProdutos  WHERE Cod = (SELECT MAX(Cod)  FROM tblProdutos)";
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
        public void SalvarNovoRegistro(Produto produtos)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (produtos.Nome.Length == 0) { sb.Append("Nome do produto").Append(Environment.NewLine); }
                if (produtos.Peso == 0) { sb.Append("Peso do produto").Append(Environment.NewLine); }
                if (produtos.Preco == 0) { sb.Append("Preço do produto").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("INSERT INTO tblProdutos (Nome, Descricao, Peso, Preco) VALUES ('{0}', '{1}', {2}, {3})",
                        produtos.Nome,
                        produtos.Descricao,
                        produtos.Peso,
                        produtos.Preco);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion INSERT

        #region UPDATE
        public void EditarRegistro(Produto produtos)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (produtos.Nome.Length == 0) { sb.Append("Nome do produto").Append(Environment.NewLine); }
                if (produtos.Peso == 0) { sb.Append("Peso do produto").Append(Environment.NewLine); }
                if (produtos.Preco == 0) { sb.Append("Preço do produto").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("UPDATE tblProdutos SET Nome='{1}', Descricao='{2}', Peso={3}, Preco={4} WHERE Cod={0}",
                        produtos.Cod,
                        produtos.Nome,
                        produtos.Descricao,
                        produtos.Peso,
                        produtos.Preco);
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion UPDATE

        #region DELETE
        public void DeletarProduto(string CodProdutos)
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("DELETE FROM tblProdutos WHERE Cod={0}", CodProdutos);
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

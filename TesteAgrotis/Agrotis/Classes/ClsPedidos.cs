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
    public class Pedidos
    {
        public string CodPedido { get; set; }
        public string dtEmissao { get; set; }
        public string CodCliente { get; set; }
        public List<Produto> Produto { get; set; }
    }

    public class ClsPedidos
    {
        SQLIteDBConnection sqlConn = new SQLIteDBConnection();

        #region SELECT
        public DataTable CarregarPedidos()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("CodPedido");
            dt.Columns.Add("DatEmissao");
            dt.Columns.Add("Cod");
            dt.Columns.Add("Nome");

            using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
            {
                sqlcmd.CommandText = @"SELECT tblPedido.CodPedido, tblPedido.DatEmissao, tblClientes.Cod, tblClientes.Nome
                                        FROM tblPedido
                                        LEFT OUTER JOIN tblClientes ON tblPedido.CodCliente = tblClientes.Cod";


                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                int CodAnterior = 0;

                while (sqlReader.Read())
                {
                    int CodPedido = int.Parse(sqlReader.GetValue(0).ToString());
                    if (CodAnterior != CodPedido)
                    {
                        dt.Rows.Add(new object[] { CodPedido, sqlReader.GetValue(1).ToString(), sqlReader.GetValue(2).ToString(), sqlReader.GetValue(3).ToString() });
                        CodAnterior = CodPedido;
                    }
                }
            }

            return dt;
        }

        public DataTable CarregarProdutosPedido(string Cod)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter()
                {
                    SelectCommand = new System.Data.SQLite.SQLiteCommand($@"SELECT tblPedido.CodProduto AS 'Código', 
                                                                            tblProdutos.Nome, tblPedido.Quantidade AS 'Qnt', 
                                                                            PRINTF('R$%.2f', tblProdutos.Preco / 100) AS 'Preço Unt', 
                                                                            PRINTF('R$%.2f', (tblPedido.Quantidade * tblProdutos.Preco) / 100) AS 'Preço Total', 
                                                                            PRINTF('%.2fKg', tblProdutos.Peso / 100) AS 'Peso Unt', 
                                                                            PRINTF('%.2fKg', (tblPedido.Quantidade * tblProdutos.Peso) / 100) AS 'Peso Total'
                                                                            FROM tblPedido
                                                                            LEFT OUTER JOIN tblProdutos ON tblPedido.CodProduto = tblProdutos.Cod
                                                                            WHERE CodPedido = {Cod};", sqlConn.AbrirConexao())
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

        public string CarregaDecricaoProduto(string Cod)
        {
            using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
            {
                sqlcmd.CommandText = $"SELECT Descricao FROM tblProdutos WHERE Cod={Cod}";


                sqlcmd.CommandType = CommandType.Text;
                SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                if (sqlReader.Read())
                {
                    return sqlReader.GetValue(0).ToString();
                }
                return null;
            }
        }

        //    public Produtos CarregarProdutos(string CodProdutos)
        //    {
        //        try
        //        {
        //            using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
        //            {
        //                sqlcmd.CommandText = $"SELECT Nome, Descricao, Peso, Preco FROM tblProdutos WHERE Cod={CodProdutos}";
        //                sqlcmd.CommandType = CommandType.Text;
        //                SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

        //                if (sqlReader.Read())
        //                {
        //                    return new Produtos()
        //                    {
        //                        Cod = int.Parse(CodProdutos),
        //                        Nome = sqlReader.GetValue(0).ToString(),
        //                        Descricao = sqlReader.GetValue(1).ToString(),
        //                        Peso = int.Parse(sqlReader.GetValue(2).ToString()),
        //                        Preco = int.Parse(sqlReader.GetValue(3).ToString())
        //                    };
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        return null;
        //    }
        public int ProximoCodigoPedidos()
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = $"SELECT CodPedido FROM tblPedido  WHERE CodPedido = (SELECT MAX(CodPedido)  FROM tblPedido)";
                    sqlcmd.CommandType = CommandType.Text;
                    SQLiteDataReader sqlReader = sqlcmd.ExecuteReader();

                    if (sqlReader.Read())
                    {
                        return int.Parse(sqlReader.GetValue(0).ToString()) + 1;
                    }
                    return 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion SELECT

        #region INSERT
        public void SalvarNovoPedido(Pedidos pedidos)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (pedidos.CodCliente.Length == 0) { sb.Append("Informação do Cliente").Append(Environment.NewLine); }
                if (pedidos.Produto.Count == 0) { sb.Append("Não existe produtos na lista").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    foreach(Produto p in pedidos.Produto)
                    {
                        sqlcmd.CommandText = string.Format("INSERT INTO tblPedido (CodPedido, DatEmissao, CodCliente, Quantidade, CodProduto) VALUES ({0}, '{1}', {2}, {3}, {4});",
                            pedidos.CodPedido,
                            pedidos.dtEmissao,
                            pedidos.CodCliente,
                            p.Quantidade,
                            p.Cod);
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion INSERT

        #region UPDATE
        public void EditarRegistro(Pedidos pedidos)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (pedidos.CodCliente.Length == 0) { sb.Append("Informação do Cliente").Append(Environment.NewLine); }
                if (pedidos.Produto.Count == 0) { sb.Append("Não existe produtos na lista").Append(Environment.NewLine); }

                if (sb.Length > 0)
                {
                    throw new Exception(string.Format("Os campos abaixo ainda precisam ser preenchidos: {0}{0}{1}", Environment.NewLine, sb));
                }

                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    foreach (Produto p in pedidos.Produto)
                    {
                        sqlcmd.CommandText = string.Format("INSERT INTO tblPedido (CodPedido, DatEmissao, CodCliente, Quantidade, CodProduto) VALUES ({0}, '{1}', {2}, {3}, {4});",
                            pedidos.CodPedido,
                            pedidos.dtEmissao,
                            pedidos.CodCliente,
                            p.Quantidade,
                            p.Cod);
                        sqlcmd.CommandType = CommandType.Text;
                        sqlcmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion UPDATE

        #region DELETE
        public void DeletarProduto(string CodPedido)
        {
            try
            {
                using (SQLiteCommand sqlcmd = sqlConn.AbrirConexao().CreateCommand())
                {
                    sqlcmd.CommandText = string.Format("DELETE FROM tblPedido WHERE CodPedido={0}", CodPedido);
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

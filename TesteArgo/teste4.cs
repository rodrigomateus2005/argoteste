using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Models;

namespace TesteArgo
{
    /// <summary>
    /// Nessa classe deve ser feito o acesso a banco de dados SQL SERVER
    /// Dados de conexao do banco de dados
    /// host: den1.mssql6.gear.host
    /// base: testecore
    /// user:testecore
    /// senha : Dz2iI~!U1Edq
    /// 
    /// Tabela Destino
    /// 
    /// Colunas:
    /// DestinoId inteiro 
    /// Nome texto nulavel
    /// Dia data nulavel
    /// 
    /// </summary>
    public class teste4
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Destino> ListarDestino()
        {
            var retorno = new List<Destino>();
            var query = new StringBuilder();

            query.AppendLine("SELECT DestinoId, Nome, Dia");
            query.AppendLine("FROM Destino");

            DataTable dt = this.executeDataTable(query.ToString());

            foreach (DataRow linha in dt.Rows)
            {
                retorno.Add(this. preencherDestino(linha));
            }

            return retorno;
        }

        public Destino buscarPorId(int id)
        {
            Destino retorno = null;
            var query = new StringBuilder();

            query.AppendLine("SELECT DestinoId, Nome, Dia");
            query.AppendLine("FROM Destino");
            query.AppendLine("WHERE DestinoId = @id");

            DataTable dt = this.executeDataTable(query.ToString(), new SqlParameter("id", id));

            if (dt.Rows.Count > 0)
            {
                retorno = this.preencherDestino(dt.Rows[0]);
            }

            return retorno;
        }

        private SqlConnection getConnection()
        {
            var conStr = new SqlConnectionStringBuilder();

            conStr.DataSource = "den1.mssql6.gear.host";
            conStr.InitialCatalog = "testecore";
            conStr.UserID = "testecore";
            conStr.Password = "Dz2iI~!U1Edq";

            return new SqlConnection(conStr.ToString());
        }

        private DataTable executeDataTable(string query, params SqlParameter[] parametros)
        {
            DataSet ds = new DataSet();

            using (SqlConnection db = getConnection())
            {
                db.Open();

                using (var cmd = new SqlCommand(query, db))
                {
                    foreach (var param in parametros)
                    {
                        cmd.Parameters.Add(param);
                    }

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
            }

            return ds.Tables[0];
        }

        private Destino preencherDestino(DataRow linha)
        {
            return new Destino
            {
                DestinoId = (int)linha["DestinoId"],
                Nome = (string)linha["Nome"],
                Dia = (DateTime?)linha["Dia"]
            };
        }
    }
}

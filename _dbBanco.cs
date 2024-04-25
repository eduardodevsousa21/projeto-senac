using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;
using static Login._dbFluxoAnual;
using System.Globalization;
using static Login._dbFluxoMensal;

namespace Login
{
    class _dbBanco
    {
        public class tarefas
        {
            public int id;
            public string tarefa;
            public DateTime prazo;
        }
        public class rastreamento
        {
            public int id;
            public string produto;
            public string origem;
            public string datasaida;
            public string localidade;
            public string previsaodechegada;

        }
        //atributo
        private static SQLiteConnection conexao;

        //metod ConexaoBanco
        public static SQLiteConnection ConexaoBanco()
        {

            //criar um conexao do tipo SQLiteConnect
            //linkado ao arquivo banco.db
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\..\\..\\banco_de_dados");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try {

                using (var cmd = ConexaoBanco().CreateCommand())
                {

                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            } catch (Exception ex) {

                ConexaoBanco().Close();
                throw ex;

            }
        }
        public static void Confirmarbanco(SQLiteCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
                
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
            }
        }

        public static DataTable ObterTarefas()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID',tarefas as 'Tarefas', prazo as 'Prazo'  FROM t_tarefas";

                di = new SQLiteDataAdapter(cmd.CommandText, vcon);
                di.Fill(du);
                vcon.Close();
                return du;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterTodasTarefas(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID', tarefas as 'Tarefas', prazo as 'Prazo' FROM t_tarefas";
                cmd.Parameters.AddWithValue("@id", id);
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarTarefas(string id)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM t_tarefas WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarTarefas(tarefas t)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE t_tarefas SET id=@id, tarefas=@tarefas WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", t.id);
                    cmd.Parameters.AddWithValue("@tarefas", t.tarefa);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static DataTable ObterRastreamento()
        {
            SQLiteDataAdapter di = null;
            DataTable du = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id as 'ID',produto as 'Produto',origem as 'Origem', datasaida as 'Data de Saída', localidade as 'Localidade',previsaodechegada as 'Previsão de Chegada' FROM rastreamento";

                di = new SQLiteDataAdapter(cmd.CommandText, vcon);
                di.Fill(du);
                vcon.Close();
                return du;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeletarRastreamento(string id)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "DELETE FROM rastreamento WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosRastreamento(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = _dbBanco.ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM rastreamento WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void AtualizarRastramento(rastreamento r)
        {
            try
            {
                using (var vcon = _dbBanco.ConexaoBanco())
                {
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = "UPDATE rastreamento SET produto=@produto, origem=@origem, datasaida=@datasaida, localidade=@localidade, previsaodechegada=@previsaodechegada WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", r.id);
                    cmd.Parameters.AddWithValue("@produto", r.produto);
                    cmd.Parameters.AddWithValue("@origem", r.origem);
                    cmd.Parameters.AddWithValue("@datasaida", r.datasaida);
                    cmd.Parameters.AddWithValue("@localidade", r.localidade);
                    cmd.Parameters.AddWithValue("@previsaodechegada", r.previsaodechegada);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace Login
{
    class Banco
    {
        //atributo
        private static SQLiteConnection conexao;

        //metod ConexaoBanco
        private static SQLiteConnection ConexaoBanco()
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

            } catch (Exception ex) 
            {

                ConexaoBanco().Close();
                throw ex;

            }
        }
        //Funçoes do Form Cadastro

        public static void Cadastro(Usuario u)
        {
            if(existeUsuario(u)) 
            {
                MessageBox.Show("Usuario já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO funcionario(usuario,senha,SETOR) VALUES (@usuario,@senha,@setor)";
                cmd.Parameters.AddWithValue("@usuario", u.usuario);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@setor", u.setor);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuario Inserido");
                ConexaoBanco().Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao Cadastrar Novo Usuario");
                ConexaoBanco().Close();
            }
        }

        //Fim Funçoes do Form Cadastro


        //ROTINAS GERAIS

        public static bool existeUsuario(Usuario u) 
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT usuario FROM funcionario WHERE usuario='"+u.usuario+"'";
            da = new SQLiteDataAdapter(cmd.CommandText,ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}


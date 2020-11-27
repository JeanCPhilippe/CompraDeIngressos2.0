using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace TrabalhoFinal2._0.DAL
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public string mensagem = "";
        public SqlCommand cmd = new SqlCommand();
        public Conexao con = new Conexao();
        public SqlDataReader reader;
        public bool verificarlogin(string login, string senha)
        {
            //Procurar no banco de dados o Login e a senha
            cmd.CommandText = "select * from  Logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                reader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados";           
            }
            return tem;
        }
        public string cadastrar(string email, string senha, string confSenha)
        {
            // Comando SQL para inserir uma nova conta no banco de dados
            tem = false;
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into Logins values (@e,@s)";
                cmd.Parameters.AddWithValue("@e",email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    this.mensagem = "Cadastrado com sucesso!";
                    tem = true;
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            
            return mensagem;
        }
    }
}

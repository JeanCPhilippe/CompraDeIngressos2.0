using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal2._0.DAL;

namespace TrabalhoFinal2._0.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();
            tem = LoginDao.verificarlogin(login, senha);
            if(!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
            }
            return tem;
        }
        public string cadastrar (string email, string senha, string confSenha)
        {
            LoginDaoComandos LoginDao = new LoginDaoComandos();

            this.mensagem = LoginDao.cadastrar(email, senha, confSenha);
            if (LoginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}

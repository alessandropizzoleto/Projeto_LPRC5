//****************************************************************************************
//**Criado por: Alessandro Viola 
//**Data de Criação: 12/04/2021
//**Descrição: 
// Faz a conexão com o SGBD MySql.
//**Instruções:
// Faz uso do MySqlConnector, versão 8.0.23, que deve ser instalado;
// Pode ser encontrado no site: https://dev.mysql.com/downloads/connector/net/
// Incluir nas referências do projeto, "MySqlData"
// Incluir "using MySql.Data.MySqlClient;"
// 
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto_LPRC5
{
    class conexaoMySql
    {
        private MySqlConnection conexao;

        public void conectaMySql(string servidor, string usuario, string bancoNome, string senha)
        {
            conexao = new MySqlConnection("server=" + servidor + ";uid=" + usuario + ";database=" + bancoNome + ";pwd=" + senha);

            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public void desconetaMySql()
        {
            conexao.Close();
        }
    }
}

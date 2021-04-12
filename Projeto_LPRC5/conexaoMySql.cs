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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5
{
    class dbCadastroFuncionarios
    {
        conexaoMySql connect = new conexaoMySql();
        public void insereCadastroFuncionariosBase(ClasseCadastroFuncionarios CF)
        {
            
        }
        public void alteraCadastroFuncionariosBase(ClasseCadastroFuncionarios CF)
        {
            
        }
        public void excluiCadastroFuncionariosBase(ClasseCadastroFuncionarios CF)
        {
          
        }

        public MySqlDataAdapter selectCadastroFuncionariosBase(ClasseCadastroFuncionarios CF)
        {
           
            return null;
        }

        public ClasseCadastroFuncionarios RetornaDadosObjeto(ClasseCadastroFuncionarios CF)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            ClasseCadastroFuncionarios CFTemp = new ClasseCadastroFuncionarios();


            adapter.Fill(ds);


            return CFTemp;
        }

        public DataTable selectCadastroFuncionariosBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

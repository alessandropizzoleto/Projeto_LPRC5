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
        public void insereCadastroFuncionariosBase(classeCadastroFuncionarios CF)
        {
            
        }
        public void alteraCadastroFuncionariosBase(classeCadastroFuncionarios CF)
        {
            
        }
        public void excluiCadastroFuncionariosBase(classeCadastroFuncionarios CF)
        {
          
        }

        public MySqlDataAdapter selectCadastroFuncionariosBase(classeCadastroFuncionarios CF)
        {
           
            return null;
        }

        public classeCadastroFuncionarios RetornaDadosObjeto(classeCadastroFuncionarios CF)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCadastroFuncionarios CFTemp = new classeCadastroFuncionarios();


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

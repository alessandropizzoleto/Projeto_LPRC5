//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Classe para auxiliar form Cor.
//
//
//****** Atualizações:
//*** Data:20/04/2021
//*** Responsável:Caique Bruno
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Projeto_LPRC5
{
    class dbCor
    {
        conexaoMySql connect = new conexaoMySql();

    
        public void insereCorBase(classeCor tinta )
        {
            string sql = $"insert into cor  (cornome)  values {tinta.getCorNome()} );";

        }

    
        public void alteraCorBase(classeCor tinta)
        {
            string sql = $"update cor  (cornome)  values {tinta.getCorNome()} where corid = " + tinta.getCorId() + ";";


        }


        public void excluiCorBase(classeCor tinta)
        {
            string sql = $"delete from cor where corid = " + tinta.getCorId() + ";";


        }

        
        public MySqlDataAdapter selectCorBase(classeCor tinta)
        {
            string sql = $"select * from cor where corid = " + tinta.getCorId() + ";";
           
            return null;
        }

        public classeCor RetornaDadosObjeto(classeCor tinta)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCor CorTemp = new classeCor();

          
            adapter.Fill(ds);

            CorTemp.setCorId(tinta.getCorId());


            return CorTemp;
        }
       // public MySqlDataAdapter selectCorDBase()
       // {
        //    command.CommandText = "SELECT corid, tipousuariodescricao FROM tipousuario;";
        //    return connectUsu.retornaSQL(command.CommandText);
       // }
        public DataTable selectCorBase()
       {
       
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
        
            //adapter = selectTipoUsuarioDBase();
            adapter.Fill(tabela);
        
            return tabela;
       }
    }
}

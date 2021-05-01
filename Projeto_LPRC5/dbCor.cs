//****************************************************************************************
//**Criado por: Guilherme, Alexandro, Caique
//**Data de Criação: 20/04/2021
//**Instruções: Classe para auxiliar form Cor.
//
//
//****** Atualizações:
//*** Data:20/04/2021
//*** Responsável:Caique Bruno
 
//****** Atualizações: Inserção dos comandos para realizar a query, inserção de novas funções para selecionar informações e exibir no grid e organização geral do código.
//*** Data: 01/05/2021
//*** Responsável: Amanda Ferrari, André Costa, Giovanna Valim
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
        private Int32 retorno;
        conexaoMySql connect = new conexaoMySql();

        public void insereCorBase(classeCor tinta )
        {
            string sql = "insert into cor  (cornome)  values ('" + tinta.getCorNome() + "');";
            retorno = connect.executaSQL(sql.ToString());
        }

    
        public void alteraCorBase(classeCor tinta)
        {
            string sql = "update cor set cornome = ('" + tinta.getCorNome() + "') where corid = " + tinta.getCorId() + ";";
            retorno = connect.executaSQL(sql.ToString());
        }


        public void excluiCorBase(classeCor tinta)
        {
            string sql = "delete from cor where corid = " + tinta.getCorId() + ";";
            retorno = connect.executaSQL(sql.ToString());
        }

        
        public MySqlDataAdapter selectCorBase(classeCor tinta)
        {
            string sql = "select * from cor where corid = " + tinta.getCorId() + ";";
            retorno = connect.executaSQL(sql.ToString());
            return connect.retornaSQL(sql.ToString());
        }

        public classeCor selectCorDBase(classeCor tinta)
        {
            classeCor CorTemp = new classeCor();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string sql = "SELECT cornome FROM cor where corid =" + tinta.getCorId() + " ;";

            adapter = connect.retornaSQL(sql.ToString());
            adapter.Fill(ds);

            CorTemp.setCorId(tinta.getCorId());
            CorTemp.setCorNome(ds.Tables[0].Rows[0][0].ToString());

            return CorTemp;
        }

        public MySqlDataAdapter selectCorDBase()
        {
           string sql = "SELECT corid, cornome FROM cor;";
           return connect.retornaSQL(sql.ToString());
        }

        public DataTable selectCorDBaseGrid()
       {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter = selectCorDBase();
            adapter.Fill(tabela);
            return tabela;
       }
    }
}

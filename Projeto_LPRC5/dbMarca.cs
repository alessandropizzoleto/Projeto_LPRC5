//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo
//**Data de Criação: 20/04/2021
//**Instruções: Classe para configurar o formulario marca.
//
//
//****** Atualizações:
//*** Data:22/04/2021
//*** Responsável:Giovanni Marques
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
    class dbMarca
    {
        conexaoMySql connect = new conexaoMySql();


        public void inseremarca(classeMarca marca)
        { 
            string sql = $"insert into marca (marcaveiculo) values {marca.getmarcaveiculonome()} );";

        }


        public void alteramarca(classeMarca marca)
        {
            string sql = $"update marca (marcaveiculonome) values {marca.getmarcaveiculonome()} where marcaveiculoid = " + marca.getmarcaveiculoid() + ";";


        }


        public void excluimarca(classeMarca marca)
        {
            string sql = $"delete from marca where marcaveiculoID = " + marca.getmarcaveiculoid() + ";";


        }


        public MySqlDataAdapter selectmarca(classeMarca marca)
        {
            string sql = $"select * from marca where marcaveiculoID = " + marca.getmarcaveiculoid() + ";";

            return null;
        }

        public classeMarca RetornaValores(classeMarca marca) 
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeMarca MarcaTemp = new classeMarca();


            adapter.Fill(ds);

            MarcaTemp.setmarcaveiculoid(marca.getmarcaveiculoid());


            return MarcaTemp;
        }

        public DataTable selectMarca()
        {

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adapter.Fill(tabela);

            return tabela;
        }
    }
}
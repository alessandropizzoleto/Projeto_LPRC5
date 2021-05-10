//****************************************************************************************
//**Criado por: Giovanni Marques
//**Data de Criação: 22/04/2021
//**Instruções:
//
//
//****** Atualizações: 
//*** Data: 
//*** Responsável:
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5
{
    class dbMarca
    {
        conexaoMySql connect = new conexaoMySql();
        public void insereMarcaBase(classeMarca marca)
        {
            string sql = $"insert into Marca  (marcaveiculoid, marcaveiculonome)  values {marca.getmarcaveiculoid()}, {marca.getmarcaveiculonome()};";
        }
        public void alteraMarcaBase(classeMarca marca)
        {
            string sql = $"update marca (marcaveiculonome) set marcaveiculonome = {marca.getmarcaveiculonome()} where marcaveiculoid = {marca.getmarcaveiculoid()}";
        }
        public void excluiMarcaBase(classeMarca marca)
        {
            string sql = $"delete from marca where marcaveiculoid = {marca.getmarcaveiculoid()} limit 1";
        }

        public MySqlDataAdapter selectMarcaBase(classeMarca marca)
        {
            string sql = $"select * from marca where marcaveiculoid = {marca.getmarcaveiculoid()}";
            return null;
        }

        public classeMarca RetornaDadosObjeto(classeMarca marca)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeMarca marcaTemp = new classeMarca();


            adapter.Fill(ds);

            marcaTemp.setmarcaveiculoid(marca.getmarcaveiculoid());


            return marcaTemp;
        }

        public DataTable selectMarcaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
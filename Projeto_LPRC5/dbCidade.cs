//****************************************************************************************
//**Criado por: Geanluca
//**Data de Criação: 20/04/2021
//**Instruções:
//
//
//****** Atualizações: Criação do acesso ao banco de dados
//*** Data: 26/04/2021
//*** Responsável: Geanluca Sampaio de Sousa
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Projeto_LPRC5 {
    class dbCidade {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereCidadeBase(classeCidade cidade) {
            string sql = $"insert into cidade  (cidadeid, cidadenome)  values {cidade.getCidadeId()}, {cidade.getCidadeNome()};";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraCidadeBase(classeCidade cidade) {
            string sql = $"update cidade (cidadenome) values {cidade.getCidadeNome()} where cidadeid = {cidade.getCidadeId()}";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiCidadeBase(classeCidade cidade) {
            string sql = $"delete from cidade where cidadeid = {cidade.getCidadeId()} limit 1";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectCidadeBase(classeCidade cidade) {
            string sql = $"select * from cidade where cidadeid = {cidade.getCidadeId()}";
            //return connect.retornaSQL(sql);
            return null;
        }

        public classeCidade RetornaDadosObjeto(classeCidade cidade) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCidade cidadeTemp = new classeCidade();

            //string sql = "select cidId, cidNome from cidade where cidId = " + padrao.getId() + ";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            cidadeTemp.setCidadeId(cidade.getCidadeId());


            return cidadeTemp;
        }

        public DataTable selectCidadeBase() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            //string sql = "select cidId, cidNome from cidade;";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

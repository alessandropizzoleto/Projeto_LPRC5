//****************************************************************************************
//**Criado por: Geanluca
//**Data de Criação: 20/04/2021
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


namespace Projeto_LPRC5 {
    class dbCidade {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereCidadeBase(classeCidade padrao) {
            string sql = "";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraCidadeBase(classeCidade padrao) {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiCidadeBase(classeCidade padrao) {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectCidadeBase(classeCidade padrao) {
            string sql = "";
            //return connect.retornaSQL(sql);
            return null;
        }

        public classeCidade RetornaDadosObjeto(classeCidade padrao) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCidade cidadeTemp = new classeCidade();

            //string sql = "select cidId, cidNome from cidade where cidId = " + padrao.getId() + ";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            cidadeTemp.setCidadeId(padrao.getCidadeId());


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

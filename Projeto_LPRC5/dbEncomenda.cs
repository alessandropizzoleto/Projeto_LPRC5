//****************************************************************************************
//**Grupo: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Guilherme de Andrade Rissato
//**Data de Criação: 03/05/2021
//**Instruções: Criação da classe dbEncomenda
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class dbEncomenda
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "";
            //return connect.retornaSQL(sql);
            return null;
        }

        public classeEncomendas RetornaDadosObjeto(classeEncomendas encomenda)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeEncomendas EncomendaTemp = new classeEncomendas();

            //string sql = "select cidId, cidNome from cidade where cidId = " + padrao.getId() + ";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            EncomendaTemp.setCodigo(encomenda.getCodigo());


            return EncomendaTemp;
        }

        public DataTable selectEncomendaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            //string sql = "select cidId, cidNome from cidade;";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

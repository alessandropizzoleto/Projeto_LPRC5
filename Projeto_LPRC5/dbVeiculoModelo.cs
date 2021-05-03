﻿//****************************************************************************************
//Grupo: Guilherme A Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por:Guilherme de Andrade Rissato
//**Data de Criação:27/04/2021
//**Descrição: criação dos SQL`s
//**Instruções:
//
//
//****** Atualizações:ajuste das strings sql para serem compativeis com o banco de dados
//*** Data:03/05/2021
//*** Responsável: Guilherme de Andrade Rissato
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
    class dbVeiculoModelo
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
            string sql = "INSERT INTO veiculomodelo(veiculomodelonome) VALUES('" +veiculoModelo.getnomeVeiculo().ToString()+"');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
           string sql = "UPDATE veiculomodelo SET veiculomodelonome ='" + veiculoModelo.getnomeVeiculo().ToString() + "'WHERE veiculomodeloid =" + veiculoModelo.getVeiculoID() + ";";
           connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
            string sql = "DELETE FROM veiculomodelo WHERE veiculomodeloid= " + veiculoModelo.getVeiculoID() + ";";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
            string sql = "SELECT * FROM veiculomodelo WHERE veiculomodeloid="+ veiculoModelo.getVeiculoID() +";";
            return connect.retornaSQL(sql);
        }

        public classeVeiculoModelo RetornaDadosObjeto(classeVeiculoModelo veiculoModelo)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeVeiculoModelo veiculoModeloTemp = new classeVeiculoModelo();

            string sql = "SELECT * FROM veiculomodelo WHERE veiculomodeloid="+ veiculoModelo.getVeiculoID() +";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoModeloTemp.setVeiculoID(veiculoModelo.getVeiculoID());


            return veiculoModeloTemp;
        }

        public DataTable selectDefaultBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT * FROM veiculomodelo";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

    }
}

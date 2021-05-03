//****************************************************************************************
//**Criado por:Guilherme de Andrade Rissato
//**Data de Criação:27/04/2021
//**Descrição: criação dos SQL`s
//**Instruções:
//
//
//****** Atualizações: O código esta OK, não sendo necessário efetuar alterações
//*** Data: 03/05/2021
//*** Responsável: Giovanni Marques
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
            //string sql = "INSERT INTO veiculomodelo(IDVeiculo,nomeVeiculo) VALUES("+veiculoModelo.getVeiculoID() +"," +veiculoModelo.getnomeVeiculo().ToString()+");";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
           //string sql = "UPDATE veiculomodelo SET nomeVeiculo ='" + veiculoModelo.getnomeVeiculo().ToString() + "'WHERE IDVeiculo =" + veiculoModelo.getVeiculoID() + ";";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
            //string sql = "DELETE FROM veiculomodelo WHERE IDVeiculo = " + veiculoModelo.getVeiculoID() + ";";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectVeiculoModelo(classeVeiculoModelo veiculoModelo)
        {
            //string sql = "SELECT * FROM veiculomodelo WHERE IDVeiculo="+ veiculoModelo.getVeiculoID() +";";
            //return connect.retornaSQL(sql);
            return null;
        }

        public classeDefault RetornaDadosObjeto(classeVeiculoModelo veiculoModelo)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeDefault veiculoModeloTemp = new classeDefault();

            //string sql = "SELECT * FROM veiculomodelo WHERE IDVeiculo="+ veiculoModelo.getVeiculoID() +";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            veiculoModeloTemp.setId(veiculoModelo.getVeiculoID());


            return veiculoModeloTemp;
        }

        public DataTable selectDefaultBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            //string sql = "SELECT * FROM veiculomodelo";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }

    }
}

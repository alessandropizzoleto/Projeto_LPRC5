//****************************************************************************************
//**Grupo 7: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
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
            string sql = "INSERT INTO encomenda(encomendadestinatario,encomendarecebidapor,encomendadataentrada," +
                "encomendatasaida,encomendaentreguepor,encomendaentregepara,encomendacomplemento,encomendadescricao) VALUES" +
                "('" + encomenda.getdestinatario().ToString() + "','" + encomenda.getRecebidaPor().ToString() + "','" + encomenda.getDataEntrada().ToString("yyyy/MM/dd")+ "'," +
                "'" + encomenda.getDataSaida().ToString() + "','" + encomenda.getEntreguePor().ToString() + "','" + encomenda.getEntreguePara().ToString() + "','" + encomenda.getComplemento().ToString()+ "'," +
                "'" + encomenda.getDescricao().ToString()+ "');";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "UPDATE encomenda SET encomendadestinatario = '"+ encomenda.getdestinatario().ToString() + "'," +
                                "encomendarecebidapor = '"+ encomenda.getRecebidaPor().ToString()  + "'," +
                                "encomendadataentrada = '"+ encomenda.getDataEntrada().ToString("yyyy/MM/dd") + "'," +
                                "encomendatasaida = '"+ encomenda.getDataSaida().ToString("yyyy/MM/dd") + "'," +
                                "encomendaentreguepor = '"+ encomenda.getEntreguePor().ToString() + "'," +
                                "encomendaentregepara = '"+ encomenda.getEntreguePara().ToString() + "'," +
                                "encomendacomplemento = '"+ encomenda.getComplemento().ToString() + "'," +
                                "encomendadescricao = '"+ encomenda.getDescricao().ToString() + "' " +
                                " WHERE encomendaid = "+ encomenda.getCodigo() + ";";
            ;
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "DELETE FROM encomenda WHERE encomendaid =" + encomenda.getCodigo() + ";";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectEncomendaBase(classeEncomendas encomenda)
        {
            string sql = "SELECT * FROM encomenda WHERE encomendaid =" + encomenda.getCodigo() + ";";
            return connect.retornaSQL(sql);
        }

        public classeEncomendas RetornaDadosObjeto(classeEncomendas encomenda)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeEncomendas EncomendaTemp = new classeEncomendas();

            string sql = "select * from encomenda where encomendaid = " + encomenda.getCodigo() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            EncomendaTemp.setCodigo(encomenda.getCodigo());
            EncomendaTemp.setDestinatario(ds.Tables[0].Rows[0][1].ToString());
            EncomendaTemp.setRecebidaPor(ds.Tables[0].Rows[0][2].ToString());
            EncomendaTemp.setDataEntrada(Convert.ToDateTime(ds.Tables[0].Rows[0][3].ToString()));
            EncomendaTemp.setDataSaida(Convert.ToDateTime(ds.Tables[0].Rows[0][4].ToString()));
            EncomendaTemp.setEntreguePor(ds.Tables[0].Rows[0][5].ToString());
            EncomendaTemp.setEntreguePara(ds.Tables[0].Rows[0][6].ToString());
            EncomendaTemp.setComplemento(ds.Tables[0].Rows[0][7].ToString());
            EncomendaTemp.setDescricao(ds.Tables[0].Rows[0][8].ToString());

            return EncomendaTemp;
        }

        public DataTable selectEncomendaBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select encomendaid, encomendadestinatario, encomendacomplemento from encomenda;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

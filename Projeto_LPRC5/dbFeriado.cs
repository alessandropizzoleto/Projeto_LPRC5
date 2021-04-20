//****************************************************************************************
//**Criado por: Rodrigo Bosso
//**Data de Criação: 19 /04 /2021
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
    class bdFeriado
    {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereFeriadoBase(ClasseFeriado feriado)
        {
            string sql = $"insert into feriados  (feriadoId, feriadoDia, feriadoMes, feriadoDescricao)  values {feriado.Dia}, {feriado.Mes},{feriado.Descricao} );";
            //connect.executaSQL("");
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraFeriadoBase(ClasseFeriado feriado)
        {
            string sql = $"Update feriados set feriadoDia ={feriado.Dia}, feriadoMes ={feriado.Mes}, feriadoDescricao = {feriado.Descricao} where feriadoId = {feriado.Id};";
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiFeriadoBase(ClasseFeriado feriado)
        {
            string sql = $"Delete from feriados where feriadoId = {feriado.Id};" ;
            //connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectFeriadoBase(ClasseFeriado feriado)
        {
            string sql = $"Select * from feriados where feriadoId = {feriado.Id};" ;
            //return connect.retornaSQL(sql);
            return null;
        }

        public ClasseFeriado RetornaDadosObjeto(ClasseFeriado feriado)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            ClasseFeriado feriadoTemp = new ClasseFeriado();

            //string sql = "select cidId, cidNome from cidade where cidId = " + feriado.getId() + ";";
            //adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            feriadoTemp.Id = feriado.Id;
            

            return feriadoTemp;
        }

        public DataTable selectFeriadoBase()
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

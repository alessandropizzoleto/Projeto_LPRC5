//****************************************************************************************
//**Criado por: André Costa, Amanda Ferrari, Giovanna Valim
//**Data de Criação: 19/04/2021
//**Instruções: --
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Projeto_LPRC5
{
    class dbTipoUsuario
    {
        private Int32 retorno;
        private conexaoMySql connectUsu = new conexaoMySql();
        public MySqlCommand command = new MySqlCommand();

        //Cria as intstrução SQL para insert de dados na Base de dados

        
        public void insereTipoUsuario(classeTipoUsuario tUsuario)
        {
            command.CommandText = "insert into tipousuario (tipousuariodescricao) values ('" + tUsuario.getDescricao() + "');";
            //command.Parameters.AddWithValue("descricao", tUsuario.getDescricao());
            retorno = connectUsu.executaSQL(command.CommandText.ToString());
        }

        public void alteraTipoUsuario(classeTipoUsuario tUsuario)
        {
            command.CommandText = "update tipousuario set tipousuariodescricao = ('" + tUsuario.getDescricao() + "') where tipousuarioid= " + tUsuario.getId() + ";";
           // command.Parameters.AddWithValue("descricao", tUsuario.getDescricao());
           // command.Parameters.AddWithValue("id", tUsuario.getId());
            retorno = connectUsu.executaSQL(command.CommandText.ToString());
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiTipoUsuario(classeTipoUsuario tUsuario)
        {
            command.CommandText = "DELETE FROM tipousuario WHERE tipousuarioid = " + tUsuario.getId() + ";";
            retorno = connectUsu.executaSQL(command.CommandText.ToString());
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectTipoUsuario(classeTipoUsuario tUsuario)
        {
            command.CommandText = "SELECT tipousuarioid, tipousuariodescricao FROM tipousuario;";
            retorno = connectUsu.executaSQL(command.CommandText.ToString());
            return connectUsu.retornaSQL(command.CommandText);      
        }

        public classeTipoUsuario selectTipoUsuarioDBase(classeTipoUsuario tUsuario)
        {
            classeTipoUsuario tempUsuario = new classeTipoUsuario();
            DataSet ds = new DataSet();       
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            command.CommandText = "SELECT tipousuariodescricao FROM tipousuario where tipousuarioid =" + tUsuario.getId() +" ;";

            adapter = connectUsu.retornaSQL(command.CommandText);
            adapter.Fill(ds);

            tempUsuario.setId(tUsuario.getId());
            tempUsuario.setDescricao(ds.Tables[0].Rows[0][0].ToString());
            
            return tempUsuario;
        }

        public MySqlDataAdapter selectTipoUsuarioDBase()
        {
            command.CommandText = "SELECT tipousuarioid, tipousuariodescricao FROM tipousuario;";
            return connectUsu.retornaSQL(command.CommandText);
        }

        public DataTable selectTipoUsuarioDBaseGrid()
        {
            MySqlDataAdapter adapter;
            DataTable tabela = new DataTable();
            adapter = selectTipoUsuarioDBase();
            adapter.Fill(tabela);
            return tabela;
        }

    }
}


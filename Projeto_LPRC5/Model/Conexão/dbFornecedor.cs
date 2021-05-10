//****************************************************************************************
//**Criado por: Daniel Galdencio dos Santos, Antonio Naranjo
//**Data de Criação: 09/05/2021
//**Instruções: Realizada a criação dos parâmetros de insert, update e select dos dados da tabela no banco de dados 
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
    class dbFornecedor
    {
        private conexaoMySql connectUsu = new conexaoMySql();

        //Cria as instrução SQL para insert de dados na Base de dados

        //adiciona cnpj ou cpf do fornecedor
        public void insere_cnpj(ClasseFornecedor dFornecedor)
        {
            string sql = "insert into fornecedor (fornecedor_cnpj_cpf) values ('" + dFornecedor.fornecedor_cnpj_cpf() + "');";
            connectUsu.executaSQL(sql);
        }


        //adiciona telefone do fornecedor
        public void insere_telefone(ClasseFornecedor dFornecedor)
        {
            string sql = "insert into fornecedor (fornecedor_telefone) values ('" + dFornecedor.fornecedor_telefone() + "');";
            connectUsu.executaSQL(sql);
        }


        //adiciona nome do fornecedor
        public void insere_nome(ClasseFornecedor dFornecedor)
        {
            string sql = "insert into fornecedor (fornecedor_nome) values ('" + dFornecedor.fornecedor_nome() + "');";
            connectUsu.executaSQL(sql);
        }


        //adiciona serviço prestado pelo fornecedor
        public void insere_servico(ClasseFornecedor dFornecedor)
        {
            string sql = "insert into fornecedor (fornecedor_tipo) values ('" + dFornecedor.fornecedor_servico() + "');";
            connectUsu.executaSQL(sql);
        }


        //adiciona e-mail do fornecedor
        public void insere_email(ClasseFornecedor dFornecedor)
        {
            string sql = "insert into fornecedor (fornecedor_email) values ('" + dFornecedor.fornecedor_email() + "');";
            connectUsu.executaSQL(sql);
        }




        //Cria as intstrução SQL para update de dados na Base de dados


        // altera telefone

        public void altera_telefone(ClasseFornecedor dFornecedor)
        {
            string sql = "update fornecedor set fornecedor_telefone = ('" + dFornecedor.fornecedor_telefone() + "') where fornecedor_id= " + dFornecedor.fornecedor_id() + ";";
            connectUsu.executaSQL(sql);
        }

        //altera nome

        public void altera_nome(ClasseFornecedor dFornecedor)
        {
            string sql = "update fornecedor set fornecedor_nome = ('" + dFornecedor.fornecedor_nome() + "') where fornecedor_id= " + dFornecedor.fornecedor_id() + ";";
            connectUsu.executaSQL(sql);
        }

        //altera serviço

        public void altera_servico(ClasseFornecedor dFornecedor)
        {
            string sql = "update fornecedor set fornecedor_servico = ('" + dFornecedor.fornecedor_servico() + "') where fornecedor_id= " + dFornecedor.fornecedor_id() + ";";
            connectUsu.executaSQL(sql);
        }

        //altera email

        public void altera_email(ClasseFornecedor dFornecedor)
        {
            string sql = "update fornecedor set fornecedor_telefone = ('" + dFornecedor.fornecedor_telefone() + "') where fornecedor_id= " + dFornecedor.fornecedor_id() + ";";
            connectUsu.executaSQL(sql);
        }




        //Cria a instrução SQL para Delete de dados na base de dados

        //exclui o fornecedor
        public void excluifornecedor(ClasseFornecedor dFornecedor)
        {
            string sql = "DELETE FROM fornecedor WHERE fornecedor_id = " + dFornecedor.fornecedor_id() + ";";
            connectUsu.executaSQL(sql);
        }




        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectTipoUsuario(ClasseFornecedor dFornecedor)
        {
            string sql = "SELECT fornecedor_id, fornecedor_cnpj_cpf, fornecedor_telefone, fornecedor_nome, tipo_servico, fornecedor_email  FROM fornecedor;";
            return connectUsu.retornaSQL(sql);
        }



        public classeFornecedor selectcondominiobase(ClasseFornecedor dFornecedor)
        {
            classeTipoUsuario tempUsuario = new classeFornecedor();
            DataSet ds = new DataSet();

            string sql = "SELECT fornecedor_id, fornecedor_cnpj_cpf, fornecedor_telefone, fornecedor_nome, tipo_servico, fornecedor_email FROM fornecedor where fornecedor_id =" + dFornecedor.fornecedor_id() + " ;";

            MySqlDataAdapter adapter = connectUsu.retornaSQL(sql);
            adapter.Fill(ds);

            

            Tempcondominiobase.setId(dFornecedor.fornecedor_id());


            return Tempcondominiobase;

        }

        public MySqlDataAdapter selectcondominiobase()
        {
            string sql = "SELECT fornecedor_id, fornecedor_cnpj_cpf, fornecedor_telefone, fornecedor_nome, tipo_servico, fornecedor_email FROM fornecedor;";
            return connectUsu.retornaSQL(sql);
        }

        public DataTable selectcondominiobase()
        {
            MySqlDataAdapter adapter;
            DataTable tabela = new DataTable();
            adapter = selectcondominiobase();
            adapter.Fill(tabela);
            return tabela;
        }

    }
}


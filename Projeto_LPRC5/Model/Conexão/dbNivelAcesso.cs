﻿//****************************************************************************************
//**Criado por: Amanda Ferrari, André Luiz, Giovanna Valim
//**Data de Criação: 24/05/2021
//**Instruções:
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
    class dbNivelAcesso
    {
        conexaoMySql connect = new conexaoMySql();

        public void insereNivelAcessoBase(classeNivelAcesso nivelAcesso)
        {
            string sql = $"insert into nivelacesso (nivelacessodescricao)  values ('{nivelAcesso.getNivelAcessoDescricao()}');";
            connect.executaSQL(sql);
        }

        public void alteraNivelAcessoBase(classeNivelAcesso nivelAcesso)
        {
            string sql = $"update nivelacesso set nivelacessodescricao = '{nivelAcesso.getNivelAcessoDescricao()}' where nivelacessoid = {nivelAcesso.getNivelAcessoId()};";
            connect.executaSQL(sql);
        }

        public void excluiNivelAcessoBase(classeNivelAcesso nivelAcesso)
        {
            string sql = $"delete from nivelacesso where nivelacessoid = {nivelAcesso.getNivelAcessoId()};";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectNivelAcessoBase(classeNivelAcesso nivelAcesso)
        {
            string sql = $"select * from nivelacesso where nivelacessoid = {nivelAcesso.getNivelAcessoId()};";
            return connect.retornaSQL(sql);
        }

        public classeNivelAcesso RetornaDadosObjeto(classeNivelAcesso nivelAcesso)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeNivelAcesso nivelAcessoTemp = new classeNivelAcesso();

            string sql = "select nivelacessoid, nivelacessodescricao from nivelacesso where nivelacessoid = " + nivelAcesso.getNivelAcessoId() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            nivelAcessoTemp.setNivelAcessoId(nivelAcesso.getNivelAcessoId());
            nivelAcessoTemp.setNivelAcessoDescricao(ds.Tables[0].Rows[0][1].ToString());

            return nivelAcessoTemp;
        }

        public DataTable selectNivelAcessoBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select nivelacessoid, nivelacessodescricao from nivelacesso;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

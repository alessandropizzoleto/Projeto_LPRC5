//****************************************************************************************
//**Criado por: Grupo 6
//**Data de Criação: 24/05/2021
//**Instruções:Criação CRUD.
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5.Model.Conexão
{
    class dbOpcaoAcesso
    {

        conexaoMySql connect = new conexaoMySql();

        public void insereOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"insert into opcaoacesso (opcaoacessotag, opcaoacessodescricao)  values ({OpcaoAcesso.getOpcaoAcessoTag()},'{OpcaoAcesso.getOpcaoAcessoDescricao}');";
            connect.executaSQL(sql);
        }

        public void alteraOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"update opcaoacesso set opcaoacessotag = {OpcaoAcesso.getOpcaoAcessoTag()}, opcaoacessodescricao = '{OpcaoAcesso.getOpcaoAcessoDescricao()}'  where opcaoacessoid = {OpcaoAcesso.getOpcaoAcessoId()};";
            connect.executaSQL(sql);
        }

        public void excluiOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"delete from opcaoacesso where opcaoacessoid = {OpcaoAcesso.getOpcaoAcessoId()};";
            connect.executaSQL(sql);
        }

        public MySqlDataAdapter selectOpcaoAcessoBase(classeOpcaoAcesso OpcaoAcesso)
        {
            string sql = $"select * from opcaoacesso where opcaoacessoid = {OpcaoAcesso.getOpcaoAcessoId()};";
            return connect.retornaSQL(sql);
        }

        public classeOpcaoAcesso RetornaDadosObjeto(classeOpcaoAcesso OpcaoAcesso)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeOpcaoAcesso OpcaoAcessoTemp = new classeOpcaoAcesso();

            string sql = "select opcaoacessoid, opcaoacessotag, opcaoacessodescricao from opcaoacesso where opcaoacessoid = " + OpcaoAcesso.getOpcaoAcessoId() + ";";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            OpcaoAcessoTemp.setOpcaoAcessoId(OpcaoAcesso.getOpcaoAcessoId());
            OpcaoAcessoTemp.setOpcaoAcessoTag(OpcaoAcesso.getOpcaoAcessoTag());
            OpcaoAcessoTemp.setOpcaoAcessoDescricao(ds.Tables[0].Rows[0][2].ToString());

            return OpcaoAcessoTemp;
        }

        public DataTable selectOpcaoAcessoBase()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "select * from opcaoacesso;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

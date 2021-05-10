//****************************************************************************************
//**Criado por: Geanluca Sampaio de Sousa, Thomas Taino, Aldemir Humberto Soares Neto, Felipe Lopes Silva e Silva
//**Data de Criação: 09/05/2021
//**Instruções: Criação do arquivo
//
//
//****** Atualizações:
//*** Data:
//*** Responsável:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LPRC5.Model.Conexão {
    class dbCondominioEmpresa {
        conexaoMySql connect = new conexaoMySql();

        //Cria as intstrução SQL para insert de dados na Base de dados
        public void insereCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"INSERT INTO condominioEmpresa (ceNome, ceLocalizacao, ceTipo) VALUES ('{condominioEmpresa.ceNome}','{condominioEmpresa.ceLocalizacao}','{condominioEmpresa.ceTipo}')";
            connect.executaSQL(sql);
        }

        //Cria as instrução SQL para update de dados na Base de dados
        public void alteraCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"UPDATE condominioEmpresa SET ceNome = '{condominioEmpresa.ceNome}', ceLocalizacao = '{condominioEmpresa.ceLocalizacao}', ceTipo = '{condominioEmpresa.ceTipo}' WHERE condominioEmpresa.ceId = '{condominioEmpresa.ceId}'";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Delete de dados na base de dados
        public void excluiCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"DELETE FROM condominioEmpresa WHERE condominioEmpresa.Id = '{condominioEmpresa.ceId}' LIMIT 1";
            connect.executaSQL(sql);
        }

        //Cria a instrução SQL para Retornar dados da Base de Dados
        public MySqlDataAdapter selectCondominioEmpresaBase(classeCondominioEmpresa condominioEmpresa) {
            string sql = $"SELECT ceId, ceNome, ceLocalizacao, ceTipo FROM condominioEmpresa WHERE ceId = '{condominioEmpresa.ceId}'";
            return connect.retornaSQL(sql);
        }

        public classeCondominioEmpresa RetornaDadosObjeto(classeCondominioEmpresa condominioEmpresa) {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            classeCondominioEmpresa condominioEmpresaTemp = new classeCondominioEmpresa();

            string sql = $"SELECT ceId, ceNome, ceLocalizacao, ceTipo FROM condominioEmpresa WHERE ceId = '{condominioEmpresa.ceId}'";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(ds);

            condominioEmpresaTemp.ceId = (condominioEmpresa.ceId);


            return condominioEmpresaTemp;
        }

        public DataTable selectCondominioEmpresaBase() {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            string sql = "SELECT ceId, ceNome, ceLocalizacao, ceTipo FROM condominioEmpresa;";
            adapter = connect.retornaSQL(sql);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}

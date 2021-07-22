//****************************************************************************************
//**Criado por: Daniel Galdencio, Antonio Naranjo, Tafael de Angelis Fogaça e Letícia Lopes Abelha
//**Data de Criação: 09/05/2021 
//**Instruções: Criação dos aributos e dos métodos acessores da classe
//
//
//****** Atualizações: Criação de funções e métodos de conexão ao banco de dados mysql
//*** Data: 22/07/21 
//*** Responsável: Daniel Galdencio, Antonio Naranjo, Tafael de Angelis Fogaça e Letícia Lopes Abelha
//****************************************************************************************

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_LPRC5
{
	class classeFornecedor
	{
		
		//Métodos Acessores
		public int fornecedor_id { get; set; }
		public int fornecedor_cnpj_cpf { get; set; }
		public int fornecedor_telefone { get; set; }
		public string fornecedor_nome { get; set; }
		public string tipo_servico { get; set; }
		public string fornecedor_email { get; set; }



        public static MySqlConnection conexao;
        public static MySqlCommand command;
        public static MySqlDataAdapter adapter;

        public static void Conectar()
        {
            conexao = new MySqlConnection("server=127.0.0.1;port=5432;database=fornecedor_db;uid=root;pwd=;");
           
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void Desconectar()
        {
            conexao.Close();
        }

        public int ExecutaSQL(string instrucaoSQL)
        {
            Conectar();
            command = new MySqlCommand(instrucaoSQL, conexao);
            command.ExecuteNonQuery();
            Desconectar();
            return 1;
        }

        public DataTable RetornaSQL(string instrucaoSQL)
        {
            Conectar();
            DataTable dt = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(instrucaoSQL, conexao))
            {
                adapter.Fill(dt);
            }
            Desconectar();
            return dt;
        }












    }
}

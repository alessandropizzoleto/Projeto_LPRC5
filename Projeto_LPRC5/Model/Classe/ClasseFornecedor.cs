//****************************************************************************************
//**Criado por: Daniel Galdencio, Antonio Naranjo
//**Data de Criação: 09/05/2021 
//**Instruções: Criação dos aributos e dos métodos acessores da classe
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

	}
}

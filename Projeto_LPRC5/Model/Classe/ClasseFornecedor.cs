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
	class ClasseFornecedor
	{

		//Atributos da classe
		private int empresa_cnpj_cpf;
		private int empresa_telefone;
		private string empresa_nome;
		private string tipo_servico;
		private string empresa_email;
		

		
		//Métodos Acessores
		public int empresa_cnpj_cpf { get; set; }
		public int empresa_telefone { get; set; }
		public string empresa_nome { get; set; }
		public string tipo_servico { get; set; }
		public string empresa_email { get; set; }

	}
}

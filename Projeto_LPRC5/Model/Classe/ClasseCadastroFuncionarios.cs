//****************************************************************************************
//**Criado por: Giovanni Marques, Bruno Bragagnolo e Renan Vaz
//**Data de Criação: 02/05/2021
//**Instruções: Classe referente ao formulário "formCadastroFuncionario".
//
//
//****** Atualizações: criação do set e get
//*** Data:02/05/2021
//*** Responsável:Giovanni Marques
//*****************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    public class classeCadastroFuncionarios
    {

       
        public int Id { get; set; }
        private string Nome { get; set; }
        private string CPF { get; set; }
        private string NumeroTelefone { get; set; }
        private string DataNascimento { get; set; }
        private string Endereco { get; set; }
        private string DataAdmissao { get; set; }
        private char Sexo { get; set; }
        private string EstadoCivil { get; set; }


        public classeCadastroFuncionarios()
        {

        }
        public classeCadastroFuncionarios(string nome, string cpf, string telefone, string datanascimento, string endereco, string dataadimissao, char sexo, string EstadoCivil)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.NumeroTelefone = telefone;
            this.DataNascimento = datanascimento;
            this.Endereco = endereco;
            this.DataAdmissao = dataadimissao;
            this.Sexo = sexo;
            this.EstadoCivil = EstadoCivil;
        }
    }
}
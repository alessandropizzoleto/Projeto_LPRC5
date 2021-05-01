//****************************************************************************************
//**Criado por: Amanda Ferrari, Giovanna Valim, André Costa
//**Data de Criação: 01/05/2021
//**Instruções: Criação da classe usada no form frmVisitantePrestador
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
    public class classVisitantePrestador
    {

        private string Nome { get; set; }
        private string Cpf { get; set; }
        private string NomeEmpresa { get; set; }
        private string Vinculo { get; set; }

        public classVisitantePrestador()
        {

        }
        public classVisitantePrestador(string nome, string cpf, string empresa, string vinculo)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.NomeEmpresa = empresa;
            this.Vinculo = vinculo;
        }
    }
}
//****************************************************************************************
//**Criado por:André Sirikaku Miyashiro
//**Data de Criação: 26/04/2021
//**Instruções:
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
    class classeEmpresaPrestadoraServico
    {
        //Atributos da Classe
            private int     EmpresaPrestadoraServicoid;
            private string  Empresa;
            private int     Telefone;
            private string  TipoServico;
            private string  Endereco;
            private string  Descricao;

        public classeEmpresaPrestadoraServico()
        {

        
        }
        public classeEmpresaPrestadoraServico(int id, string Nome, int Numero, String Servico, String Local, String Desc)
        {
        EmpresaPrestadoraServicoid = id;
        Empresa = Nome;
        Telefone = Numero;
        TipoServico = Servico;
        Endereco = Local;
        Descricao = Desc;
        }
        public void setEmpresaPrestadoraServicoId(int idEmpresaPrestadoraServicoid)
        {
            EmpresaPrestadoraServicoid = idEmpresaPrestadoraServicoid;
        }
        public int getEmpresaPrestadoraServicoId()
        {
            return EmpresaPrestadoraServicoid;
        }
        public void setEmpresaPrestadoraServicoNome(string NomeEmpresaPrestadoraServicoEmpresa)
        {
            Empresa = NomeEmpresaPrestadoraServicoEmpresa;
        }
        public string getEmpresaPrestadoraServicoNome()
        {
            return Empresa;
        }
        public void setEmpresaPrestadoraServiconumero(int NomeEmpresaPrestadoraServicoNumero)
        {
            Telefone = NomeEmpresaPrestadoraServicoNumero;
        }
        public int getEmpresaPrestadoraServiconumero()
        {
            return Telefone;
        }
        public void setEmpresaPrestadoraServicoservico(string NomeEmpresaPrestadoraServicoServico)
        {
            TipoServico = NomeEmpresaPrestadoraServicoServico;
        }
        public string getEmpresaPrestadoraServicoservico()
        {
            return TipoServico;
        }
        public void setEmpresaPrestadoraServicolocal(string NomeEmpresaPrestadoraServicoLocal)
        {
            Endereco = NomeEmpresaPrestadoraServicoLocal;
        }
        public string getEmpresaPrestadoraServicolocal()
        {
            return Endereco;
        }
        public void setEmpresaPrestadoraServicoDesc(string NomeEmpresaPrestadoraServicodesc)
        {
            Descricao = NomeEmpresaPrestadoraServicodesc;
        }
        public string getEmpresaPrestadoraServicoDesc()
        {
            return Descricao;
        }
    } 
}

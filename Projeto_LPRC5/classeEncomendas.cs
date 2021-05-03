//****************************************************************************************
//**Grupo: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 03/05/2021
//**Instruções: Criação dos getters and setters do objeto frmEncomendas
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
    class classeEncomendas
    {
        private string tipoEncomenda;
        private string destinatario;
        private string recebidaPor;
        private string dataEntrada;
        private string entreguePor;
        private string dataSaida;
        private string entreguePara;
        private string unidade;

        public classeEncomendas(string tipoEncomenda, string destinatario, string recebidaPor, string dataEntrada, string entreguePor, string dataSaida, string entreguePara, string unidade)
        {
            
            this.tipoEncomenda = tipoEncomenda;
            this.destinatario = destinatario;
            this.recebidaPor = recebidaPor;
            this.dataEntrada = dataEntrada;
            this.entreguePor = entreguePor;
            this.dataSaida = dataSaida;
            this.entreguePara = entreguePara;
            this.unidade = unidade;
        }

        public classeEncomendas()
        {

        }       

        public void settipoEncomenda(string tipo)
        {
            tipoEncomenda = tipo;
        }

        public string gettipoEncomenda()
        {
            return tipoEncomenda;
        }
        public void setdestinatario(string destina)
        {
            destinatario = destina;
        }

        public string getdestinatario()
        {
            return destinatario;
        }
        public void setrecebidaPor(string recepor)
        {
            recebidaPor = recepor;
        }

        public string getrecebidaPor()
        {
            return recebidaPor;
        }
        public void setdataEntrada(string datentra)
        {
            dataEntrada = datentra;
        }

        public string getdataEntrada()
        {
            return dataEntrada;
        }
        public void setentreguePor(string entrepor)
        {
            entreguePor = entrepor;
        }

        public string getentreguePor()
        {
            return entreguePor;
        }
        public void setdataSaida(string datesai)
        {
            dataSaida = datesai;
        }

        public string getdataSaida()
        {
            return dataSaida;
        }
        public void setentreguePara(string entrepara)
        {
            entreguePara = entrepara;
        }

        public string getentreguePara()
        {
            return entreguePara;
        }
        public void setunidade(string unide)
        {
            unidade = unide;
        }

        public string getunidade()
        {
            return unidade;
        }
    }
}
    


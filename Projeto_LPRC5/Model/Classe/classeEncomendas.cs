//****************************************************************************************
//**Grupo: Guilherme A. Rissato, Caio Costa Braga, Roberto Marcheti Neto
//**Criado por: Roberto Marcheti Neto
//**Data de Criação: 03/05/2021
//**Instruções: Criação dos getters and setters do objeto frmEncomendas
//
//
//****** Atualizações:ajuste de variaveis
//*** Data:03/05/2021
//*** Responsável:Guilherme de Andrade Rissato
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
        private int codigo;
        private string destinatario;
        private string recebidaPor;
        private DateTime? dataEntrada;
        private string entreguePor;
        private DateTime? dataSaida;
        private string entreguePara;
        private string complemento;
        private string descricao;

        public classeEncomendas(int codigo,string descricao, string destinatario, string recebidaPor, DateTime? dataEntrada, string entreguePor, DateTime? dataSaida, string entreguePara, string complemento)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.destinatario = destinatario;
            this.recebidaPor = recebidaPor;
            this.dataEntrada = dataEntrada;
            this.entreguePor = entreguePor;
            this.dataSaida = dataSaida;
            this.entreguePara = entreguePara;
            this.complemento = complemento;
        }

        public classeEncomendas()
        {

        }       

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int getCodigo() {
            return codigo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public string getDescricao()
        {
            return descricao;
        }
        public void setDestinatario(string destina)
        {
            destinatario = destina;
        }

        public string getdestinatario()
        {
            return destinatario;
        }
        public void setRecebidaPor(string recepor)
        {
            recebidaPor = recepor;
        }

        public string getRecebidaPor()
        {
            return recebidaPor;
        }
        public void setDataEntrada(DateTime? datentra)
        {
            dataEntrada = datentra;
        }

        public DateTime? getDataEntrada()
        {
            return dataEntrada;
        }
        public void setEntreguePor(string entrepor)
        {
            entreguePor = entrepor;
        }

        public string getEntreguePor()
        {
            return entreguePor;
        }
        public void setDataSaida(DateTime? datesai)
        {
            dataSaida = datesai;
        }

        public DateTime? getDataSaida()
        {
            return dataSaida;
        }
        public void setEntreguePara(string entrepara)
        {
            entreguePara = entrepara;
        }

        public string getEntreguePara()
        {
            return entreguePara;
        }
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }

        public string getComplemento()
        {
            return complemento;
        }
    }
}
    


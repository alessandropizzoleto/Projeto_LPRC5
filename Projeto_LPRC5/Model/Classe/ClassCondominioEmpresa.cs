//****************************************************************************************
//**Criado por: Thomas Taino, Aldemir Neto, Felipe Lopes, Geanluca Sampaio de Sousa
//**Data de Criação:09/05
//**Instruções: Criação da classe com uso de geração automático dos getter's e setter's.
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

namespace Projeto_LPRC5{
    class classeCondominioEmpresa {
        //Atributos da Classe
        public int ceId { get; set; }
        public string ceNome { get; set; }
        public string ceLocalizacao { get; set; }
        public string ceTipo { get; set; }


        //Método Construtor
        public classeCondominioEmpresa() {

        }

        public classeCondominioEmpresa(int Id, string nome, string localizacao, string tipo) {
            this.ceId = Id;
            this.ceNome = nome;
            this.ceLocalizacao = localizacao;
            this.ceTipo = tipo;
        }

        
    }
}

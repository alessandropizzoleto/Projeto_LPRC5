﻿//****************************************************************************************
//**Criado por: Antonio Jose Naranjo, Leticia Lopes Abelha, Rafael de Angelis Fogaça e Daniel Galdencio
//**Data de Criação: 19/04/2021
//**Instruções: criação dos atributos id e descrição utilizando propriedades
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
    class classeClassificaPessoa
    {
        //Atributos da Classe
        private int classificapessoaid;
        private int classificapessoadescricao { get; set; }


        //Método Construtor
        public classeClassificaPessoa()
        {

        }

        //Métodos Acessores
        public void setId(int id)
        {
            classificapessoaid = id;
        }
        public int getId()
        {
            return classificapessoaid;
        }
     } 
}

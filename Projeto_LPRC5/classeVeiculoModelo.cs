//****************************************************************************************
//**Criado por: Guilherme A Rissato
//**Data de Criação: 19/04/2021
//**Descrição: criação dos getters and setters do objeto veiculo modelo
//**Instruções: 
// 
// 
//****** Atualizações: O código está OK, não sendo necessário efetuar alterações
//*** Data: 03/05/2021
//*** Responsável: Giovanni Marques
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeVeiculoModelo
    {
        private int idVeiculo;
        private string nomeVeiculo;

        public classeVeiculoModelo(int idVeiculo, string nomeVeiculo)
        {
            this.idVeiculo = idVeiculo;
            this.nomeVeiculo = nomeVeiculo;
        }

        public classeVeiculoModelo() {
        
        }

        public void setVeiculoID(int ID) 
        {
            idVeiculo = ID;
        }

        public int getVeiculoID() {
            return idVeiculo;
        }

        public void setnomeVeiculo(string nome)
        {
            nomeVeiculo = nome;
        }

        public string getnomeVeiculo()
        {
            return nomeVeiculo;
        }

    }
}

//****************************************************************************************
//**Criado por: André Sirikaku Miyashiro
//**Data de Criação: 19/04/2021
//**Instruções: criação dos atributos dia, mês e descrição utilizando prop.
// O prop ja cria os metodos get e set para os atributos criados
//
//
//****** Atualizações: passei a variavel feriadoId para Id e utilizei o prop para criar os 
// metods get e set
//*** Data:20/04
//*** Responsável: André Sirikaku
//
//
//****** Atualizações: Get e Set funcionais alem da criação do construtor e nomes corrigidos de acordo com o banco de dados
//*** Data:03/05/2021
//*** Responsável:Grupo 6
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LPRC5
{
    class classeFeriado
    {

        private int FeriadoId;
        private int FeriadoDia;
        private int FeriadoMes;
        private string FeriadoNome;

        public classeFeriado() { 
        
        
        
        }
        public classeFeriado(int id, int dia, int mes, string nome)
        {
            FeriadoId = id;
            FeriadoDia = dia;
            FeriadoMes = mes;
            FeriadoNome = nome;

        }

        public void setFeriadoId(int IdFeriado)
        {
            FeriadoId = IdFeriado;
        }
        public int getFeriadoId()
        {
            return FeriadoId;
        }
        public void setFeriadoDia(int DiaFeriado)
        {
            FeriadoDia = DiaFeriado;
        }
        public int getFeriadoDia()
        {
            return FeriadoDia;
        }
        public void setFeriadoMes(int MesFeriado)
        {
            FeriadoMes = MesFeriado;
        }
        public int getFeriadoMes()
        {
            return FeriadoMes;
        }
        public void setFeriadoNome(string NomeFeriado)
        {
            FeriadoNome = NomeFeriado;
        }
        public string getFeriadoNome()
        {
            return FeriadoNome;
        }
    }
}


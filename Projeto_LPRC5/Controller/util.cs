//****************************************************************************************
//**Criado por: Alessandro Viola 
//**Data de Criação: 12/04/2021
//**Descrição: 
// Contém Funções úteis para o gerenciamento e configurção das funcionalidades implementadas 
// de uso geral para o Software
//**Instruções:
// 
// 
//****** Atualizações:
//*** Data: 13/04/2021
//*** Responsável: Alessandro Viola
//*** O que feito:
// Inclusão da informação para guardar o SGBD Selecionado.
//*** Data: 14/04/2021
//*** Responsável: Caique, Guilherme, Alexandro
//*** O que feito:
//  Botão Salvar exibe mensagem de confirmação e limpa campos, botão cancelar fecha frame Acesso.
//*** Data:
//*** Responsável:
//*** O que feito:
// 
//****************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace Projeto_LPRC5
{
    class util
    {
        public string servidor = "";
        public string usuario = "";
        public string senha = "";
        public string banco = "";
        public Int16 sgbd_Id = -1;
        private string path = "C:\\software\\acesso.txt";

        public void lerArquivoAcessoBanco()
        {
            string linha = "";
            if (System.IO.File.Exists(path))
            {
                StreamReader texto = new StreamReader(path);
                while (texto.EndOfStream == false)
                {
                    linha = texto.ReadLine().ToString();
                    if (linha.Contains("servidor="))
                    {
                        servidor = linha.Substring(9, linha.IndexOf(";") - 9);
                    }
                    else if (linha.Contains("usuario="))
                    {
                        usuario = linha.Substring(8, linha.IndexOf(";") - 8);
                    }
                    else if (linha.Contains("banco="))
                    {
                        banco = linha.Substring(6, linha.IndexOf(";") - 6);
                    }
                    else if (linha.Contains("senha="))
                    {
                        senha = linha.Substring(6, linha.IndexOf(";") - 6);
                    }
                    else if (linha.Contains("sgbd="))
                    {
                        sgbd_Id = Convert.ToInt16(linha.Substring(5, linha.IndexOf(";") - 5));
                    }
                }
                texto.Close();
            }
        }

        public void gravaArquivoAcessoBanco(string servidor, string usuario, string banco, string senha, Int16 sgbd)
        {
            StreamWriter texto = new StreamWriter(path);
            texto.WriteLine("servidor=" + servidor + ";");
            texto.WriteLine("usuario=" + usuario + ";");
            texto.WriteLine("banco=" + banco + ";");
            texto.WriteLine("senha=" + senha + ";");
            texto.WriteLine("sgbd=" + sgbd.ToString() + ";");
            texto.Close();
        }

        
    }
}

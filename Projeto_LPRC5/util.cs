using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Projeto_LPRC5
{
    class util
    {
        public string servidor = "";
        public string usuario = "";
        public string senha = "";
        public string banco = "";

        public void lerArquivoAcessoBanco(string path)
        {
            string linha = "";
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
            }
            texto.Close();
        }

        public void gravaArquivoAcessoBanco(string path, string servidor, string usuario, string banco, string senha)
        {
            StreamWriter texto = new StreamWriter(path);
            texto.WriteLine("servidor=" + servidor + ";");
            texto.WriteLine("usuario=" + usuario + ";");
            texto.WriteLine("banco=" + banco + ";");
            texto.WriteLine("senha=" + senha + ";");
            texto.Close();
        }
    }
}

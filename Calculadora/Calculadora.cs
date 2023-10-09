using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculadora
    {
        private List<string> listahistorico;
        private string data;

        public Calculadora(string data)
    {
        listaHistorico = new List<string>();

        this.data = data;
    }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listahistorico.Insert(0, "res: " + res + " - data" + data);
            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
           listahistorico.Insert(0, "res: " + res + " - data" + data);
            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listahistorico.Insert(0, "res: " + res + " - data" + data);
            return res;
            
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listahistorico.Insert(0, "res: " + res + " - data" + data);
            return res;
        }
        public List<String> historico()
        {
            
            listahistorico.Insert(0, "res: " + res + " - data" + data);
            
            return listahistorico;
        }
            

    }
}
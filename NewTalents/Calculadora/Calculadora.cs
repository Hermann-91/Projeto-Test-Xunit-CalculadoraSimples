using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Calculadora
{
    public class Calculadora
    {
        private List<string>listaHitorico;
        private string data;
        public Calculadora(string data)
        {
            listaHitorico = new List<string>();
            this.data = data;
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaHitorico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHitorico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHitorico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHitorico.Insert(0, "Res:" + res + "- data: " + data);
            return res;
        }

        public List<string> historico()
        {
            
            listaHitorico.RemoveRange(3, listaHitorico.Count - 3);
            return listaHitorico;
        }

        


        

    }
}
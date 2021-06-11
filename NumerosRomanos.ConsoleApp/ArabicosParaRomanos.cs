using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class ArabicosParaRomanos
    {
        public Dictionary<int, string> numerosArabicosParaRomanos = GerarDicionarioArabicoParaRomano();
        public string valor;
        public string ConverterParaRomano()
        {
            string resultado = "";
            if (Validar() == "valido")
            {
                resultado = TransformarEmNumerosRomanos(Convert.ToInt32(valor));                
                return resultado;
            }
            else
                return Validar();
        }

        private string TransformarEmNumerosRomanos(int numeroArabico)
        {
            foreach (int numero in numerosArabicosParaRomanos.Keys)
            {
                if (numeroArabico >= numero) return numerosArabicosParaRomanos[numero] + TransformarEmNumerosRomanos(numeroArabico - numero);
            }
            return "";
        }

        private static Dictionary<int, string> GerarDicionarioArabicoParaRomano()
        {
            Dictionary<int, string> numerosRomanosParaArabicos = new Dictionary<int, string>()
            {
                {10000, "X̄"}, {9000, "ĪV̄"}, {8000, "V̄ĪĪĪ"}, {7000, "V̄ĪĪ"}, {6000, "V̄Ī"},
                {5000, "V̄"}, {4000, "ĪV̄"}, {1000, "M"}, {900, "CM"}, {500, "D"},
                {400, "DC"}, {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
            };
            return numerosRomanosParaArabicos;
        }

        private string Validar()
        {
            foreach (char c in valor)
            {
                if (char.IsLetter(c))
                    return "Mensagem contém números romanos, use somente números arabicos!";
            }
            if (valor == "0")
                return "Não existe ZERO em números romanos!";
            if (valor == "")
                return "Mensagem vazia, erro!";
            if (Convert.ToDouble(valor) > 10000)
                return "Números romanos não passam de 10 MIL!";
            return "valido";
        }
    }
}

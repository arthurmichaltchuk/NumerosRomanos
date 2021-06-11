using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class RomanosParaArabicos
    {
        public Dictionary<string, int> numerosRomanosParaArabicos = GerarDicionarioRomanoParaArabico();
        public string valor;
        public string ConverterParaArabico()
        {
            TrocarCaracteresEspeciais();

            int ultimoNumero = 999999999;
            int soma = 0;
            int resultado = 0;
            if (Validar() == "valido")
            {
                foreach (char c in valor)
                {
                    resultado = TransformarEmNumerosArabicos(Convert.ToString(c));    
                    if (ultimoNumero < resultado)
                    {
                        soma -= ultimoNumero;
                        soma += resultado - ultimoNumero;
                    }
                    else
                        soma += resultado;
                    ultimoNumero = resultado;       
                }
                return Convert.ToString(soma);
            }
            else
                return Validar();
        }

        private void TrocarCaracteresEspeciais()
        {
            valor = valor.Replace("Ī", "O");
            valor = valor.Replace("V̄", "P");
            valor = valor.Replace("X̄", "K");
        }

        private int TransformarEmNumerosArabicos(string numeroEmTexto)
        {
            if (numerosRomanosParaArabicos.ContainsKey(numeroEmTexto))
                return numerosRomanosParaArabicos[numeroEmTexto];
            return 0;
        }

        private static Dictionary<string, int> GerarDicionarioRomanoParaArabico()
        {
            Dictionary<string, int> numerosRomanosParaArabicos = new Dictionary<string, int>()
            {
                {"I", 1 },{"V", 5},{"X", 10},{"L", 50},{"C", 100},{"D", 500},{"M", 1000},{"O", 1000},
                {"P", 5000},{"K", 10000}
            };
            return numerosRomanosParaArabicos;
        }

        private string Validar()
        {

            if (valor == "0")
                return "Não existe ZERO em números romanos!";            
            if (valor == "")
                return "Mensagem vazia, erro!";
            foreach (char c in valor)
            {
                if (char.IsNumber(c))
                    return "Mensagem contém número arabico, use somente números romanos!";
            }
            return "valido";
        }
    }
}

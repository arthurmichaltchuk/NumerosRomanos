using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ConsoleApp;

namespace Testes
{
    [TestClass]
    public class ParaArabicos
    {
        [TestMethod]
        [DataRow("I","1")]
        [DataRow("II", "2")]
        [DataRow("IV", "4")]
        [DataRow("VI", "6")]
        [DataRow("X", "10")]
        [DataRow("IX", "9")]
        [DataRow("XIX", "19")]
        [DataRow("XXIX", "29")]
        [DataRow("XLIV", "44")]
        [DataRow("LXXX", "80")]
        [DataRow("LXXXV", "85")]
        [DataRow("XCIX", "99")]
        [DataRow("CXXI", "121")]
        [DataRow("CLXVIII", "168")]
        [DataRow("CXCIX", "199")]
        [DataRow("CCLIII", "253")]
        [DataRow("CCCLXXI", "371")]
        [DataRow("CDXXVIII", "428")]
        [DataRow("DLXXVI", "576")]
        [DataRow("DCXL", "640")]
        [DataRow("DCCLI", "751")]
        [DataRow("DCCCX", "810")]
        [DataRow("CMI", "901")]
        [DataRow("MXX", "1020")]
        [DataRow("MCCC", "1300")]
        [DataRow("MDCXL", "1640")]
        [DataRow("MMIX", "2009")]
        [DataRow("MMMDXXX", "3530")]
        [DataRow("ĪV̄DCCLXXI", "4771")]
        [DataRow("V̄", "5000")]
        [DataRow("V̄C", "5100")]
        [DataRow("V̄CMI", "5901")]
        [DataRow("V̄Ī", "6000")]
        [DataRow("V̄ĪĪCMVI", "7906")]
        [DataRow("V̄ĪĪĪCC", "8200")]
        [DataRow("ĪX̄CDII", "9402")]
        [DataRow("DX̄", "9500")]
        [DataRow("ĪX̄CMXCV", "9995")]
        [DataRow("ĪX̄CMXCIX", "9999")]
        //ERROS
        [DataRow("3", "Mensagem contém número arabico, use somente números romanos!")]
        [DataRow("0", "Não existe ZERO em números romanos!")]
        [DataRow("", "Mensagem vazia, erro!")]
        public void TESTESRomanoParaArabico(string numeroRomano, string numeroArabico)
        {
            RomanosParaArabicos numero = new RomanosParaArabicos();
            numero.valor = numeroRomano;

            Assert.AreEqual(numeroArabico, numero.ConverterParaArabico());
        }
    }
}

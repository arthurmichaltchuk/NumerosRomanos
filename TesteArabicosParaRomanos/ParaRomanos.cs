using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos.ConsoleApp;

namespace TesteArabicosParaRomanos
{
    [TestClass]
    public class ParaRomanos
    {
        [TestMethod]
        [DataRow("1", "I")]
        [DataRow("2", "II")]
        [DataRow("4", "IV")]
        [DataRow("6", "VI")]
        [DataRow("10", "X")]
        [DataRow("9", "IX")]
        [DataRow("19", "XIX")]
        [DataRow("29", "XXIX")]
        [DataRow("44", "XLIV")]
        [DataRow("80", "LXXX")]
        [DataRow("85", "LXXXV")]
        [DataRow("99", "XCIX")]
        [DataRow("121", "CXXI")]
        [DataRow("168", "CLXVIII")]
        [DataRow("199", "CXCIX")]
        [DataRow("253", "CCLIII")]
        [DataRow("371", "CCCLXXI")]
        [DataRow("428", "DCXXVIII")]
        [DataRow("576", "DLXXVI")]
        [DataRow("640", "DCXL")]
        [DataRow("751", "DCCLI")]
        [DataRow("810", "DCCCX")]
        [DataRow("901", "CMI")]
        [DataRow("1020", "MXX")]
        [DataRow("1300", "MCCC")]
        [DataRow("1640", "MDCXL")]
        [DataRow("2009", "MMIX")]
        [DataRow("3530", "MMMDXXX")]
        [DataRow("4771", "ĪV̄DCCLXXI")]
        [DataRow("5000", "V̄")]
        [DataRow("5100", "V̄C")]
        [DataRow("5901", "V̄CMI")]
        [DataRow("6000", "V̄Ī")]
        [DataRow("7906", "V̄ĪĪCMVI")]
        [DataRow("8200", "V̄ĪĪĪCC")]
        //ERROS
        [DataRow("10001", "Números romanos não passam de 10 MIL!")]
        [DataRow("v", "Mensagem contém números romanos, use somente números arabicos!")]
        [DataRow("0", "Não existe ZERO em números romanos!")]
        [DataRow("", "Mensagem vazia, erro!")]
        public void TESTESArabicoParaRomano(string numeroArabico, string numeroRomano)
        {
            ArabicosParaRomanos numero = new ArabicosParaRomanos();
            numero.valor = numeroArabico;

            Assert.AreEqual(numeroRomano, numero.ConverterParaRomano());
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenario
{

    [TestClass]
    public class Pedra
    {
        [TestMethod]
        public void PedraXPedra()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Pedra, JokenPo.Pedra);
            Assert.AreEqual("Empate -> USER [PEDRA] | CPU [PEDRA]", result);
        }

        [TestMethod]
        public void PedraXPapel()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Pedra, JokenPo.Papel);
            Assert.AreEqual("Vencedor -> CPU [ PAPEL ]", result);
        }

        [TestMethod]
        public void PedraXTesoura()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Pedra, JokenPo.Tesoura);
            Assert.AreEqual("Vencedor -> USER [ PEDRA ]", result);
        }
    }

    [TestClass]
    public class Papel
    {
        [TestMethod]
        public void PapelXPedra()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Papel, JokenPo.Pedra);
            Assert.AreEqual("Vencedor -> USER [ PAPEL ]", result);
        }

        [TestMethod]
        public void PapelXPapel()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Papel, JokenPo.Papel);
            Assert.AreEqual("Empate -> USER [PAPEL] | CPU [PAPEL]", result);
        }

        [TestMethod]
        public void PapelXTesoura()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Papel, JokenPo.Tesoura);
            Assert.AreEqual("Vencedor -> CPU [ TESOURA ]", result);
        }
    }

    [TestClass]
    public class Tesoura
    {
        [TestMethod]
        public void TesouraXPedra()
        {

            Verificador juiz = new Verificador();

            string result = juiz.ChecarResultado(JokenPo.Tesoura, JokenPo.Pedra);
            Assert.AreEqual("Vencedor -> CPU [ PEDRA ]", result);

        }

        [TestMethod]
        public void TesouraXPapel()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Tesoura, JokenPo.Papel);
            Assert.AreEqual("Vencedor -> USER [ TESOURA ]", result);
        }

        [TestMethod]
        public void TesouraXTesoura()
        {
            Verificador juiz = new Verificador();
            string result = juiz.ChecarResultado(JokenPo.Tesoura, JokenPo.Tesoura);
            Assert.AreEqual("Empate -> USER [TESOURA] | CPU [TESOURA]", result);
        }

    }

}

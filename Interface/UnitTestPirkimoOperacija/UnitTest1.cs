using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interfacas;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPirkimoOperacija
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IdetiIKrepseli_AssertstringEquealsstring()
        {
            FakeShipment fake = new FakeShipment(); //Mock
            PirkimoOperacija pirkimas = new PirkimoOperacija(fake); // Testuojamas objektas

            string mock = "mock"; //Informacinis mock
            pirkimas.ĮdėtiĮkrepšelį(mock); //Prisidedam informacija
            List<string> mockString = new List<string>() { mock }; // Sukuriam toki pat elementa
            Assert.AreEqual(mockString.First(), pirkimas.GautiPirkiniuKrepseli().First()); // Patikrinam ar informacija sutampa
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SkaiciuotiSuma_ExceptionExpected()
        {
            FakeShipment fake = new FakeShipment();
            PirkimoOperacija pirkimas = new PirkimoOperacija(fake);
            pirkimas.SkaiciuotiVisaSuma();
        }

        [TestMethod]
        public void SkaiciuotiVisaSuma_AddMockElement_Assert2()
        {
            FakeShipment fake = new FakeShipment(); //Mock
            PirkimoOperacija pirkimas = new PirkimoOperacija(fake); // Testuojamas objektas

            string mock = "mock"; //Informacinis mock
            pirkimas.ĮdėtiĮkrepšelį(mock); //Prisidedam informacija

            Assert.AreEqual(2, pirkimas.SkaiciuotiVisaSuma());
        }
    }

    internal class FakeShipment : IshipementSkaiciuokle
    {
        public double svorisSiuntos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double SiuntosDydis(List<string> prekes)
        {
            throw new NotImplementedException();
        }

        public double SiuntosSuma()
        {
            throw new NotImplementedException();
        }

        public double SiuntosSuma(List<string> prekes)
        {
            return 1;
        }

        public double SiuntosSvoris(string preke, int svoris)
        {
            throw new NotImplementedException();
        }
    }
}
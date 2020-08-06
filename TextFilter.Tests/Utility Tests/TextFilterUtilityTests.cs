using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TextFilter.Tests.Utility_Tests
{
    [TestClass]
    public class TextFilterUtilityTests
    {
        #region String Contains Vowel

        [TestMethod]
        public void ContainsVowel_InputIs_Calastone_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("calastone");

            Assert.IsTrue(result, "calastone should contain a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_CalAstone_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("calAstone");

            Assert.IsTrue(result, "calastone should contain a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_klpiuSZx_ReturnFalse()
        {
            var result = Core.TextFilter.ContainsVowel("klpiuszx");

            Assert.IsTrue(result, "calastone should contain a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_klpIUszx_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("klpIUszx");

            Assert.IsTrue(result, "calastone should contain a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_a_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("a");

            Assert.IsTrue(result, "a is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_e_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("e");

            Assert.IsTrue(result, "e is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_i_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("i");

            Assert.IsTrue(result, "i is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_o_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("o");

            Assert.IsTrue(result, "o is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_u_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("u");

            Assert.IsTrue(result, "u is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_A_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("A");

            Assert.IsTrue(result, "A is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_E_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("E");

            Assert.IsTrue(result, "E is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_I_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("I");

            Assert.IsTrue(result, "I is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_O_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("O");

            Assert.IsTrue(result, "O is a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_U_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("U");

            Assert.IsTrue(result, "u is a vowel");
        }

        public void ContainsVowel_InputIs_af_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("af");

            Assert.IsTrue(result, "af has a vowel");
        }

        [TestMethod]
        public void ContainsVowel_InputIs_ae_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("ak");

            Assert.IsTrue(result, "ak has a vowel");
        }

        public void ContainsVowel_InputIs_el_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("el");

            Assert.IsTrue(result, "el has a vowel");
        }

        public void ContainsVowel_InputIs_if_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("if");

            Assert.IsTrue(result, "if has a vowel");
        }

        public void ContainsVowel_InputIs_ok_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("ok");

            Assert.IsTrue(result, "ok has a vowel");
        }

        public void ContainsVowel_InputIs_zx_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("zx");

            Assert.IsFalse(result, "zx has no vowels");
        }

        public void ContainsVowel_InputIs_LS_ReturnTrue()
        {
            var result = Core.TextFilter.ContainsVowel("LS");

            Assert.IsFalse(result, "LS has no vowels");
        }

        #endregion

        #region Get Middle Of String

        [TestMethod]
        public void ContainsVowel_InputIs_calaStone_ReturnTrue()
        {
            var result = Core.TextFilter.GetMiddleOfString("calaStone");
            Assert.AreEqual("S", result);
        }

        [TestMethod]
        public void MiddleOfSting_calaStones_shouldbe_St()
        {
            var result = Core.TextFilter.GetMiddleOfString("calaStones");
            Assert.AreEqual("St", result);
        }

        [TestMethod]
        public void MiddleOfSting_calaStones_shouldbe_st()
        {
            var result = Core.TextFilter.GetMiddleOfString("calastones");
            Assert.AreEqual("st", result);
        }

        [TestMethod]
        public void MiddleOfSting_ayo_shouldbe_st()
        {
            var result = Core.TextFilter.GetMiddleOfString("ayo");
            Assert.AreEqual("y", result);
        }

        [TestMethod]
        public void MiddleOfSting_ayoDOTadesina_shouldbe_d()
        {
            var result = Core.TextFilter.GetMiddleOfString("ayo.adesina");
            Assert.AreEqual("d", result);
        }


        [TestMethod]
        public void MiddleOfSting_ayoadesiNa_shouldbe_d()
        {
            var result = Core.TextFilter.GetMiddleOfString("ayo!adesiNa");
            Assert.AreEqual("d", result);
        }

        [TestMethod]
        public void MiddleOfSting_ayoadesina_shouldbe_st()
        {
            var result = Core.TextFilter.GetMiddleOfString("ayoadesina");
            Assert.AreEqual("de", result);
        }






        //[TestMethod]
        //public void ContainsVowel_InputIs_calaStones_ReturnTrue()
        //{
        //    var result = Core.TextFilter.GetMiddleOfString("calaStones");
        //    Assert.AreEqual("St", result);
        //}
        #endregion

        #region Remove Symbols

        [TestMethod]
        public void RemoveSymbols_InputIs_calaStone()
        {
            var result = Core.TextFilter.RemoveSymbols("calaStone");
            Assert.AreEqual("calaStone", result);
        }

        [TestMethod]
        public void RemoveSymbols_InputIs_calaplusStone()
        {
            var result = Core.TextFilter.RemoveSymbols("cala+Stone");
            Assert.AreEqual("cala Stone", result);
        }

        [TestMethod]
        public void RemoveSymbols_InputIs_labelledORANGEMARMALADE()
        {
            var result = Core.TextFilter.RemoveSymbols("labelled `ORANGE MARMALADE'");
            Assert.AreEqual("labelled ORANGE MARMALADE ", result);
        }

        [TestMethod]
        public void RemoveSymbols_InputIs_heartheRabbitsaytoitself()
        {
            var result = Core.TextFilter.RemoveSymbols("hear the Rabbit say&.to itself");
            Assert.AreEqual("hear the Rabbit say to itself", result);
        }

        [TestMethod]
        public void RemoveSymbols_InputIs_LotsofSymbols()
        {
            var result = Core.TextFilter.RemoveSymbols("deep well.Ei$£ther the well was $£v!ry deep, !or s");
            Assert.AreEqual("deep well Ei ther the well was  v ry deep  or s", result);
        }

        #endregion
    }
}



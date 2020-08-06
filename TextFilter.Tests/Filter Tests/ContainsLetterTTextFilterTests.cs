using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilter.Core;

namespace TextFilter.Tests.Filter_Tests
{
    [TestClass]
    public class ContainsLetterTTextFilterTests
    {
        
        [TestMethod]
        public void ContainsLetterTTextFilter_inputIs_calastone_ReturnsFalse()
        {
            var testRequest = new Request() { IsValid = true, Word = "calastone" };

            ContainsLetterTTextFilter containsLetterTTextFilter = new ContainsLetterTTextFilter();

            containsLetterTTextFilter.Process(testRequest);

            Assert.IsFalse(testRequest.IsValid);
        }

        [TestMethod]
        public void ContainsLetterTTextFilter_inputIs_ayoadesina_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "ayoadesina" };

            ContainsLetterTTextFilter containsLetterTTextFilter = new ContainsLetterTTextFilter();

            containsLetterTTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }


        [TestMethod]
        public void ContainsLetterTTextFilter_inputIs_and_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "and" };

            ContainsLetterTTextFilter containsLetterTTextFilter = new ContainsLetterTTextFilter();

            containsLetterTTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }


        [TestMethod]
        public void ContainsLetterTTextFilter_inputIs_aTndT_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "aTndT" };

            ContainsLetterTTextFilter containsLetterTTextFilter = new ContainsLetterTTextFilter();

            containsLetterTTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }
     

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilter.Core;

namespace TextFilter.Tests.Filter_Tests
{
    [TestClass]
    public class LessThanThreeTextFilterTests
    {
       
        [TestMethod]
        public void LessThanThreeTextFilter_inputIs_calastone_ReturnsFalse()
        {
            var testRequest = new Request() { IsValid = true, Word = "calastone" };

            LessThanThreeTextFilter lessThanThreeTextFilter = new LessThanThreeTextFilter();

            lessThanThreeTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }

        public void LessThanThreeTextFilter_inputIs_to_ReturnsFalse()
        {
            var testRequest = new Request() { IsValid = true, Word = "to" };

            LessThanThreeTextFilter lessThanThreeTextFilter = new LessThanThreeTextFilter();

            lessThanThreeTextFilter.Process(testRequest);

            Assert.IsFalse(testRequest.IsValid);
        }


      
    }
}

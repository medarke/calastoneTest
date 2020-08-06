using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextFilter.Core;

namespace TextFilter.Tests.Filter_Tests
{
    [TestClass]
    public class MiddleVowelTextFilterTests
    {
        #region MiddleVowelTextFilter

        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_calastone_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "calastone" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }

        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_ayoadesIna_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "ayoadesIna" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsFalse(testRequest.IsValid);
        }


        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_join_ReturnsFalse()
        {
            var testRequest = new Request() { IsValid = true, Word = "join" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsFalse(testRequest.IsValid);
        }

        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_yavan_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "yavan" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }

        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_textWithSymbol_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "docks" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }


        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_omobono_ReturnsTrue()
        {
            var testRequest = new Request() { IsValid = true, Word = "omobono" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsTrue(testRequest.IsValid);
        }

        [TestMethod]
        public void MiddleVowelTextFilter_inputIs_Microsoft_ReturnsFalse()
        {
            var testRequest = new Request() { IsValid = true, Word = "Microsoft" };

            MiddleVowelTextFilter middleVowelTextFilter = new MiddleVowelTextFilter();

            middleVowelTextFilter.Process(testRequest);

            Assert.IsFalse(testRequest.IsValid);
        }

        #endregion
    }
}

using LogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicLayer_Tests
{
    [TestClass]
    public class WorkingWithStringsTests
    {   
        [TestMethod]
        [DataRow("racecar")]
        public void CheckIfStringIsPalindrome(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsTrue(repo.IsStringAPalindrome(data));
        }

        [TestMethod]
        [DataRow("ThisIsNotAPalindrome")]
        public void CheckIfStringIsNotAPalindrome(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsFalse(repo.IsStringAPalindrome(data));
        }

        [TestMethod]
        [DataRow("ThisIsLongerThan5Characters")]
        public void CheckIfStringIsGreaterThan5Chars(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsTrue(repo.IsStringGreaterThan5Characters(data));
        }

        [TestMethod]
        [DataRow("Blah")]
        [DataRow("Bleh")]
        [DataRow("Blih")]
        [DataRow("Bloh")]
        [DataRow("Bluh")]
        public void CheckIfStringContainsVowel(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsTrue(repo.DoesStringContainAVowel(data));
        }

        [TestMethod]
        [DataRow("sdwqfgjtn")]
        public void CheckIfStringDoesNotContainVowel(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsFalse(repo.DoesStringContainAVowel(data));
        }

        [TestMethod]
        [DataRow("3123546")]
        [DataRow("ThiSha$D1ff3ntStuff$")]
        public void CheckIfStringContainsANumber(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsTrue(repo.DoesStringContainANumber(data));
        }

        [TestMethod]
        [DataRow("NoNumbersHere")]
        public void CheckIfStringDoesNotContainANumber(string data)
        {
            var repo = new WorkingWithStrings();

            Assert.IsFalse(repo.DoesStringContainANumber(data));
        }
    }
}

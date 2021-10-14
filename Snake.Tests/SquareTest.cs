using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Snake.Tests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestIndex()
        {
            Assert.AreEqual(new Square(File.A, Rank.First).Index, 0);
            Assert.AreEqual(new Square(File.E, Rank.Sixth).Index, 44);
            Assert.AreEqual(new Square(File.H, Rank.Eighth).Index, 63);
        }

        [TestMethod]
        public void TestRank()
        {
            Assert.AreEqual(new Square(File.A, Rank.First).Rank, Rank.First);
            Assert.AreEqual(new Square(File.E, Rank.Sixth).Rank, Rank.Sixth);
            Assert.AreEqual(new Square(File.H, Rank.Eighth).Rank, Rank.Eighth);
        }

        [TestMethod]
        public void TestFile()
        {
            Assert.AreEqual(new Square(File.A, Rank.First).File, File.A);
            Assert.AreEqual(new Square(File.E, Rank.Sixth).File, File.E);
            Assert.AreEqual(new Square(File.H, Rank.Eighth).File, File.H);
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.AreEqual(new Square(File.A, Rank.First), new Square(File.A, Rank.First));
            Assert.IsTrue(new Square(File.A, Rank.First).Equals(new Square(File.A, Rank.First)));
            Assert.IsTrue(new Square(File.A, Rank.First).Equals(new Square(File.A, Rank.First)));
            Assert.AreEqual(new Square(File.A, Rank.First).GetHashCode(), new Square(File.A, Rank.First).Index.GetHashCode());
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual(new Square(File.A, Rank.First).ToString(), "a1");
        }
    }
}

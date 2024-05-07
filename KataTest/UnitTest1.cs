namespace KataTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(
            new[] { "Mark", "Jimmy", "Abel", "Amanda" },
            new[] { "Mark", "Abel" })]
        [TestCase(
            new[] { "Peter", "Anna", "Michael" },
            new[] { "Anna" })]
        [TestCase(
            new[] { "Linus", "Beau", "Azul" },
            new[] { "Beau", "Azul" })]
        public void KataTests(string[] names, IEnumerable<string> expected)
        {
            CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
        }
    }
}
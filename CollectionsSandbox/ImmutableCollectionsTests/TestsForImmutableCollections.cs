using System.Collections.Immutable;

namespace ImmutableCollectionsTests
{
    public class TestsForImmutableCollections
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ImmutableArray<int> immutableArray = [1, 2, 3];

            ImmutableDictionary<int, string> immutableDictionary = 
                ImmutableDictionary.CreateRange(
                new []
                {
                    KeyValuePair.Create(1, "one"),
                    KeyValuePair.Create(2, "two"),
                });

            ImmutableHashSet<int> immutableHashSet = [1, 2, 3];

            ImmutableQueue<int> immutableQueue = [1, 2, 3];

            ImmutableSortedDictionary<int, string> immutableSortedDictionary = 
                ImmutableSortedDictionary.CreateRange(
                new[]
                {
                    KeyValuePair.Create(1, "one"),
                    KeyValuePair.Create(2, "two"),
                });

            ImmutableSortedSet<int> immutableSortedSet = [1, 2, 3];

            ImmutableStack<int> immutableStack = [1, 2, 3];

            Assert.Pass();
        }
    }
}
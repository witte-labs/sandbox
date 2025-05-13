using System.Collections.Concurrent;

namespace ConcurrentCollectionsTests
{
    public class TestsForConcurrentCollections
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeclareConcurrentCollectionsWorks()
        {
            BlockingCollection<int> blockingCollection = new();
            blockingCollection.Add(1);

            ConcurrentBag<int> concurrentBag = new();
            concurrentBag.Add(1);

            ConcurrentDictionary<string, int> concurrentDictionary = new();
            concurrentDictionary.TryAdd("key", 1);

            ConcurrentQueue<int> concurrentQueue = new();
            concurrentQueue.Enqueue(1);

            ConcurrentStack<int> concurrentStack = new();
            concurrentStack.Push(1);

            Assert.Pass();
        }
    }
}
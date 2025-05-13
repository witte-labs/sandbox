using System.Collections.ObjectModel;

namespace GenericCollectionsTests
{
    public class TestsForGenericCollections
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeclareGenericCollectionsWorks()
        {
            int[] stringArray = [1, 2, 3];

            List<int> list = [1];
            List<int> list2 = new List<int> { 1, 2, 3, 4 };

            Dictionary<int, string> dictionary1 = new()
            {
                { 1, "one" }
            };

            Dictionary<int, string> dictionary2 = new Dictionary<int, string>
            {
                { 1, "one" }
            };

            HashSet<int> hashSet = [1];
            HashSet<string> hashSetString = ["test"];

            LinkedList<int> linkedList = new();
            linkedList.AddLast(1);

            ObservableCollection<int> collection = [1];

            SortedDictionary<string, int> sortedDictionary = new()
            {
                { "key", 1 }
            };

            SortedSet<int> sortedSet = [1, 2];

            Queue<int> queue = new();
            queue.Enqueue(1);

            Stack<int> stack = new();
            stack.Push(1);

            Assert.Pass();
        }
    }
}
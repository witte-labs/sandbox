using System.Collections;

namespace CollectionsTests
{
    public class TestsForCollections
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeclareSystemCollectionsWorks()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);

            BitArray bitArray = new BitArray(10);
            bitArray.Set(0, true);

            Hashtable hashtable = new Hashtable();
            hashtable.Add("key", "value");

            // Non-generic Queue requires boxing and unboxing. Don't use for new development.
            Queue queue = new Queue();
            queue.Enqueue(1);

            // Non-generic Stack requires boxing and unboxing. Don't use for new development.
            Stack stack = new Stack();
            stack.Push(1);

            SortedList sortedList = new SortedList();   
            sortedList.Add("key", "value");

            Assert.Pass();
        }
    }
}
using System.Collections.Specialized;

namespace SpecializedCollectionsTests
{
    public class TestsForSpecializedCollections
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeclareSpecializedCollectionsWorks()
        {
            HybridDictionary hybridDictionary = new HybridDictionary();
            hybridDictionary.Add("key", "value");

            ListDictionary listDictionary = new ListDictionary();
            listDictionary.Add("key", "value");

            NameValueCollection nameValueCollection = new NameValueCollection();
            nameValueCollection.Add("key", "value");

            OrderedDictionary orderedDictionary = new OrderedDictionary();
            orderedDictionary.Add("key", "value");

            // Not recommended for new development.
            // Use List<string> instead.
            // Uses casting and boxing.
            StringCollection stringCollection = new StringCollection();
            stringCollection.Add("value");

            StringDictionary stringDictionary = new StringDictionary();
            stringDictionary.Add("key", "value");

            Assert.Pass();
        }
    }
}
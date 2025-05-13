using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace GenericCollectionsTests
{
    public class TestsForGenericCollections2
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MergeAndSortStringArraysWorks()
        {
            string[] array1 = { "banana", "apple", "cherry" };
            string[] array2 = new[] { "kiwi", "lemon" };

            string[] combinedArray = array1.Concat(array2).ToArray();

            // Sort the combined array
            Array.Sort(combinedArray);

            CollectionAssert.AreEqual(new[] { "apple", "banana", "cherry", "kiwi", "lemon" }, combinedArray);
        }

        [Test]
        public void FindCommonItemsInDictionariesWorks()
        {
            Dictionary<string, string> dict1 = new()
                {
                    { "key1", "value1" },
                    { "key2", "value2" },
                    { "key3", "value3" }
                };

            Dictionary<string, string> dict2 = new()
                {
                    { "key2", "value2" },
                    { "key3", "value3" },
                    { "key4", "value4" }
                };

            Dictionary<string, string> commonItems = 
                dict1.Where(kv => dict2.ContainsKey(kv.Key) && dict2[kv.Key] == kv.Value)
                        .ToDictionary(kv => kv.Key, kv => kv.Value);

            //commonItems = dict1.Concat(dict2)
            //    .GroupBy(kv => kv)
            //    .Where(g => g.Count() > 1)
            //    .ToDictionary(g => g.Key.Key, g => g.Key.Value);

            CollectionAssert.AreEquivalent(commonItems, new Dictionary<string, string>()
            {
                { "key2", "value2" },
                { "key3", "value3" }
            });

            CollectionAssert.AreEqual(new Dictionary<string, string>
                {
                    { "key2", "value2" },
                    { "key3", "value3" }
                }, commonItems);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class XORTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void XORTestSimplePasses()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10 };
            int[] output = XOR21.XORFunc(input);
            int[] expected = { 17, 23, 29, 22, 28, 17, 31 };

            CollectionAssert.AreEqual(expected, output);

        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator XORTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}

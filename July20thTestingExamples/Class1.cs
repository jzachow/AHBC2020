using NUnit.Framework;
using System;

namespace July20thTestingExamples
{

    public class Class1
    {
        //Broken. Not working in class

        

        [Test]
        public void OneEqualsOne()
        {
            var expected = 1;
            var actual = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}

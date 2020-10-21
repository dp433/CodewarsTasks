using NUnit.Framework;
using System;
using SplitInParts;

namespace Tests
{
    [TestFixture]
    class SplitInPartsTest
    {
        [TestCase]
        //Fixed values
        public void splitString1()
        {
            string str = "supercalifragilisticexpialidocious";
            Assert.AreEqual("sup erc ali fra gil ist ice xpi ali doc iou s", SplitInParts.Kata.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString2()
        {
            string str = "HelloKata";
            Assert.AreEqual("Hel loK ata", SplitInParts.Kata.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString3()
        {
            string str = "HelloKata";
            Assert.AreEqual("H e l l o K a t a", SplitInParts.Kata.SplitInParts(str, 1));
        }

        [TestCase]
        //Fixed values
        public void splitString4()
        {
            string str = "HelloKata";
            Assert.AreEqual("HelloKata", SplitInParts.Kata.SplitInParts(str, 9));
        }
    }
}

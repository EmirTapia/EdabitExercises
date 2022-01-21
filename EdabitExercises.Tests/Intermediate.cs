using NUnit.Framework;

namespace EdabitExercises.Tests
{
    public class Intermediate
    {
        [Test]
        [TestCase("There is a bomb.", ExpectedResult = "Duck!!!")]
        [TestCase("Hey, did you find it?", ExpectedResult = "There is no bomb, relax.")]
        [TestCase("Hey, did you think there is a bomb?", ExpectedResult = "Duck!!!")]
        [TestCase("This goes boom!!!", ExpectedResult = "There is no bomb, relax.")]
        [TestCase("Hey, did you find the BoMb?", ExpectedResult = "Duck!!!")]
        [TestCase("Commotion in the third, a bomb is found!", ExpectedResult = "Duck!!!")]
        public static string Bomb(string a)
        {
            return EdabitExercises.Intermediate.Bomb(a);
        }

        [Test]
        [TestCase(1, true, ExpectedResult = false)]
        [TestCase(0, "0", ExpectedResult = false)]
        [TestCase(1, 1, ExpectedResult = true)]
        [TestCase(true, true, ExpectedResult = true)]
        [TestCase("nmv", "nmv", ExpectedResult = true)]
        [TestCase(0, "", ExpectedResult = false)]
        [TestCase(1, "1", ExpectedResult = false)]
        [TestCase('h', 'm', ExpectedResult = false)]
        [TestCase('a', 'a', ExpectedResult = true)]
        [TestCase(0, false, ExpectedResult = false)]
        [TestCase(1.0, 1.0, ExpectedResult = true)]
        [TestCase("str", "rts", ExpectedResult = false)]
        [TestCase('c', "test", ExpectedResult = false)]
        [TestCase(true, "true", ExpectedResult = false)]
        [TestCase(true, false, ExpectedResult = false)]
        public static bool CheckEquality(object a, object b)
        {
            return EdabitExercises.Intermediate.CheckEquality(a, b);
        }

        [Test]
        public void ParseArray()
        {
            object[] testArr_1 = new object[] { 1, 2, "a", "b" };
            object[] testArr_2 = new object[] { "a", "b", 10, 115 };
            object[] testArr_3 = new object[] { };
            object[] testArr_4 = new object[] { -4, "k", 0 };
            object[] testArr_5 = new object[] { "Hell000!", 5 };

            Assert.AreEqual(new string[] { "1", "2", "a", "b" }, EdabitExercises.Intermediate.ParseArray(testArr_1));
            Assert.AreEqual(new string[] { "a", "b", "10", "115" }, EdabitExercises.Intermediate.ParseArray(testArr_2));
            Assert.AreEqual(new string[] { }, EdabitExercises.Intermediate.ParseArray(testArr_3));
            Assert.AreEqual(new string[] { "-4", "k", "0" }, EdabitExercises.Intermediate.ParseArray(testArr_4));
            Assert.AreEqual(new string[] { "Hell000!", "5" }, EdabitExercises.Intermediate.ParseArray(testArr_5));
        }

        [Test]
        [TestCase("eDaBiT", ExpectedResult = new int[] { 1, 3, 5 })]
        [TestCase("eQuINoX", ExpectedResult = new int[] { 1, 3, 4, 6 })]
        [TestCase("determine", ExpectedResult = new int[] { })]
        [TestCase("STRIKE", ExpectedResult = new int[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase("sUn", ExpectedResult = new int[] { 1 })]
        [TestCase("SpiDer", ExpectedResult = new int[] { 0, 3 })]
        [TestCase("accOmpAnY", ExpectedResult = new int[] { 3, 6, 8 })]
        [TestCase("@xCE#8S#i*$en", ExpectedResult = new int[] { 2, 3, 6 })]
        [TestCase("1854036297", ExpectedResult = new int[] { })]
        [TestCase("Fo?.arg~{86tUx=|OqZ!", ExpectedResult = new int[] { 0, 12, 16, 18 })]
        public static int[] IndexTests(string str)
        {
            return EdabitExercises.Intermediate.IndexOfCapitals(str);
        }
    }
}
using NUnit.Framework;
using NUnitDemonstration1;

namespace TraingleTest
{
    public class TraingleTest
    {
        [TestFixture]

        public class TraingleTest1
        {
            public static void Main()
            {

            }

            [Test]

            public void ValidTriangle_Input60and60and60_OutputTriangle()
            {
                int firstAngle = 60;
                int secondAngle = 100;
                int thirdAngle = 60;

                string expected = "The triangle is valid";

                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
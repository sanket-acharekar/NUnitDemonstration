using NUnitDemonstration1;

namespace TestClass;

public class Tests
{

    [Test]
    public void TriangleWithMutant_Input60and60and60_OutputTriangle()
    {
        int firstAngle = 60;
        int secondAngle = 60;
        int thirdAngle = 60;

        string expected = "The triangle is valid.";
        string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TriangleWithoutMutant_Input60and60and70_OutputTriangle()
    {
        int firstAngle = 60;
        int secondAngle = 50;
        int thirdAngle = 60;

        string expected = "The triangle is valid.";
        string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
        Assert.AreEqual(expected, actual);
    }
}

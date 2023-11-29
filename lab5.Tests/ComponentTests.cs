using Component;
namespace lab5.Tests;

public class ComponentTests
{
    private static double EPSILON = 0.001;
    private static int N = 20;
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(-3)]
    [TestCase(1)]
    [TestCase(0)]
    [TestCase(3)]
    public void Component_CalculateIterativly_ShouldReturnExpX_WhenXis(double x)
    {
        var result = ComponentClass.CalculateIterativly(x, N);
        var correctResult = Math.Exp(x);

        Assert.LessOrEqual(Math.Abs(correctResult - result), EPSILON);
    }

    [TestCase(-3)]
    [TestCase(1)]
    [TestCase(0)]
    [TestCase(3)]
    public void Component_CalculateRec_ShouldReturnExpX_WhenXis(double x)
    {
        double sum = 0;
        var result = ComponentClass.CalculateRec(x, N, ref sum);
        var correctResult = Math.Exp(x);

        Assert.LessOrEqual(Math.Abs(correctResult - result), EPSILON);
    }


}
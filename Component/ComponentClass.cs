namespace Component;

public static class ComponentClass
{
    public static double CalculateIterativly(double x, int n)
    {
        double result = 0;
        for (int i = 0; i <= n; i++)
        {
            result += Math.Pow(x, i) / GetFactorial(i);
        }

        return result;
    }

    public static double Formula(double x, int n) => Math.Pow(x, n) / GetFactorial(n);

    public static double CalculateRec(double x, int n, ref double sum, int currentIteration = 0)
    {
        if(currentIteration == 0)
        {
            sum = 0;
        }

        sum += Formula(x, currentIteration++);
        
        return currentIteration >= n ? sum : 
            CalculateRec(x, n, ref sum, currentIteration);
    }

    private static double GetFactorial(int n)
    {
        double answer = 1;
        double counter = 1;

        while (counter <= n)
        {
            answer *= counter;
            counter++;
        }

        return answer;
    }
}

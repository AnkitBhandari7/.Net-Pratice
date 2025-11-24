namespace Week_4;

public class ParameterDemo
{
    // ref → sends variable by reference
    public void Increase(ref int number)
    {
        number += 10;
    }

    // out → method MUST assign value
    public void GetFullName(out string fullname)
    {
        fullname = "Ankit Bhandari";
    }

    // params → accepts multiple values
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}
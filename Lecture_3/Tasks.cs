namespace Lecture_3;

public static class Tasks
{
    public static IEnumerable<int> GetFibonacci(int number)
    {
        int prev1 = 0, prev2 = 0, index = 0;
        return Enumerable
            .Repeat(-1, number)
            .Select(num =>
                {
                    num = index++ switch
                    {
                        0 or 1 => 1,
                        _ => prev2 + prev1
                    };
                    prev2 = prev1;
                    prev1 = num;
                    return num;
                });
    }
}
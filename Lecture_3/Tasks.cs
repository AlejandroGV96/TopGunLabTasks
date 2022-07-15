namespace Lecture_3;

public static class Tasks
{
    public static IEnumerable<int> GetFibonacci(int number)
    {
        int prev1 = 0, prev2 = 0, index = 0, onHold;
        
        return Enumerable
            .Repeat(-1, number)
            .Select(num =>
                {
                    num = index++ switch
                    {
                        0 or 1 => 1,
                        _ => prev2 + prev1
                    };
                    onHold = num;
                    prev2 = prev1;
                    prev1 = onHold;
                    return num;
                });
    }
}
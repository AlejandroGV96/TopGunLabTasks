namespace Lecture_3;

public static class Tasks
{
    public static int GetFactorial(int number) => 
        Enumerable.Range(1, number)
            .Aggregate(number,
                (current, next) => current * next,
                result => result / number);

}
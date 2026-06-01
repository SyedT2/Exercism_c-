public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int total_sum = (max * (max + 1))/2;
        return total_sum * total_sum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum_of_squares = 0;
        for(int i = 0;i<=max;i++){
            sum_of_squares += (i*i);
        }
        return sum_of_squares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
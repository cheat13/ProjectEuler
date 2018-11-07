namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public int Calc(int number)
        {
            var result = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
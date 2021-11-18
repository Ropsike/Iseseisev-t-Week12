using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num, guess, n = 0;
                srand(time(0));
                num = rand() % 100 + 1;
                printf("Guess the number between 1 to 100\n");
                do
                {
                    scanf("%d", &guess);
                    if (guess > num)
                        printf("Enter lower number please!\n");
                    else if (guess < num)
                        printf("Enter higher number please!\n");
                    else
                        printf("You gussed it in %d attempt\n", n);
                    n++;
                } while (guess != num);
                return 0;
            }
        }
    }
}

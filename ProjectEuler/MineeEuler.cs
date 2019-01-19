using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class MineeEuler
    {
        public IEnumerable<long> Range(long start, long count, Func<long, long> step)
        {
            long i = 0;
            while (i < count)
            {
                yield return start;
                start = step(start);
                i++;
            }
        }

        public IEnumerable<long> Fibonacci()
        {
            long first = 1;
            long second = 2;

            yield return first;
            yield return second;

            while (true)
            {
                (first, second) = (second, second + first);
                yield return second;
            }
        }

        public IEnumerable<long> PrimeNumbers()
        {
            yield return 2;

            long num = 3;
            while (true)
            {
                if (IsPrime(num))
                {
                    yield return num;
                }
                num += 2;
            }
        }

        public bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return (number == 2);
            }

            long root = (long)Math.Sqrt(number);
            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerable<long> Factorize(long number)
        {
            if (IsPrime(number))
            {
                yield return number;
            }
            else
            {
                long divisor = 2;
                while (number > 1)
                {
                    if (number % divisor == 0)
                    {
                        yield return divisor;
                        number /= divisor;
                    }
                    else
                    {
                        divisor += (divisor % 2 == 0) ? 1 : 2;
                    }
                }
            }
        }

        public long Gcd(long[] numbers)
        {
            return numbers.Aggregate(Gcd);
        }

        public long Gcd(long left, long right)
        {
            while (left != 0 && right != 0)
            {
                if (left > right)
                {
                    left %= right;
                }
                else
                {
                    right %= left;
                }
            }

            return left == 0 ? right : left;
        }

        public long Lcm(long[] numbers)
        {
            return numbers.Aggregate(Lcm);
        }

        public long Lcm(long left, long right)
        {
            long gcd = Gcd(left, right);
            return left * right / gcd;
        }

        public long ReverseNumber(long number)
        {
            long reverse = 0;
            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            return reverse;
        }

        public IEnumerable<long> GetDigits(long source)
        {
            long individualFactor = 0;
            long tennerFactor = Convert.ToInt64(Math.Pow(10, source.ToString().Length));
            do
            {
                source -= tennerFactor * individualFactor;
                tennerFactor /= 10;
                individualFactor = source / tennerFactor;

                yield return individualFactor;
            } while (tennerFactor > 1);
        }

        public bool IsPalindrome(long number)
        {
            return number == ReverseNumber(number);
        }
    }
}

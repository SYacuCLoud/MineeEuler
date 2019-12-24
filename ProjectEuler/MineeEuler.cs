using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProjectEuler
{
    public sealed class MineeEuler
    {
        private static readonly Lazy<MineeEuler> _lazy =
            new Lazy<MineeEuler>(() => new MineeEuler());

        public static MineeEuler Instance => _lazy.Value;

        private MineeEuler()
        {
        }

        /// <summary>
        /// 열거가능한 정수를 시작점에서부터 스텝에 따라 지정한 개수로 리턴합니다.
        /// </summary>
        /// <param name="start">시작점</param>
        /// <param name="count">정수의 개수</param>
        /// <param name="step">스텝의 수식</param>
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

        /// <summary>
        /// 0부터 부호 없는 정수 target까지의 합을 리턴합니다.
        /// </summary>
        public ulong SumZeroToUNum(ulong target)
        {
            return target * (target + 1) / 2;
        }

        /// <summary>
        /// 열거가능한 피보나치 수열
        /// </summary>
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

        /// <summary>
        /// 열거가능한 소수
        /// </summary>
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

        /// <summary>
        /// 지정한 범위의 자연수 중 에라토스테네스의 체를 사용하여 소수의 list를 반환합니다.
        /// </summary>
        public List<int> SieveofEratosthenes(int limit)
        {
            int current = 1;
            List<int> range = Enumerable.Range(2, limit).ToList();
            int root = (int) Math.Sqrt(limit);
            while (current <= root)
            {
                current = range.First(i => i > current);
                int copy = current;
                range.RemoveAll(i => i != copy && i % copy == 0);
            }

            return range;
        }

        /// <summary>
        /// number가 소수인지 확인합니다.
        /// </summary>
        public bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number % 2 == 0)
            {
                return number == 2;
            }

            long root = (long) Math.Sqrt(number);
            for (long i = 3; i <= root; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// number를 소인수 분해하여 열거가능한 정수로 리턴합니다.
        /// </summary>
        public IEnumerable<long> Factorize(long number)
        {
            if (number == 1 || IsPrime(number))
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

        /// <summary>
        /// number의 약수의 개수를 리턴합니다.
        /// </summary>
        public long NumberOfdivisors(long number)
        {
            return Factorize(number).GroupBy(x => x)
                .Select(x => x.Count() + 1)
                .Aggregate(1, (c, n) => c * n);
        }

        /// <summary>
        /// numbers의 최대공약수를 리턴합니다.
        /// </summary>
        public long Gcd(long[] numbers)
        {
            return numbers.Aggregate(Gcd);
        }

        /// <summary>
        /// left와 right의 최대공약수를 유클리드 호제법으로 계산하여 리턴합니다.
        /// </summary>
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

        /// <summary>
        /// numbers의 최소공배수를 리턴합니다.
        /// </summary>
        public long Lcm(long[] numbers)
        {
            return numbers.Aggregate(Lcm);
        }

        /// <summary>
        /// left와 right의 최소공배수를 리턴합니다.
        /// </summary>
        public long Lcm(long left, long right)
        {
            long gcd = Gcd(left, right);
            return left * right / gcd;
        }

        /// <summary>
        /// number의 좌우반전한 정수를 리턴합니다.
        /// </summary>
        public long ReverseNumber(long number)
        {
            long reverse = 0;
            while (number != 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number /= 10;
            }

            return reverse;
        }

        /// <summary>
        /// source의 각 자리수를 리턴합니다.
        /// </summary>
        public IEnumerable<long> GetDigits(long source)
        {
            if (source < 0)
            {
                source *= -1;
            }

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

        /// <summary>
        /// number가 Palindrome한(좌우반전을 해도 같은) 수인지 확인합니다.
        /// </summary>
        public bool IsPalindrome(long number)
        {
            return number == ReverseNumber(number);
        }

        /// <summary>
        /// str 1차원 문자열을 공백으로 구분하여 2차원 배열&lt;T&gt;로 리턴합니다.
        /// </summary>
        public T[][] SplitString2DArray<T>(string str)
        {
            return Regex.Split(str, "\\r\\n")
                .Select(x => Regex.Split(x, "\\s")
                    .Select(i => (T) Convert.ChangeType(i, typeof(T)))
                    .ToArray())
                .ToArray();
        }
    }
}
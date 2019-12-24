using System;
using System.Text;

namespace ProjectEuler
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // 문제 번호
            const int number = 1;

            // 
            StringBuilder sb = new StringBuilder("ProjectEuler.");
            sb.AppendFormat("P{0:D4}", number);
            object answer = Activator.CreateInstance(Type.GetType(sb.ToString()));
            Console.WriteLine(answer.GetType().GetMethod("Answer").Invoke(answer, null));
            Console.Read();
        }
    }
}
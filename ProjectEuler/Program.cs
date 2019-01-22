using System;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 문제 번호
            int number = 10;

            //
            StringBuilder sb = new StringBuilder("ProjectEuler.");
            sb.AppendFormat("P{0:D4}", number);
            var answer = Activator.CreateInstance(Type.GetType(sb.ToString()));
            Console.WriteLine(answer.GetType().GetMethod("Answer").Invoke(answer, null));
            Console.Read();
        }
    }
}

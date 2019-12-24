namespace ProjectEuler
{
    public class P0012 : IEuler
    {
        private long GetMininum(int counter)
        {
            for (int i = 1; ; i++)
            {
                int triangleNum = (i * (i + 1)) / 2;
                if (MineeEuler.Instance.NumberOfdivisors(triangleNum) >= counter)
                {
                    return triangleNum;
                }
            }
        }

        public long Answer()
        {
            return GetMininum(500);
        }
    }
}

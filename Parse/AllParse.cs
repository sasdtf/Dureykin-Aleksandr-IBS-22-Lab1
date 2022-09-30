namespace Parse
{
    public static class AllParse
    {
        public static int IntParse()
        {
            int result;
            bool secsessful = int.TryParse(Console.ReadLine(), out result);
            if (!secsessful)
            {
                Console.WriteLine("Введите число");
                 secsessful = int.TryParse(Console.ReadLine(), out result);
                return result;
            }
            return result;
        }
        public static double DoubleParse()
        {
            double result;
            bool secsessful = double.TryParse(Console.ReadLine(), out result);
            if (!secsessful)
            {
                Console.WriteLine("Введите число");
                secsessful = double.TryParse(Console.ReadLine(), out result);
                return result;
            }
            return result;
        }
        public static byte ByteParse()
        {
            byte result;
            bool secsessful = byte.TryParse(Console.ReadLine(), out result);
            if (!secsessful)
            {
                Console.WriteLine("Введите число");
                 secsessful = byte.TryParse(Console.ReadLine(), out result);
                return result;
            }
            return result;
        }
    }
}
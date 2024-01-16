namespace First
{
    public static class FirstProgram
    {

        public static int MaxIntegerByNumDigts(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return int.Parse(arr);
        }

        public static int Main(string[] argv)
        {
            string? input_line = Console.ReadLine();

            if (input_line is null)
            {
                return -1;
            }
        
            int input_num = int.Parse(input_line);

            int result = MaxIntegerByNumDigts(input_num);

            Console.WriteLine(result);

            return 0;
        }
    }
}
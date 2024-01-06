namespace UcenjeCS
{
    internal class V01ZimskoVjezbanje
    {
        public static void Izvedi()
        {
            for (int i = 0; i<100; i++)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 99; i>0; i--)
            {
                Console.WriteLine(i+1);
            }

            for (int i = 7; i<100; i = i+7)
            {
                Console.WriteLine(i);
            }
        }
    }
}

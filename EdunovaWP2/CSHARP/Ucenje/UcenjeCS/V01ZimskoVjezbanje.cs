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

            Console.WriteLine(" ");

            for (int i = 100; i>0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            for (int i = 7; i<100; i = i+7)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");

            int broj;
            int br=0;

            for ( ; ; )
            {
                broj = int.Parse( Console.ReadLine() );
                br++;
                if (broj > 100)
                {
                    break;
                }                
            }
            Console.WriteLine(br);
        }
    }
}

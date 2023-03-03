internal class Program
{
    private static void Main(string[] args)
    {
        //exercicio do maior e do menor numero entre 15 outros

        Random r = new Random();
        int num, maior=0, menor=0;

        for(int i = 0; i < 15; i++)
        {
            num= r.Next(100);
            Console.WriteLine(num);
            if(i == 0)
            {
                maior = num;
                menor=num;
            }
            else
            {
                if (num > maior)
                {
                    maior=num;

                }
                if(num<menor)
                {
                    menor=num;
                }
            }

        }
        Console.WriteLine("maior: "+maior+"\nmenor: "+menor);
    }
}
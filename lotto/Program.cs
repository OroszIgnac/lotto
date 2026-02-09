namespace lotto
{
    internal class Program
    {
        static void LottoszamokGeneralas()
        {
            Random rnd = new Random();
            int[] szamok = new int[5];
            for (int i = 0; i < szamok.Length; i++) 
            {
                szamok[i] = rnd.Next(1, 91);
            }
        }




        static void Main(string[] args)
        {
            LottoszamokGeneralas();
        }
    }
}

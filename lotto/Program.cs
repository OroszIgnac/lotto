using System.Threading.Channels;

namespace lotto
{
	internal class Program
	{
		static int[] LottoszamokGeneralas()
		{
			Random rnd = new Random();
			int[] szamok = new int[5];
			for (int i = 0; i < szamok.Length; i++)
			{
				szamok[i] = rnd.Next(1, 91);
			}
			return szamok;
		}
		static int[] Bekeresek()
		{
			int[] tippek = new int[5];
			int i = 0;
			while (i < tippek.Length)
			{
				Console.WriteLine("Kérem a tippet: ");
				int tipp = Convert.ToInt32(Console.WriteLine());
				bool vanE = false;
				for (int j = 0; j < i; j++)
				{
					if (tippek[j] == tipp)
					{
						vanE = true;
					}
				}
				if (vanE)
				{
					tippek[i] = tipp;
					i++;
				}
				else
				{
					Console.WriteLine("Ezt a számot már megadtad, adj másikat!");
				}
			}
			return tippek;
		}
		static void Kiir(int[] tomb)
		{
			for (int i = 0; i < tomb.Length; i++)
			{
				Console.Write(tomb[i] + " ");
			}
			Console.WriteLine();
		}

		static void TalalaatokSzama(int[] nyeroSzamok, int[] tippek)
		{
			int db = 0;
			for (int i = 0;i < tippek.Length; i++)
			{
				for (int j = 0; j< nyeroSzamok.Length; j++)
				{
					if (tippek [j] == tippek[i])
					{
						db++;
					}
				}
			} 
		}

		static void Main(string[] args)
		{
			int[] nyeroszamok = LottoszamokGeneralas();
			Kiir(nyeroszamok);
			int[] tippek = Bekeresek();
			Kiir(tippek);
			TalalaatokSzama(nyeroszamok, tippek);
		}
	}
}

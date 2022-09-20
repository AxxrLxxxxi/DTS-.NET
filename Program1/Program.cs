using System;

namespace Vacancy_Sortir
{
	class Program
	{
		static void Main(string[] args)
		{
			Data();
		}
		
		static void Data()
		{
			int [] id = new int[10];
			string [] name = new string[10];
			int jumlah = 0;
			
			if(jumlah<=10)
			{
				for(int i=1; i<=10; i++)
				{
					Console.WriteLine("Masukan Id Pelamar ke - " + i);
					id[i] = Convert.ToInt32(Console.ReadLine());
					if(id[i]!=0)
					{
						Console.WriteLine("Masukan Nama Pelamar ke - " + i);
						name[i] = Console.ReadLine();
					}
				}
			}else{
				Console.WriteLine("===================================");
				foreach(var hasil in id)
				{
					Console.WriteLine("Berikut adalah data yang berhasil ditambahkan: ");
					Console.WriteLine(hasil);
				}
			}
		}
	}
}

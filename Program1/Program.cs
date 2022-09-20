using System;

namespace Vacancy_Sortir
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] id = new int[10];
			
			for(int i=1; i<=10; i++)
			{
				Console.WriteLine("Masukan Id Pelamar ke - " + i);
				id[i] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Masukan Nama Pelamar: ");
			}
			
			Console.WriteLine("===================================");
			
			foreach(var hasil in id)
			{
				Console.WriteLine("Berikut adalah data yang berhasil ditambahkan: ");
				Console.WriteLine(hasil);
			}
		}
	}
}

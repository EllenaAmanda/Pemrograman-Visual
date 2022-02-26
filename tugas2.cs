/*
 * Created by SharpDevelop.
 * User: USER
 * Date: 26/02/2022
 * Time: 17.20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tugas1._
{
	class ProgramHW
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Nama kamu siapa?");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu "+nama);
			Console.Write("Press any key to continue...");
			Console.ReadKey(true);
		}
	}
}

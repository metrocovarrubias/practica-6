using System;

namespace Practica6
{
	class Program : Profesor
	
	{
		public static void Main(string[] args)
		{
			Profesor p = new Profesor();
			p.Menu();
			//Alunmos al= new Alunmos();
			//al.Menu();
			Console.ReadKey(true);
		}
	}
}
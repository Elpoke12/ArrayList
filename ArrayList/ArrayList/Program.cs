using System;
using System.Collections;

namespace ArrayList
{
	class Lista
	{
        /*En este programa se esta sacando las calificaciones de alumnos utilizando Arraylist que fue el menos complicado para mi  */

		int grupos, alumnos, calificaciones;
		ArrayList List;
		ArrayList List1;
		public Lista()
		{
			List = new ArrayList();
			List1 = new ArrayList();

		}
        /* Aqui esta ingresando las clases y alumnos*/
		public void Datos()
		{
			Console.WriteLine("Cuantas clases son?");
			grupos = int.Parse(Console.ReadLine());

			for (int r = 0; r < grupos; r++)
			{
				Console.WriteLine("Cuantos alumnos hay en cada grupo: {0} ?", r + 1);
				alumnos = int.Parse(Console.ReadLine());
				List.Add(alumnos);
			}

			for (int r = 0; r < List.Count; r++)
			{
				Console.WriteLine("Ingresa calificaciones de cada grupo: ");
				calificaciones = int.Parse(Console.ReadLine());
				List1.Add(calificaciones);

			}
		}
        /*Este metodo solo es para imprimir*/
		public void Imprimir()
		{
			Console.WriteLine("Cantidad de alumnos por grupo: ");
			foreach (var pug in List)
			{
				Console.WriteLine(pug);
			}

			Console.WriteLine("Calificacion por grupo: ");
			foreach (var pong in List1)
			{
				Console.WriteLine(pong);
			}

			Console.ReadKey();
		}
	}

	
	static void Main(string[] args)
	{
		Lista cuadraplejico = new Lista();
        cuadraplejico.Datos();
		Console.Clear();
        cuadraplejico.Imprimir();
		Console.ReadKey();
	}
}

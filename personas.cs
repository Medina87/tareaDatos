using System;

namespace datos
{

	public class Persona{
	
		public string nombre;
		public string facebook;
		public string domicilio;
		public int numeroDeTelefono;
		public Persona (){
		}
		public static void Main (string[] args)
		{
			Persona persona = new Persona ();
			Console.WriteLine ("Cuál es tu nombre?");
			persona.nombre = Console.ReadLine ();
			Console.WriteLine ("Cuál es su facebook?");
			persona.facebook = Console.ReadLine ();
			Console.WriteLine ("Cuál es su domicilio?");
			persona.domicilio = Console.ReadLine ();
			Console.WriteLine ("Cuál es su número Telefonico?");
			persona.numeroDeTelefono = int.Parse ("nombre: " + persona.nombre);
			Console.WriteLine ();
			Console.WriteLine ("face: " + persona.facebook);
			Console.WriteLine ();
			Console.WriteLine ("domicilio: " + persona.domicilio);
			Console.WriteLine ();
			Console.WriteLine ("numero: " + persona.numeroDeTelefono);
			Console.WriteLine ();
			Console.ReadLine ();
		}
	}

}
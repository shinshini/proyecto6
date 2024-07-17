/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 13/06/2024
 * Time: 06:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practca_2bi_proyecto_estudant
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string Nombre;
		protected string Apellidos;
		protected int Ci;
		protected string Direccion;
		protected int Telefono;
		protected string Nacionaldad;
		protected string Fecha_nacimiento;
		
		public Persona()
		{
			Nombre="leonor";
			Apellidos="Chnchi salinas";
			Ci=14450000;
			Direccion="calle cevero";
			Telefono=78962524;
			Nacionaldad="bolivia";
			Fecha_nacimiento="01-09-01";
		}
		protected void leer(){
			Console.Write("Ingrese nombre: ");
			Nombre=Console.ReadLine();
			Console.Write("Ingrese Apellidos: ");
			Apellidos=Console.ReadLine();
			Console.Write("Ingrese ci: ");
			Ci=int.Parse(Console.ReadLine());
			Console.Write("Ingrese direccion: ");
			Direccion=Console.ReadLine();
			Console.Write("Ingrese telefono: ");
			Telefono=int.Parse(Console.ReadLine());
			Console.Write("Ingrese nacionalidad: ");
			Nacionaldad=Console.ReadLine();
			Console.Write("Ingrese fecha de nacimiento: ");
			Fecha_nacimiento=Console.ReadLine();
		}
		protected void mostrar(){
			Console.WriteLine("nombre= "+Nombre);
			Console.WriteLine("apellidos= "+Apellidos);
			Console.WriteLine("ci= "+Ci);
			Console.WriteLine("direccion= "+Direccion);
			Console.WriteLine("Telefono= "+Telefono);
			Console.WriteLine("Nacionalidad= "+Nacionaldad);
			Console.WriteLine("Fecha de nacimiento= "+Fecha_nacimiento);
			
		}
		public string Nombree
		{
			get{return Nombre;}
			set{Nombre=value;}
		}
		public string Apellido
		{
			get{return Apellidos;}
			set{Apellidos=value;}
		}
		public int CI
		{
			get{return Ci;}
			set{Ci=value;}
		}
		public string direccion
		{
			get{return Direccion;}
			set{Direccion=value;}
		}
		public int telefono
		{
			get{return Telefono;}
			set{Telefono=value;}
		}
		public string naconalidad
		{
			get{return Nacionaldad;}
			set{Nacionaldad=value;}
		}
		public string fecha_Naci
		{
			get{return Fecha_nacimiento;}
			set{Fecha_nacimiento=value;}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 13/06/2024
 * Time: 06:29 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practca_2bi_proyecto_estudant
{
	/// <summary>
	/// Description of Materia.
	/// </summary>
	public class Materia
	{
		private string nombre;
		private string sigla;
		private Nota Nota=new Nota();
		
		public Materia()
		{
			nombre="lemguaje";
			sigla="leg";
		}
		public void leer(){
			Console.Write("ingrese nombre: ");
			nombre=Console.ReadLine();
			Console.Write("ingrese sigla: ");
			sigla=Console.ReadLine();
			Nota.leer();
		}
		public void mostrar(){
			Console.WriteLine("\n-- Datos de la Materia --");
			Console.WriteLine("nombre: "+nombre);
			Console.WriteLine("sigla: "+sigla);
			Nota.mostrar();
		}
		
		
		public string Nombre
		{
			get{return nombre;}
			set{nombre=value;}
		}
		public string Sigla
		{
			get{return sigla;}
			set{sigla=value;}
		}
		
		public Nota  NOTA
		{
			get{return Nota;}
			set{Nota=value;}
		}
		
	}
}

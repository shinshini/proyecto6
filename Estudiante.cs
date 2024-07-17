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
	/// Description of Estudiante.
	/// </summary>
	public class Estudiante:Persona
	{
		protected string Matricula;
	
		 Materia []Ma= new Materia[3];
		public Estudiante():base()
		{
			Matricula="12a2";
			
			for(int i=0;i<Ma.Length;i++){
				Ma[i]=new Materia();
			}
			
		}
		public void leer(){
			Console.WriteLine("\n-- datos del estudiante --");
			base.leer();
			Console.Write("ingrese matrcula: ");
			Matricula=Console.ReadLine();
			for(int i=0;i<Ma.Length;i++){
				Ma[i].leer();
			}
		}
		public void mostrar(){
		Console.WriteLine("\n-- datos del estudiante --");
		base.mostrar();
		Console.WriteLine("matricula: "+Matricula);
		for(int i=0;i<Ma.Length;i++){
			Ma[i].mostrar();
		}
		}
		public string matricula
		{
			get{return Matricula;}
			set{Matricula=value;}
		}
		
		
		public Materia [] MATERIA
		{
			get{return Ma;}
			set{Ma=value;}
		}
		
			
	}
}

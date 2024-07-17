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
	/// Description of Nota.
	/// </summary>
	public class Nota
	{
		private short Nota_1;
		private short Nota_2;
		private short Nota_3;
		private short Nota_Ayudantia;
		private short Nota_Final;
		private string Observacon;
		public Nota()
		{
			Nota_1=45;
			Nota_2=67;
			Nota_3=68;
			Nota_Ayudantia=56;
			Nota_Final=59;
			Observacon="nota baja";
		}
		public void leer(){
			
			Console.Write("ingrese nota 1: ");
			Nota_1=short.Parse(Console.ReadLine());
			Console.Write("ingrese nota 2: ");
			Nota_2=short.Parse(Console.ReadLine());
			Console.Write("ingrese nota 3: ");
			Nota_3=short.Parse(Console.ReadLine());
			Console.Write("ingrese nota Ayudantia: ");
			Nota_Ayudantia=short.Parse(Console.ReadLine());
			Console.Write("ingrese nota final: ");
			Nota_Final=short.Parse(Console.ReadLine());
			Console.Write("ingrese observacion: ");
			Observacon=Console.ReadLine();
		}
		public void mostrar(){
			Console.WriteLine("\n Datos de la Nota");
			Console.WriteLine("Nota 1: "+Nota_1);
			Console.WriteLine("Nota 2: "+Nota_2);
			Console.WriteLine("Nota 3: "+Nota_3);
			Console.WriteLine("Nota Ayudantia: "+Nota_Ayudantia);
			Console.WriteLine("Nota fnal: "+Nota_Final);
			Console.WriteLine("Observacion: "+Observacon);
		}
		
		public short Nota1
		{
			get{return Nota_1;}
			set{Nota_1=value;}
		}
		public short Nota2
		{
			get{return Nota_2;}
			set{Nota_2=value;}
		}
		public short Nota3
		{
			get{return Nota_3;}
			set{Nota_3=value;}
		}
		public short NotaAyudanta
		{
			get{return Nota_Ayudantia;}
			set{Nota_Ayudantia=value;}
		}
		public short NotaFinal
		{
			get{return Nota_Final;}
			set{Nota_Final=value;}
		}
		public string Observacion
		{
			get{return Observacon;}
			set{Observacon=value;}
		}
	}
}

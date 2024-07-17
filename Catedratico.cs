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
	/// Description of Catedratico.
	/// </summary>
	public class Catedratico:Persona
	{
		protected string Cod_cate;
		protected int item;
		protected double saldo;
		public Catedratico():base()
		{
			Cod_cate="4117";
			item=41111;
			saldo=1500;
			
		}
		public void leer(){
			base.leer();
			Console.Write("ingrese codigo catedratico: ");
			Cod_cate=Console.ReadLine();
			Console.Write("ingrese item: ");
			item=int.Parse(Console.ReadLine());
			Console.Write("imgrese saldo: ");
			saldo=double.Parse(Console.ReadLine());
		}
		public void mostrar(){
			Console.WriteLine("\n-- Datos del Catedratico --");
			base.mostrar();
			Console.WriteLine("codgo de categoria= "+Cod_cate);
			Console.WriteLine("item= "+item);
			Console.WriteLine("saldo= "+saldo);
		}
		public string Cod_cat
		{
			get{return Cod_cate;}
			set{Cod_cate=value;}
		}
		public int Item
		{
			get{return item;}
			set{item=value;}
		}
		public double Saldo
		{
			get{return saldo;}
			set{saldo=value;}
		}
		
	}
}

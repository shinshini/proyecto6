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
	/// Description of Semestre.
	/// </summary>
	public class Semestre
	{
		private string periodo;
		private int cant_catedratico;
		private Catedratico [] Ca;
		private int cant_estudiante;
		private Estudiante [] Es;
		public Semestre(Catedratico Cat, Estudiante Est)
		{
			periodo="6 meses";
			cant_catedratico=2;
			Ca= new Catedratico[cant_catedratico];
			for(int i=0;i<cant_catedratico;i++){
				Ca[i]=Cat;
						
			}
			cant_estudiante=2;
			Es = new Estudiante[cant_estudiante];
			
			for(int j=0;j<cant_estudiante;j++){
				Es[j]=Est;
			}
			
		}
		public void leer(){
			Console.Write("ingrese periodo: ");
			periodo=Console.ReadLine();
			Console.Write("ingrese cantdad categratico: ");
			cant_catedratico=int.Parse(Console.ReadLine());
			for(int i=0;i<Ca.Length;i++){
				Ca[i].leer();
			}
			Console.Write("ingrese cantidad estudiante: ");
			cant_estudiante=int.Parse(Console.ReadLine());
			for(int j=0;j<Es.Length;j++){
				Es[j].leer();
			}
			
			
		}
		public void mostrar(){
			Console.WriteLine("\n-- datos del semestre --");
			Console.WriteLine("periodo: "+periodo);
			Console.WriteLine("cantdad de catedratico: ");
			for(int i=0;i<Ca.Length;i++){
				Ca[i].mostrar();
			}
			Console.WriteLine("cantdad de estudante: "+cant_estudiante);
			for(int i=0;i<Es.Length;i++){
				Es[i].mostrar();
			}
		}
		public string Periodo
		{
			get{ return periodo;}
			set{periodo=value;}
		}
		public int CantCate
		{
			get{return cant_catedratico;}
			set{cant_catedratico=value;}
		}
		public Catedratico[] CATEDRATCO
		{
			get{return Ca;}
			set{Ca=value;}
		}
		public int CantEst
		{
			get{return cant_estudiante;}
			set{cant_estudiante=value;}
		}
		public Estudiante[] ESTUDIANTE
		{
			get{return Es;}
			set{Es=value;}
		}
	
	}
}

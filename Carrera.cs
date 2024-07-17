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
	/// Description of Carrera.
	/// </summary>
	public class Carrera
	{
		protected string nombre;
		protected int cant_semestre;
		protected Semestre [] Se;
		public Carrera(Semestre s)
		{
			nombre="textil";
			cant_semestre=3;
			Se=new Semestre[cant_semestre];
			for(int i=0;i<cant_semestre;i++){
				Se[i]=s;
			}
		}
		public void leer(){
			Console.Write("ingrese nombre: ");
			nombre=Console.ReadLine();
			Console.Write("ingrese cantidad de semestre: ");
			cant_semestre=int.Parse(Console.ReadLine());
			for(int i=0;i<Se.Length;i++){
				Se[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("\nDatos de la Carrera");
			Console.WriteLine("nombre: "+nombre);
			Console.WriteLine("cantdad semestre: "+cant_semestre);
			for(int i=0;i<Se.Length;i++){
				Se[i].mostrar();
			}
		}
		//b) Cuantas personas son de nacionalidad “x”, mostrar su nombre y teléfono.
		public void contarNacionalidadX(){
			int c=0;
			Console.WriteLine("\nIngrese nacionalidad: ");
			string x=Console.ReadLine().ToLower();
			for (int i = 0; i <Se.Length; i++) {
				for (int j = 0; j < Se[i].CantEst; j++) {
					if (Se[i].ESTUDIANTE[j].naconalidad.Equals(x)) {
						Console.WriteLine("Nombre: "+Se[i].ESTUDIANTE[j].Nombree+"\n Telefono: "+Se[i].ESTUDIANTE[j].telefono);
						c++;
					}
				}
				for (int k = 0; k < Se[i].CantCate; k++) {
					if(Se[i].CATEDRATCO[k].naconalidad.Equals(x)){
						Console.WriteLine("Nombre: "+Se[i].CATEDRATCO[k].Nombree+"\n Telefono: "+Se[i].CATEDRATCO[k].telefono);
						c++;
					}
				}
			}
			Console.WriteLine("Cantidasd de personas con nacionalidad "+x+" es "+c);
		}
		//c) Buscar al Estudiante con ci “x” y mostrar la nota final de la materia “y”.
		//1ra de forma
		public void buscarEstudent(){
			Console.WriteLine("\n ngrese ci de estudiante: ");
			int x=int.Parse(Console.ReadLine());
			for(int i=0;i<Se.Length;i++){
				for(int j=0;j<Se[i].CantEst;j++){
						if(Se[i].ESTUDIANTE[j].CI.Equals(x)){
						for(int k=0;k < Se[i].ESTUDIANTE[j].MATERIA.Length; k++)
							Console.WriteLine("nota final: "+Se[i].ESTUDIANTE[j].MATERIA[k].NOTA.NotaFinal);
						}
						}
				}
				
			
			}
		//d) Existe un error en la segunda nota del estudiante con ci “x” corregir 
		//ese error por “y” luego mostrar datos
         //actualizados.
          //1ra forma
          public void coregirNota(){
          Console.WriteLine("\n ingrese ci de estudiante: ");
			int x=int.Parse(Console.ReadLine());
			for(int i=0;i<Se.Length;i++){
				for(int j=0;j<Se[i].CantEst;j++){
					if(Se[i].ESTUDIANTE[j].CI.Equals(x)){
						for(int k=0;k < Se[i].ESTUDIANTE[j].MATERIA.Length; k++){
							Console.WriteLine("\ncorregir la segumda nota: ");
					
							Se[i].ESTUDIANTE[j].MATERIA[k].NOTA.Nota2=short.Parse(Console.ReadLine());
							Se[i].ESTUDIANTE[j].MATERIA[k].NOTA.mostrar();
						
						}
					}
				}
			}
          }
          // e) Si el catedrático con ítem “x” es de nacionalidad “y” adicionar 
          //el 20% más al sueldo, mostrar datos
          //actualizados.
             //1ra forma
             public void buscarItemNacio(){
               Console.WriteLine("\n ingrese en item del catedratico: ");
			int x=int.Parse(Console.ReadLine());
			  Console.WriteLine("\n ingrese nacionalidad del catedratico: ");
			  string y=Console.ReadLine().ToLower();
			  for(int i=0;i<Se.Length;i++){
			  	for(int j=0;j<Se[i].CantCate;j++){
			  		if(Se[i].CATEDRATCO[j].Item.Equals(x) && Se[i].CATEDRATCO[j].naconalidad.ToLower().Equals(y)){
			  			Se[i].CATEDRATCO[j].Saldo=Se[i].CATEDRATCO[j].Saldo+Se[i].CATEDRATCO[j].Saldo*0.20;
			  			Se[i].CATEDRATCO[j].mostrar();
			  		}
			  	}
			  }
             }
             //  f) Buscar a los estudiantes del periodo semestral “x” y que pertenezcan a la materia de nombre “y”, mostrar su
//nombre, matrícula y observación de la nota
             //1ra forma
             public void BuscarEstudPeriodoSemestral(){
             Console.WriteLine("\n ngrese periodo semestral del estudiante: ");
			  string x=Console.ReadLine().ToLower();
			  for(int i=0;i<Se.Length;i++){
			  	if(Se[i].Periodo.ToLower().Equals(x)){
			  		for(int j=0;j<Se[i].CantEst;j++){
			  		for(int k=0;k < Se[i].ESTUDIANTE[j].MATERIA.Length; k++){
			  			
			  			Console.WriteLine("nombre: "+Se[i].ESTUDIANTE[j].Nombree);
			  			Console.WriteLine("matricula: "+Se[i].ESTUDIANTE[j].matricula);
			  			Console.WriteLine("obdervacion: "+Se[i].ESTUDIANTE[j].MATERIA[k].NOTA.Observacion);
			  			
			  		}
			  	}
			  	}
			  }
             }
	}
}

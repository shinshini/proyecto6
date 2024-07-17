/*
 * Created by SharpDevelop.
 * User: CONTROL
 * Date: 13/06/2024
 * Time: 06:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practca_2bi_proyecto_estudant
{
	class Program
	{
		public static void Main(string[] args)
		{
			Catedratico C=new Catedratico();
			Estudiante E=new Estudiante();
			Semestre S=new Semestre(C,E);
			Carrera Car=new Carrera(S);
			Car.mostrar();
		//b) Cuantas personas son de nacionalidad “x”, mostrar su nombre y teléfono.
		//1ra de forma
			//Car.contarNacionalidadX();
		//2da de forma
                     		
		//Car.contarNaconaldadx3();
		//c) Buscar al Estudiante con ci “x” y mostrar la nota final de la materia “y”.
		//1ra de forma
		//Car.buscarEstudent();
		//2ra de forma
		//Car.buscarEstudent5();
		//d) Existe un error en la segunda nota del estudiante con ci “x” corregir ese error por “y” luego mostrar datos
//actualizados.
          //1ra forma
          //Car.coregirNota();
         // e) Si el catedrático con ítem “x” es de nacionalidad “y” adicionar el 20% más al sueldo, mostrar datos
//actualizados.
             //1ra forma
            //Car.buscarItemNacio();
          //  f) Buscar a los estudiantes del periodo semestral “x” y que pertenezcan a la materia de nombre “y”, mostrar su
//nombre, matrícula y observación de la nota
             //1ra forma
             Car.BuscarEstudPeriodoSemestral();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
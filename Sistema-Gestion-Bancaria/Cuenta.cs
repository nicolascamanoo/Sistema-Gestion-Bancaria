/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 13/5/2022
 * Hora: 10:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TpFinal
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	public class Cuenta
	{ 
		private int numeroDeCuenta;
		private string apellido;
		private int dni;
		private double saldo;
		
		
		public Cuenta(int dni, string apellido, double saldo, int numeroDeCuenta)
		{
			this.dni= dni;
			this.apellido= apellido;
			this.saldo=saldo;
			this.numeroDeCuenta= numeroDeCuenta;
		}
		public int NumeroDeCuenta{set{numeroDeCuenta= value;} get{return numeroDeCuenta;}}
		public string Apellido{set{apellido= value;}get{return apellido;}}
		public int Dni{set{dni= value;} get{return dni;}}
		public double Saldo{set{saldo= value;}get{return saldo;}}
		
		
		
	
		
	}
}

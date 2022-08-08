/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 13/5/2022
 * Hora: 10:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */ 
using System;
using System.Collections;

namespace TpFinal
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		//nombre y apellido, dni, dirección, teléfono de contacto y mail
		private string nombre, apellido, direccion, mail, telefono;
		private int dni;
		
		
		public Cliente(string nombre, string apellido, string telefono, string mail, string direccion, int dni)
		{
			this.nombre= nombre;
			this.dni= dni;
			this.apellido= apellido;
			this.telefono=telefono ;
			this.mail= mail;
			this.direccion= direccion;
		}
		
		public string Nombre{set{nombre= value;}get{return nombre;}}
		public string Apellido{set{apellido= value;}get{return apellido;}}
		public int Dni{set{dni= value;}get{return dni;}}
		public string Direccion{set{direccion= value;}get{return direccion;}}
		public string Telefono{set{telefono= value;}get{return telefono;}}
		public string Mail{set{mail= value;}get{return mail;}}
		
	}
}

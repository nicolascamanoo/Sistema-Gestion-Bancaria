/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 13/5/2022
 * Hora: 09:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace TpFinal
{
	/// <summary>
	/// Description of Banco.
	/// </summary>
	public class Banco
	{
		
		private ArrayList listaCuentas;
		private ArrayList listaCllientes;
		private string nombre;
		
		public Banco(string nombre)
		{
			this.nombre = nombre;
			listaCuentas = new ArrayList();
			listaCllientes= new ArrayList();
			
		}
		public string Nombre{set{nombre= value;}get{return nombre;}}
		public void eliminarCliente(int dni)
		{
			foreach(Cliente x in listaCllientes)
			{
				if(x.Dni == dni)
				{
					listaCllientes.Remove(x);
					break;
				}
			}
		}
		public void agregarCliente(Cliente client)
		{
			listaCllientes.Add(client);
		}
		
		public void agregarCuenta(Cuenta cuenta)
		{	
			listaCuentas.Add(cuenta);
		}
		public void depositarDinero(double deposito, int dnii, Cuenta x)
		{
			if (dnii==x.Dni)
			{x.Saldo += deposito;}
			else{Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("La cuenta no existe en este cliente.");}
		}
		public void retirarDinero(double retiro, int dnii, Cuenta x)
		{	if (dnii==x.Dni)
			{x.Saldo -= retiro;}
			else{Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("La cuenta no existe en este cliente.");}
		}
		public ArrayList retornarListaClientes(){return listaCllientes;}
		public ArrayList retornarListaDeCuentas(){return listaCuentas;}
		public void EliminarCuenta(int numeroCuenta, int dni)
		{
				Cuenta x=DevolverCuenta(numeroCuenta, dni);
				if((x.NumeroDeCuenta == numeroCuenta) && (x.Dni==dni))
				{
					listaCuentas.Remove(x);
					Console.ForegroundColor = ConsoleColor.Green ; Console.WriteLine("La cuenta se elimino Correctamente.");
				} 
		}
		
		public bool ExisteCliente(int dni)
		{
			bool variable= false;
			foreach (Cliente x in listaCllientes)
			{
				if (x.Dni == dni) {variable= true; break;}
			}
			return variable;
		}
		public bool ExisteCuenta(int numCuenta)
		{
			bool variable= false;
			foreach (Cuenta x in listaCuentas)
			{
				if (x.NumeroDeCuenta == numCuenta) {variable= true; break;}
			}
			return variable;
		}
		public void imprimirCuenta(int numCuenta)
		{
			foreach(Cuenta x in listaCuentas)
			{
				if(numCuenta == x.NumeroDeCuenta)
				{
					Console.WriteLine("Numero de cuenta: {0}",x.NumeroDeCuenta);
					Console.WriteLine("Saldo: {0}",x.Saldo);
					Console.WriteLine("----------");
				}
			}
		}
		public void imprimirCuentaConDni(int dni)
		{
			foreach(Cuenta x in listaCuentas)
			{
				if(dni == x.Dni)
				{ 	Console.ForegroundColor = ConsoleColor.Cyan ;
					Console.WriteLine("Numero de cuenta: {0}",x.NumeroDeCuenta);
					Console.Write("Saldo: ");
					Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine(x.Saldo);
					Console.ForegroundColor = ConsoleColor.DarkYellow ; Console.WriteLine("----------");
				}
			}
		}
		public void imprimirDatosCLiente(int dni)
		{
			foreach(Cliente x in listaCllientes)
			{
				if (dni==x.Dni)
				{
					Console.WriteLine("Apellido: {0} ", x.Apellido);
					Console.WriteLine("Dni: {0}", x.Dni);
				}
			}
		}
		public int cantidadDeClientes(){
			return listaCllientes.Count;
		}
		//devuelvo el cliente para poder trabajarlo en el main
		public Cliente DevolverCliente(int dni)
		{
			
			foreach( Cliente x in listaCllientes)
			{
				if (dni==x.Dni)
				{ return x; }
			}
			return null;
		}
		//devuelvo la cuenta para poder trabajarla en el main
       		  public Cuenta DevolverCuenta(int numeroDeCuenta,int dni)
      		  {
            		foreach( Cuenta x in listaCuentas)
          		 {
                			if (numeroDeCuenta == x.NumeroDeCuenta && dni==x.Dni)
                			{ return x;}
            		}
           		 return null;
       		 }
		public int CantidadDeCuentas(Cliente cli)
		{	int contador=0;
			foreach (Cuenta x in listaCuentas)
			{
				if (x.Dni== cli.Dni)
				{
					contador +=1;
				}
			}
			return contador;
		}
		
		
		
		
		
	}
}

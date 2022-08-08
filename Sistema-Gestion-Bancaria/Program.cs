/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 13/5/2022
 * Hora: 09:55 
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace TpFinal
{
	class Program
	{
		 
		public static void Main(string[] args)
		{ 
			//...A.....C...E...G....H
			// FALTA   B... D....F
			//valores asignados por defecto para probar rapido el programa.
			Banco banc= new Banco("provincia");
			Cliente cli= new Cliente("lautaro", "parramon", "1234","lauta@gmail.com","av. siempre viva 1888", 324232);
			Cliente cli2= new Cliente("nicolas", "camano", "123","nicolas@gmail.com","av. san martin 1234", 42093781);
			Cliente cli3= new Cliente("jose", "carrizo", "123","jose@gmail.com","av. san martin 333", 123);
			banc.agregarCliente(cli); 
			banc.agregarCliente(cli2); 
			banc.agregarCliente(cli3);
			Cuenta cu = new Cuenta( 324232, "parramon", 50000,5);
			Cuenta cu2 = new Cuenta( 42093781, "nicolas", 60087,6);
			Cuenta cu3 = new Cuenta( 42093781, "nicolas", 150000,7);
			Cuenta cu4 = new Cuenta( 324232, "parramon", 552000,8);
			Cuenta cu5 = new Cuenta( 123, "carrizo", 1501000,9);
			Cuenta cu6 = new Cuenta( 123, "carrizo", 552000,10);
			banc.agregarCuenta(cu);
			banc.agregarCuenta(cu2);
			banc.agregarCuenta(cu3);
			banc.agregarCuenta(cu4);
			banc.agregarCuenta(cu5);
			banc.agregarCuenta(cu6);
			string controlwhile = "n";
            do{ 
				menu();
				Console.ForegroundColor = ConsoleColor.Green ; string opcion =  Console.ReadLine();		
			
				switch(opcion.ToLower()){
					case "a": 
						{
							//AGREGAR CUENTA.
						CrearCuenta(banc);
						break;}
					case "b":
					
						{
							//Eliminar una cuenta y si no existe ninguna otra cuenta del mismo titular, dar de baja también al cliente
							EliminarCuentaa( banc);
							break;
						}
					case "c":
						
						{	//Listado de clientes que tienen más de una cuenta , indicando nro de cuenta y saldo de cada una.
							ListaClientesConMasDeUnaCuenta(banc);
							break;
						} 
					case "d":
					
						Extraccion(banc); 
						//Realizar una extracción. En caso de no poseer saldo suficiente Indicar (“Saldo insuficiente”)
						break;
						
					case "e":
					
						{
							//DEPOSITAR DINERO EN UNA CUENTA DADA.
							DepositarDinero(banc);
							break;
						}
					case "f":
					
						{       //Transferencia a otras cuentas incluyendo a otra del mismo cliente.
							Transferencia(banc);
							break;
						} 
						
					case "g":
					
					{   	//LISTADO DE CUENTAS.
							ListadoDeCuentas(banc.retornarListaDeCuentas());
						break;
					}
				case "h":
				
					{	//LISTADO DE CLIENTES
							ListadoDeClientes(banc.retornarListaClientes());
						break;
					}
					case "n":
						{  controlwhile = "n"; break;}
					
						default:{Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("ingrese datos correctos."); break;}
				
						
					

				//cierre del case						
				}
			
			 
			
			
			//cierre del case
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.DarkCyan ; Console.WriteLine("Desea realizar otra consulta? s/n");
			controlwhile= Console.ReadLine();
			Console.Clear();
			controlwhile= controlwhile.ToLower();
			}while(controlwhile != "n");
           
			
		} 
		
		static void menu(){
			Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("a-Agregar Cuenta. ");
			         Console.WriteLine("b-Eliminar Cuenta");
				Console.WriteLine("c-Listado de clientes con mas de una cuenta. ");
				Console.WriteLine("d-Realizar Extraccion  ");
				Console.WriteLine("e-Depositar Dinero. ");
				Console.WriteLine("f-Transferir dinero a otra cuenta.");
				Console.WriteLine("g-Listado de cuentas. ");
				Console.WriteLine("h-Listado de Clientes. ");
				Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.Cyan ;
			 	Console.WriteLine("INGRESE OPCION:  ");
		}
			static void agregarCuentaSinDni(Banco banc, int dni)
			{				
				try{	                  if(banc.cantidadDeClientes()>=0){
							Console.ForegroundColor = ConsoleColor.DarkBlue ;
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese nombre: ");
							Console.ForegroundColor = ConsoleColor.Green; string nombre= Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese Apellido: ");
							Console.ForegroundColor = ConsoleColor.Green; string apellido= Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese telefono: ");
							Console.ForegroundColor = ConsoleColor.Green; string telefono= Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese mail: ");
							Console.ForegroundColor = ConsoleColor.Green; string mail= Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese direccion: ");
							Console.ForegroundColor = ConsoleColor.Green; string direccion= Console.ReadLine();
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese Saldo: ");
							Console.ForegroundColor = ConsoleColor.Green; double saldo= double.Parse(Console.ReadLine());
							Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Ingrese Nro. Cuenta: ");
							Console.ForegroundColor = ConsoleColor.Green; int numCuenta = int.Parse(Console.ReadLine());
							if(!banc.ExisteCuenta(numCuenta)){
							Cuenta cuentaa = new Cuenta(dni, apellido, saldo, numCuenta);
							Cliente clientee = new Cliente(nombre, apellido, telefono, mail,  direccion, dni);
							banc.agregarCliente(clientee);
							banc.agregarCuenta(cuentaa);
							}else{ Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("El numero de cuenta ya existe.");}
				}
				}catch(Exception){ Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("Error, datos incorrectos.");}
		}
		
		static void ListadoDeCuentas( ArrayList lista)
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow ; Console.WriteLine("LISTADO DE CUENTAS.");
			Console.ForegroundColor = ConsoleColor.Blue ; Console.WriteLine("-----------------------");
		foreach(Cuenta x in lista){
				Console.ForegroundColor = ConsoleColor.DarkGray ;
							Console.WriteLine("Numero de cuenta: {0}", x.NumeroDeCuenta);
							Console.WriteLine("DNI: {0}",x.Dni);
							Console.WriteLine("Apellido: {0}",x.Apellido);
							Console.Write("Saldo: ");
							Console.ForegroundColor = ConsoleColor.Green ; Console.WriteLine(x.Saldo);
							Console.ForegroundColor = ConsoleColor.DarkYellow ; Console.WriteLine("-------------------------");
						}
		}
		
		static  void ListadoDeClientes(ArrayList lista){
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Yellow ; Console.WriteLine("LISTADO CLIENTES.");
			Console.ForegroundColor = ConsoleColor.Blue ; Console.WriteLine("-----------------------");
		foreach(Cliente x in lista)
						{Console.ForegroundColor = ConsoleColor.DarkGray ;
							Console.WriteLine("Nombre: {0}",x.Nombre);
							Console.WriteLine("Apellido: {0}",x.Apellido);
							Console.WriteLine("DNI: {0}",x.Dni);
							 Console.ForegroundColor = ConsoleColor.DarkYellow ; Console.WriteLine("-------------");
						}
		}
		
		static void ListaClientesConMasDeUnaCuenta(Banco banc)
		{
		Console.Clear();
		
		try{
			 
			foreach (Cliente x in banc.retornarListaClientes())
			{	
				if (banc.CantidadDeCuentas(x)>=2)
				{	Console.ForegroundColor = ConsoleColor.DarkCyan ;
					Console.WriteLine("Apellido: {0} ", x.Apellido);
					Console.WriteLine("Dni: {0}", x.Dni);
					 Console.ForegroundColor = ConsoleColor.Yellow ; Console.WriteLine("------------------------------------------------");
					Console.ForegroundColor = ConsoleColor.Cyan ;
					 banc.imprimirCuentaConDni(x.Dni);
					Console.WriteLine();
					Console.WriteLine();
				}
			}
			
		}catch(Exception){Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("Error, datos incorrectos.");}
		
		}
		
		
		
		
		
		static void CrearCuenta( Banco banc)
		{
		try{ 
						Console.Clear();
						Cuenta cue;
						int dnii;
						
						Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("Ingrese DNI: "); 
						Console.ForegroundColor = ConsoleColor.Green;  dnii= int.Parse (Console.ReadLine());	
						if(!banc.ExisteCliente(dnii)){agregarCuentaSinDni(banc, dnii);}
						else{
						Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("Ingrese Nro. Cuenta: ");
						Console.ForegroundColor = ConsoleColor.Green; int numCuentaa = int.Parse(Console.ReadLine());
						if(!(banc.ExisteCuenta(numCuentaa))){
						Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Apellido: "); 
						Console.ForegroundColor = ConsoleColor.Green; string apellido= Console.ReadLine();
						Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("Ingrese Saldo: ");
						Console.ForegroundColor = ConsoleColor.Green; double saldoo= double.Parse(Console.ReadLine());
						banc.agregarCuenta(cue= new Cuenta(dnii, apellido, saldoo, numCuentaa)); 
						}else{Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("El numero de cuenta ya existe.");}
							}
						
						
						}
			catch(Exception){Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("Datos incorrectos.");}
		}
		
		

		
		static void ImprimirCuentasDelCLiente(int dni, Banco banc)
		{
			foreach(Cuenta c in banc.retornarListaDeCuentas())
			{
					if(dni == c.Dni){
					Console.ForegroundColor = ConsoleColor.Yellow ;
					Console.WriteLine("-------------------------");
					Console.ForegroundColor = ConsoleColor.DarkCyan ;
					Console.WriteLine( "Numero de Cuenta: {0}", c.NumeroDeCuenta);
					Console.Write( "Saldo: ");
					Console.ForegroundColor = ConsoleColor.Green ; Console.WriteLine(c.Saldo);
					}
			}
		} 
		
		static void Extraccion(Banco banc)
		{
		 
		Console.Clear();
		int numCuenta;
		Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingrese DNI: ");
		try{
							Console.ForegroundColor = ConsoleColor.Green ;int dni = int.Parse(Console.ReadLine());
							if( banc.ExisteCliente(dni))
							{
								ImprimirCuentasDelCLiente(dni, banc);
								Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de cuenta a extraer dinero. ");
								Console.ForegroundColor = ConsoleColor.Green ; numCuenta= int.Parse(Console.ReadLine());
								if(banc.ExisteCuenta(numCuenta)){
								 Cuenta x=banc.DevolverCuenta(numCuenta, dni);
									Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingrese Monto  a retirar.");
									try{
										Console.ForegroundColor = ConsoleColor.Green ; double monto= double.Parse(Console.ReadLine());
										if(x.Saldo<monto){throw new SaldoInsuficientException();}
										else{
										banc.retirarDinero(monto, dni, x);
										}
									}catch(SaldoInsuficientException){Console.ForegroundColor = ConsoleColor.Red ;  Console.WriteLine("Saldo Insuficiente");}
								}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("la cuenta no existe en el banco");}
							}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El cliente no existe en el banco");}
		}catch(Exception){Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error, datos incorrectos.");}
		} 
		
		
		static void DepositarDinero(Banco banc)
		{
		
		Console.Clear();
		int numCuenta;
		 Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingrese DNI: ");
		try{ 
							Console.ForegroundColor = ConsoleColor.Green ; int dni = int.Parse(Console.ReadLine());
							if( banc.ExisteCliente(dni))
							{
								ImprimirCuentasDelCLiente(dni, banc);
								Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de cuenta a depositar dinero. ");
								Console.ForegroundColor = ConsoleColor.Green ; numCuenta= int.Parse(Console.ReadLine());
								if(banc.ExisteCuenta(numCuenta)){
								foreach (Cuenta x in banc.retornarListaDeCuentas())
								{
									if(x.NumeroDeCuenta== numCuenta)
									{ Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingrese Monto  a depositar.");
									Console.ForegroundColor = ConsoleColor.Green ;	double monto= double.Parse(Console.ReadLine());
										
					
										banc.depositarDinero(monto, dni, x);
										
									}
								} 
								 }else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("la cuenta no existe en el banco");}
							}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El cliente no existe en el banco");}
		}catch(Exception){Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error, datos incorrectos.");}
		}
		
		static void Transferencia(Banco banc)
		{ 
			try{
			int nummCuenta;
		double monto;
		Console.Clear(); 
		int numCuenta;
		Console.ForegroundColor = ConsoleColor.Cyan;  Console.WriteLine("ingrese DNI: "); 
							Console.ForegroundColor = ConsoleColor.Green ; int dni = int.Parse(Console.ReadLine());
							if( banc.ExisteCliente(dni))
							{
								ImprimirCuentasDelCLiente(dni, banc);
								Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de cuenta a retirar dinero. ");
								Console.ForegroundColor = ConsoleColor.Green; numCuenta= int.Parse(Console.ReadLine());
								if(banc.ExisteCuenta(numCuenta)){
									Cuenta x= banc.DevolverCuenta(numCuenta, dni);
									Console.ForegroundColor = ConsoleColor.Cyan ;Console.WriteLine("ingrese Monto  a retirar.");
									try{
										Console.ForegroundColor = ConsoleColor.Green ; monto= double.Parse(Console.ReadLine());
									 if(x.Saldo<monto){throw new SaldoInsuficientException();}
									else{
											Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de DNI del cliente a transferir:  ");
											Console.ForegroundColor = ConsoleColor.Green ; int dnii= int.Parse(Console.ReadLine());
											if(banc.ExisteCliente(dnii))
											{
											Console.Clear();
											ImprimirCuentasDelCLiente(dnii, banc);
											Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de cuenta a transferir dinero. ");
											Console.ForegroundColor = ConsoleColor.Green ;  nummCuenta= int.Parse(Console.ReadLine());
											if(banc.ExisteCuenta(nummCuenta))
											{
												Cuenta j = banc.DevolverCuenta(nummCuenta, dnii);
												if(j.NumeroDeCuenta== nummCuenta)
														{
															banc.retirarDinero(monto, dni, x);
															banc.depositarDinero(monto, dnii, j);
															Console.WriteLine("Transferencia Exitosa.");
														}
												
											}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("la cuenta no existe en el banco");}
											}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El cliente no existe en el banco");}
									}
								 }
									catch(SaldoInsuficientException){Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Saldo Insuficiente.");}
								 }else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("la cuenta no existe en el banco");}
							}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("El cliente no existe en el banco");}
			}catch(Exception){Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error, datos incorrectos");}
		}
		
		
		
		
		
		static void EliminarCuentaa ( Banco banc)
		{try{
				Console.ForegroundColor = ConsoleColor.Cyan ;
			bool variable = false;
		Console.WriteLine("Ingrese DNI del cliente.");
							
		Console.ForegroundColor = ConsoleColor.Green ; int dniCliente= int.Parse (Console.ReadLine());
							if(banc.ExisteCliente(dniCliente)){
								
								Cliente xx = banc.DevolverCliente(dniCliente);
								
									ImprimirCuentasDelCLiente(dniCliente, banc);
									Console.ForegroundColor = ConsoleColor.Cyan ; Console.WriteLine("ingresar numero de cuenta a eliminar.");
									Console.ForegroundColor = ConsoleColor.Green; int numDeCuenta= int.Parse(Console.ReadLine());
									if(banc.ExisteCuenta(numDeCuenta)){
									banc.EliminarCuenta(numDeCuenta, dniCliente );
									}else{Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("La cuenta no existe en el banco.");}
									foreach(Cuenta x in banc.retornarListaDeCuentas())
								{
										if(x.Dni==dniCliente){ variable = true;}
								}
									if(variable == false){banc.eliminarCliente(dniCliente);} 
								
							
							}else{Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("no existe el cliente");}
			}catch(Exception){Console.ForegroundColor = ConsoleColor.Red ; Console.WriteLine("Error, datos incorrectos.");}
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
	public class SaldoInsuficientException: Exception
	{}
}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
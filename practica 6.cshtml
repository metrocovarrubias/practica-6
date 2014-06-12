using System;
using MySql.Data.MySqlClient;

namespace Practica6
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Conexion
	{
		public string  id,codigo, nombre;

		public Profesor()
		{
		}

		public void Menu(){
		 int opcion;
		 string respuesta;

			Console.WriteLine("Elegir una opcion");
			Console.WriteLine("1.- Mostrar");
			Console.WriteLine("2.- Agregar");
			Console.WriteLine("3.- Editar");
			Console.WriteLine("4.- Eliminar");
			Console.WriteLine("5.- Salir");
			
			opcion = int .Parse(Console.ReadLine());

			switch (opcion){
				case 1:
					Console.Clear();
					mostrarTodos();
					Console.WriteLine("1 ¿Regresar al menu?");
					Console.WriteLine("2 Salir");
					respuesta = Console.ReadLine();

					if(respuesta == "1"){
						Console.Clear();
						Menu();
					}
					else{
						Environment.Exit(0);
					}
				break;
				
			    case 2:
				    Console.Clear();
				   
				    Console.WriteLine("Ingrese el código");
				    codigo = Console.ReadLine();
				    Console.WriteLine("Ingrese el nombre");
				    nombre = Console.ReadLine();
				    Agregar(id,codigo,nombre);
				    Console.WriteLine("Exito al guardar" + "\n");
				    Console.WriteLine("1.- ¿Regresar al menu?");
					Console.WriteLine("2.- Salir");
					respuesta = Console.ReadLine();

					if(respuesta == "1"){
						Console.Clear();
						Menu();
					}
					else{
						Environment.Exit(0);
					}
				break;
				
				 case 3:
				    Console.Clear();
				    
					Console.WriteLine("Editar Registro"+"\n");
					Console.WriteLine ("Ingrese el id: ");
					id = Console.ReadLine();
					Console.WriteLine("Ingrese el codigo");
					codigo = Console.ReadLine();
					Console.WriteLine ("Ingrese el nuevo codigo : ");
					codigo = Console.ReadLine();
					editarCodigoRegistro(codigo,id);
				    Console.WriteLine("Exito al guardar" + "\n");
				   	Console.WriteLine("1 ¿Regresar al menu?");
					Console.WriteLine("2 Salir");
					respuesta = Console.ReadLine();

					if(respuesta == "1"){
						Console.Clear();
						Menu();
					}
					else{
						Environment.Exit(0);
					}
				break;
				
				
				case 4:
				    Console.Clear();
					Console.WriteLine("Eliminar Registro" + "\n");
					Console.WriteLine ("Ingrese el ID a borrar");
					id=Console.ReadLine();
					this.eliminarRegistroPorid(id);
				    Console.WriteLine("¿Qué desea hacer?");
					Console.WriteLine("1.- Regresar al menu");
					Console.WriteLine("2.- Salir");
					respuesta = Console.ReadLine();

					if(respuesta == "1"){
						Console.Clear();
						Menu();
					}
					else{
						Environment.Exit(0);
					}
				break;
			   
           
			    case 5:
				    Environment.Exit(0);
				break;
			}

		}
		
			
		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string id = myReader["id"].ToString();
	            string codigo = myReader["codigo"].ToString();
	            string nombre = myReader["nombre"].ToString();
	            Console.WriteLine("ID: " + id +"\n"+" Código: " + codigo +"\n"+" Nombre: " + nombre+"\n");
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}
//para poner los datos en la base de datos		
public void Agregar(string id,string codigo, string nombre){
	
this.abrirConexion();
string sql = "INSERT INTO alumno1 (codigo, nombre) VALUES ('" + codigo + "', '" + nombre + "')";
this.ejecutarComando(sql);
this.cerrarConexion();


}
//para poner editar codigo
public void editarCodigoRegistro(string codigo,string id){
			this.abrirConexion();
			string sql = "UPDATE `alumno1` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
				
					
		public  void  eliminarRegistroPorid ( string id ) {
			this.abrirConexion ();
			string  sql  =  "DELETE FROM `alumno1` WHERE (`ID`= '"  + id  +  "')" ;
			
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}

		private string querySelect(){
			return "SELECT * " +
	           	"FROM alumno1";
		}

	}
}
using System;
using MySql.Data.MySqlClient;

namespace Practica6
{
	public class Conexion
	{
		protected MySqlConnection myConnection;
		public Conexion ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=alumno1;" +
	          	"User ID=root;" +
	          	"Password=metro;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}

		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}

	}
}

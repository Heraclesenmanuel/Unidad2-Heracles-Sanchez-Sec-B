using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{
	
	public abstract class Personal : Titulo_interfaz //Clase MADRE
	{ //Atributos globales
		private String nombre;
		private Int16 edad, años_trabajo;
		private Int32 cedula;
		protected String Nombre {get{return nombre;} set{nombre=value;}}
		protected Int16 Edad {get{return edad;} set{edad=value;}}
		protected Int16 Años_trabajo {get{return años_trabajo;} set{años_trabajo=value;}}
		protected Int32 Cedula {get{return cedula;} set{cedula=value;}}
					
		public String Titulo {get; set;}                    //Atributo de interfaz	
		protected String t; 								//Almacenamiento de título	
		public String Titulo_validar(String t) 				//Método de Interfaz
		{ 
			return Titulo = t;
				}
		
		//Constructores base
		public Personal()
		{
			Nombre = ""; Edad = 0; Años_trabajo = 0; Cedula = 0; Titulo = t;
		}
		public Personal(String a, Int16 b, Int16 c, Int32 d)
		{
			Nombre = a; Edad = b; Años_trabajo = c; Cedula = d; Titulo = t;
		}
		
		//Métodos
		public void Actualizar_documentos()
		{
			Console.WriteLine("El {0} {1} actualizó los registros médicos del paciente", Titulo, nombre);
		}
		
		public void Informar_paciente()
		{
			Console.WriteLine("El {0} {1} atendió la duda del paciente", Titulo, nombre);
		}
		
		public void Observacion_quirurgica()
		{
			Console.WriteLine("El {0} {1} asistió observacionalmente a la cirugía", Titulo, Nombre);
		}
		

		public override string ToString()
		{
			return string.Format("[Personal Nombre={0}, Edad={1}, Años_trabajo={2}, Cedula={3}, Titulo={4}]", nombre, edad, años_trabajo, cedula, Titulo);
		}

	}
}

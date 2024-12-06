using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{
	public class Médico : Personal //Clase Hija
	{														//Atributos
		protected bool recetario;
		public bool Recetario {get{return recetario;}set{recetario=value;}}
		
		//Constructores
		public Médico () : base()
		{
		}
		public Médico(bool e) : base()
		{
			Recetario = e;
		}
		
		public Médico(String a, Int16 b, Int16 c, Int32 d, bool e)
		{
		Nombre = a; Edad = b; Años_trabajo = c; Cedula = d; Recetario = e;
		}
		
		//Métodos
		public void Diagnostico()
		{
			Console.WriteLine("El {0} {1} realizó el diagnóstico", Titulo, Nombre);
		}
		public void Atender_paciente()
		{
			Console.WriteLine("El paciente ha sido atendido por el {0} {1}", Titulo, Nombre);
		}
		public void Administrar_medicamentos()
		{
			Console.WriteLine("El paciente se ha medicado como el {0} {1} consideró necesario", Titulo, Nombre); 
		}
		public void Recetar_medicamentos()
		{
			Console.WriteLine("Al paciente se le ha recetado lo que el {0} {1} prescribió", Titulo, Nombre); 
		}
		public void Cirugía()
		{
			Console.WriteLine("El {0} {1} participó en la cirugía", Titulo, Nombre); 
		}
	
		public override string ToString()
		{
			return base.ToString() + ", Recetario:" + Recetario;
		}

	}
}

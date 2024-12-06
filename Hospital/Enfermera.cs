using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{
	public class Enfermera : Personal //Clase Hija
	{														//Atributos
		protected bool uniforme_enf;
		public bool Uniforme_enf {get{return uniforme_enf;}set{uniforme_enf=value;}}
		
		//Constructores
		public Enfermera () : base()
		{
		}
		public Enfermera(bool e) : base()
		{
			Uniforme_enf = e;
		}
		
		public Enfermera(String a, Int16 b, Int16 c, Int32 d, bool e)
		{
		Nombre = a; Edad = b; Años_trabajo = c; Cedula = d; Uniforme_enf = e;
		}
		
		//Métodos
		public void Monitorización()
		{
			Console.WriteLine("La {0} {1} monitoreó al paciente por el día", Titulo, Nombre);
		}
		public void Atender_paciente()
		{
			Console.WriteLine("El paciente ha sido atendido por la {0} {1}", Titulo, Nombre);
		}
		public void Administrar_medicamentos()
		{
			Console.WriteLine("El paciente se ha medicado como la {0} {1} consideró necesario", Titulo, Nombre); 
		}
		public void Cirugía()
		{
			Console.WriteLine("La {0} {1} participó en la cirugía", Titulo, Nombre); 
		}
		
		public override string ToString()
		{
			return base.ToString() + ", Uniforme de enfermera:" + Uniforme_enf;
		}

	}
}

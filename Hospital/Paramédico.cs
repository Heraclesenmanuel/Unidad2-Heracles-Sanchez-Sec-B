using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{ 
	public class Paramédico : Personal //Clase Hija
	{														//Atributos
		protected bool botiquin;
		public bool Botiquin {get{return botiquin;}set{botiquin=value;}}
		
		//Constructores
		public Paramédico() : base()
		{
		}
		public Paramédico(bool e) : base()
		{
			Botiquin = e;
		}
		
		public Paramédico(String a, Int16 b, Int16 c, Int32 d, bool e)
		{
		Nombre = a; Edad = b; Años_trabajo = c; Cedula = d; Botiquin = e;
		}
		
		//Métodos
		public void Reanimación_cardiopulmonar()
		{
			Console.WriteLine("El {0} {1} proporcionó atención médica en el lugar", Titulo, Nombre);
		}
		public void Atender_paciente()
		{
			Console.WriteLine("El paciente ha sido atendido por el {0} {1}", Titulo, Nombre);
		}
		public void Administrar_medicamentos()
		{
			Console.WriteLine("El paciente se ha medicado como el {0} {1} consideró necesario", Titulo, Nombre); 
		}
		
		public override string ToString()
		{
			return base.ToString() + ", Botiquín de primeros auxilios:" + Botiquin ;
		}

	}
}

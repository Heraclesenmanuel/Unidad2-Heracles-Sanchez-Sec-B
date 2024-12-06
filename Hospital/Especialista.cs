using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{
	public class Especialista : Personal //Clase Hija
	{														//Atributos
		protected bool equip_diagnostico;
		public bool Equip_diagnostico {get{return equip_diagnostico;}set{equip_diagnostico=value;}}
		
		//Constructores
		public Especialista () : base()
		{
		}
		public Especialista(bool e) : base()
		{
			Equip_diagnostico = e;
		}
		
		public Especialista(String a, Int16 b, Int16 c, Int32 d, bool e)
		{
		Nombre = a; Edad = b; Años_trabajo = c; Cedula = d; Equip_diagnostico = e;
		}
		
		//Métodos
		public void Cirugía_cardiaca()
		{
			Console.WriteLine("El {0} {1} realizó la cirugía cardiaca", Titulo, Nombre); 
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
			return base.ToString() + ", Equipo de diagnóstico:" + Equip_diagnostico;
		}

	}
}

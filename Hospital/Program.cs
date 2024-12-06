using System;
//Heracles Sánchez CI 31987430 Informática 1er Semestre Sección B
namespace Hospital
{ 
	class Program
	{
		public static void Main(string[] args)
		{
			//Instancia de 1 objeto Paramédico de clase Personal, mostrada por consola, métodos de clase hija y clase madre
			Personal Marcos = new Paramédico("Marcos", 5, 3, 31987430, true);
			Marcos.Titulo_validar("Doctor");
			Console.WriteLine(Marcos);
			Console.WriteLine();
			Paramédico paramédico = Marcos as Paramédico;
			if (paramédico != null)
			{ 
				paramédico.Reanimación_cardiopulmonar();
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Paramédico"); 
			}
			if (paramédico != null)
			{ 
				paramédico.Administrar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Paramédico"); 
			}
			if (paramédico != null)
			{ 
				paramédico.Atender_paciente(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Paramédico"); 
			}
			Console.WriteLine();
			Marcos.Actualizar_documentos();
			Marcos.Informar_paciente();
			Marcos.Observacion_quirurgica();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			//Instancia de 2 objetos Médicos de clase Personal, mostrados por consola, métodos de clase hija y clase madre
			//Instancia de 1 objeto Enfermera intentando ejecutar Métodos de Médico, así como de clase madre
			Personal Victor = new Médico("Victor Hernandez", 39, 8, 18325932, true);
			Personal Pedro = new Médico();
			Personal Alfredo = new Enfermera("Alfredo Mendoza", 34, 0, 21432594, true);
			Victor.Titulo_validar("Doctor");
			Console.WriteLine(Victor);
			Console.WriteLine();
			
			Médico x = Victor as Médico;
			if (x != null)
			{ 
				x.Diagnostico(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (x != null)
			{ 
				x.Administrar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (x != null)
			{ 
				x.Atender_paciente(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (x != null)
			{ 
				x.Recetar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (x != null)
			{ 
				x.Cirugía(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			Console.WriteLine();
			Victor.Actualizar_documentos();
			Victor.Informar_paciente();
			Victor.Observacion_quirurgica();
			Console.WriteLine();
			Médico y = Pedro as Médico;
			if (y != null)
			{ 
				y.Diagnostico(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (y != null)
			{ 
				y.Administrar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (y != null)
			{ 
				y.Atender_paciente(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (y != null)
			{ 
				y.Recetar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (y != null)
			{ 
				y.Cirugía(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			Console.WriteLine();
			Pedro.Actualizar_documentos();
			Pedro.Informar_paciente();
			Pedro.Observacion_quirurgica();
			Console.WriteLine();

			Alfredo.Titulo_validar("Doctor");
			Console.WriteLine(Alfredo);
			Console.WriteLine();
			
			Médico r = Alfredo as Médico;
			if (r != null)
			{ 
				r.Diagnostico(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (r != null)
			{ 
				r.Administrar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (r != null)
			{ 
				r.Atender_paciente(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (r != null)
			{ 
				r.Recetar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (r != null)
			{ 
				r.Cirugía(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			Console.WriteLine();
			Alfredo.Actualizar_documentos();
			Alfredo.Informar_paciente();
			Alfredo.Observacion_quirurgica();
			Console.WriteLine();

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			
			//Instancia de 1 objeto Especialista de clase Personal, mostrados por consola, métodos de clase hija y clase madre
			Personal Hernel = new Especialista("Hernel Piñeda", 37, 6, 22343243, true);
			Hernel.Titulo_validar("Doctor");
			Console.WriteLine(Hernel);
			Console.WriteLine();
			
			Especialista z = Hernel as Especialista;
			if (z != null)
			{ 
				z.Cirugía_cardiaca(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (z != null)
			{ 
				z.Recetar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Especialista"); 
			}
			if (z != null)
			{ 
				z.Cirugía(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Especialista"); 
			}
			Console.WriteLine();
			Hernel.Actualizar_documentos();
			Hernel.Informar_paciente();
			Hernel.Observacion_quirurgica();
			Console.WriteLine();
			
			//Instancia de 1 objeto Enfermera de clase Personal, mostrados por consola, métodos de clase hija y clase madre
			Personal Sara = new Enfermera("Sara Ramos", 21, 0, 32435953, true);
			Sara.Titulo_validar("Enfermera");
			Console.WriteLine(Sara);
			Console.WriteLine();
			
			Enfermera s = Sara as Enfermera;
			if (s != null)
			{ 
				s.Monitorización(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Médico"); 
			}
			if (s != null)
			{ 
				s.Administrar_medicamentos(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Enfermera"); 
			}
			if (s != null)
			{ 
				s.Atender_paciente(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Enfermera"); 
			}
			if (s != null)
			{ 
				s.Cirugía(); 
			}
			else
			{ 
				Console.WriteLine("La instancia no es de tipo Enfermera"); 
			}
			Console.WriteLine();
			Sara.Actualizar_documentos();
			Sara.Informar_paciente();
			Sara.Observacion_quirurgica();
			Console.WriteLine();
			
			Console.ReadKey(true);
		}
	}
}
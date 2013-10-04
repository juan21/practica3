using System.Collections;
using System;

namespace practic{
	
	public class inicio{
		
		static void Main (string [] args){
			
			persona d=new persona();
			
			d.captura();
			Console.Clear();
			d.editar ();
			Console.Clear();
			d.eliminar ();
			Console.Clear();
			d.Mostrar();
			Console.Clear ();
		}
	}
}

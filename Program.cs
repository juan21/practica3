using System.Collections;
using System;

namespace practic {
	
	 public class persona {
		
	 private Hashtable tabla; 
		
	 public persona (){
	 	this.tabla = new Hashtable();
	 }
	
  public void captura (){
	 	for (int i=0;i<4;i++){		
	 		Console.Clear();
	 		this.capturarbaseregistro (new registro());
	   }
  }
	
  private void capturarbaseregistro (registro registro){
	 	this.capturarbase(registro);
	 	this.agregarregistro (registro);
  }
	
  private void capturarbase (registro registro){
	 		if (registro.codigo == ""){
	 		Console.WriteLine ("Ingresa un numero para registrar en codigo\n");
	 		Console.WriteLine ("dame codigo");
		    registro.codigo=Console.ReadLine ();
	 		}
	 	
		    Console.WriteLine ("\nNombre");
		   	registro.nombre=Console.ReadLine ();
		   	Console.WriteLine ("\nTelefono");
		   	registro.telefono=Console.ReadLine ();
	    	Console.WriteLine ("\nFacebook");
	    	registro.facebook=Console.ReadLine ();
	 	}
   private void agregarregistro (registro registro){
	 		if (this.tabla.ContainsKey(registro.codigo)){
	 		this.tabla.Remove(registro.codigo);
	 		}
	 		this.tabla.Add(registro.codigo,registro);
	 	}
    public void editar (){
	 		for (int i=0;i<2;i++){
	 		Console.Clear ();
	 		string codigo="";
	 		Console.WriteLine ("dame codigo a modificar");
	 		codigo= Console.ReadLine();
	 		if (this.tabla.ContainsKey (codigo)){
	 		registro registro= (registro)this.tabla [codigo];
	 		this.capturarbaseregistro (registro);
	 		}
	 		else {
	 		this.error();
	 		}
	 	}
	}
	public void eliminar (){
	 		for (int i=0;i<2;i++){
	 		Console.Clear ();
	 		string codigo="";
	 		Console.WriteLine ("dame codigo a eliminar");
	 		codigo= Console.ReadLine();
	 		if (this.tabla.ContainsKey (codigo)){
	 		registro registro= (registro)this.tabla [codigo];
	 		this.eliminar (registro.codigo);	
	 	}
	 		else{
	 		this.error();
	 		}
	 	}
	}
	 private void eliminar (string codigo){
	 			Console.WriteLine("desea eliminarlo");
	 			Console.WriteLine ("n=No, s=SI");
	 			string opc = Console.ReadLine();
	 			      if (opc!="0"){
	 			        this.tabla.Remove(codigo);   	
	 			  }
	 		}
	 private void error(){
	 			Console.WriteLine("el codigo que me diste no existe");
	 			Console.WriteLine ("presione enter para continuar");
	 			Console.ReadLine ();
	 		}
	
	 public void Mostrar(){
		Console.WriteLine("registros que quedaron");
				Console.WriteLine();
				IDictionaryEnumerator enumerador = tabla.GetEnumerator();
			    while ( enumerador.MoveNext() )
				{
	               registro m = (registro)(tabla[enumerador.Key]);
					Console.Write ("Codigo:");
					Console.WriteLine (m.codigo);

					Console.Write ("Nombre:");
					Console.WriteLine (m.nombre);

					Console.Write ("Telefono:");
					Console.WriteLine (m.telefono);

					Console.Write ("Facebook:");
					Console.WriteLine (m.facebook);
					Console.WriteLine();
			    
		
	       }
			    Console.ReadKey ();
	    }
	}
}


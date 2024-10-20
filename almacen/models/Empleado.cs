namespace almacen.models{
    public abstract class  Empleado{

        private  int idEmpleado{get;set;}

      private string nombre {get; set;}

      private string rol{get; set;}

      public int IDEmpleado{
      get { return idEmpleado; }   // Getter
      set { idEmpleado = value; }  // Setter

     }

      public string Nombre
    {
        get { return nombre; }   // Getter
        set { nombre = value; }  // Setter
    }
     public string Rol{
      get { return rol; }   // Getter
      set { rol = value; }  // Setter

     }

      public Empleado(){

      }

        

        public Empleado (int idEmpleado, string nombre, string rol){
        this.idEmpleado=idEmpleado;
        this.nombre=nombre;
        this.rol=rol;
      }



      public abstract void MostrarInformacion();

        
    }
}
namespace almacen.models{

    public class Aministrador : Empleado{

    public Aministrador(){

    }

    public Aministrador( int IdEmpleado, string nombre, string rol) : base(IdEmpleado,nombre,rol) { 

      IDEmpleado=IdEmpleado;
        Nombre=nombre;
        Rol=rol;
        
    }

        public override void MostrarInformacion()
        {
              Console.WriteLine($" nombre: {Nombre} rol: {Rol}");
        }
    }
}
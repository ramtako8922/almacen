namespace almacen.models
{
    public class EncargadoAlmacen:Empleado{
        
     
public EncargadoAlmacen(){
        
    }

    public EncargadoAlmacen( int IdEmpleado, string nombre, string rol) : base(IdEmpleado,nombre,rol){

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
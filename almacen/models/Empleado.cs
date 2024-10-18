namespace almacen.models{
    public class Empleado{
      private  int idEmpleado;

      private string nombre;

      private string rol;

      public Empleado(){

      }


      public Empleado (int idEmpleado, string nombre, string rol){
        this.idEmpleado=idEmpleado;
        this.nombre=nombre;
        this.rol=rol;
      }

    }
}
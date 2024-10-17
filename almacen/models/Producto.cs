namespace almacen.models
{
    public class Producto

{
    private  int codigo;
    private String nombre;

    private String descripcion;

    private float precioUnitario;

    private int cantidadStoock;

    private Proveedor proveedor;
public Producto (){

}

public Producto(int codigo, String nombre, String descripcion, float precioUnitario,int cantidadStoock, Proveedor proveedor ){

    this.codigo=codigo;
    this.nombre=nombre;
    this.descripcion=descripcion;
    this.precioUnitario=precioUnitario;
    this.cantidadStoock=cantidadStoock;
    this.proveedor=proveedor;
}




}


}

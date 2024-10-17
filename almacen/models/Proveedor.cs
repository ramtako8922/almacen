namespace almacen.models

{
   public class Proveedor{
     private int idProveerdor;
     private String nombre;

     private List<Producto> productosSuministrados;

     public Proveedor(){

     }

     public Proveedor( int idProveerdor, String nombre, List<Producto> productosSuminstrados ){
         this.idProveerdor=idProveerdor;
         this.nombre=nombre;
         this.productosSuministrados=[];


     }

     public void AgregarProducto( Producto p){

        productosSuministrados.Add(p);

     }
       
      

   } 
    
}
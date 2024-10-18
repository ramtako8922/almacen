namespace almacen.models

{
   public class Proveedor{
     private int idProveerdor;
     private string nombre;

     private List<Producto> productosSuministrados;

     public Proveedor(){

     }

     public Proveedor( int idProveerdor, string nombre ){
         this.idProveerdor=idProveerdor;
         this.nombre=nombre;
         productosSuministrados=[];


     }

     public void AgregarProducto( Producto p){

        productosSuministrados.Add(p);

     }
       
      

   } 
    
}
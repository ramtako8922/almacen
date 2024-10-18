namespace almacen.models{
    public class ItemPedido{
        public int cantidad;
        public Producto producto;

    

    public ItemPedido(){
    
    }

    public ItemPedido( int cantidad, Producto producto){
        this.cantidad=cantidad;
        this.producto=producto;
    }
}
}
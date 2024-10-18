namespace almacen.models{
    class Pedido{
        private  int idPedido;

        private DateTime fecha;
        private float total;

        List <ItemPedido> itemPedidos;

         private Proveedor proveedor;

        private  Empleado empleado;

    

    public Pedido(){

    }

    public Pedido(int idPedido, DateTime fecha, float total, List<ItemPedido> itemPedidos, Proveedor proveedor, Empleado empleado){
        this.idPedido=idPedido;
        this.fecha=new DateTime();
        this.total=total;
        this.itemPedidos=[];
        this.proveedor=proveedor;
        this.empleado=empleado;

    }

      public void agregarItemPedido(ItemPedido itempedido){
       itemPedidos.Add(itempedido);

    }

    
}
}

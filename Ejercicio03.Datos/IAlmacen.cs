using Ejercicio03.Entidades;

namespace Ejercicio03.Datos
{
    public interface IAlmacen
    {
        List<Producto> GetProductos();
        void AgregarProducto(Producto producto);
        void EliminarProducto(string codigo);
        Producto? BuscarProductoPorCodigo(string codigo);
        Producto? BuscarProductoPorNombre(string nombre);
        decimal CalcularValorTotal();

    }
}

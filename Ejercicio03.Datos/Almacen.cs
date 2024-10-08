using Ejercicio03.Entidades;

namespace Ejercicio03.Datos
{
    public class Almacen : IAlmacen
    {
        private List<Producto> productos=null!;
        public Almacen()
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");

            if (BuscarProductoPorCodigo(producto.Codigo) != null)
                throw new InvalidOperationException("Ya existe un producto con el mismo código.");

            productos.Add(producto);
        }

        public Producto? BuscarProductoPorCodigo(string codigo)
        {
            return productos.FirstOrDefault(p=>p.Codigo == codigo);
        }

        public Producto? BuscarProductoPorNombre(string nombre)
        {
            return productos.FirstOrDefault(p => p.Nombre
                .Equals(nombre,StringComparison.CurrentCultureIgnoreCase));
        }

        public decimal CalcularValorTotal()
        {
            var total = 0m;
            foreach (var p in productos)
            {
                total += p.Precio;
            }
            return total;
        }

        public void EliminarProducto(string codigo)
        {
            Producto? producto=BuscarProductoPorCodigo(codigo);
            if (producto != null)
            {
                productos.Remove(producto);
            }
        }

        public List<Producto> GetProductos()
        {
            return productos;
        }
    }
}

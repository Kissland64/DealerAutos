using Microsoft.JSInterop;
using System.Text.Json;

namespace DealerAutos.Client.Sesion
{
    public interface IUsuarioAutenticadoService
    {
        Task CargarUsuarioAsync();
        Usuario Usuarios { get; set; }
        void AgregarVehiculosAlCarrito(Vehiculos vehiculos);
        List<Vehiculos> ObtenerVehiculosDelCarrito();
        void RemoverVehiculosDelCarrito(Vehiculos vehiculos);

    }

    public class UsuarioAutenticadoService : IUsuarioAutenticadoService
    {
        private readonly IJSRuntime jsRuntime;

        public UsuarioAutenticadoService(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        private Usuario _usuario;
        public Usuario Usuarios
        {
            get => _usuario;
            set
            {
                _usuario = value;
                GuardarUsuarioEnLocalStorageAsync(value);
            }
        }

        public async Task CargarUsuarioAsync()
        {
            var userJson = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "user");
            if (!string.IsNullOrEmpty(userJson))
            {
                _usuario = JsonSerializer.Deserialize<Usuario>(userJson);
            }
        }

        private async Task GuardarUsuarioEnLocalStorageAsync(Usuario usuario)
        {
            var userJson = JsonSerializer.Serialize(usuario);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "user", userJson);
        }

        public void AgregarVehiculosAlCarrito(Vehiculos vehiculos)
        {
            if (Usuarios != null)
            {
                Usuarios.Carrito.Vehiculos.Add(vehiculos);
                GuardarUsuarioEnLocalStorageAsync(Usuarios);
            }
        }

        public List<Vehiculos> ObtenerVehiculosDelCarrito()
        {
            return Usuarios?.Carrito?.Vehiculos ?? new List<Vehiculos>();
        }

        public void RemoverVehiculosDelCarrito(Vehiculos vehiculos)
        {
            if (Usuarios != null && vehiculos != null && Usuarios.Compras != null)
            {
                var compraAEliminar = Usuarios.Compras.FirstOrDefault(c => c.VehiculoId == vehiculos.VehiculoId);

                if (compraAEliminar != null)
                {
                    Usuarios.Compras.Remove(compraAEliminar);
                    GuardarUsuarioEnLocalStorageAsync(Usuarios);
                }
            }
        }
    }
}
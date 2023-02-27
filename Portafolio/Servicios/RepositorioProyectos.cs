using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();

    }
    public class RepositorioProyectos: IRepositorioProyectos
    {

        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://www.amazon.com.mx",
                ImagenURL = "/imagenes/amazon.png"
            },
                  new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://nytimes.com",
                ImagenURL = "/imagenes/nyt.png"
            },
                    new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "E-Commerce realizado en ASP.NET Core",
                Link = "https://reddit.com",
                ImagenURL = "/imagenes/reddit.png"
            },
                      new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Tienda en línea para comprar videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/steam.png"
            },
            };
        }
    }
}

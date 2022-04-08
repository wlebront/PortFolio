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
            return new List<Proyecto>() {
                new Proyecto

                {
                    Titulo = "Dominican Marketing Digital",
                    Descripcion = "Marketing Agency",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/dominican.png"
                },

                new Proyecto

                {
                    Titulo = "Ing.Federico Antún",
                    Descripcion = "Personal Website",
                    Link = "https://steam.com",
                    ImagenURL = "/imagenes/federico2.png"
                },

                new Proyecto

                {
                    Titulo = "Consultoria Politica",
                    Descripcion = "Political Agency",
                    Link = "https://nytimes.com",
                    ImagenURL = "/imagenes/politica.png"
                },

                   new Proyecto

                {
                    Titulo = "App Asamblea General",
                    Descripcion = "Control de Asistencia de La Secretaria de Tecnologia PRSC",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/asamblea.png"
                },

                   new Proyecto

                {
                    Titulo = "Web API Asambleista PRSC",
                    Descripcion = "API RESTful IN ASP.NET Core Web API",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/api.png"
                },

                   new Proyecto

                {
                    Titulo = "IFP",
                    Descripcion = "Instituto de Formacion Politica Joaquin Balaguer",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/ifp.png"
                },

                   new Proyecto

                {
                    Titulo = "Dashboard Asambleistas",
                    Descripcion = "Dashboard de administracion de la Secretaria de Tecnologia PRSC",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/PB.png"
                },
                   new Proyecto

                {
                    Titulo = "El Chipero.com",
                    Descripcion = "Digital News",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/CHIPERO.png"
                },

                   new Proyecto

                {
                    Titulo = "Medicina Casera",
                    Descripcion = "Website of Natural Medicine",
                    Link = "https://reddit.com",
                    ImagenURL = "/imagenes/medicina.png"
                },


                };
        }

    }
}

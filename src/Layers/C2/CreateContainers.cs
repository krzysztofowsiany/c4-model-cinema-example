using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using Structurizr;

namespace CinemaC4Model.Layers.C2 {
    internal class CreateContainers {
        protected CreateContainers(Model model)
        {
            var cinemaSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);
       
            ContainerExtensions.AddContainer(
                cinemaSoftwareSystem, 
                Containers.Database, 
                "Database for whole application", 
                "RDB",
                ContainerTags.Database);

            ContainerExtensions.AddContainer(
                cinemaSoftwareSystem, 
                Containers.Repertoire,
                "For management all repertoire operations.", 
                "Angular 8",
                ContainerTags.WebPage);

            ContainerExtensions.AddContainer(
                cinemaSoftwareSystem, 
                Containers.Customer,
                "For reservations seats and buy tickets by customers.", 
                ".NET Core 5.0 - Razor Page",
                ContainerTags.WebPage);

            ContainerExtensions.AddContainer(
                cinemaSoftwareSystem, 
                Containers.Terminal,
                "For serve customers offline in cinema.", 
                ".NET Framework 4.0 - Windows Forms",
                ContainerTags.WindowsApplication);

            ContainerExtensions.AddContainer(
                cinemaSoftwareSystem, 
                Containers.API,
                "REST endpoint for all web pages.", 
                ".NET Core 5.0 WebApi",
                ContainerTags.RESTAPI);
        }

        static public void Create(Model model){
            new CreateContainers(model);
        }
    }
}
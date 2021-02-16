using Structurizr;

namespace CinemaC4Model.Extensions {
    static public class ContainerExtensions {
        static public Container AddTagsToContainer(this Container container, params string[] tags) {
            container.AddTags(tags);
            return container;
        }

        static public Container AddContainer(this SoftwareSystem softwareSystem, string name, string description, string technology, params string[] tags) {
            return softwareSystem
                .AddContainer(name, description, technology)
                .AddTagsToContainer(tags);
        }
    }
}
using Structurizr;

namespace CinemaC4Model.Extensions
{
    static public class SoftwareSystemExtensions
    {
        static public SoftwareSystem AddTagsToSoftwareSystem(this SoftwareSystem softwareSystem, params string[] tags){
            softwareSystem.AddTags(tags);
            return softwareSystem;
        }

          static public SoftwareSystem CreateSystem(this Model model, string name, string description, params string[] tags) {
            return model
                .AddSoftwareSystem(name, description)
                .AddTagsToSoftwareSystem(tags);
        }
    }
}
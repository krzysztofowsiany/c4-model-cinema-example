using Structurizr;

namespace CinemaC4Model.Extensions
{
    static public class SoftwareSystemExtensions
    {
        static public SoftwareSystem AddTagsToSoftwareSystem(this SoftwareSystem softwareSystem, params string[] tags){
            softwareSystem.AddTags(tags);
            return softwareSystem;
        }
    }
}
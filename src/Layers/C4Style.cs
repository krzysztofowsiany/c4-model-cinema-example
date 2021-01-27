using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using Structurizr;

namespace CinemaC4Model.Layers {
    public class C4Style {

        internal void CreateStyle(Workspace workspace) {
            var styles = workspace.Views.Configuration.Styles;

            styles.Add(new ElementStyle(Tags.SoftwareSystem) {
                Color = "#000000"
            });

            styles.Add(new ElementStyle(SoftwareSystemTags.ExternalSystemTag) {
                Background = "#e7a2c4",
                    Shape = Shape.Box,
                    FontSize = 26
            });

            styles.Add(new ElementStyle(SoftwareSystemTags.CinemaSystemTag) {
                Background = "#f89e41",
                    Shape = Shape.WebBrowser,
                    FontSize = 40,
                    Width = 600,
                    Height = 400
            });

            styles.Add(new ElementStyle(Tags.Person) {
                Background = "#fefab7",
                    Color = "#000000",
                    Shape = Shape.Person,
                    FontSize = 34
            });

            styles.Add(new ElementStyle(Tags.Container) { Background = "#438dd5", Color = "#ffffff" });
            styles.Add(new ElementStyle(Tags.Component) { Background = "#85bbf0", Color = "#000000" });
        }

    }
}
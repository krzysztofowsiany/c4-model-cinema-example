using System;
using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using Structurizr;

namespace CinemaC4Model.Layers {
    public class C4Style {

        internal void CreateStyle(Workspace workspace) {
            var styles = workspace.Views.Configuration.Styles;

            SoftwareSystemsStylize(styles);
            ContainersStylize(styles);
        }

        private void ContainersStylize(Styles styles)
        {
            styles.Add(new ElementStyle(Tags.Container) {
                Color = "#000000"
            });

            styles.Add(new ElementStyle(ContainerTags.Database) {
                Background = "#A8A8A8",
                    Color = "#000000",
                    Shape = Shape.Cylinder,
                    FontSize = 34
            });

            styles.Add(new ElementStyle(ContainerTags.WebPage) {
                Background = "#f89e41",
                    Color = "#000000",
                    Shape = Shape.WebBrowser,
                    FontSize = 30
            });

            styles.Add(new ElementStyle(ContainerTags.WindowsApplication) {
                Background = "#2E7AFF",
                    Color = "#000000",
                    Shape = Shape.Component,
                    FontSize = 30
            });

            styles.Add(new ElementStyle(ContainerTags.RESTAPI) {
                Background = "#f89e41",
                    Color = "#000000",
                    Shape = Shape.Hexagon,
                    FontSize = 34,
                    Width = 500,
                    Height = 500
            });

            styles.Add(new RelationshipStyle(RelationshipTags.Internal) {
                Color = "#005DFF",
                FontSize = 34,
                Thickness = 5,
                Dashed = false
            });
        }

        private void SoftwareSystemsStylize(Styles styles)
        {
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

            styles.Add(new RelationshipStyle(Tags.Relationship) {
                Color = "#ff0000",
                FontSize = 34
            });
        }
    }
}
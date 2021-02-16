using System;
using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C2 {
    internal class LayerView {
        private LayerView(Workspace workspace) {
            var cinemaSoftwareSystem = workspace.Model
                .GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);

            var contextView = workspace.Views
                .CreateContainerView(
                    cinemaSoftwareSystem,
                    "Cinema System Containers",
                    "An example of a Containers diagram for Cinema.");

            contextView.PaperSize = PaperSize.A4_Landscape;
            contextView.EnableAutomaticLayout(RankDirection.TopBottom, 300, 100, 150, true);
            contextView.AddAllSoftwareSystems();
            contextView.AddAllContainers();
            contextView.AddAllPeople();
        }

        internal static void Create(Workspace workspace) {
            new LayerView(workspace);
         }
    }
}
using System;
using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C1 {
    internal class LayerView {
        private LayerView(Workspace workspace) {
            var cinemaSoftwareSystem = workspace.Model
                .GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);

            var contextView = workspace.Views
                .CreateSystemContextView(
                    cinemaSoftwareSystem,
                    "System Context",
                    "An example of a System Context diagram for Cinema.");

            contextView.PaperSize = PaperSize.A5_Portrait;
            contextView.EnableAutomaticLayout(RankDirection.RightLeft, 300, 100, 150, true);
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();
        }

        internal static void Create(Workspace workspace) {
            new LayerView(workspace);
         }
    }
}
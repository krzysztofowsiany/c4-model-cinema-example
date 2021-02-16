using Structurizr;

namespace CinemaC4Model.Layers.C2 {
    public class ContainerLayer {
        internal void AddLayerToModel(Workspace workspace) {
            CreateContainers.Create(workspace.Model);
            LayerRelations.Create(workspace.Model);
            LayerView.Create(workspace);
        }
    }
}
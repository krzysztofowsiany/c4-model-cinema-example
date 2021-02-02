using Structurizr;

namespace CinemaC4Model.Layers.C2 {
    public class ContainerLayer {
        internal void AddLayerToModel(Workspace workspace) {
            CreatePersons.Create(workspace.Model);
            CreateSystems.Create(workspace.Model);
            LayerRelations.Create(workspace.Model);
            LayerView.Create(workspace);
        }
    }
}
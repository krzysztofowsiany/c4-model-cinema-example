using Structurizr;

namespace CinemaC4Model.Layers.C1 {
    public class SystemContextLayer {
        internal void AddLayerToModel(Workspace workspace) {
            CreatePersons.Create(workspace.Model);
            CreateSystems.Create(workspace.Model);
            LayerRelations.Create(workspace.Model);
            LayerView.Create(workspace);
        }
    }
}
using CinemaC4Model.Config;
using Structurizr;
using Structurizr.Api;

namespace CinemaC4Model.Layers {
    public class C4Uploader {
        public void UploadWorkspaceToStructurizr(Workspace workspace, StructurizerOptions structurizerOptions) {
            var structurizrClient = new StructurizrClient(
                structurizerOptions.ApiKey,
                structurizerOptions.ApiSecret);
            
            structurizrClient.PutWorkspace(structurizerOptions.WorkspaceId, workspace);
        }
    }
}
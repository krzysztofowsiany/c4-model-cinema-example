using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using CinemaC4Model.Config;
using Structurizr;
using Structurizr.Api;
using Structurizr.Documentation;

namespace CinemaC4Model.Layers {
    public class C4Uploader {
        public  void UploadWorkspaceToStructurizr(Workspace workspace, StructurizerOptions structurizerOptions) {
            var structurizrClient = new StructurizrClient(
                structurizerOptions.ApiKey,
                structurizerOptions.ApiSecret);
            
            structurizrClient.PutWorkspace(structurizerOptions.WorkspaceId, workspace);
        }
    }
}
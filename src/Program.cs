using System;
using CinemaC4Model.Config;
using CinemaC4Model.Layers.C1;
using CinemaC4Model.Layers;
using Microsoft.Extensions.Configuration;
using Structurizr;
using CinemaC4Model.Layers.C2;

namespace CinemaC4Model {
    class Program {
        static void Main(string[] args) {
            var appConfig = LoadConfiguration();
            var systemContextLayer = new SystemContextLayer();
            var containerLayer = new ContainerLayer();
            var c4Style = new C4Style();
            var c4Uploader = new C4Uploader();

            //https://structurizr.com/workspace/62359
            var workspace = new Workspace("Cinema System", "This is a model of Cinema software system.");
            systemContextLayer.AddLayerToModel(workspace);
            containerLayer.AddLayerToModel(workspace);
            
            c4Style.CreateStyle(workspace);
            c4Uploader.UploadWorkspaceToStructurizr(workspace, appConfig.Structurizer);
        }

        private static AppConfig LoadConfiguration() =>
            new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .AddEnvironmentVariables()
            .Build()
            .Get<AppConfig>();
    }
}
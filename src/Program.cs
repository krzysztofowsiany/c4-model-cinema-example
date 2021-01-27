using System;
using CinemaC4Model.Config;
using CinemaC4Model.Enums;
using CinemaC4Model.Layers.C1;
using CinemaC4Model.Layers;
using Microsoft.Extensions.Configuration;
using Structurizr;

namespace CinemaC4Model {
    class Program {
        static void Main(string[] args) {
            var appConfig = LoadConfiguration();
            var systemContextLayer = new SystemContextLayer();
            var c4Style = new C4Style();
            var c4Uploader = new C4Uploader();

            //https://structurizr.com/workspace/62359
            var workspace = new Workspace("Cinema System", "This is a model of Cinema software system.");
            systemContextLayer.AddLayeToModel(workspace);
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
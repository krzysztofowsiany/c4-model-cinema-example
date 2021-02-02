using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using Structurizr;

namespace CinemaC4Model.Layers.C1 {
    internal class CreateSystems {
        protected CreateSystems(Model model)
        {
            model.CreateSystem(SoftwareSystems.CinemaSystem, "Cinema software system.", SoftwareSystemTags.CinemaSystemTag);
            model.CreateSystem(SoftwareSystems.GutekSystem, "Movie Database System.", SoftwareSystemTags.ExternalSystemTag);
            model.CreateSystem(SoftwareSystems.MailSystem, "System to sending e-mails.", SoftwareSystemTags.ExternalSystemTag);
            model.CreateSystem(SoftwareSystems.PaymentSystem, "Payment System.", SoftwareSystemTags.ExternalSystemTag);
            model.CreateSystem(SoftwareSystems.CardSystem, "Card Terminal System.", SoftwareSystemTags.ExternalSystemTag);
            model.CreateSystem(SoftwareSystems.PrinterSystem, "Printer System to print.", SoftwareSystemTags.ExternalSystemTag);
        }

        static public void Create(Model model){
            new CreateSystems(model);
        }
    }
}
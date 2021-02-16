using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C2 {
    internal class LayerRelations {
        private LayerRelations(Model model) {
            var cinemaSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);
            var cardProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.CardSystem);
            var paymentProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.PaymentSystem);
            var mailProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.MailSystem);
            var gutekMovieSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.GutekSystem);
            var printerSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.PrinterSystem);

            var employeePerson = model.GetPersonWithName(Persons.Employee);
            var customerPerson = model.GetPersonWithName(Persons.Customer);

            var repertoire = cinemaSoftwareSystem.GetContainerWithName(Containers.Repertoire);
            var database = cinemaSoftwareSystem.GetContainerWithName(Containers.Database);
            var customer = cinemaSoftwareSystem.GetContainerWithName(Containers.Customer);
            var api = cinemaSoftwareSystem.GetContainerWithName(Containers.API);
            var terminal = cinemaSoftwareSystem.GetContainerWithName(Containers.Terminal);

            api.Uses(database, "Uses", "ORM/JDBC").AddTags(RelationshipTags.Internal);
            
            employeePerson.Uses(repertoire, "Management the repertoire", "HTTPS");
            employeePerson.Uses(terminal, "Reserve and sell tickets to customer", "Touch Screen");
            customerPerson.Uses(customer, "Reserve and buy tickets");
      
            api.Uses(gutekMovieSoftwareSystem, "Get movie list", "HTTP");
            api.Uses(mailProviderSoftwareSystem, "Sends e-mails to customers", "SMTP");            
            terminal.Uses(printerSoftwareSystem, "Printing ticket", "System Driver");
            terminal.Uses(cardProviderSoftwareSystem, "Handle payment request", "HTTPS");            
            
            customer.Uses(api, "Uses", "HTTPS/REST").AddTags(RelationshipTags.Internal);
            repertoire.Uses(api, "Uses", "HTTPS/REST").AddTags(RelationshipTags.Internal);
            terminal.Uses(api, "Uses", "HTTPS/REST").AddTags(RelationshipTags.Internal);
        }

        internal static void Create(Model model) {
            new LayerRelations(model);
        }
    }
}
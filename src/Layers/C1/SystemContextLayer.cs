using CinemaC4Model.Enums;
using CinemaC4Model.Extensions;
using Structurizr;

namespace CinemaC4Model.Layers.C1 {
    public class SystemContextLayer {
        private Model _model;

        internal void AddLayeToModel(Workspace workspace) {
            _model = workspace.Model;
            AddSystems();
            AddPersons();
            SetRelations();
            CreateContextView(workspace.Views);
        }

        private void SetRelations() {
            var cinemaSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);
            var cardProviderSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.CardSystem);
            var paymentProviderSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.PaymentSystem);
            var mailProviderSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.MailSystem);
            var gutekMovieSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.GutekSystem);
            var printerSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.PrinterSystem);
            var employeePerson = _model.GetPersonWithName(Persons.Employee);
            var customerPerson = _model.GetPersonWithName(Persons.Customer);

            employeePerson.Uses(cinemaSoftwareSystem, "Sell ticket and make repertoire", "HTTPS");
            employeePerson.Uses(cinemaSoftwareSystem, "Sell ticket and make repertoire", "HTTPS");

            customerPerson.Uses(cinemaSoftwareSystem, "Reserving seat in cinema", "HTTPS");
            customerPerson.Uses(cardProviderSoftwareSystem, "Pay by card", "Terminal");
            customerPerson.Uses(paymentProviderSoftwareSystem, "Pay over internet", "HTTPS");
            customerPerson.InteractsWith(employeePerson, "Reserving ticket", "Talk");
            mailProviderSoftwareSystem.Delivers(customerPerson, "Sends e-mails to", "SMTP");

            cinemaSoftwareSystem.Uses(mailProviderSoftwareSystem, "Sends e-mails", "SMTP");
            cinemaSoftwareSystem.Uses(gutekMovieSoftwareSystem, "Get movie list", "HTTPS");
            cinemaSoftwareSystem.Uses(printerSoftwareSystem, "Print ticket", "Driver");
        }

        private void CreateContextView(ViewSet views) {
            var cinemaSoftwareSystem = _model.GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);

            var contextView = views.CreateSystemContextView(
                cinemaSoftwareSystem,
                "System Context",
                "An example of a System Context diagram for Cinema.");

            contextView.EnableAutomaticLayout(RankDirection.RightLeft, 300, 50, 150, true);
            contextView.AddAllSoftwareSystems();
            contextView.AddAllPeople();
        }

        private void AddSystems() {
            AddSystem(SoftwareSystems.CinemaSystem, "Cinema software system.", SoftwareSystemTags.CinemaSystemTag);
            AddSystem(SoftwareSystems.GutekSystem, "Movie Database System.", SoftwareSystemTags.ExternalSystemTag);
            AddSystem(SoftwareSystems.MailSystem, "System to sending e-mails.", SoftwareSystemTags.ExternalSystemTag);
            AddSystem(SoftwareSystems.PaymentSystem, "Payment System.", SoftwareSystemTags.ExternalSystemTag);
            AddSystem(SoftwareSystems.CardSystem, "Card Terminal Provider System.", SoftwareSystemTags.ExternalSystemTag);
            AddSystem(SoftwareSystems.PrinterSystem, "Printer System to print.", SoftwareSystemTags.ExternalSystemTag);
        }

        private void AddSystem(string name, string description, params string[] tags) {
            _model
                .AddSoftwareSystem(name, description)
                .AddTagsToSoftwareSystem(tags);
        }

        private void AddPersons() {
            _model.AddPerson(Persons.Employee, "A employee in Cinema.");
            _model.AddPerson(Persons.Customer, "A customer of Cinema.");
        }
    }
}
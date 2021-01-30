using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C1
{
    internal class LayerRelations
    {
        private LayerRelations(Model model)
        {
            var cinemaSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.CinemaSystem);
            var cardProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.CardSystem);
            var paymentProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.PaymentSystem);
            var mailProviderSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.MailSystem);
            var gutekMovieSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.GutekSystem);
            var printerSoftwareSystem = model.GetSoftwareSystemWithName(SoftwareSystems.PrinterSystem);
            var employeePerson = model.GetPersonWithName(Persons.Employee);
            var customerPerson = model.GetPersonWithName(Persons.Customer);

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

        internal static void Create(Model model)
        {
            new LayerRelations(model);
        }
    }
}
using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C2
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

            employeePerson.Uses(cinemaSoftwareSystem, "Sell ticket and make repertoire");
            employeePerson.Uses(cinemaSoftwareSystem, "Sell ticket and make repertoire");

            customerPerson.Uses(cinemaSoftwareSystem, "Reserving seat in cinema");
            customerPerson.Uses(cardProviderSoftwareSystem, "Pay by card");
            customerPerson.Uses(paymentProviderSoftwareSystem, "Pay over internet");
            customerPerson.InteractsWith(employeePerson, "Reserving ticket");
            mailProviderSoftwareSystem.Delivers(customerPerson, "Sends e-mails to");

            cinemaSoftwareSystem.Uses(mailProviderSoftwareSystem, "Sends e-mails");
            cinemaSoftwareSystem.Uses(gutekMovieSoftwareSystem, "Get movie list");
            cinemaSoftwareSystem.Uses(printerSoftwareSystem, "Print ticket");
        }

        internal static void Create(Model model)
        {
            new LayerRelations(model);
        }
    }
}
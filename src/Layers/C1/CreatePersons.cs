using CinemaC4Model.Enums;
using Structurizr;

namespace CinemaC4Model.Layers.C1
{
    internal class CreatePersons
    {
        private CreatePersons(Model model)
        {
            model.AddPerson(Persons.Employee, "A employee in Cinema.");
            model.AddPerson(Persons.Customer, "A customer of Cinema.");
        }

        static public void Create(Model model){
            new CreatePersons(model);
        }
    }
}
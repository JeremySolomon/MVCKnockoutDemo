using System;
namespace MVCKnockoutDemo.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // NOTE: For demonstration purpose included both Id as well as strong reference. In real projects, we need to use either of one (Id is preferred in case of performance).
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
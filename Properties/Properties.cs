namespace play_csharp.Properties
{
    using System;
    public class Properties
    {
        private string _lastName;

        public Properties(string firstName, string lastName)
        {
            this.FirstName = firstName;
            _lastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName => _lastName;

        public string FullName { get => $"{FirstName} {LastName}"; }

        public Guid Identifier { get; init; } = Guid.NewGuid();
    }
}
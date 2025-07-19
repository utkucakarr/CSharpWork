namespace Classes
{
    class Customer
    {
        //This is a field.
        private string _firstName;

        //This is a property.
        public int Id { get; set; }

        //This is a encapsulation.
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName { get; set; }

        public string City { get; set; }
    }
}

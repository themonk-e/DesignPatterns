namespace designPattern.Builder
{
    public class User
    {
        public string? FirstName { get; private set; }
        public string? LastName { get;private set; }

        public string? Email { get; private set; }

        public string? Phone { get;private set; }

        public string? Address { get;private set; }

        public int Age { get;private set; }


        public class UserBuilder
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }

            public string? Email { get; set; }

            public string? Phone { get; set; }

            public string? Address { get; set; }

            public int Age { get; set; }

            public UserBuilder(string firstName, string lastName)
            {

                FirstName = firstName;
                LastName = lastName;
            }

            public UserBuilder WithEmail(string email)
            {
                Email = email;
                return this;
            }

            public UserBuilder WithPhone(string phone)
            {
                Phone = phone;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                Address = address;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                Age = age;
                return this;
            }

            public User Build()
            {
                return new User()
                {
                    FirstName = this.FirstName,
                    LastName = this.LastName,
                    Email = this.Email,
                    Address = this.Address,
                    Phone = this.Phone,
                    Age = this.Age
                };
            }
                        
        }

    }
}
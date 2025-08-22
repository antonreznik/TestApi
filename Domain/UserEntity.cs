namespace Domain
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string Email { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        private UserEntity(string firstName, string lastName, string email, int age)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
        }

        public static UserEntity CreateUser(string firstName, string lastName, string email, int age)
        {
            return new UserEntity(firstName, lastName, email, age);
        }

        public void Update(string firstName, string lastName, string email, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Age = age;
        }
    }
}

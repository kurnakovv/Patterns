namespace ChainOfResponsibility.DTO
{
    public class User
    {
        public User(string name, string question)
        {
            Name = name;
            Question = question;
        }

        public string Name { get; private set; }
        public string Question { get; private set; }
    }
}

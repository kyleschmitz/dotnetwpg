namespace OnlineStore
{
    public abstract class User
    {
        public string FullName { get; }
        public string Username { get; }
        public string Password { get; }

        public User(string fullName, string username, string password)
        {
            FullName = fullName;
            Username = username;
            Password = password;
        }

        public bool IsPasswordCorrect(string passwordAttempt)
        {
            return Password == passwordAttempt;
        }

        public abstract decimal GetCostOfAccount();

        public override string ToString()
        {
            return $"{Username} - {FullName}";
        }
    }
}
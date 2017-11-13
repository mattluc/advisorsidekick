namespace Advisor_Sidekick_V2
{
    internal class User
    {
        public User()
        {
        }

        public User(string username1, string password1, string firstName1, string lastName1, string address1,
            string phoneNumber1,
            string highSchool1, string email1)
        {
            username = username1;
            password = password1;
            firstName = firstName1;
            lastName = lastName1;
            address = address1;
            phoneNumber = phoneNumber1;
            highSchool = highSchool1;
            email = email1;
        }

        public string username { get; }
        public string password { get; }
        public string firstName { get; }
        public string lastName { get; }
        public string address { get; }
        public string phoneNumber { get; }
        public string highSchool { get; }
        public string email { get; }
    }
}
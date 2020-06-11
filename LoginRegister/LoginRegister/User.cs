using System;

namespace LoginRegister
{
    [Serializable]
    public class User
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }

        public User() { }
    }
}

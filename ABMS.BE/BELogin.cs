
namespace ABMS.BE
{
   public class BELogin
    {
        private string userId;
        private string password;

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
    }
}

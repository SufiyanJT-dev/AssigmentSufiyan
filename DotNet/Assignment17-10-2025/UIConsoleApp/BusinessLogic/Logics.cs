using  DataAccess;

namespace BusinessLogic
{
    public class Logics
    {
        public Logics()
        {
            UserData userData = new UserData();
            Console.WriteLine("Name ID before Asseceing :" + userData.NameId );
            userData.NameId = 10;
            Console.WriteLine("After: " + userData.NameId);
        }
    }
}

namespace Membership;
public class Authentication
{
    public static bool Validation(string email, string password)
    {
        bool status = false;
        if (email == "rushabhgunjalrg17@gmail.com" && password == "12345")
        {
            Console.WriteLine("Logged In Successfull....");
            status = true;
            return status;
        }
        return status;
    }

    public static bool Registration(string firstname, string lastname, string email, string contactnumber, string location)
    {
        bool status = false;

        try
        {
            User theUser = new User();
            theUser.Firstname = firstname;
            theUser.Lastname = lastname;
            theUser.Email = email;
            theUser.ContactNo = contactnumber;
            theUser.Location = location;
            status = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return status;

    }
}
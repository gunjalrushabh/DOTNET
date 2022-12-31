namespace Membership;
public static class Authentication
{

public static bool validate( string mail,string password)
{
    bool status=false;
    if(mail=="r@gmail.com"&&password=="12345")
    {
        Console.WriteLine("heloow brother welcome.....");
    status=true;
    }
    return status;
}



}

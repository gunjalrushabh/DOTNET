namespace BOL;
public class Product
{
    public int Pid { get; set; }
    public string Pname { get; set; }

    public Product()
    {
        this.Pid = 1000;
        this.Pname = "default";
    }
    public Product(int pid, string pname)
    {
        this.Pid = pid;
        this.Pname = pname;
    }


}
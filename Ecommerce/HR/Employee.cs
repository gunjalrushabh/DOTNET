namespace HR;
public abstract class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }
    public DateTime BirthDate { get; set; }
    public double DailyAllowance { get; set; }
    public double HRA { get; set; }
    public double BasicSalary { get; set; }
    public string ContactNumber { get; set; }

    public Employee(string firstName, string lastName, string email, 
    string location, DateTime birthDate, double dailyAllowance, 
    double hRA, double basicSalary, string contactNumber){
    this.FirstName=firstName;
    this.LastName=lastName;
    this.Email=email;
    this.Location=location;
    this.BirthDate=birthDate;
    this.DailyAllowance=dailyAllowance;
    this.HRA=hRA;
    this.BasicSalary=basicSalary;
    this.ContactNumber=contactNumber;

}

 public Employee():this("Ravi", "Tambade", "ravi.tambade@transflower.in",
                           "Pune", new DateTime(1975, 8,18),1000,10000,15000, "9881735801"){
        
    }

    public override string ToString()
    {
        // return base.ToString();
        string str= string.Format("{0} ,{1} ,{2} ,{3} ,{4} ,{5} ,{6} ,{7}, {8}",FirstName,LastName,Email,Location,BirthDate,DailyAllowance,HRA,BasicSalary,ContactNumber);
         return str;
    }

public virtual double ComputSalary()
{
    double pay=DailyAllowance*25 +BasicSalary+HRA;
    return pay;
}

public abstract void DoWork();

}


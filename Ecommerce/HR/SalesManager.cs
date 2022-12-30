namespace HR;
public class SalesManager : SalesEmployee
{
    public SalesManager() : base()
    {
        Bonus=0;
    }
    public double Bonus { get; set; }

    public SalesManager(string firstName, string lastName, string email, string location, DateTime birthDate, double dailyAllowance, double
    hRA, double basicSalary, string contactNumber, double target, double salesDone, double incentive,double bonus) : base(firstName, lastName, email, location, birthDate, dailyAllowance,
    hRA, basicSalary, contactNumber, target, salesDone, incentive)
    {
        this.Bonus = bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override double ComputSalary()
    {
        return  base.ComputSalary() + this.Bonus;
        
    }

    public override string ToString()
    {
        return base.ToString() + "Bonus : " + Bonus;
    }
}

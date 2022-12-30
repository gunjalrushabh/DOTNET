namespace HR;
public class SalesEmployee : Employee
{
    public double Target { get; set; }
    public double SalesDAone { get; set; }
    public double Incentive { get; set; }

    public SalesEmployee():base()
    
    {
        this.Target = 0;
        this.SalesDAone = 0;
        this.Incentive = 0;
    }

    public SalesEmployee(string firstName, string lastName, string email, string location, DateTime birthDate, double dailyAllowance, double hRA, double basicSalary, string contactNumber, double salesDone, double target, double incentive ) : base(firstName, lastName, email, location, birthDate, dailyAllowance, hRA, basicSalary, contactNumber)
    {
        this.SalesDAone = salesDone;
        this.Target = target;
        this.Incentive=incentive;
    }

    public override void DoWork()
    {
        // (SalesDAone >= Target) ? (this.Incentive = 10000 ): (this.Incentive = 0);
        //return base.ComputSalary();
        if(SalesDAone>=Target){
            this.Incentive=6000;

        }
        else{
            this.Incentive=0;
        }
    }
    public override double ComputSalary()
    {
        double salary = base.ComputSalary() + this.Incentive;

        return salary;
    }

    public override string ToString()
    {
        return base.ToString()+ " ,Target: "+Target+" ,incentive: "+Incentive;    }
}
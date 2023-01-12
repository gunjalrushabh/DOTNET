namespace User;

public class Student{
    public int RollNo{get; set;}
    public string FullName{get; set;}
    public string MotherName{get;set;}
    public string FatherName{get; set;}
    public DateOnly DOB{get; set;}
    public string Gender{get; set;}
    public string Adress{get; set;}
    public string State{get; set;}
    public int PinCode{get; set;}
    public string Course{get; set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public Student(int rollno, string fullName, string motherName, string fatherName, DateOnly dob, 
    string gender, string address, string state, int pincode, string course, string email,string password){
        this.RollNo=rollno;
        this.FullName=fullName;
        this.MotherName=motherName;
        this.FatherName=fatherName;
        this.DOB=dob;
        this.Gender=gender;
        this.Adress=address;
        this.State=state;
        this.PinCode=pincode;
        this.Course=course;
        this.Email=email;
        this.Password=password;

    } 
}
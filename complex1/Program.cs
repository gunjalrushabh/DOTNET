using Maths;
Complex c1= new Complex(10,20);
c1.Real=30;//setter
c1.Imag=40;
Console.WriteLine(c1.Real);//getter
Complex c2= new Complex(20,30);
Complex c3=c1+c2;//(30,40),,,,(20,30)
Console.WriteLine("ADDITION Complex c3 real: "+c3.Real+" imag: "+c3.Imag);//50,70
Complex c4=c1-c2;
Console.WriteLine("SUBTRACTION Complex c4 real: "+c4.Real+ " imag: "+c4.Imag);
Complex c5=c1 * c2;
Console.WriteLine("Multiplication: "+c5.Real+" + i"+c5.Imag);
Complex c6=c1/c2;
Console.WriteLine("Divide: "+c6.Real+"  "+c6.Imag);
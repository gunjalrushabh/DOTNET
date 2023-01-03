namespace Catalog;
using System.ComponentModel.DataAnnotations;
//POCO class 
[Serializable] //attribute
public class Product
{
  [Required] //mandetory
public int Id{get;set;}
public string Title{get;set;}
public string Desc{get;set;}
public string Price{get;set;}

public Product() //constructor
{
    this.Id=100;
    this.Title="Default Product";
    this.Desc="Default desc";
    this.Price="100";
}

public Product(int id,string title,string desc,string price)
{
    this.Id=id;
    this.Title=title;
    this.Desc=desc;
    this.Price=price;
}

public Product(int pid)
{
  this.Id=pid;
}

    // public override bool Equals(object obj)
    // {
    //     return this.Id.Equals((Product)obj.id);
    // }
}

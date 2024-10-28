//Encapsulation (private variable accessing with public method)

using System;
public class person{
   private string name;
   private string age;
   
   public void getInfo(string name,string age){
       this.name=name;
       this.age=age;
   }
   public void display (){
     Console.WriteLine($"Name:{name}");
     Console.WriteLine($"Age:{age}");
     
   }
 
}
public class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter your name & age:");
        string n=Console.ReadLine();
        string a=Console.ReadLine();
         person p1=new person();
         p1.getInfo(n,a);
         p1.display();
         
    }
}

namespace TCB651.Models;

public class Person
{
   public string id;
   public required string Address;
   public required string School;


   public void Create(){
     System.Console.WriteLine("id= ");
     id = Console.ReadLine();
    System.Console.WriteLine("Address= ");
     Address = Console.ReadLine();
     System.Console.WriteLine("School= ");
     Address = Console.ReadLine();
   }
    public string Read(string idPs){
     if(id == idPs){
        
     }
   }
    public void Update(int idPs){
    
   }

    public void Delete(){
     
   }

}
public class StringProcessTCB651(string cau4){
    public string cau4; 
    public string LowerToUpper(){
        string result=cau4.ToUpper();
        return result;
    }
    
}

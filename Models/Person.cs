namespace TCB651.Models;

// public class Person
{
   public int id;
   public required string Address;
   public required string School;

   public void EnterData() {
     System.Console.WriteLine("Address= ");
     Address = Console.ReadLine();
     System.Console.WriteLine("School= ");
     Address = Console.ReadLine();
   }


   public void Create(){
         
   }
    public void Read(int id){
     if(){

     }
   }
    public void Update(int id){
    
   }

    public void Delete(int id){
      
   }

}
public class StringProcessTCB651(string cau4){
    public string cau4; 
    public string LowerToUpper(){
        string result=cau4.ToUpper();
        return result;
    }
    
}

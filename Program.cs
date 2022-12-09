using System;

class Program
{
    
    
    static void Main()
    {
        
        
        Stack<string> stack = new Stack<string>(); 
        string input;
        int inputint;
        
        input = Console.ReadLine();
        
        
        
        
        stack.Push(input);

        
        if(input == ")")

        {
            
            
            Main();

            

            
            
            
        }

        else if(input == "(")
        {
            
            Main();

           

            


            
            

        }
        else
        {
            
        }
        

        
    
    }
    
       
}

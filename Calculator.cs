using System;

public static class Calculator
{
    public static double? Calculate(int num1, int num2, string operation)
    {
        // calculate method 
       switch(operation){
              //add
              case "+":
                    return = num1 + num2; 
                break;
                
              //subtract
              case "-":
                    return = num1 - num2;
                break;
                
              //multiply
              case "*":
                    return = num1 * num2;
                break;
                
              //divide
              case "/":
                if(num2 == 0){  
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                
                else{
                    return(double) num1 / num2;
                }
                break;
                
              //modulo
                case "%":
                if(num2 == 0){  
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                else{
                    return = num1 % num2;
                }
                break;
                
              //exit     
              case "=":
                    Environment.Exit(0);
                    return 0;
                break;
            default:
                Console.WriteLine("Invalid Operarion Used, Please Try againn");
                return null;
    }
}


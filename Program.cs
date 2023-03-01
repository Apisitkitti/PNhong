using System;
class Program
{
    static void Main()
    {
        bool Check1 = false ,Check2 = false,Check3 = false;
        int passwordCheck1,passwordCheck2,passwordCheck3;
        Console.Write("Password: ");
        int password = int.Parse(Console.ReadLine());
        Console.Write("Role: ");
        string role = Console.ReadLine();
        if(role == "CIA")
        {
            passwordCheck1 = password%10000;
            passwordCheck1 = passwordCheck1/1000;
            passwordCheck2 = password%100;
            passwordCheck2 = passwordCheck2/10;
            passwordCheck3 = password%10;
            if(passwordCheck3 %3 == 0)
            {
                Check1 = true;
            }
            if(passwordCheck2 != 1 && passwordCheck2 != 3 && passwordCheck2 !=5 )
            {
                Check2 = true;
            }
            if(passwordCheck1 >= 6 && passwordCheck1 != 8)
            {
                Check3 = true;
            }
            if(Check1 && Check2 && Check3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
        if(role == "FBI")
        {
           
            passwordCheck1 = password/100000;
            passwordCheck2 = password%1000;
            passwordCheck2 = passwordCheck2/100;
            passwordCheck3 = password%100000;
            passwordCheck3 = passwordCheck3/10000;
             if(passwordCheck3 %2 != 0)
            {
                Check1 = true;
            }
            if(passwordCheck2 % 2 == 0 && passwordCheck2 !=6 )
            {
                Check2 = true;
            }
            if(passwordCheck1 >= 4 && passwordCheck1 <=7 )
            {
                Check3 = true;
            }
            if(Check1 && Check2 && Check3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        if(role == "NSA")
        {
            passwordCheck1 = password%10;
            passwordCheck2 = password%1000;
            passwordCheck2 = passwordCheck2/100;
            Console.WriteLine("{0} {1}", passwordCheck1,passwordCheck2);
            for(int i = 0 ;i<5; i++ )
            {
                passwordCheck3 = password % (1000000/(int)Math.Pow(10,i+1));
                passwordCheck3 = passwordCheck3/(100000/(int)Math.Pow(10,i+1));
             
                if(passwordCheck3 == 7)
             {
                Check3 =true;
                break;
             }

            }
            if(passwordCheck2 % 2 != 0 && passwordCheck2 %3 == 0 )
            {
                Check2 = true;
            }
            if(passwordCheck1 == 1 || passwordCheck1 == 2 || passwordCheck1 == 3 || passwordCheck1 == 5 || passwordCheck1 == 6 )
            {
                Check1 = true;
            }
            if(Check1 && Check2 && Check3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }    
}
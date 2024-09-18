using System.Security.Cryptography;

int answer;
string strAnswer;
double answerd;
ChooseOpg();
void ChooseOpg()
{
    Console.WriteLine("\nIndtast opg nr. \n1: Simple Age Checker\n2: Odd or Even Checker\n3: Simple Login System\n4: Temperature Converter\n5: Leap Tear Checker\n6: Number Guessing Game");
    try
    {
        answer = Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("indtast opg nr. EKS ''1''");
        ChooseOpg();
    }
    if (answer == 1)
    {
        opg1();
    }
    else if (answer == 2)
    {
        opg2();
    }
    else if (answer == 3)
    {
        opg3();
    }
    else if(answer == 4)
    {
        opg4();
    }
    else if(answer == 5)
    {
        opg5();
    }
    else if( answer == 6)
    {
        opg6();
    }
    else
    {
        Console.WriteLine("indtast et opgave tal 1-6");
        ChooseOpg();
    }
    void opg1()
    {
        Console.WriteLine("opgave 1: Simple Age Checker\n\nInput your age:");
        try
        { 
        answer = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\nInput Error!\n");
            opg1();
        }
        if (answer < 18) 
        {
            Console.WriteLine("You are not an adult");
            ChooseOpg();
        }
        else
        {
            Console.WriteLine("You are an adult");
            ChooseOpg();
        }


        
    }
    void opg2()
    {
        Console.WriteLine("Opgave 2: Odd or Even Checker \n\nInput a Number:");
        try
        {
            answer = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\nInput Error!\n");
            opg2();
        }
        if(answer %2 == 0)
        {
            Console.WriteLine("Even");
            ChooseOpg();
        }
        else
        {
            Console.WriteLine("Odd");
            ChooseOpg();
        }

    }
    void opg3()
    {
        Console.WriteLine("Opgave 3: Simple Login System \n\nInput Username (All lowercase)\n(hint: A great comedy show and an area associated with start-up companies):");
        string username = Console.ReadLine();
        Console.WriteLine("Input Password (All lowercase)\n(hint: det programmeringssprog vi lærer lige nu)");
        string password = Console.ReadLine();
        if( username =="silicon valley" && password =="c#")
        {
            Console.WriteLine("Login successful");
            ChooseOpg();
        }
        else
        {
            Console.WriteLine("Login failed");
            ChooseOpg();
        }

    }
    void opg4()
    {
        Console.WriteLine("Opgave 4: Temperature Converter (Celsius to Fahrenheit) \n\nInput Celsius Temperature:");
        try
        {
            answerd = Convert.ToDouble(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\nInput Error!\n");
            opg4();
        }
        double fahrenheit = (answerd * 1.8)+32;
        Console.WriteLine(fahrenheit);
        Console.WriteLine("\n"+answerd + " celcius = " + fahrenheit+" fahrenheit");
        ChooseOpg();
    }
    void opg5()
    {
        Console.WriteLine("Opgave 5: Leap Year Checker \n\nInput a year to check whether it's a leap year");
        try
        {
            answer = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("\nInput Error!\n");
            opg5();
        }
        if(answer %100 == 0 && answer %400 !=0)
        {
            Console.WriteLine("Not a leap year");
            ChooseOpg();
        }
        else if(answer %4 == 0)
        {
            Console.WriteLine("Leap Year");
            ChooseOpg();
        }
        else
        {
            Console.WriteLine("Not a Leap year");
            ChooseOpg();
        }
    }
    void opg6()
    {
        Random rnd = new Random();
        int correctNumber = rnd.Next(1, 10);
        Console.WriteLine("Opgave 6: Number Guessing Game \n\nGuess a number between 1-10");
        Guess();
        void Guess()
        {
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\nInput Error!\n");
                opg6();
            }
            
            if (correctNumber == answer)
            {
                Console.WriteLine("Correct");
                ChooseOpg();
            }
            else if (correctNumber <= answer)
            {
                Console.WriteLine("Too High\nGuess Again!");
                Guess();
            }
            else
            {
                Console.WriteLine("Too Low\nGuess Again!");
                Guess();
            }
        }
    }
    ChooseOpg();
}
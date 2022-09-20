using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World");*/
            
           /* Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.ReadLine();*/
           /* string characterName = "David";
            int characterAge;
            characterAge = 100;

            Console.WriteLine("There was a man name " + characterName);
            Console.WriteLine("He was "+ characterAge +" years old");

            characterName = "Bryan";
            Console.WriteLine("He really like the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();*/
            
            //-----------------------------------------------------------DATA TYPES

            // STRING - only use two qoutation mark
            //string phrase ="im string"; 

            // CHAR - only one letter and must use sing qoutation
            //char grade = 'A';
            
            // INT(integer) = only whole number and negative signs allows.
            //int age = -11;

            // DECIMALS - there is THREE DATA TYPE we can use to store decimals values
             // FLOAT, DOUBLE AND DECIMALS
             // Least ----------->  accurate 
           
            //FLOAT in float you in need to give every values of decimal in the last part a 'f' to represent it's a float
            // use float if you are only restricted in memory
            //float x = 13.3f; 

            // most used type for begginners or most use in language
            //double gpa = 3.0;
            // this tow data type cannot be trusted in terms of precisiom

            //Decimal is for precision and it mostly use for the money
           // decimal money = 300.00M; 

            // BOOLEAN
           // bool inMale = true; //false;  

            // ------------------------------------------------------- DEALING WITH STRINGS

            //-- NEWLINE
            //Console.WriteLine("Girrafe\n Academy");
            
            //------------------------------------------------------- Quation mark

            //Console.WriteLine("David\" bry");

            /*string phrase = "abcdefghi";
            Console.WriteLine(phrase.Length);

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("abc"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf('a'));
            Console.WriteLine(phrase.Substring(5,1));

            Console.ReadLine();*/

            // -------------------------------------------------------- DEALING WITH NUMBERS
            
            /*Console.WriteLine(-11);
            Console.WriteLine(-11.44);

            Console.WriteLine(12 % 5);
            Console.WriteLine(2 + 1 * 4);
            Console.WriteLine((2 + 1) * 4);
            Console.WriteLine(1 * 2.1);
            Console.WriteLine(3 + 2.1);*/

            // if you want the result has a decimal back use one decimal/ double.
            //Console.WriteLine(1 / 4.0);



            // --------------------------------------------------------- MATH OPERATIONS
            
            //Absolute
            //Console.WriteLine(Math.Abs(-40));
            //Powerof
           // Console.WriteLine(Math.Pow(3.8, 2));
           // Console.WriteLine(Math.Sqrt(2));
              
            // Max - which one is the bigger
           // Console.WriteLine(Math.Max(2, 4));
            // And min
            
            //Round
            //Console.WriteLine(Math.Round(2.334));

            /*Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Your Age:");
            string age = Console.ReadLine();

            Console.WriteLine(name + " Welcome Your age is " + age);

            Console.ReadLine();*/
            /* Console.Write("Enter number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine( "equals to : "+ (num1 + num2)); */

            //-----------------------------------------------------------------------Madlibs
            /*string color, pluralNoun, celebrity;

            Console.Write("Enter Color:");
            color = Console.ReadLine();
            Console.Write("Enter PluralNoun:");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter Celebrity:");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color + "\n" + pluralNoun + " are Blue \nI love " + celebrity); */
            
            // -------------------------------------------------------------------- ARRAYS
            /*int[] luckyNumbers = { 4, 7, 14, 51, 55, 56 };

            luckyNumbers[0] = 400;*/

            // Creating Empty array need to specify how many array will put inside.

            /*string[] friends = new String[5];
            friends[0] = "david";
            friends[1] = "tamb";

            Console.WriteLine(friends[0]);
            Console.WriteLine(luckyNumbers[0]);*/

            //---------------------------------------------------------------- METHOD
            //SayHi("mike", 33);
            // --------------------------------------------------------------- RETURN in function
            //Console.WriteLine(Cube(3));

            // IF STATEMENT
            /*bool isMale = true  ;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("true he is Male and Tall");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("Male is Not tall")
            }
            else
            {
                Console.WriteLine("False She is");
            } */
            /* char cont;
            do{
            double num1, num2;

            Console.Write("Pick Operations (+, -, *, /): ");
             char operations = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            double result = Calculate(num1, num2, operations);
            string invalid = "invalid";
            if (result == 0)
            {
                Console.WriteLine("Equal to : " + result);
            
            }
            // Console.WriteLine(whichBigger(444, 144, 755));
            Console.ReadLine();

            Console.WriteLine("Do you want to Continue: Y/N");
            cont = Convert.ToChar(Console.ReadLine()); 
           }while(cont == 'Y' || cont == 'y');
            */

            // ======================= -------------------------------------Switch

            /*Console.Write("Insert day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            string dayNow = GetDay(day);

            Console.WriteLine("Today is " + dayNow); */
           
            // ---------------------------------------------------------- While loop
            /*int index = 1;
            while (index <= 5) 
            {
                Console.WriteLine(index);
                index++;
            }*/

            /*string secretWord = "girrafe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 4;
            bool outOfGuesses = false;
            while(guess != secretWord && !outOfGuesses){

                if (guessCount != guessLimit)
                {
                    Console.Write("Please Enter Your Guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else 
                {
                    outOfGuesses = true;
                } */
                

                /*if (guess == secretWord) {
                    Console.WriteLine("Congratulations");
                    break;
                }
                Console.WriteLine("Wrong");
                Console.Write(" Do you want to continue? Y/N ");                
                char cont = Convert.ToChar(Console.ReadLine());
                
                if (cont == 'N' || cont == 'n' || cont == ' ') {
                    break;
                }*/
            //}
            //Console.WriteLine("Congratulations");*/

            // ------------------------------------------------------- Building exponents method
            //Console.WriteLine(GetPow(3,2));

            // ------------------------------------------------------ 2D Array

            /*int[,] numbeGrid = {
                    {1,3},
                    {2,5},
                    {5,7}
                 };*/

            // - custom array

            /*int[,] myArray = new int[2, 3];

            Console.WriteLine(numbeGrid);

            Console.WriteLine(numbeGrid[0,1]);*/

            //--------------------------------------------------------Handling Exception   

            /* Console.Write("Enter a number: ");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter a number: ");            
             int num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(num1/num2);
             */

            /*try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e){
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
            }*/

            //--------------------------------------------------------------------------- Classses And Object

            // Creating Object

            /*Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Spongebob", "Toms", 100);*/
        
            
            //---------------------------------------------------------------------------- Constructor



            /*Console.WriteLine(book1.title + book1.author + book1.pages);
            Console.WriteLine(book2.title + book2.author + book2.pages);*/

            //-------------------------------------------------------------------Method Objects

            //Student student1 = new Student("David", "BSIT", 3.5);

            //Console.WriteLine(student1.isHonor());

            //-------------------------------------------------------------------Getters and Setters

            /*Movies harryPotter =new Movies("harry poter", "JK. Rowling", "PG12");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(harryPotter.Rating);*/


            //--------------------------------------------------------------------Static class attributes

            /*Song holiday = new Song("Holiday", "Green day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());*/

            //--------------------------------------------------------------------Static class methods

            // if you put static in the usefulclass you cannot create object this class

            //UsefulClass.ssayHi("David");

            //---------------------------------------------------------------------Inheritance 
            // chef and italian chef
            Chef chef = new Chef();

            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();

            italianChef.MakeSpecialDish();

            Console.ReadLine();
            
            //--------------------------------------------------------------------- Yield Return
            // Yield return
            FillValues();
            // custom iteration
            foreach(int i in filter())
            {
                print(i);
            }
            // statefull iteration
            foreach (int i in RunningTotal())
            {
                print(i);
            }
            // SUMMARY
            // 1. Custom iteration without temp collection.
            // 2. Stateful iteration
            
            //--------------------------------------------------------------------- Indexers
            
            public class List{
                public void Add(int number){
                    thow new NotImplementedException();
                }
            }
            //this is the indexer
            public int this[int index]{
                get {throw new NotImplementedException();}
            }

        }
        //----------- METHODs

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello User: " + name + " Age: " + age);
        }

        //------------- RETURN

        static int Cube(int num) 
        {
            int solve = num * num * num;
            return solve;
        }

        // Method if Statement

        static int whichBigger(int num1, int num2, int num3) {
        
            int result;
            if (num1 > num2 && num1 > num3) 
            {
                return result = num1;

            }
            else if (num2 > num1 && num2 > num3)
            {
                return result = num2;
            }
            else {
                return result = num3;
            }

            return result;
        }

      
        //----- Calculator Method
        static double Calculate(double num1, double num2, char operations)
        {
            double resultTo;

            if (operations == '+')
            {
                return resultTo = num1 + num2;
            }
            else if(operations == '-')
            {
                return resultTo = num1 - num2;
            }
            else if (operations == '*')
            {
                return resultTo = num1 * num2;
            }
            else if (operations == '/')
            {
                return resultTo = num1 / num2;
            }else
            {
                return 0;
            }
        

            
            return 0;
        }

        // -------------------------------- Swtich method
        static string GetDay(int dayNum) {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thurday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            return dayName;

        }   
        // ------------------- Building Exponent Method

        static int GetPow(int baseNum, int powNum) 
        {
            int result = 1;

            for (int i = 0; i < powNum; i++) 
            {
                result = result * baseNum;
            }
            return result;
        }
        // --------------------------- Yield Return
        // custom iteration
        static IEnumerable<int> filter()
        {
            foreach(int i in MyList)
            {
                if (i > 3)
                {
                    yield return i;
                }
            }

        }
        //statefull iteration
        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach(int i in MyList)
            {
                runningTotal += i;
                yield return (runningTotal);
            }
        }
        }
}

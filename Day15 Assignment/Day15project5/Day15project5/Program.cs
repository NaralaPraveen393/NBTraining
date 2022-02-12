using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuizapp
{
    internal class Program
    {    //Name:Narala Praveen
        //Purpose:To print score in flat txt file.
        static void Main(string[] args)
        {
            //Variable declaration
           
            int score = 0, ans;
            string name;
            //User output
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0}, Welcome to Narala Praveen Quiz", name);
            Console.WriteLine("Q1.Who is the Father of Indian Nation");
            Console.WriteLine("1.B.R Ambedhkar 2.Babu Jagjivan Rao 3.Mahathma Gandhiji 4.Sarder Vallabhai Patel");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("Q2.Who is the first president of India");
            Console.WriteLine("1.Babu Rajendraprasad 2.Jawaharlal Nehru 3.Mohmmed Alijinna 4.Sarojini naidu");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("Q3.Who is the fisrt prime minister of India");
            Console.WriteLine("1.Bipin chandrapal 2.Jawaharlal Nehru 3.Apj Abdul kalam 4.Indira Gandhi");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q4.Who is the Teacher of Mahatma Gandhiji");
            Console.WriteLine("1.Raja Ram 2.Gopal Krishna Gokule 3.Bagath sing 4.Viveka nandha");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("Q5.Who is first vice president of India");
            Console.WriteLine("1.Jawaharlal Nehru 2.Sarder Vallabhai Patel 3.Indira Gandhi 4.Prathibha Patel");
            Console.WriteLine("Enter your choice");
            ans = (Convert.ToInt32(Console.ReadLine()));
            if (ans == 2)
                score += 20;
            
                Console.WriteLine("Congratulations You have completed the Quiz \nYour score is Recorded at @Admin");
            StreamWriter sr = new StreamWriter("C:\\NBHtraining\\Day15 Assignment\\Quiz.txt", true);
            sr.WriteLine($"Hi {name} Score={score}");
            sr.Close(); 

           // File.WriteAllText("C:\\NBHtraining\\Day15 Assignment\\Quiz.txt",$"Hi {name}Score={score}");
            Console.ReadLine();
        }
    }
}

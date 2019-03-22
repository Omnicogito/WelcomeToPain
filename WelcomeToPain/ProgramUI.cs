using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToPain
{
    public class ProgramUI
    {
        StoryRepository storyRepo = new StoryRepository();

        public void run()

        {
            
            Console.WriteLine("Welcome to Greatest Personality Test Ever");
            Console.ReadLine();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please choose from the options below: \n" +
                    "1. Take the best personality test\n" +
                    "2. Review cool peoples reults\n" +
                    "3. Give Up\n");

                int result = int.Parse(Console.ReadLine());

                switch (result)
                {
                    case 1:
                        TakeTest();
                        break;

                    case 2:
                        ShowTests();
                        break;

                    case 3:
                        isRunning = false;
                        break;
                }
            }

        }

        private void ShowTests()
        {
            Console.Clear();
            List<User> users = storyRepo.ReturnAllUsers();

            foreach(User user in users)
            {
                Console.WriteLine($"{user.FullName}\n {user.Personality}");
            }

            Console.ReadLine();
        }

        private void TakeTest()
        {
            int introversion = 0;
            int extraversion = 0;
            int structure = 0;
            int impulsive = 0;
            int realist = 0;
            int dreamer = 0;
            Console.Clear();

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Read these instructions carefully\n  1.Answer all the questions for correct answers." +
                "\nAnswer 1 for Strongly Agree, \nAnswer 2 for Agree, \nAnswer 3 for neutral , \nAnswer 4 for Disagree, \nAnswer 5 for Strongly Disagree");
            Console.WriteLine("Press any key to start");
            Console.ReadLine();

            Console.WriteLine("\n1.You find it difficult to introduce yourself to other people?");
            int result = GetInt();

            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n2. You try to respond to your emails as soon as possible and can not stand a messy inbox:");
            result = GetInt();

            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n3.You often go lost in thoughts that you ignore or lost in surroundings: ");
            result = GetInt();

            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n4.You find it easy to stay relaxed when you have a lot a pressure:");
            result = GetInt();

            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n5.You do not generally initiate conversations:");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n6.You rarely do something out to sheer curiosity:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n7.You feel superior to other people:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n8.Being organized to you is more important to you than being adaptable:");
            result = GetInt();
            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n9.You are usually motivated and energetic:");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n10.Your home and work environments are quite tidy:");
            result = GetInt();
            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n11.You consider yourself to be more practical than creative:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n12.Your mood can change very quickly:");
            result = GetInt();
            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n13.You are often envious of others:");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n14.You do not let other people influence your actions:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n15.Your emotions control you more often then you control them:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n16.If your friend is sad about something,you are more likely to offer emotional support then suggest ways to deal with the problem:");
            result = GetInt();
            AddPersonalityValue(ref realist, ref dreamer, result);

            Console.WriteLine("\n17.You rarely feel insecure:");
            result = GetInt();
            AddPersonalityValuesStrImp(ref structure, ref impulsive,result);

            Console.WriteLine("\n18.You frequently misplace your things:");
            result = GetInt();
            AddPersonalityValuesStrImp(ref structure, ref impulsive, result);

            Console.WriteLine("\n19.If the room is full,you probably stay closer to walls avoiding the center");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n20.You often take initiative in social situations:");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            Console.WriteLine("\n21.You often feel that you have to justify yourself to other people");
            result = GetInt();
            AddPersonalityValuesExtInt(ref introversion, ref extraversion, result);

            string personality = "";

            User user = new User(name, introversion, extraversion, structure, impulsive, dreamer, realist, personality);

            storyRepo.AddNewUser(user);

            string response = storyRepo.CalculateUserPersonality(user);

            //user.Personality = response;

            //Console.WriteLine(response);

            //Console.ReadLine();
        }

        private static void AddPersonalityValue(ref int realist, ref int dreamer, int result)
        {
            switch (result)
            {
                case 1:
                    dreamer += 3;
                    realist -= 3;
                    break;
                case 2:
                    dreamer += 2;
                    realist -= 2;
                    break;
                case 3:
                    dreamer += 1;
                    realist += 1;
                    break;
                case 4:
                    dreamer -= 2;
                    realist += 2;
                    break;
                case 5:
                    dreamer -= 3;
                    realist += 3;
                    break;
            }
        }

        private static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        private static void AddPersonalityValuesStrImp(ref int structure, ref int impulsive, int result)
        {
            switch (result)
            {
                case 1:
                    structure += 3;
                    impulsive -= 3;
                    break;
                case 2:
                    structure += 2;
                    impulsive -= 2;
                    break;
                case 3:
                    structure += 1;
                    impulsive += 1;
                    break;
                case 4:
                    structure -= 2;
                    impulsive += 2;
                    break;
                case 5:
                    structure -= 3;
                    impulsive += 3;
                    break;
            }
        }

        private static void AddPersonalityValuesExtInt(ref int introversion, ref int extraversion, int result)
        {
            switch (result)
            {
                case 1:
                    introversion += 3;
                    extraversion -= 3;
                    break;
                case 2:
                    introversion += 2;
                    extraversion -= 2;
                    break;
                case 3:
                    introversion += 1;
                    extraversion += 1;
                    break;
                case 4:
                    introversion -= 2;
                    extraversion += 2;
                    break;
                case 5:
                    introversion -= 3;
                    extraversion += 3;
                    break;
            }
        }
    }
}

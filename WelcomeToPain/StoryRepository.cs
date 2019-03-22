using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToPain
{
    public class StoryRepository
    {
        List<User> users = new List<User>();

        public void AddNewUser(User user)
        {
            users.Add(user);
        }

        public List<User> ReturnAllUsers()
        {
            return users;
        }

        public string CalculateUserPersonality(User user)
        {
            if(user.Introversion > 5 && user.Structure > 8 && user.Dreamer > 6)
            {
                Console.WriteLine("You are an intense dreamer, you live to shape the world to your imagination but do not work well with others in attaining your vision.");
                string result = Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else if(user.Extraversion > 5 && user.Impulsive > 6 && user.Realist > 4)
            {
                Console.WriteLine("You have your feet firmly on the ground, you are always up for adventure, you don't worry about tomrorrow but you know you'll make more friends.");
                string result = Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else if(user.Introversion > 5 && user.Structure > 6 && user.Realist > 5)
            {
                Console.WriteLine("you are very down to earth person and you like things in a particular order but you like to work alone and do not like to talk to people much");
                string result = Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else
            {
                Console.WriteLine("You're too weird to categorize");
                return Console.ReadLine();
            }
        }
    }
}

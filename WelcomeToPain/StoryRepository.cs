using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeToPain
{
    public class StoryRepository
    {
        public StoryRepository()
        {
           
        }

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
                string result = "OUTPUT:\n You are an intense dreamer, you live to shape the world to your imagination but do not work well with others in attaining your vision.";
                Console.WriteLine(result);
               Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else if(user.Extraversion > 5 && user.Impulsive > 6 && user.Realist > 4)
            {
                string result = "OUTPUT:\n You have your feet firmly on the ground, you are always up for adventure, you don't worry about tomrorrow but you know you'll make more friends.";

                Console.WriteLine(result);
                Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else if(user.Introversion > 5 && user.Structure > 6 && user.Realist > 5)
            {
                string result = "OUTPUT:\n You are very down to earth person and you like things in a particular order but you like to work alone and do not like to talk to people much";
                Console.WriteLine(result);
               Console.ReadLine();

                user.Personality = result;

                return result;
            }

            else
            {
                string result = "You're too weird to categorize";

                Console.WriteLine(result);
                Console.ReadLine();

                user.Personality = result;

                return result;
            }
        }
    }
}

using ChallengeMe.CONFIDENT;

namespace ChallengeMe.Tests
{
    public class WelcomeToTheFridge : UserService
    {
        public void EnterTheFridge(string String, string _String)
        {
            NotUser[] notUsers = new NotUser[2];
            bool isHooman = false;
            
            foreach(var user in NotUsersAtAll.hohoho)
            {
                if(user.GetNotName() == String && user.GetNotNumbers() == _String)
                {
                    notUsers[0] = user;
                    isHooman = true;
                }
            }
            if(isHooman)
            {
                Console.WriteLine("You have entered the fridge", notUsers[0]);
            }
            else
            {
                Console.WriteLine("Your fridge has benn lohed");
            }
        }

        public void RegisterFood(string String, string _String)
        {
            throw new NotImplementedException();
        }

        public void UnregisterFood(string String)
        {
            NotUsersAtAll.hohoho[0] = null;
        }
    }
}

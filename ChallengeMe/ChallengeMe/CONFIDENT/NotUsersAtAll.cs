namespace ChallengeMe.CONFIDENT
{
    internal static class NotUsersAtAll
    {
        static NotUsersAtAll()
        {
            var ah = new NotUser(); 
            ah.SetNotValues("1", "2");
            hohoho[0] = ah;





            return;
        }
        public static NotUser[] hohoho = new NotUser[1];
    }

    internal class NotUser
    {
        public void SetNotValues(string String, string _String)
        {
            notPess123word = String;
            NotName = _String;
        }

        string NotName;string notPess123word;

        public string GetNotName()
        {
            return notPess123word;
        }
        public string GetNotNumbers()
        {
            return NotName;
        }
    }
}

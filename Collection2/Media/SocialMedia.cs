
namespace Media
{
    internal class SocialMedia
    {
        private Dictionary<string, List<string>> Friends = new Dictionary<string, List<string>>();
        public void AddFriend(string username, List<string> friends)
        {
            Friends.Add(username, friends);

        }
        public void RemoveFriend(string username)
        {
            Friends.Remove(username);
        }
        public List<string> GetAllFriendsByUsername(string username)
        {
            if (Friends.ContainsKey(username))
            {
                return Friends[username];
            }
            else
            {
                return new List<string>(); 
            }
        }
    }

}

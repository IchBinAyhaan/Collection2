using Media;

public class Program
{
    static void Main()
    {
        SocialMedia socialMedia = new SocialMedia();
        socialMedia.AddFriend("Ayhan", new List<string> { "Oktay", "Kamil" });
        List<string> friends = socialMedia.GetAllFriendsByUsername("Ayhan");
        Console.WriteLine("Ayhan's friends:");
        foreach (var friend in friends)
        {
            Console.WriteLine(friend);
        }
        socialMedia.RemoveFriend("Kamil");
        friends = socialMedia.GetAllFriendsByUsername("Ayhan");
        Console.WriteLine("After removing Kamil from Ayhan's friends:");
        friends = socialMedia.GetAllFriendsByUsername("Ayhan");
        foreach (var friend in friends)
        {
            Console.WriteLine(friend);
        }
    }
}
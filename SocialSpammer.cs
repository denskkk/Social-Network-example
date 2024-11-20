using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class SocialSpammer
    {
        private SocialNetwork network;

        public SocialSpammer(SocialNetwork network)
        {
            this.network = network;
        }

        public void SendSpamToFriends(string profileId, string message)
        {
            ProfileIterator iterator = network.CreateFriendsIterator(profileId);
            Send(iterator, message);
        }

        public void SendSpamToCoworkers(string profileId, string message)
        {
            ProfileIterator iterator = network.CreateCoworkersIterator(profileId);
            Send(iterator, message);
        }

        private void Send(ProfileIterator iterator, string message)
        {
            while (iterator.HasMore())
            {
                Profile profile = iterator.GetNext();
                System.Console.WriteLine($"Sending message to: {profile.GetEmail()} - Message: {message}");
            }
        }
    }

}

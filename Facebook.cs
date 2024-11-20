using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class Facebook : SocialNetwork
    {
        private Dictionary<string, List<Profile>> socialGraph;

        public Facebook()
        {
            socialGraph = new Dictionary<string, List<Profile>>
        {
            { "1", new List<Profile> { new Profile("1", "alice@example.com"), new Profile("2", "bob@example.com") } },
            { "2", new List<Profile> { new Profile("3", "charlie@example.com"), new Profile("4", "david@example.com") } }
        };
        }

        public ProfileIterator CreateFriendsIterator(string profileId)
        {
            return new FacebookIterator(this, profileId, "friends");
        }

        public ProfileIterator CreateCoworkersIterator(string profileId)
        {
            return new FacebookIterator(this, profileId, "coworkers");
        }

        public List<Profile> GetProfiles(string profileId, string type)
        {
            return socialGraph.ContainsKey(profileId) ? socialGraph[profileId] : new List<Profile>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class FacebookIterator : ProfileIterator
    {
        private readonly Facebook facebook;
        private readonly string profileId;
        private readonly string type;
        private int currentPosition;
        private List<Profile> cache;

        public FacebookIterator(Facebook facebook, string profileId, string type)
        {
            this.facebook = facebook;
            this.profileId = profileId;
            this.type = type;
            this.currentPosition = 0;
        }

        private void LazyInit()
        {
            if (cache == null)
            {
                cache = facebook.GetProfiles(profileId, type);
            }
        }

        public Profile GetNext()
        {
            if (HasMore())
            {
                return cache[currentPosition++];
            }
            return null;
        }

        public bool HasMore()
        {
            LazyInit();
            return currentPosition < cache.Count;
        }
    }
}

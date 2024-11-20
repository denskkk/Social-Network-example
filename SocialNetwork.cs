using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public interface SocialNetwork
    {
        ProfileIterator CreateFriendsIterator(string profileId);
        ProfileIterator CreateCoworkersIterator(string profileId);
    }

}

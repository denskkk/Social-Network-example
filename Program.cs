using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SocialNetwork facebook = new Facebook();
            SocialSpammer spammer = new SocialSpammer(facebook);

            // Надсилаємо повідомлення друзям
            spammer.SendSpamToFriends("1", "Привіт, друзі!");

            // Надсилаємо повідомлення колегам
            spammer.SendSpamToCoworkers("2", "Привіт, колеги!");
        }
    }
}

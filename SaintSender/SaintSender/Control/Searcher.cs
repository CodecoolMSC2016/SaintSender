using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//An InternetAddressList is a list of InternetAddress items.
//An InternetAddress is an abstract class with 2 subclasses: GroupAddress and MailboxAddress.

//A MailboxAddress is what you probably consider an "email address" that 
//    comes in the form "John Smith" <john @smith-plumbing.com>.
//The Name property on the MailboxAddress contains the string John Smith 
//    while the Address property contains the string john@smith-plumbing.com.

//A GroupAddress is something that is rarely used these days.
//It is a named list of addresses that might look something like this 
//    if you ever find an example of one 
//    in a message's To or Cc header: Friends: Joey <joey@friends.com>, Monica <monica@friends.com>, 
//    "Mrs. Chanandler Bong" <chandler@friends.com>, Ross <ross@firnds.com>, Rachel <rachel@friends.com>;

//Since you probably only care about the individual email addresses on the From header of the message, 
//    you could just use this:

//foreach (var mailbox in message.From.Mailboxes)
//    Console.WriteLine("{0}'s email address is {1}", mailbox.Name, mailbox.Address);


namespace SaintSender.Control
{
    class Searcher
    {
        
        

        public string SearchByMailboxAddress(string pattern)
        {

            return null;
        }

        public string SearchByName(string pattern)
        {


            return null;
        }
    }
}

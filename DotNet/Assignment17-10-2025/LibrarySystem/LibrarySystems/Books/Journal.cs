using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystems.Books
{
    public class Journal
    {
        string JournalAuthorName { get; set; }
        public string JournalTitle { get; set; }
        public string JournalId { get; set; }
        public static int TotolJournal = 0;
        public Journal(string journaltitle, string journalAuthorname)
        {
            TotolJournal = TotolJournal + 1;
            JournalAuthorName = journalAuthorname;
            JournalId = "J" + (1000 + TotolJournal);
            JournalTitle = journaltitle;

            DisplayJournalDetails();
        }
        public void DisplayJournalDetails()
        {
            Console.WriteLine("\nJournal Details");
            Console.WriteLine("JournalId:" + JournalId + " \nJournal Name:" + JournalTitle + " \nJournalDetails:" + JournalAthorName);
        }

    }

}

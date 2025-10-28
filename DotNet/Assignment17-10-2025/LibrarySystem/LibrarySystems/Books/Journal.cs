using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystems.Books
{
    public class Journal
    {
        string JournalAthorName { get; set; }
        public string JournalTitle { get; set; }
        public string JournalId { get; set; }
        public static int TotolJournal = 0;
        public Journal(string Journaltitle, string Journalathorname)
        {
            TotolJournal = TotolJournal + 1;
            JournalAthorName = Journalathorname;
            JournalId = "J" + (1000 + TotolJournal);
            JournalTitle = Journaltitle;

            DisplayJournalDetails();
        }
        public void DisplayJournalDetails()
        {
            Console.WriteLine("\nJournal Details");
            Console.WriteLine("JournalId:" + JournalId + " \nJournal Name:" + JournalTitle + " \nJournalDetails:" + JournalAthorName);
        }

    }

}

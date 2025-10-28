using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Books
{
    public class Magazine
    {
        string MagazineAthorName { get; set; }
        public string MagazineTitle { get; set; }
        public string MagazineId { get; set; }
        public static int TotolMagazine = 0;
        public Magazine(string Magazinetitle, string Magazineathorname)
        {
            TotolMagazine = TotolMagazine + 1;
            MagazineAthorName = Magazineathorname;
            MagazineId = "M" + (1000 + TotolMagazine);
            MagazineTitle = Magazinetitle;

            DisplayMagazineDetails();
        }
        public void DisplayMagazineDetails()
        {
            Console.WriteLine("\nMagazine Details");
            Console.WriteLine("MagazineId:" + MagazineId + " \nMagazine Name:" + MagazineTitle + " \nMagazine Details:" + MagazineAthorName);
        }
    }
}

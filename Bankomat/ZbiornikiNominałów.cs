using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public static class ZbiornikiNominałów
    {
        public static int NOM10 { get; set; }
        public static int NOM20 { get; set; }
        public static int NOM50 { get; set; }
        public static int NOM100 { get; set; }
        public static int NOM200 { get; set; }

        public static int NOM10X { get; set; }
        public static int NOM20X { get; set; }
        public static int NOM50X { get; set; }
        public static int NOM100X { get; set; }
        public static int NOM200X { get; set; }

        static ZbiornikiNominałów()
        {
            NOM10 = 1;
            NOM20 = 1;
            NOM50 = 1;
            NOM100 = 1;
            NOM200 = 10;

            NOM10X = NOM10 * 10;
            NOM20X = NOM20 * 20;
            NOM50X = NOM50 * 50;
            NOM100X = NOM100 * 100;
            NOM200X = NOM200 * 200;
        }
    }
}

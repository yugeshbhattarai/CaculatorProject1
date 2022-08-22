using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Banner
    {

       public string startBanner()
        {
            string banner = "\t\t\t\t  ╔═╗ ╔═╗ ╦   ╔═╗ ╦ ╦ ╦   ╔═╗ ╔╦╗ ╔═╗ ╦═╗\n\t\t\t\t  ║   ╠═╣ ║   ║   ║ ║ ║   ╠═╣  ║  ║ ║ ╠╦╝\n\t\t\t\t  ╚═╝ ╩ ╩ ╩═╝ ╚═╝ ╚═╝ ╩═╝ ╩ ╩  ╩  ╚═╝ ╩╚═";
            return banner;
        }

        public string endProgramBanner()
        {
            string endBanner = "\t\t\t\t╔╦╗  ╦ ╦  ╔═╗  ╔╗╔  ╦╔═      ╦ ╦  ╔═╗  ╦ ╦\n\t\t\t\t ║   ╠═╣  ╠═╣  ║║║  ╠╩╗      ╚╦╝  ║ ║  ║ ║\n\t\t\t\t ╩   ╩ ╩  ╩ ╩  ╝╚╝  ╩ ╩       ╩   ╚═╝  ╚═╝";
            return endBanner;
        }

        public string Buildcalc()
        {
            string builder = "\n\n\t\t\t\t\t    SELECT OPERATION\n\t\t\t\t ------------------------------------\n\t\t\t\t|| A ||       A D D I T I O N       ||\n\t\t\t\t||---||-----------------------------||\n\t\t\t\t|| S ||    S U B T R A C T I O N    ||\n\t\t\t\t||---||-----------------------------||\n\t\t\t\t|| M || M U L T I P L I C A T I O N ||\n\t\t\t\t||---||-----------------------------||\n\t\t\t\t|| D ||       D I V I S I O N       ||\n\t\t\t\t ------------------------------------";
            return builder;
        }
        public string AdditionBanner()
        {
            string addBanner = "\t\t\t   ╔═╗  ╔╦╗  ╔╦╗  ╦  ╔╦╗  ╦  ╔═╗  ╔╗╔\n\t\t\t   ╠═╣   ║║   ║║  ║   ║   ║  ║ ║  ║║║\n\t\t\t   ╩ ╩  ═╩╝  ═╩╝  ╩   ╩   ╩  ╚═╝  ╝╚╝\n________________________________________________________________________________________________\n";
            return addBanner;
        }

         public string SubtractionBanner()
        {
            string subBanner= "\t\t\t   ╔═╗  ╦ ╦  ╔╗   ╔╦╗  ╦═╗  ╔═╗  ╔═╗  ╔╦╗  ╦  ╔═╗  ╔╗╔\n\t\t\t   ╚═╗  ║ ║  ╠╩╗   ║   ╠╦╝  ╠═╣  ║     ║   ║  ║ ║  ║║║\n\t\t\t   ╚═╝  ╚═╝  ╚═╝   ╩   ╩╚═  ╩ ╩  ╚═╝   ╩   ╩  ╚═╝  ╝╚╝\n________________________________________________________________________________________________\n";
            return subBanner;
        }
         public string MultiplicationBanner()
        {
            string mulBanner = "\t\t\t   ╔╦╗  ╦ ╦  ╦    ╔╦╗  ╦  ╔═╗  ╦    ╦  ╔═╗  ╔═╗  ╔╦╗  ╦  ╔═╗  ╔╗╔\n\t\t\t   ║║║  ║ ║  ║     ║   ║  ╠═╝  ║    ║  ║    ╠═╣   ║   ║  ║ ║  ║║║\n\t\t\t   ╩ ╩  ╚═╝  ╩═╝   ╩   ╩  ╩    ╩═╝  ╩  ╚═╝  ╩ ╩   ╩   ╩  ╚═╝  ╝╚╝\n________________________________________________________________________________________________\n";
            return mulBanner;
        }
        public string DivisionBanner()
        {
            string divBanner= "\t\t\t  ╔╦╗  ╦  ╦  ╦  ╦  ╔═╗  ╦  ╔═╗  ╔╗╔\n\t\t\t   ║║  ║  ╚╗╔╝  ║  ╚═╗  ║  ║ ║  ║║║\n\t\t\t  ═╩╝  ╩   ╚╝   ╩  ╚═╝  ╩  ╚═╝  ╝╚╝\n________________________________________________________________________________________________\n";
            return divBanner;
        }
    }
}

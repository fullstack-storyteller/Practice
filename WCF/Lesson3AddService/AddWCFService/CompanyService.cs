using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddWCFService
{
    public class CompanyService : ICompanyPrivateService, ICompanyPublicService
    {
        public string PrivateInformation()
        {
            return "Private Information using net.tcp.";
        }

        public string PublicInformation()
        {
            return "Public Information using HTTP protocol";
        }
    }
}

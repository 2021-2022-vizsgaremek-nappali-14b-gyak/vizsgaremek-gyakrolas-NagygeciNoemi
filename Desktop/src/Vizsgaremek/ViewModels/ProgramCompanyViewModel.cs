using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    class ProgramCompanyViewModel
    {
        private ProgramInfo programInfo;
        public string Company
        {
            get
            {
                return programInfo.Company.ToString();
            }
            set
            {
                Company = value;
            }
        }

        public ProgramCompanyViewModel()
        {
            programInfo = new ProgramInfo();
        }
    }
}

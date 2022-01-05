using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    class ProgramDescriptionViewModel
    {
        private ProgramInfo programInfo;
        public string Description
        {
            get
            {
                return programInfo.Description.ToString();
            }
            set
            {
                Description = value;
            }
        }

        public ProgramDescriptionViewModel()
        {
            programInfo = new ProgramInfo();
        }
    }
}

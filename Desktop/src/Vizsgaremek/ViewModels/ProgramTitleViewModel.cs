using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    class ProgramTitleViewModel
    {
        private ProgramInfo programInfo;
        public string Title
        {
            get
            {
                return programInfo.Title.ToString();
            }
            set
            {
                Title = value;
            }
        }

        public ProgramTitleViewModel()
        {
            programInfo = new ProgramInfo();
        }
    }
}

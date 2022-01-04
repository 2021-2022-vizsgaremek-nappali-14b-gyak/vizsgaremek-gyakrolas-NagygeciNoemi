using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    class ProgramAuthorsViewModels
    {
        private ProgramInfo programInfo;
        public string Authors
        {
            get
            {
                return programInfo.Authors.ToString();
            }
            set
            {
                Authors = value;
            }
        }

        public ProgramAuthorsViewModels()
        {
            programInfo = new ProgramInfo();
        }
    }
}

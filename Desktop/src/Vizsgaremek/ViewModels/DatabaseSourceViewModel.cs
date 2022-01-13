using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Repositories;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    public class DatabaseSourceViewModel
    {
        private ObservableCollection<string> displayedDatabaseSources;
        private string selectedDatabaseSource;
        private DbSource dbSource;

        DatabaseSources repoDatabaseSources;

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
        }

        public ObservableCollection<string> DisplayedDatabaseSource 
        { 
            get => displayedDatabaseSources; 
        }

        public DbSource DbSource
        {
            get
            {
                return DbSource.NONE;
            }
        }

        public string SelectedDatabaseSource 
        { 
            get => selectedDatabaseSource; 
            set => selectedDatabaseSource = value; 
        }
    }
}

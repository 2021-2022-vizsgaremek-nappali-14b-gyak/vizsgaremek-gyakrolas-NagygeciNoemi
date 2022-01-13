﻿using System;
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
        private string displayedDatabaseSource;
        private DbSource dbSource;

        DatabaseSources repoDatabaseSources;

        public DatabaseSourceViewModel()
        {
            repoDatabaseSources = new DatabaseSources();
            displayedDatabaseSources = new ObservableCollection<string>(repoDatabaseSources.GetAllDatabaseSources());
            SelectedDatabaseSource = "localhost";
        }

        public ObservableCollection<string> DisplayedDatabaseSource 
        { 
            get => displayedDatabaseSources; 
        }

        public DbSource DbSource
        {
            get
            {
                //return DbSource.NONE;
                if (selectedDatabaseSource == "localhost")
                    return DbSource.LOCALHOST;
                else if (selectedDatabaseSource == "devops")
                    return DbSource.DEVOPS;
                return DbSource.NONE;
            }
        }

        public string SelectedDatabaseSource 
        { 
            get => selectedDatabaseSource;
            set
            {
                selectedDatabaseSource = value;
            } 
        }
        public string DisplayedDatabaseSource1
        {
            get
            {
                switch (dbSource)
                {
                    case DbSource.DEVOPS:
                        return "develops adatforrás";
                        break;
                    case DbSource.LOCALHOST:
                        return "localhost adatforrás";
                        break;
                    case DbSource.NONE:
                        return "beépített teszt adatok";
                        break;
                    default:
                        return "";

                }
            }
        }
    }
}

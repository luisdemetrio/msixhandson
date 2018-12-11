using CustomerList.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerList.WPF
{

   

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // Pipeline for interacting with backend service or database.
        public static IContosoRepository Repository { get; private set; }

        public App()
        {
            UseSqlite();

        }

        // Configures the app to use the Sqlite data source. If no existing Sqlite database exists, loads a demo database filled with fake data so the app has content.
        public static void UseSqlite()
        {

           // string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string demoDatabasePath = $"{AppDomain.CurrentDomain.BaseDirectory}Assets\\Contoso.db";


            

            if (File.Exists(demoDatabasePath))
            {

                var dbOptions = new DbContextOptionsBuilder<ContosoContext>()
                         .UseSqlite("Data Source=" + demoDatabasePath)
                         ;

                Repository = new SqlContosoRepository(dbOptions);


            }

        }
    }



}

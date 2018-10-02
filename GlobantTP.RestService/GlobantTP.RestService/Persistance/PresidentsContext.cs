using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using GlobantTP.RestService.Models;
using GlobantTP.RestService.Persistance;

namespace GlobantTP.RestService.Persistance
{
    public class PresidentsContext
    {

        public List<President> loadCsvFile()
        {

            List<President> presidents = new List<President>();
            int count = -1;
            string path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/PresidentsSheet.csv");
            using (var reader = new StreamReader(path))
            {
               
                while (!reader.EndOfStream)
                {
                    count++;
                    var line = reader.ReadLine();
                    var values = line.Split('|');

                    President president = new President()
                    {
                        Id = count,
                        Name = values[0],
                        Birthday = values[1],
                        Birthplace = values[2],
                        DeathDay =values[3],
                        DeathPlace = values[4]

                    };
                    
                    presidents.Add(president);
                   
                    
                }

                presidents.RemoveAt(0);
            }



            return presidents;
        }
    }
}
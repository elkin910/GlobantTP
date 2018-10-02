using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobantTP.RestService.Persistance;
using GlobantTP.RestService.Models;
using GlobantTP.RestService.Repositories;

namespace GlobantTP.RestService.Persistance.Repositories
{
    public class PresidentRepository: IPresidentRepository
    {


        PresidentsContext db = new PresidentsContext();

        public List<President> GetAll() {

            return db.loadCsvFile();
        }


    }
}
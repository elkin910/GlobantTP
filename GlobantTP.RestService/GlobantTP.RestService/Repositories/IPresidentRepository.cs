using GlobantTP.RestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobantTP.RestService.Repositories
{
    public interface IPresidentRepository
    {
        List<President> GetAll();
    }
}

using GlobantTP.RestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData;

namespace GlobantTP.RestService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PresidentController : ApiController
    {
        [EnableQuery]
        // GET: api/President
        public IEnumerable<President> Get()
        {
            List<President> listPresidents = new List<President> {

                    new President{ Id=1, Name="George Washington", Birthday="1732-2-22", Birthplace="Westmoreland Co., Va.", DeathDay="1799-12-14", DeathPlace="Mount Vernon, Va." },
                    new President{ Id=2, Name="John Adams", Birthday="1735-10-30", Birthplace="Quincy, Mass.", DeathDay="1826-7-4", DeathPlace="Quincy, Mass." },
                    new President{ Id=3, Name="Thomas Jefferson", Birthday="1743-4-13", Birthplace="Albemarle Co., Va.", DeathDay="1826-7-4", DeathPlace="Albemarle Co., Va." },
                    new President{ Id=4, Name="James Madison", Birthday="1751-3-16", Birthplace="Port Conway, Va.", DeathDay="1836-6-28", DeathPlace="Orange Co., Va." },
                    new President{ Id=5, Name="James Monroe", Birthday="1758-4-28", Birthplace="Westmoreland Co., Va.", DeathDay="1831-7-4", DeathPlace="New York, New York" },
                    new President{ Id=6, Name="John Quincy Adams", Birthday="1767-7-11", Birthplace="Quincy, Mass.", DeathDay="1848-2-23", DeathPlace="Washington, D.C." },
                    new President{ Id=7, Name="Andrew Jackson", Birthday="1767-3-15", Birthplace="Waxhaws, No./So. Carolina", DeathDay="1845-6-8", DeathPlace="Nashville, Tennessee" },
                    new President{ Id=8, Name="Martin Van Buren", Birthday="1782-12-5", Birthplace="Kinderhook, New York", DeathDay="1862-7-24", DeathPlace="Kinderhook, New York" },
                    new President{ Id=9, Name="William Henry Harrison", Birthday="1773-2-9", Birthplace="Charles City Co., Va.", DeathDay="1841-4-4", DeathPlace="Washington, D.C." },
                    new President{ Id=10, Name="John Tyler", Birthday="1790-3-29", Birthplace="Charles City Co., Va.", DeathDay="1862-1-18", DeathPlace="Richmond, Va." },
                    new President{ Id=11, Name="James K. Polk", Birthday="1795-11-2", Birthplace="Mecklenburg Co., N.C.", DeathDay="1849-6-15", DeathPlace="Nashville, Tennessee" },
                    new President{ Id=12, Name="Zachary Taylor", Birthday="1784-11-24", Birthplace="Orange County, Va.", DeathDay="1850-7-9", DeathPlace="Washington, D.C" },
                    new President{ Id=13, Name="Millard Fillmore", Birthday="1800-1-7", Birthplace="Cayuga Co., New York", DeathDay="1874-3-8", DeathPlace="Buffalo, New York" },
                    new President{ Id=14, Name="Franklin Pierce", Birthday="1804-11-23", Birthplace="Hillsborough, N.H.", DeathDay="1869-10-8", DeathPlace="Concord, New Hamp." },
                    new President{ Id=15, Name="James Buchanan", Birthday="1791-4-23", Birthplace="Cove Gap, Pa.", DeathDay="1868-6-1", DeathPlace="Lancaster, Pa." },
                    new President{ Id=16, Name="Abraham Lincoln", Birthday="1809-2-12", Birthplace="LaRue Co., Kentucky", DeathDay="1865-4-15", DeathPlace="Washington, D.C." },
                    new President{ Id=17, Name="Andrew Johnson", Birthday="1808-12-29", Birthplace="Raleigh, North Carolina", DeathDay="1875-7-31", DeathPlace="Elizabethton, Tenn." },
                    new President{ Id=18, Name="Ulysses S. Grant", Birthday="1822-4-27", Birthplace="Point Pleasant, Ohio", DeathDay="1885-7-23", DeathPlace="Wilton, New York" },
                    new President{ Id=19, Name="Rutherford B. Hayes", Birthday="1822-10-4", Birthplace="Delaware, Ohio", DeathDay="1893-1-17", DeathPlace="Fremont, Ohio" },
                    new President{ Id=20, Name="James A. Garfield", Birthday="1831-11-19", Birthplace="Cuyahoga Co., Ohio", DeathDay="1881-9-19", DeathPlace="Elberon, New Jersey" },
                    new President{ Id=21, Name="Chester Arthur", Birthday="1829-10-5", Birthplace="Fairfield, Vermont", DeathDay="1886-11-18", DeathPlace="New York, New York" },
                    new President{ Id=22, Name="Grover Cleveland", Birthday="1837-3-18", Birthplace="Caldwell, New Jersey", DeathDay="1908-6-24", DeathPlace="Princeton, New Jersey" },
                    new President{ Id=23, Name="Benjamin Harrison", Birthday="1833-8-20", Birthplace="North Bend, Ohio", DeathDay="1901-3-13", DeathPlace="Indianapolis, Indiana" },
                    new President{ Id=24, Name="William McKinley", Birthday="1843-1-29", Birthplace="Niles, Ohio", DeathDay="1901-9-14", DeathPlace="Buffalo, New York" },
                    new President{ Id=25, Name="Theodore Roosevelt", Birthday="1858-10-27", Birthplace="New York, New York", DeathDay="1919-1-6", DeathPlace="Oyster Bay, New York" },
                    new President{ Id=26, Name="William Howard Taft", Birthday="1857-9-15", Birthplace="Cincinnati, Ohio", DeathDay="1930-3-8", DeathPlace="Washington, D.C." },
                    new President{ Id=27, Name="Woodrow Wilson", Birthday="1856-12-28", Birthplace="Staunton, Virginia", DeathDay="1924-2-3", DeathPlace="Washington, D.C." },
                    new President{ Id=28, Name="Warren G. Harding", Birthday="1865-11-2", Birthplace="Morrow County, Ohio", DeathDay="1923-8-2", DeathPlace="San Francisco, Cal." },
                    new President{ Id=29, Name="Calvin Coolidge", Birthday="1872-7-4", Birthplace="Plymouth, Vermont", DeathDay="1933-1-5", DeathPlace="Northampton, Mass." },
                    new President{ Id=30, Name="Herbert Hoover", Birthday="1874-8-10", Birthplace="West Branch, Iowa", DeathDay="1964-10-20", DeathPlace="New York, New York" },
                    new President{ Id=31, Name="Franklin Roosevelt", Birthday="1882-1-30", Birthplace="Hyde Park, New York", DeathDay="1945-4-12", DeathPlace="Warm Springs, Georgia" },
                    new President{ Id=32, Name="Harry S. Truman", Birthday="1884-5-8", Birthplace="Lamar, Missouri", DeathDay="1972-12-26", DeathPlace="Kansas City, Missouri" },
                    new President{ Id=33, Name="Dwight Eisenhower", Birthday="1890-10-14", Birthplace="Denison, Texas", DeathDay="1969-3-28", DeathPlace="Washington, D.C." },
                    new President{ Id=34, Name="John F. Kennedy", Birthday="1917-5-29", Birthplace="Brookline, Mass.", DeathDay="1963-11-22", DeathPlace="Dallas, Texas" },
                    new President{ Id=35, Name="Lyndon B. Johnson", Birthday="1908-8-27", Birthplace="Gillespie Co., Texas", DeathDay="1973-1-22", DeathPlace="Gillespie Co., Texas" },
                    new President{ Id=36, Name="Richard Nixon", Birthday="1913-1-9", Birthplace="Yorba Linda, Cal.", DeathDay="1994-4-22", DeathPlace="New York, New York" },
                    new President{ Id=37, Name="Gerald Ford", Birthday="1913-7-14", Birthplace="Omaha, Nebraska", DeathDay="2006-12-26", DeathPlace="Rancho Mirage, Cal." },
                    new President{ Id=38, Name="Jimmy Carter", Birthday="1924-10-1", Birthplace="Plains, Georgia", DeathDay="", DeathPlace="" },
                    new President{ Id=39, Name="Ronald Reagan", Birthday="1911-2-6", Birthplace="Tampico, Illinois", DeathDay="2004-6-5", DeathPlace="Los Angeles, Cal." },
                    new President{ Id=40, Name="George Bush", Birthday="1924-6-12", Birthplace="Milton, Mass.", DeathDay="", DeathPlace="" },
                    new President{ Id=41, Name="Bill Clinton", Birthday="1946-8-19", Birthplace="Hope, Arkansas", DeathDay="", DeathPlace="" },
                    new President{ Id=42, Name="George W. Bush", Birthday="1646-7-6", Birthplace="New Haven, Conn.", DeathDay="", DeathPlace="" },
                    new President{ Id=43, Name="Barack Obama", Birthday="1961-8-4", Birthplace="Honolulu, Hawaii", DeathDay="", DeathPlace="" },
                    new President{ Id=44, Name="Donald Trump", Birthday="1946-6-14", Birthplace="New York, New York", DeathDay="", DeathPlace="" }
                    


            };

            return listPresidents;
        }

        
    }
}

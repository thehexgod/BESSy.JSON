using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BESSy.Json.Tests.Documentation.Samples.Serializer
{
    public class SerializeTypeNameHandling
    {
        #region Types
        public abstract class Business
        {
            public string Name { get; set; }
        }

        public class Hotel : Business
        {
            public int Stars { get; set; }
        }

        public class Stockholder
        {
            public string FullName { get; set; }
            public IList<Business> Businesses { get; set; }
        }
        #endregion

        public void Example()
        {
            #region Usage
            Stockholder stockholder = new Stockholder
            {
                FullName = "Steve Stockholder",
                Businesses = new List<Business>
                {
                    new Hotel
                    {
                        Name = "Hudson Hotel",
                        Stars = 4
                    }
                }
            };

            string jsonTypeNameAll = JsonConvert.SerializeObject(stockholder, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });

            Console.WriteLine(jsonTypeNameAll);
            // {
            //   "$type": "BESSy.Json.Samples.Stockholder, BESSy.Json.Tests",
            //   "FullName": "Steve Stockholder",
            //   "Businesses": {
            //     "$type": "System.Collections.Generic.List`1[[BESSy.Json.Samples.Business, BESSy.Json.Tests]], mscorlib",
            //     "$values": [
            //       {
            //         "$type": "BESSy.Json.Samples.Hotel, BESSy.Json.Tests",
            //         "Stars": 4,
            //         "Name": "Hudson Hotel"
            //       }
            //     ]
            //   }
            // }

            string jsonTypeNameAuto = JsonConvert.SerializeObject(stockholder, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            Console.WriteLine(jsonTypeNameAuto);
            // {
            //   "FullName": "Steve Stockholder",
            //   "Businesses": [
            //     {
            //       "$type": "BESSy.Json.Samples.Hotel, BESSy.Json.Tests",
            //       "Stars": 4,
            //       "Name": "Hudson Hotel"
            //     }
            //   ]
            // }

            // for security TypeNameHandling is required when deserializing
            Stockholder newStockholder = JsonConvert.DeserializeObject<Stockholder>(jsonTypeNameAuto, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            Console.WriteLine(newStockholder.Businesses[0].GetType().Name);
            // Hotel
            #endregion
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Sah
{
    class Partija
    {
        public ObjectId Id { get; set; }
        public string pozicija { get; set; }
        public string ime { get; set; }
    }
}

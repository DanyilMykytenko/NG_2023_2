using MongoExample.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoExample.Entity.Collections
{
    [BsonCollectionAttribute("User")]
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}

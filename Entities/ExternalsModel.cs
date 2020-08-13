using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ExternalsModel
    {
        public int ExternalId { get; set; }
        public String ExternalName { get; set; }
        public String ExternalSurname { get; set; }
        public int UserTypeId { get; set; }
    }
}

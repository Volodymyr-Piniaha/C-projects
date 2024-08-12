using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_JSON_files
{
    public class DataItem
    {
        public string objectId { get; set; }
        public DateTime effectimeFrom { get; set; }
        public DateTime effectiveTo { get; set; }

        //unnessesary
        public string quality { get; set; }
        public string hobby { get; set; }
        public string job { get; set; }
    }
}

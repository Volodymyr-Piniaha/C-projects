using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Working_with_JSON_files
{
    public class AllInfo
    {
        public string identificatorId { get; set; }
        public DateTime effectiveFrom { get; set; }
        public DateTime effectiveTo { get; set; }
        public string type { get; set; }
        public string objectId { get; set; }
        public override string ToString()
        {
            return $"ID: {identificatorId}\nEffectiveFrom: {effectiveFrom}\nEffectiveTo: {effectiveTo}\nType: {type}\nObjectID: {objectId}";
        }
    }
}

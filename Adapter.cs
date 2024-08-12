using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Working_with_JSON_files
{
    public class Adapter
    {
        public Root toAdapt;

        public Adapter(Root toAdapt)
        {
            this.toAdapt = toAdapt;
        }

        public AllInfo Adapt()
        {
            return new AllInfo
            {
                identificatorId = toAdapt.identificatorId,
                effectiveFrom = DateTime.Parse(toAdapt.dataItem.effectimeFrom),
                effectiveTo = DateTime.Parse(toAdapt.dataItem.effectiveTo),
                type = toAdapt.info.type,
                objectId = toAdapt.dataItem.objectId
               
            };

        }
    }
}

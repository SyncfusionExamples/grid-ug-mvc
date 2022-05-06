using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace dotnet_mvc_sample.Models
{
    public partial class Database1Entities
    {
        [DbFunction("Database1Model.Store", "ToLocalDatetime")]
        public DateTime ToLocalDatetime(DateTimeOffset value, string offset)
        {
            List<ObjectParameter> parameters = new List<ObjectParameter>(2);
            parameters.Add(new ObjectParameter("value", value));
            parameters.Add(new ObjectParameter("offset", offset));
            var lObjectContext = ((IObjectContextAdapter)this).ObjectContext;
            var output = lObjectContext.CreateQuery<DateTime>("Database1Model.Store.ToLocalDatetime(@value,@digits)", parameters.ToArray()).Execute(MergeOption.NoTracking).FirstOrDefault();
            return output;
        }
    }
}
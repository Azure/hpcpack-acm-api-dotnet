// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JobUpdate
    {
        /// <summary>
        /// Initializes a new instance of the JobUpdate class.
        /// </summary>
        public JobUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobUpdate class.
        /// </summary>
        /// <param name="request">Possible values include: 'cancel'</param>
        public JobUpdate(string request = default(string))
        {
            Request = request;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'cancel'
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public string Request { get; set; }

    }
}

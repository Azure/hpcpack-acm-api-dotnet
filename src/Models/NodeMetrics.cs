// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NodeMetrics
    {
        /// <summary>
        /// Initializes a new instance of the NodeMetrics class.
        /// </summary>
        public NodeMetrics()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeMetrics class.
        /// </summary>
        /// <param name="rangeSeconds">Time span in second of the metric
        /// data</param>
        public NodeMetrics(double? rangeSeconds = default(double?), IList<NodeMetricsDataItem> data = default(IList<NodeMetricsDataItem>))
        {
            RangeSeconds = rangeSeconds;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time span in second of the metric data
        /// </summary>
        [JsonProperty(PropertyName = "rangeSeconds")]
        public double? RangeSeconds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<NodeMetricsDataItem> Data { get; set; }

    }
}

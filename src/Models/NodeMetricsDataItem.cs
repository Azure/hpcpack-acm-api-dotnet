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

    public partial class NodeMetricsDataItem
    {
        /// <summary>
        /// Initializes a new instance of the NodeMetricsDataItem class.
        /// </summary>
        public NodeMetricsDataItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeMetricsDataItem class.
        /// </summary>
        /// <param name="time">Time of the metric data</param>
        public NodeMetricsDataItem(System.DateTime? time = default(System.DateTime?), IList<NodeMetricsDataItemMetricItemsItem> metricItems = default(IList<NodeMetricsDataItemMetricItemsItem>))
        {
            Time = time;
            MetricItems = metricItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time of the metric data
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metricItems")]
        public IList<NodeMetricsDataItemMetricItemsItem> MetricItems { get; set; }

    }
}

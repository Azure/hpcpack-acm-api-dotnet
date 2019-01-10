using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HPC.ACM.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NodeMetricsData {
    /// <summary>
    /// Time of the metric data
    /// </summary>
    /// <value>Time of the metric data</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public DateTime? Time { get; set; }

    /// <summary>
    /// Gets or Sets MetricItems
    /// </summary>
    [DataMember(Name="metricItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricItems")]
    public List<NodeMetricsMetricItems> MetricItems { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetricsData {\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  MetricItems: ").Append(MetricItems).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

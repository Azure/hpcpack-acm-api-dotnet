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
  public class NodeMetricsMetricItems {
    /// <summary>
    /// Metric category
    /// </summary>
    /// <value>Metric category</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Metric data
    /// </summary>
    /// <value>Metric data</value>
    [DataMember(Name="instanceValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instanceValues")]
    public Dictionary<string, double?> InstanceValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetricsMetricItems {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  InstanceValues: ").Append(InstanceValues).Append("\n");
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

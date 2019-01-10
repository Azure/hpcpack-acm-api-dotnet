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
  public class NodeMetadata {
    /// <summary>
    /// Gets or Sets Compute
    /// </summary>
    [DataMember(Name="compute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compute")]
    public NodeMetadataCompute Compute { get; set; }

    /// <summary>
    /// Gets or Sets Network
    /// </summary>
    [DataMember(Name="network", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "network")]
    public NodeMetadataNetwork Network { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetadata {\n");
      sb.Append("  Compute: ").Append(Compute).Append("\n");
      sb.Append("  Network: ").Append(Network).Append("\n");
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

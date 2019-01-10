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
  public class NodeMetadataNetworkIpv4IpAddress {
    /// <summary>
    /// Gets or Sets PrivateIpAddress
    /// </summary>
    [DataMember(Name="privateIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateIpAddress")]
    public IpV4 PrivateIpAddress { get; set; }

    /// <summary>
    /// Gets or Sets PublicIpAddress
    /// </summary>
    [DataMember(Name="publicIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publicIpAddress")]
    public IpV4 PublicIpAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetadataNetworkIpv4IpAddress {\n");
      sb.Append("  PrivateIpAddress: ").Append(PrivateIpAddress).Append("\n");
      sb.Append("  PublicIpAddress: ").Append(PublicIpAddress).Append("\n");
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

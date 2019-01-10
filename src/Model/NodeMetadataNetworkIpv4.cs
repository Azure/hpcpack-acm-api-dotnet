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
  public class NodeMetadataNetworkIpv4 {
    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name="ipAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipAddress")]
    public List<NodeMetadataNetworkIpv4IpAddress> IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets Subnet
    /// </summary>
    [DataMember(Name="subnet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subnet")]
    public List<NodeMetadataNetworkIpv4Subnet> Subnet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetadataNetworkIpv4 {\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  Subnet: ").Append(Subnet).Append("\n");
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

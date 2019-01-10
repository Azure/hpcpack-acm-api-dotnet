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
  public class NodeMetadataNetworkInterface {
    /// <summary>
    /// Gets or Sets Ipv4
    /// </summary>
    [DataMember(Name="ipv4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipv4")]
    public NodeMetadataNetworkIpv4 Ipv4 { get; set; }

    /// <summary>
    /// Gets or Sets Ipv6
    /// </summary>
    [DataMember(Name="ipv6", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipv6")]
    public NodeMetadataNetworkIpv6 Ipv6 { get; set; }

    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [DataMember(Name="macAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "macAddress")]
    public MacAddress MacAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetadataNetworkInterface {\n");
      sb.Append("  Ipv4: ").Append(Ipv4).Append("\n");
      sb.Append("  Ipv6: ").Append(Ipv6).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
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

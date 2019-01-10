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
  public class NodeNetwork {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [DataMember(Name="macAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "macAddress")]
    public MacAddress MacAddress { get; set; }

    /// <summary>
    /// Gets or Sets IpV4
    /// </summary>
    [DataMember(Name="ipV4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipV4")]
    public IpV4 IpV4 { get; set; }

    /// <summary>
    /// Gets or Sets IpV6
    /// </summary>
    [DataMember(Name="ipV6", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipV6")]
    public IpV6 IpV6 { get; set; }

    /// <summary>
    /// Gets or Sets IsIB
    /// </summary>
    [DataMember(Name="isIB", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isIB")]
    public bool? IsIB { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeNetwork {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
      sb.Append("  IpV4: ").Append(IpV4).Append("\n");
      sb.Append("  IpV6: ").Append(IpV6).Append("\n");
      sb.Append("  IsIB: ").Append(IsIB).Append("\n");
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

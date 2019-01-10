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
  public class NodeGpu {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Uuid
    /// </summary>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Gets or Sets PciBusDevice
    /// </summary>
    [DataMember(Name="pciBusDevice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pciBusDevice")]
    public string PciBusDevice { get; set; }

    /// <summary>
    /// Gets or Sets PciBusId
    /// </summary>
    [DataMember(Name="pciBusId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pciBusId")]
    public string PciBusId { get; set; }

    /// <summary>
    /// Gets or Sets TotalMemory
    /// </summary>
    [DataMember(Name="totalMemory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalMemory")]
    public int? TotalMemory { get; set; }

    /// <summary>
    /// Gets or Sets MaxSMClock
    /// </summary>
    [DataMember(Name="maxSMClock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxSMClock")]
    public int? MaxSMClock { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeGpu {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  PciBusDevice: ").Append(PciBusDevice).Append("\n");
      sb.Append("  PciBusId: ").Append(PciBusId).Append("\n");
      sb.Append("  TotalMemory: ").Append(TotalMemory).Append("\n");
      sb.Append("  MaxSMClock: ").Append(MaxSMClock).Append("\n");
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

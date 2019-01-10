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
  public class NodeRegistration {
    /// <summary>
    /// Gets or Sets NodeName
    /// </summary>
    [DataMember(Name="nodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeName")]
    public string NodeName { get; set; }

    /// <summary>
    /// Gets or Sets CoreCount
    /// </summary>
    [DataMember(Name="coreCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coreCount")]
    public int? CoreCount { get; set; }

    /// <summary>
    /// Gets or Sets SocketCount
    /// </summary>
    [DataMember(Name="socketCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "socketCount")]
    public int? SocketCount { get; set; }

    /// <summary>
    /// Gets or Sets MemoryMegabytes
    /// </summary>
    [DataMember(Name="memoryMegabytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memoryMegabytes")]
    public int? MemoryMegabytes { get; set; }

    /// <summary>
    /// Gets or Sets GpuInfo
    /// </summary>
    [DataMember(Name="gpuInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gpuInfo")]
    public List<NodeGpu> GpuInfo { get; set; }

    /// <summary>
    /// Gets or Sets NetworksInfo
    /// </summary>
    [DataMember(Name="networksInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "networksInfo")]
    public List<NodeNetwork> NetworksInfo { get; set; }

    /// <summary>
    /// Gets or Sets DistroInfo
    /// </summary>
    [DataMember(Name="distroInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distroInfo")]
    public string DistroInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeRegistration {\n");
      sb.Append("  NodeName: ").Append(NodeName).Append("\n");
      sb.Append("  CoreCount: ").Append(CoreCount).Append("\n");
      sb.Append("  SocketCount: ").Append(SocketCount).Append("\n");
      sb.Append("  MemoryMegabytes: ").Append(MemoryMegabytes).Append("\n");
      sb.Append("  GpuInfo: ").Append(GpuInfo).Append("\n");
      sb.Append("  NetworksInfo: ").Append(NetworksInfo).Append("\n");
      sb.Append("  DistroInfo: ").Append(DistroInfo).Append("\n");
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

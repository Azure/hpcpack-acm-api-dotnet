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
  public class Node {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets Health
    /// </summary>
    [DataMember(Name="health", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "health")]
    public string Health { get; set; }

    /// <summary>
    /// Gets or Sets RunningJobCount
    /// </summary>
    [DataMember(Name="runningJobCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runningJobCount")]
    public int? RunningJobCount { get; set; }

    /// <summary>
    /// Gets or Sets EventCount
    /// </summary>
    [DataMember(Name="eventCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventCount")]
    public int? EventCount { get; set; }

    /// <summary>
    /// Gets or Sets NodeRegistrationInfo
    /// </summary>
    [DataMember(Name="nodeRegistrationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeRegistrationInfo")]
    public NodeRegistration NodeRegistrationInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Node {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Health: ").Append(Health).Append("\n");
      sb.Append("  RunningJobCount: ").Append(RunningJobCount).Append("\n");
      sb.Append("  EventCount: ").Append(EventCount).Append("\n");
      sb.Append("  NodeRegistrationInfo: ").Append(NodeRegistrationInfo).Append("\n");
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

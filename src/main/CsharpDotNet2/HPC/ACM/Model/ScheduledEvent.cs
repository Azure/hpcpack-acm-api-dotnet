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
  public class ScheduledEvent {
    /// <summary>
    /// Globally unique identifier for this event
    /// </summary>
    /// <value>Globally unique identifier for this event</value>
    [DataMember(Name="eventId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventId")]
    public string EventId { get; set; }

    /// <summary>
    /// Impact this event causes
    /// </summary>
    /// <value>Impact this event causes</value>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// Type of resource this event impacts
    /// </summary>
    /// <value>Type of resource this event impacts</value>
    [DataMember(Name="resourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceType")]
    public string ResourceType { get; set; }

    /// <summary>
    /// List of resources this event impacts. This is guaranteed to contain machines from at most one Update Domain, but may not contain all machines in the UD.
    /// </summary>
    /// <value>List of resources this event impacts. This is guaranteed to contain machines from at most one Update Domain, but may not contain all machines in the UD.</value>
    [DataMember(Name="resources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resources")]
    public List<string> Resources { get; set; }

    /// <summary>
    /// No Completed or similar status is ever provided; the event will no longer be returned when the event is completed.
    /// </summary>
    /// <value>No Completed or similar status is ever provided; the event will no longer be returned when the event is completed.</value>
    [DataMember(Name="eventStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventStatus")]
    public string EventStatus { get; set; }

    /// <summary>
    /// Time after which this event may start
    /// </summary>
    /// <value>Time after which this event may start</value>
    [DataMember(Name="notBefore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notBefore")]
    public DateTime? NotBefore { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledEvent {\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  EventStatus: ").Append(EventStatus).Append("\n");
      sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
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

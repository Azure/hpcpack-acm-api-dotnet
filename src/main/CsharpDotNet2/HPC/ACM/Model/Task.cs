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
  public class Task {
    /// <summary>
    /// task id
    /// </summary>
    /// <value>task id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Id of the job the task belongs to
    /// </summary>
    /// <value>Id of the job the task belongs to</value>
    [DataMember(Name="jobId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobId")]
    public int? JobId { get; set; }

    /// <summary>
    /// Type of the job the task belongs to
    /// </summary>
    /// <value>Type of the job the task belongs to</value>
    [DataMember(Name="jobType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobType")]
    public JobType JobType { get; set; }

    /// <summary>
    /// Task state
    /// </summary>
    /// <value>Task state</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public TaskState State { get; set; }

    /// <summary>
    /// Available only when task's job type is ClusRun
    /// </summary>
    /// <value>Available only when task's job type is ClusRun</value>
    [DataMember(Name="commandLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commandLine")]
    public string CommandLine { get; set; }

    /// <summary>
    /// The node on which the task runs
    /// </summary>
    /// <value>The node on which the task runs</value>
    [DataMember(Name="node", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "node")]
    public string Node { get; set; }

    /// <summary>
    /// Gets or Sets ParentIds
    /// </summary>
    [DataMember(Name="parentIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentIds")]
    public List<int?> ParentIds { get; set; }

    /// <summary>
    /// Gets or Sets ChildIds
    /// </summary>
    [DataMember(Name="childIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childIds")]
    public List<int?> ChildIds { get; set; }

    /// <summary>
    /// Gets or Sets RemainingParentIds
    /// </summary>
    [DataMember(Name="remainingParentIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remainingParentIds")]
    public List<int?> RemainingParentIds { get; set; }

    /// <summary>
    /// Gets or Sets CustomizedData
    /// </summary>
    [DataMember(Name="customizedData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customizedData")]
    public string CustomizedData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Task {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  JobType: ").Append(JobType).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  CommandLine: ").Append(CommandLine).Append("\n");
      sb.Append("  Node: ").Append(Node).Append("\n");
      sb.Append("  ParentIds: ").Append(ParentIds).Append("\n");
      sb.Append("  ChildIds: ").Append(ChildIds).Append("\n");
      sb.Append("  RemainingParentIds: ").Append(RemainingParentIds).Append("\n");
      sb.Append("  CustomizedData: ").Append(CustomizedData).Append("\n");
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

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
  public class Job {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public JobType Type { get; set; }

    /// <summary>
    /// job id
    /// </summary>
    /// <value>job id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// job name give by user
    /// </summary>
    /// <value>job name give by user</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Available only for ClusRun job
    /// </summary>
    /// <value>Available only for ClusRun job</value>
    [DataMember(Name="commandLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commandLine")]
    public string CommandLine { get; set; }

    /// <summary>
    /// Available only for Diagnostics job
    /// </summary>
    /// <value>Available only for Diagnostics job</value>
    [DataMember(Name="diagnosticTest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "diagnosticTest")]
    public DiagnoticTest DiagnosticTest { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public JobState State { get; set; }

    /// <summary>
    /// Nodes on which the job runs
    /// </summary>
    /// <value>Nodes on which the job runs</value>
    [DataMember(Name="targetNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetNodes")]
    public List<string> TargetNodes { get; set; }

    /// <summary>
    /// Job progress
    /// </summary>
    /// <value>Job progress</value>
    [DataMember(Name="progress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "progress")]
    public int? Progress { get; set; }

    /// <summary>
    /// Events happened in the job
    /// </summary>
    /// <value>Events happened in the job</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<Event> Events { get; set; }

    /// <summary>
    /// The number of times the job is requeued
    /// </summary>
    /// <value>The number of times the job is requeued</value>
    [DataMember(Name="requeueCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requeueCount")]
    public int? RequeueCount { get; set; }

    /// <summary>
    /// Gets or Sets FailJobOnTaskFailure
    /// </summary>
    [DataMember(Name="failJobOnTaskFailure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failJobOnTaskFailure")]
    public bool? FailJobOnTaskFailure { get; set; }

    /// <summary>
    /// Gets or Sets CreatedAt
    /// </summary>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets UpdatedAt
    /// </summary>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Job {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CommandLine: ").Append(CommandLine).Append("\n");
      sb.Append("  DiagnosticTest: ").Append(DiagnosticTest).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TargetNodes: ").Append(TargetNodes).Append("\n");
      sb.Append("  Progress: ").Append(Progress).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  RequeueCount: ").Append(RequeueCount).Append("\n");
      sb.Append("  FailJobOnTaskFailure: ").Append(FailJobOnTaskFailure).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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

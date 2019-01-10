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
  public class TaskResult {
    /// <summary>
    /// Gets or Sets JobId
    /// </summary>
    [DataMember(Name="jobId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobId")]
    public int? JobId { get; set; }

    /// <summary>
    /// Gets or Sets TaskId
    /// </summary>
    [DataMember(Name="taskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskId")]
    public int? TaskId { get; set; }

    /// <summary>
    /// The name of the node on which the task runs
    /// </summary>
    /// <value>The name of the node on which the task runs</value>
    [DataMember(Name="nodeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeName")]
    public string NodeName { get; set; }

    /// <summary>
    /// Available only for ClusRun task
    /// </summary>
    /// <value>Available only for ClusRun task</value>
    [DataMember(Name="commandLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commandLine")]
    public string CommandLine { get; set; }

    /// <summary>
    /// Gets or Sets Exited
    /// </summary>
    [DataMember(Name="exited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exited")]
    public bool? Exited { get; set; }

    /// <summary>
    /// Gets or Sets ExitCode
    /// </summary>
    [DataMember(Name="exitCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>
    /// Gets or Sets ResultKey
    /// </summary>
    [DataMember(Name="resultKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resultKey")]
    public string ResultKey { get; set; }

    /// <summary>
    /// The number of times the task is requeued
    /// </summary>
    /// <value>The number of times the task is requeued</value>
    [DataMember(Name="taskRequeueCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskRequeueCount")]
    public int? TaskRequeueCount { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets FilteredResult
    /// </summary>
    [DataMember(Name="filteredResult", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filteredResult")]
    public string FilteredResult { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfProcesses
    /// </summary>
    [DataMember(Name="numberOfProcesses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfProcesses")]
    public int? NumberOfProcesses { get; set; }

    /// <summary>
    /// Gets or Sets ProcessIds
    /// </summary>
    [DataMember(Name="processIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processIds")]
    public string ProcessIds { get; set; }

    /// <summary>
    /// Gets or Sets KernelProcessorTime
    /// </summary>
    [DataMember(Name="kernelProcessorTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kernelProcessorTime")]
    public long? KernelProcessorTime { get; set; }

    /// <summary>
    /// Gets or Sets UserProcessorTime
    /// </summary>
    [DataMember(Name="userProcessorTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userProcessorTime")]
    public long? UserProcessorTime { get; set; }

    /// <summary>
    /// Gets or Sets WorkingSet
    /// </summary>
    [DataMember(Name="workingSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workingSet")]
    public int? WorkingSet { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryTask
    /// </summary>
    [DataMember(Name="primaryTask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryTask")]
    public bool? PrimaryTask { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaskResult {\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  TaskId: ").Append(TaskId).Append("\n");
      sb.Append("  NodeName: ").Append(NodeName).Append("\n");
      sb.Append("  CommandLine: ").Append(CommandLine).Append("\n");
      sb.Append("  Exited: ").Append(Exited).Append("\n");
      sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
      sb.Append("  ResultKey: ").Append(ResultKey).Append("\n");
      sb.Append("  TaskRequeueCount: ").Append(TaskRequeueCount).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  FilteredResult: ").Append(FilteredResult).Append("\n");
      sb.Append("  NumberOfProcesses: ").Append(NumberOfProcesses).Append("\n");
      sb.Append("  ProcessIds: ").Append(ProcessIds).Append("\n");
      sb.Append("  KernelProcessorTime: ").Append(KernelProcessorTime).Append("\n");
      sb.Append("  UserProcessorTime: ").Append(UserProcessorTime).Append("\n");
      sb.Append("  WorkingSet: ").Append(WorkingSet).Append("\n");
      sb.Append("  PrimaryTask: ").Append(PrimaryTask).Append("\n");
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

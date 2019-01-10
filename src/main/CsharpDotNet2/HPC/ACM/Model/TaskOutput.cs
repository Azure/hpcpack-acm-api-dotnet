using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace HPC.ACM.Model {

  /// <summary>
  /// The end of the output can only be told by size of value 0 and the end of the task.
  /// </summary>
  [DataContract]
  public class TaskOutput {
    /// <summary>
    /// Whether the end of output is reached
    /// </summary>
    /// <value>Whether the end of output is reached</value>
    [DataMember(Name="eof", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eof")]
    public bool? Eof { get; set; }

    /// <summary>
    /// Distance between the start of the returned content and the start of the whole output
    /// </summary>
    /// <value>Distance between the start of the returned content and the start of the whole output</value>
    [DataMember(Name="offset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offset")]
    public int? Offset { get; set; }

    /// <summary>
    /// Length of the content(in a unit meaningful only to the server, not in character of content)
    /// </summary>
    /// <value>Length of the content(in a unit meaningful only to the server, not in character of content)</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public int? Size { get; set; }

    /// <summary>
    /// The output content
    /// </summary>
    /// <value>The output content</value>
    [DataMember(Name="content", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "content")]
    public string Content { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaskOutput {\n");
      sb.Append("  Eof: ").Append(Eof).Append("\n");
      sb.Append("  Offset: ").Append(Offset).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  Content: ").Append(Content).Append("\n");
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

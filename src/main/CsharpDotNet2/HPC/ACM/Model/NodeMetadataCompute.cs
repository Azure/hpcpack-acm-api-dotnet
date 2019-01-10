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
  public class NodeMetadataCompute {
    /// <summary>
    /// Azure Region the VM is running in
    /// </summary>
    /// <value>Azure Region the VM is running in</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public string Location { get; set; }

    /// <summary>
    /// Name of the VM
    /// </summary>
    /// <value>Name of the VM</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Offer information for the VM image. This value is only present for images deployed from Azure image gallery.
    /// </summary>
    /// <value>Offer information for the VM image. This value is only present for images deployed from Azure image gallery.</value>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public string Offer { get; set; }

    /// <summary>
    /// Linux or Windows
    /// </summary>
    /// <value>Linux or Windows</value>
    [DataMember(Name="osType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osType")]
    public string OsType { get; set; }

    /// <summary>
    /// Fault domain the VM is running in
    /// </summary>
    /// <value>Fault domain the VM is running in</value>
    [DataMember(Name="platformFaultDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformFaultDomain")]
    public string PlatformFaultDomain { get; set; }

    /// <summary>
    /// Update domain the VM is running in
    /// </summary>
    /// <value>Update domain the VM is running in</value>
    [DataMember(Name="platformUpdateDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "platformUpdateDomain")]
    public string PlatformUpdateDomain { get; set; }

    /// <summary>
    /// Publisher of the VM image
    /// </summary>
    /// <value>Publisher of the VM image</value>
    [DataMember(Name="publisher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publisher")]
    public string Publisher { get; set; }

    /// <summary>
    /// Specific SKU for the VM image
    /// </summary>
    /// <value>Specific SKU for the VM image</value>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Version of the VM image
    /// </summary>
    /// <value>Version of the VM image</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Unique identifier for the VM
    /// </summary>
    /// <value>Unique identifier for the VM</value>
    [DataMember(Name="vmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vmId")]
    public string VmId { get; set; }

    /// <summary>
    /// VM size
    /// </summary>
    /// <value>VM size</value>
    [DataMember(Name="vmSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vmSize")]
    public string VmSize { get; set; }

    /// <summary>
    /// Azure subscription for the Virtual Machine
    /// </summary>
    /// <value>Azure subscription for the Virtual Machine</value>
    [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Tags for your Virtual Machine
    /// </summary>
    /// <value>Tags for your Virtual Machine</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public string Tags { get; set; }

    /// <summary>
    /// Resource group for your Virtual Machine
    /// </summary>
    /// <value>Resource group for your Virtual Machine</value>
    [DataMember(Name="resourceGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceGroupName")]
    public string ResourceGroupName { get; set; }

    /// <summary>
    /// Placement Group of your virtual machine scale set
    /// </summary>
    /// <value>Placement Group of your virtual machine scale set</value>
    [DataMember(Name="placementGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "placementGroupId")]
    public string PlacementGroupId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NodeMetadataCompute {\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  OsType: ").Append(OsType).Append("\n");
      sb.Append("  PlatformFaultDomain: ").Append(PlatformFaultDomain).Append("\n");
      sb.Append("  PlatformUpdateDomain: ").Append(PlatformUpdateDomain).Append("\n");
      sb.Append("  Publisher: ").Append(Publisher).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  VmId: ").Append(VmId).Append("\n");
      sb.Append("  VmSize: ").Append(VmSize).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  ResourceGroupName: ").Append(ResourceGroupName).Append("\n");
      sb.Append("  PlacementGroupId: ").Append(PlacementGroupId).Append("\n");
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

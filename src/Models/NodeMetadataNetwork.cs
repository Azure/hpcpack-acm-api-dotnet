// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace HPC.ACM.API.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class NodeMetadataNetwork
    {
        /// <summary>
        /// Initializes a new instance of the NodeMetadataNetwork class.
        /// </summary>
        public NodeMetadataNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeMetadataNetwork class.
        /// </summary>
        public NodeMetadataNetwork(IList<NodeMetadataNetworkInterfaceItem> interfaceProperty = default(IList<NodeMetadataNetworkInterfaceItem>))
        {
            InterfaceProperty = interfaceProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        public IList<NodeMetadataNetworkInterfaceItem> InterfaceProperty { get; set; }

    }
}

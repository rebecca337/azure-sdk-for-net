// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Partner configuration information
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PartnerConfiguration : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PartnerConfiguration class.
        /// </summary>
        public PartnerConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PartnerConfiguration class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of the
        /// resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource.</param>
        /// <param name="partnerAuthorization">The details of authorized
        /// partners.</param>
        /// <param name="provisioningState">Provisioning state of the partner
        /// configuration. Possible values include: 'Creating', 'Updating',
        /// 'Deleting', 'Succeeded', 'Canceled', 'Failed'</param>
        /// <param name="systemData">The system metadata relating to partner
        /// configuration resource.</param>
        /// <param name="location">Location of the resource.</param>
        /// <param name="tags">Tags of the resource.</param>
        public PartnerConfiguration(string id = default(string), string name = default(string), string type = default(string), PartnerAuthorization partnerAuthorization = default(PartnerAuthorization), string provisioningState = default(string), SystemData systemData = default(SystemData), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            PartnerAuthorization = partnerAuthorization;
            ProvisioningState = provisioningState;
            SystemData = systemData;
            Location = location;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the details of authorized partners.
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerAuthorization")]
        public PartnerAuthorization PartnerAuthorization { get; set; }

        /// <summary>
        /// Gets or sets provisioning state of the partner configuration.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Canceled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets the system metadata relating to partner configuration
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets tags of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}

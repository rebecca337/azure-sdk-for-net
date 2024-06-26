// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Consumption.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableConsumptionTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableConsumptionTenantResource"/> class for mocking. </summary>
        protected MockableConsumptionTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableConsumptionTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableConsumptionTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }
    }
}

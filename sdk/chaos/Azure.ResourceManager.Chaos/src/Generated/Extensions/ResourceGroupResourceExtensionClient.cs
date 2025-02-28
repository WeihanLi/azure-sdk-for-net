// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Chaos
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ExperimentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ExperimentResources and their operations over a ExperimentResource. </returns>
        public virtual ExperimentCollection GetExperiments()
        {
            return GetCachedClient(Client => new ExperimentCollection(Client, Id));
        }

        /// <summary> Gets a collection of TargetResources in the ResourceGroupResource. </summary>
        /// <param name="parentProviderNamespace"> String that represents a resource provider namespace. </param>
        /// <param name="parentResourceType"> String that represents a resource type. </param>
        /// <param name="parentResourceName"> String that represents a resource name. </param>
        /// <returns> An object representing collection of TargetResources and their operations over a TargetResource. </returns>
        public virtual TargetCollection GetTargets(string parentProviderNamespace, string parentResourceType, string parentResourceName)
        {
            return new TargetCollection(Client, Id, parentProviderNamespace, parentResourceType, parentResourceName);
        }
    }
}

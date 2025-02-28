// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StorageCache. </summary>
    public static partial class StorageCacheExtensions
    {
        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new ResourceGroupResourceExtensionClient(client, resource.Id);
            });
        }

        private static ResourceGroupResourceExtensionClient GetResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ResourceGroupResourceExtensionClient(client, scope);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new SubscriptionResourceExtensionClient(client, resource.Id);
            });
        }

        private static SubscriptionResourceExtensionClient GetSubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new SubscriptionResourceExtensionClient(client, scope);
            });
        }
        #region StorageCacheResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageCacheResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageCacheResource.CreateResourceIdentifier" /> to create a <see cref="StorageCacheResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageCacheResource" /> object. </returns>
        public static StorageCacheResource GetStorageCacheResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageCacheResource.ValidateResourceId(id);
                return new StorageCacheResource(client, id);
            }
            );
        }
        #endregion

        #region StorageTargetResource
        /// <summary>
        /// Gets an object representing a <see cref="StorageTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageTargetResource.CreateResourceIdentifier" /> to create a <see cref="StorageTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageTargetResource" /> object. </returns>
        public static StorageTargetResource GetStorageTargetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                StorageTargetResource.ValidateResourceId(id);
                return new StorageTargetResource(client, id);
            }
            );
        }
        #endregion

        /// <summary> Gets a collection of StorageCacheResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageCacheResources and their operations over a StorageCacheResource. </returns>
        public static StorageCacheCollection GetStorageCaches(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceGroupResourceExtensionClient(resourceGroupResource).GetStorageCaches();
        }

        /// <summary>
        /// Returns a Cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageCacheResource>> GetStorageCacheAsync(this ResourceGroupResource resourceGroupResource, string cacheName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetStorageCaches().GetAsync(cacheName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a Cache.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.StorageCache/caches/{cacheName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="cacheName"> Name of Cache. Length of name must not be greater than 80 and chars must be from the [-0-9a-zA-Z_] char class. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageCacheResource> GetStorageCache(this ResourceGroupResource resourceGroupResource, string cacheName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetStorageCaches().Get(cacheName, cancellationToken);
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheSku" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheSku> GetStorageCacheSkusAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCacheSkusAsync(cancellationToken);
        }

        /// <summary>
        /// Get the list of StorageCache.Cache SKUs available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheSku" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheSku> GetStorageCacheSkus(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCacheSkus(cancellationToken);
        }

        /// <summary>
        /// Get the list of Cache Usage Models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsageModel" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheUsageModel> GetUsageModelsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetUsageModelsAsync(cancellationToken);
        }

        /// <summary>
        /// Get the list of Cache Usage Models available to this subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/usageModels</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UsageModels_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsageModel" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheUsageModel> GetUsageModels(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetUsageModels(cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheUsage> GetStorageCacheUsagesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCacheUsagesAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets the quantity used and quota limit for resources
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AscUsages_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the region to query for usage information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheUsage> GetStorageCacheUsages(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCacheUsages(location, cancellationToken);
        }

        /// <summary>
        /// Returns all Caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageCacheResource> GetStorageCachesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCachesAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all Caches the user has access to under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageCache/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Caches_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageCacheResource> GetStorageCaches(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionResourceExtensionClient(subscriptionResource).GetStorageCaches(cancellationToken);
        }
    }
}

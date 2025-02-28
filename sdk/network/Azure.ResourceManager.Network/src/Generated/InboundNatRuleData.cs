// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the InboundNatRule data model.
    /// Inbound NAT rule of the load balancer.
    /// </summary>
    public partial class InboundNatRuleData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of InboundNatRuleData. </summary>
        public InboundNatRuleData()
        {
        }

        /// <summary> Initializes a new instance of InboundNatRuleData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="frontendIPConfiguration"> A reference to frontend IP addresses. </param>
        /// <param name="backendIPConfiguration"> A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP. </param>
        /// <param name="protocol"> The reference to the transport protocol used by the load balancing rule. </param>
        /// <param name="frontendPort"> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. </param>
        /// <param name="backendPort"> The port used for the internal endpoint. Acceptable values range from 1 to 65535. </param>
        /// <param name="idleTimeoutInMinutes"> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </param>
        /// <param name="enableFloatingIP"> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </param>
        /// <param name="enableTcpReset"> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </param>
        /// <param name="provisioningState"> The provisioning state of the inbound NAT rule resource. </param>
        internal InboundNatRuleData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, WritableSubResource frontendIPConfiguration, NetworkInterfaceIPConfigurationData backendIPConfiguration, LoadBalancingTransportProtocol? protocol, int? frontendPort, int? backendPort, int? idleTimeoutInMinutes, bool? enableFloatingIP, bool? enableTcpReset, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendIPConfiguration = backendIPConfiguration;
            Protocol = protocol;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            EnableTcpReset = enableTcpReset;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> A reference to frontend IP addresses. </summary>
        internal WritableSubResource FrontendIPConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier FrontendIPConfigurationId
        {
            get => FrontendIPConfiguration is null ? default : FrontendIPConfiguration.Id;
            set
            {
                if (FrontendIPConfiguration is null)
                    FrontendIPConfiguration = new WritableSubResource();
                FrontendIPConfiguration.Id = value;
            }
        }

        /// <summary> A reference to a private IP address defined on a network interface of a VM. Traffic sent to the frontend port of each of the frontend IP configurations is forwarded to the backend IP. </summary>
        public NetworkInterfaceIPConfigurationData BackendIPConfiguration { get; }
        /// <summary> The reference to the transport protocol used by the load balancing rule. </summary>
        public LoadBalancingTransportProtocol? Protocol { get; set; }
        /// <summary> The port for the external endpoint. Port numbers for each rule must be unique within the Load Balancer. Acceptable values range from 1 to 65534. </summary>
        public int? FrontendPort { get; set; }
        /// <summary> The port used for the internal endpoint. Acceptable values range from 1 to 65535. </summary>
        public int? BackendPort { get; set; }
        /// <summary> The timeout for the TCP idle connection. The value can be set between 4 and 30 minutes. The default value is 4 minutes. This element is only used when the protocol is set to TCP. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> Configures a virtual machine&apos;s endpoint for the floating IP capability required to configure a SQL AlwaysOn Availability Group. This setting is required when using the SQL AlwaysOn Availability Groups in SQL server. This setting can&apos;t be changed after you create the endpoint. </summary>
        public bool? EnableFloatingIP { get; set; }
        /// <summary> Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP. </summary>
        public bool? EnableTcpReset { get; set; }
        /// <summary> The provisioning state of the inbound NAT rule resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}

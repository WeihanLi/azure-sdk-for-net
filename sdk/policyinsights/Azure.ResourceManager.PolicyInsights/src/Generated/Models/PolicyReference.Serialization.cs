// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class PolicyReference
    {
        internal static PolicyReference DeserializePolicyReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> policyDefinitionId = default;
            Optional<ResourceIdentifier> policySetDefinitionId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<ResourceIdentifier> policyAssignmentId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policySetDefinitionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policySetDefinitionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyAssignmentId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new PolicyReference(policyDefinitionId.Value, policySetDefinitionId.Value, policyDefinitionReferenceId.Value, policyAssignmentId.Value);
        }
    }
}

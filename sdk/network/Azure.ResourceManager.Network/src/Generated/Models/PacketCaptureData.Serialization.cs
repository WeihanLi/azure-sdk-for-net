// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class PacketCaptureData
    {
        internal static PacketCaptureData DeserializePacketCaptureData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> target = default;
            Optional<long> bytesToCapturePerPacket = default;
            Optional<long> totalBytesPerSession = default;
            Optional<int> timeLimitInSeconds = default;
            Optional<PacketCaptureStorageLocation> storageLocation = default;
            Optional<IReadOnlyList<PacketCaptureFilter>> filters = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bytesToCapturePerPacket"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesToCapturePerPacket = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("totalBytesPerSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalBytesPerSession = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeLimitInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeLimitInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("storageLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageLocation = PacketCaptureStorageLocation.DeserializePacketCaptureStorageLocation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PacketCaptureFilter> array = new List<PacketCaptureFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PacketCaptureFilter.DeserializePacketCaptureFilter(item));
                            }
                            filters = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PacketCaptureData(id, name, type, systemData.Value, Optional.ToNullable(etag), target.Value, Optional.ToNullable(bytesToCapturePerPacket), Optional.ToNullable(totalBytesPerSession), Optional.ToNullable(timeLimitInSeconds), storageLocation.Value, Optional.ToList(filters), Optional.ToNullable(provisioningState));
        }
    }
}

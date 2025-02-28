// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabVmDetachDataDiskContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ExistingLabDiskId))
            {
                writer.WritePropertyName("existingLabDiskId"u8);
                writer.WriteStringValue(ExistingLabDiskId);
            }
            writer.WriteEndObject();
        }
    }
}

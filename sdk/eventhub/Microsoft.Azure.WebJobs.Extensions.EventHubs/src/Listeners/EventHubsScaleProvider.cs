// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Azure.Messaging.EventHubs.Primitives;
using Microsoft.Azure.WebJobs.EventHubs.Processor;
using Microsoft.Azure.WebJobs.Extensions.EventHubs.Listeners;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Microsoft.Azure.WebJobs.EventHubs.Listeners
{
    internal class EventHubsScaleProvider : IScaleMonitorProvider, ITargetScalerProvider
    {
        private readonly IConfiguration _configuration;
        private readonly IOptions<EventHubOptions> _options;
        private readonly AzureEventSourceLogForwarder _logForwarder;
        private readonly TriggerMetadata _triggerMetadata;
        private readonly ILoggerFactory _loggerFactory;
        private readonly EventHubMetadata _evetnHubMetadata;
        private readonly AzureComponentFactory _triggerCompoenntFactory;
        private readonly AzureComponentFactory _hostComponentFactory;
        private readonly INameResolver _nameResolver;
        private readonly CheckpointClientProvider _checkpointClientProvider;
        private readonly EventHubClientFactory _factory;
        private readonly EventHubMetricsProvider _eventHubMerticsProvider;
        private readonly BlobCheckpointStoreInternal _checkpointStore;
        private readonly IEventHubConsumerClient _eventHubConsumerClient;

        public EventHubsScaleProvider(IServiceProvider serviceProvider, TriggerMetadata triggerMetadata)
        {
            _configuration = serviceProvider.GetService<IConfiguration>();

            if ((triggerMetadata.Properties != null) && (triggerMetadata.Properties.TryGetValue(nameof(AzureComponentFactory), out object value)))
            {
                _triggerCompoenntFactory = value as AzureComponentFactory;
            }
            _hostComponentFactory = serviceProvider.GetService<AzureComponentFactory>();

            _triggerMetadata = triggerMetadata;
            _logForwarder = serviceProvider.GetService<AzureEventSourceLogForwarder>();
            _options = serviceProvider.GetService<IOptions<EventHubOptions>>();
            _loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            _checkpointClientProvider = serviceProvider.GetService<CheckpointClientProvider>();
            _nameResolver = serviceProvider.GetService<INameResolver>();
            _evetnHubMetadata = JsonConvert.DeserializeObject<EventHubMetadata>(_triggerMetadata.Metadata.ToString());
            _factory = new EventHubClientFactory(_configuration, _hostComponentFactory, _options, _nameResolver, _logForwarder, _checkpointClientProvider);
            _eventHubConsumerClient = _factory.GetEventHubConsumerClient(_evetnHubMetadata.EventHubName, _evetnHubMetadata.Connection, _evetnHubMetadata.ConsumerGroup);
            _checkpointStore = new BlobCheckpointStoreInternal(
                _factory.GetCheckpointStoreClient(),
                _triggerMetadata.FunctionName,
                _loggerFactory.CreateLogger<BlobCheckpointStoreInternal>());
            _eventHubMerticsProvider = new EventHubMetricsProvider(
                triggerMetadata.FunctionName,
                _eventHubConsumerClient,
                _checkpointStore,
                 _loggerFactory.CreateLogger<EventHubMetricsProvider>()
                );
        }

        public IScaleMonitor GetMonitor()
        {
            return new EventHubsScaleMonitor(
                _triggerMetadata.FunctionName,
                _eventHubConsumerClient,
                _checkpointStore,
                _loggerFactory.CreateLogger<EventHubsScaleMonitor>());
        }

        public ITargetScaler GetTargetScaler()
        {
            return new EventHubsTargetScaler(
                _triggerMetadata.FunctionName,
                _eventHubConsumerClient,
                _options.Value,
                _eventHubMerticsProvider,
                _loggerFactory.CreateLogger<EventHubsScaleMonitor>());
        }

        internal class EventHubMetadata
        {
            [JsonProperty]
            public string EventHubName { get; set; }

            [JsonProperty]
            public string ConsumerGroup { get; set; }

            [JsonProperty]
            public string Connection { get; set; }
        }
    }
}

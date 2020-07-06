// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The VpnSiteLinkConnections service client. </summary>
    public partial class VpnSiteLinkConnectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VpnSiteLinkConnectionsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of VpnSiteLinkConnectionsOperations for mocking. </summary>
        protected VpnSiteLinkConnectionsOperations()
        {
        }
        /// <summary> Initializes a new instance of VpnSiteLinkConnectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VpnSiteLinkConnectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VpnSiteLinkConnectionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnSiteLinkConnection>> GetAsync(string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, gatewayName, connectionName, linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VpnGateway. </param>
        /// <param name="gatewayName"> The name of the gateway. </param>
        /// <param name="connectionName"> The name of the vpn connection. </param>
        /// <param name="linkConnectionName"> The name of the vpn connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSiteLinkConnection> Get(string resourceGroupName, string gatewayName, string connectionName, string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnSiteLinkConnectionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, gatewayName, connectionName, linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
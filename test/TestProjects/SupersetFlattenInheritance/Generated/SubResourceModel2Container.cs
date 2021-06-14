// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of SubResourceModel2 and their operations over a ResourceGroup. </summary>
    public partial class SubResourceModel2Container : ResourceContainerBase<ResourceGroupResourceIdentifier, SubResourceModel2, SubResourceModel2Data>
    {
        /// <summary> Initializes a new instance of the <see cref="SubResourceModel2Container"/> class for mocking. </summary>
        protected SubResourceModel2Container()
        {
        }

        /// <summary> Initializes a new instance of SubResourceModel2Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubResourceModel2Container(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private SubResourceModel2SRestOperations _restClient => new SubResourceModel2SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a SubResourceModel2. Please note some properties can be set only during creation. </summary>
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<SubResourceModel2> CreateOrUpdate(string subResourceModel2SName, SubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(subResourceModel2SName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubResourceModel2. Please note some properties can be set only during creation. </summary>
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<SubResourceModel2>> CreateOrUpdateAsync(string subResourceModel2SName, SubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(subResourceModel2SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubResourceModel2. Please note some properties can be set only during creation. </summary>
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public SubResourceModel2SPutOperation StartCreateOrUpdate(string subResourceModel2SName, SubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, subResourceModel2SName, parameters, cancellationToken: cancellationToken);
                return new SubResourceModel2SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a SubResourceModel2. Please note some properties can be set only during creation. </summary>
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="parameters"> The SubResourceModel2 to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<SubResourceModel2SPutOperation> StartCreateOrUpdateAsync(string subResourceModel2SName, SubResourceModel2Data parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, subResourceModel2SName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new SubResourceModel2SPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public override Response<SubResourceModel2> Get(string subResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.Get");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, subResourceModel2SName, cancellationToken: cancellationToken);
                return Response.FromValue(new SubResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="subResourceModel2SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async override Task<Response<SubResourceModel2>> GetAsync(string subResourceModel2SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.Get");
            scope.Start();
            try
            {
                if (subResourceModel2SName == null)
                {
                    throw new ArgumentNullException(nameof(subResourceModel2SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, subResourceModel2SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SubResourceModel2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubResourceModel2 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubResourceModel2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of SubResourceModel2 for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubResourceModel2Container.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubResourceModel2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, SubResourceModel2, SubResourceModel2Data> Construct() { }
    }
}

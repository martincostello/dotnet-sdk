// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Orgs.Item.Repos {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\repos
    /// </summary>
    public class ReposRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ReposRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/repos{?type*,sort*,direction*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ReposRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReposRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/repos{?type*,sort*,direction*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists repositories for the specified organization.**Note:** In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
        /// API method documentation <see href="https://docs.github.com/rest/repos/repos#list-organization-repositories" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<MinimalRepository>?> GetAsync(Action<ReposRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<MinimalRepository>> GetAsync(Action<ReposRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<MinimalRepository>(requestInfo, MinimalRepository.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a new repository in the specified organization. The authenticated user must be a member of the organization.**OAuth scope requirements**When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:*   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository.*   `repo` scope to create a private repository
        /// API method documentation <see href="https://docs.github.com/rest/repos/repos#create-an-organization-repository" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Repository?> PostAsync(ReposPostRequestBody body, Action<ReposRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Repository> PostAsync(ReposPostRequestBody body, Action<ReposRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Repository>(requestInfo, Repository.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists repositories for the specified organization.**Note:** In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReposRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReposRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ReposRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Creates a new repository in the specified organization. The authenticated user must be a member of the organization.**OAuth scope requirements**When using [OAuth](https://docs.github.com/apps/building-oauth-apps/understanding-scopes-for-oauth-apps/), authorizations must include:*   `public_repo` scope or `repo` scope to create a public repository. Note: For GitHub AE, use `repo` scope to create an internal repository.*   `repo` scope to create a private repository
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ReposPostRequestBody body, Action<ReposRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ReposPostRequestBody body, Action<ReposRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ReposRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ReposRequestBuilder WithUrl(string rawUrl) {
            return new ReposRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists repositories for the specified organization.**Note:** In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see &quot;[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).&quot;
        /// </summary>
        public class ReposRequestBuilderGetQueryParameters {
            /// <summary>The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`.</summary>
            [Obsolete("This property is deprecated, use directionAsGetDirectionQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("direction")]
            public string? Direction { get; set; }
#nullable restore
#else
            [QueryParameter("direction")]
            public string Direction { get; set; }
#endif
            /// <summary>The order to sort by. Default: `asc` when using `full_name`, otherwise `desc`.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>The property to sort the results by.</summary>
            [Obsolete("This property is deprecated, use sortAsGetSortQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort")]
            public string? Sort { get; set; }
#nullable restore
#else
            [QueryParameter("sort")]
            public string Sort { get; set; }
#endif
            /// <summary>The property to sort the results by.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>Specifies the types of repositories you want returned.</summary>
            [Obsolete("This property is deprecated, use typeAsGetTypeQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            /// <summary>Specifies the types of repositories you want returned.</summary>
            [QueryParameter("type")]
            public GetTypeQueryParameterType? TypeAsGetTypeQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReposRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReposRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReposRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reposRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReposRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReposRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reposRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ReposRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

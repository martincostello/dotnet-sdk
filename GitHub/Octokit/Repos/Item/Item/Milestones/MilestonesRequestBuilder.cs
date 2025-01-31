// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Repos.Item.Item.Milestones.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Milestones {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\milestones
    /// </summary>
    public class MilestonesRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.milestones.item collection</summary>
        /// <param name="position">The number that identifies the milestone.</param>
        public WithMilestone_numberItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("milestone_number", position);
            return new WithMilestone_numberItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the GitHub.Octokit.repos.item.item.milestones.item collection</summary>
        /// <param name="position">The number that identifies the milestone.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithMilestone_numberItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("milestone_number", position);
            return new WithMilestone_numberItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MilestonesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MilestonesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/milestones{?state*,sort*,direction*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MilestonesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MilestonesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/milestones{?state*,sort*,direction*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists milestones for a repository.
        /// API method documentation <see href="https://docs.github.com/rest/issues/milestones#list-milestones" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Milestone>?> GetAsync(Action<MilestonesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Milestone>> GetAsync(Action<MilestonesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<Milestone>(requestInfo, Milestone.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Creates a milestone.
        /// API method documentation <see href="https://docs.github.com/rest/issues/milestones#create-a-milestone" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Milestone?> PostAsync(MilestonesPostRequestBody body, Action<MilestonesRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Milestone> PostAsync(MilestonesPostRequestBody body, Action<MilestonesRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
                {"422", ValidationError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Milestone>(requestInfo, Milestone.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists milestones for a repository.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MilestonesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MilestonesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MilestonesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Creates a milestone.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(MilestonesPostRequestBody body, Action<MilestonesRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(MilestonesPostRequestBody body, Action<MilestonesRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MilestonesRequestBuilderPostRequestConfiguration();
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
        public MilestonesRequestBuilder WithUrl(string rawUrl) {
            return new MilestonesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists milestones for a repository.
        /// </summary>
        public class MilestonesRequestBuilderGetQueryParameters {
            /// <summary>The direction of the sort. Either `asc` or `desc`.</summary>
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
            /// <summary>The direction of the sort. Either `asc` or `desc`.</summary>
            [QueryParameter("direction")]
            public GetDirectionQueryParameterType? DirectionAsGetDirectionQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
            /// <summary>What to sort results by. Either `due_on` or `completeness`.</summary>
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
            /// <summary>What to sort results by. Either `due_on` or `completeness`.</summary>
            [QueryParameter("sort")]
            public GetSortQueryParameterType? SortAsGetSortQueryParameterType { get; set; }
            /// <summary>The state of the milestone. Either `open`, `closed`, or `all`.</summary>
            [Obsolete("This property is deprecated, use stateAsGetStateQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("state")]
            public string? State { get; set; }
#nullable restore
#else
            [QueryParameter("state")]
            public string State { get; set; }
#endif
            /// <summary>The state of the milestone. Either `open`, `closed`, or `all`.</summary>
            [QueryParameter("state")]
            public GetStateQueryParameterType? StateAsGetStateQueryParameterType { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MilestonesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MilestonesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MilestonesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new milestonesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MilestonesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MilestonesRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new milestonesRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MilestonesRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

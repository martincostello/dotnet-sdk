// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Stats.Punch_card {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\stats\punch_card
    /// </summary>
    public class Punch_cardRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Punch_cardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Punch_cardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/stats/punch_card", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Punch_cardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Punch_cardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/stats/punch_card", rawUrl) {
        }
        /// <summary>
        /// Each array contains the day number, hour number, and number of commits:*   `0-6`: Sunday - Saturday*   `0-23`: Hour of day*   Number of commitsFor example, `[2, 14, 25]` indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.
        /// API method documentation <see href="https://docs.github.com/rest/metrics/statistics#get-the-hourly-commit-count-for-each-day" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<int?>?> GetAsync(Action<Punch_cardRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<int?>> GetAsync(Action<Punch_cardRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendPrimitiveCollectionAsync<int?>(requestInfo, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Each array contains the day number, hour number, and number of commits:*   `0-6`: Sunday - Saturday*   `0-23`: Hour of day*   Number of commitsFor example, `[2, 14, 25]` indicates that there were 25 total commits, during the 2:00pm hour on Tuesdays. All times are based on the time zone of individual commits.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<Punch_cardRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<Punch_cardRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new Punch_cardRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Punch_cardRequestBuilder WithUrl(string rawUrl) {
            return new Punch_cardRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class Punch_cardRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new punch_cardRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public Punch_cardRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

// <auto-generated/>
using GitHub.Octokit.App.Installations.Item.Access_tokens;
using GitHub.Octokit.App.Installations.Item.Suspended;
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.App.Installations.Item {
    /// <summary>
    /// Builds and executes requests for operations under \app\installations\{installation_id}
    /// </summary>
    public class WithInstallation_ItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The access_tokens property</summary>
        public Access_tokensRequestBuilder Access_tokens { get =>
            new Access_tokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The suspended property</summary>
        public SuspendedRequestBuilder Suspended { get =>
            new SuspendedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithInstallation_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInstallation_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/installations/{installation_id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithInstallation_ItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithInstallation_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/app/installations/{installation_id}", rawUrl) {
        }
        /// <summary>
        /// Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app&apos;s access to your account&apos;s resources, then we recommend the &quot;[Suspend an app installation](https://docs.github.com/rest/apps/apps#suspend-an-app-installation)&quot; endpoint.You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/apps/apps#delete-an-installation-for-the-authenticated-app" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WithInstallation_ItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WithInstallation_ItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Enables an authenticated GitHub App to find an installation&apos;s information using the installation id.You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// API method documentation <see href="https://docs.github.com/rest/apps/apps#get-an-installation-for-the-authenticated-app" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GitHub.Octokit.Models.Installation?> GetAsync(Action<WithInstallation_ItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GitHub.Octokit.Models.Installation> GetAsync(Action<WithInstallation_ItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GitHub.Octokit.Models.Installation>(requestInfo, GitHub.Octokit.Models.Installation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app&apos;s access to your account&apos;s resources, then we recommend the &quot;[Suspend an app installation](https://docs.github.com/rest/apps/apps#suspend-an-app-installation)&quot; endpoint.You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WithInstallation_ItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WithInstallation_ItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithInstallation_ItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Enables an authenticated GitHub App to find an installation&apos;s information using the installation id.You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithInstallation_ItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithInstallation_ItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithInstallation_ItemRequestBuilderGetRequestConfiguration();
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
        public WithInstallation_ItemRequestBuilder WithUrl(string rawUrl) {
            return new WithInstallation_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithInstallation_ItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithInstallation_ItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WithInstallation_ItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithInstallation_ItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithInstallation_ItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithInstallation_ItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

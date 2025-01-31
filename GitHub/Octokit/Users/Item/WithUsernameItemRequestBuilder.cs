// <auto-generated/>
using GitHub.Octokit.Models;
using GitHub.Octokit.Users.Item.Docker;
using GitHub.Octokit.Users.Item.Events;
using GitHub.Octokit.Users.Item.Followers;
using GitHub.Octokit.Users.Item.Following;
using GitHub.Octokit.Users.Item.Gists;
using GitHub.Octokit.Users.Item.Gpg_keys;
using GitHub.Octokit.Users.Item.Hovercard;
using GitHub.Octokit.Users.Item.Installation;
using GitHub.Octokit.Users.Item.Keys;
using GitHub.Octokit.Users.Item.Orgs;
using GitHub.Octokit.Users.Item.Packages;
using GitHub.Octokit.Users.Item.Projects;
using GitHub.Octokit.Users.Item.Received_events;
using GitHub.Octokit.Users.Item.Repos;
using GitHub.Octokit.Users.Item.Settings;
using GitHub.Octokit.Users.Item.Social_accounts;
using GitHub.Octokit.Users.Item.Ssh_signing_keys;
using GitHub.Octokit.Users.Item.Starred;
using GitHub.Octokit.Users.Item.Subscriptions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace GitHub.Octokit.Users.Item {
    /// <summary>
    /// Builds and executes requests for operations under \users\{username}
    /// </summary>
    public class WithUsernameItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The docker property</summary>
        public DockerRequestBuilder Docker { get =>
            new DockerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The events property</summary>
        public EventsRequestBuilder Events { get =>
            new EventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The followers property</summary>
        public FollowersRequestBuilder Followers { get =>
            new FollowersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The following property</summary>
        public FollowingRequestBuilder Following { get =>
            new FollowingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gists property</summary>
        public GistsRequestBuilder Gists { get =>
            new GistsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gpg_keys property</summary>
        public Gpg_keysRequestBuilder Gpg_keys { get =>
            new Gpg_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hovercard property</summary>
        public HovercardRequestBuilder Hovercard { get =>
            new HovercardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The installation property</summary>
        public InstallationRequestBuilder Installation { get =>
            new InstallationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The keys property</summary>
        public KeysRequestBuilder Keys { get =>
            new KeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The orgs property</summary>
        public OrgsRequestBuilder Orgs { get =>
            new OrgsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The packages property</summary>
        public PackagesRequestBuilder Packages { get =>
            new PackagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projects property</summary>
        public ProjectsRequestBuilder Projects { get =>
            new ProjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The received_events property</summary>
        public Received_eventsRequestBuilder Received_events { get =>
            new Received_eventsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The repos property</summary>
        public ReposRequestBuilder Repos { get =>
            new ReposRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The social_accounts property</summary>
        public Social_accountsRequestBuilder Social_accounts { get =>
            new Social_accountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ssh_signing_keys property</summary>
        public Ssh_signing_keysRequestBuilder Ssh_signing_keys { get =>
            new Ssh_signing_keysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The starred property</summary>
        public StarredRequestBuilder Starred { get =>
            new StarredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The subscriptions property</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithUsernameItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithUsernameItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithUsernameItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{username}", rawUrl) {
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account.GitHub Apps with the `Plan` user permission can use this endpoint to retrieve information about a user&apos;s GitHub plan. The GitHub App must be authenticated as a user. See &quot;[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)&quot; for details about authentication. For an example response, see &apos;Response with GitHub plan information&apos; below&quot;The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithUsernameGetResponse?> GetAsWithUsernameGetResponseAsync(Action<WithUsernameItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithUsernameGetResponse> GetAsWithUsernameGetResponseAsync(Action<WithUsernameItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithUsernameGetResponse>(requestInfo, WithUsernameGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account.GitHub Apps with the `Plan` user permission can use this endpoint to retrieve information about a user&apos;s GitHub plan. The GitHub App must be authenticated as a user. See &quot;[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)&quot; for details about authentication. For an example response, see &apos;Response with GitHub plan information&apos; below&quot;The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// API method documentation <see href="https://docs.github.com/rest/users/users#get-a-user" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("This method is obsolete. Use GetAsWithUsernameGetResponse instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WithUsernameResponse?> GetAsync(Action<WithUsernameItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WithUsernameResponse> GetAsync(Action<WithUsernameItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"404", BasicError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WithUsernameResponse>(requestInfo, WithUsernameResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides publicly available information about someone with a GitHub account.GitHub Apps with the `Plan` user permission can use this endpoint to retrieve information about a user&apos;s GitHub plan. The GitHub App must be authenticated as a user. See &quot;[Identifying and authorizing users for GitHub Apps](https://docs.github.com/apps/building-github-apps/identifying-and-authorizing-users-for-github-apps/)&quot; for details about authentication. For an example response, see &apos;Response with GitHub plan information&apos; below&quot;The `email` key in the following response is the publicly visible email address from your GitHub [profile page](https://github.com/settings/profile). When setting up your profile, you can select a primary email address to be “public” which provides an email entry for this endpoint. If you do not set a public email address for `email`, then it will have a value of `null`. You only see publicly visible email addresses when authenticated with GitHub. For more information, see [Authentication](https://docs.github.com/rest/overview/resources-in-the-rest-api#authentication).The Emails API enables you to list all of your email addresses, and toggle a primary email to be visible publicly. For more information, see &quot;[Emails API](https://docs.github.com/rest/users/emails)&quot;.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithUsernameItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithUsernameItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithUsernameItemRequestBuilderGetRequestConfiguration();
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
        public WithUsernameItemRequestBuilder WithUrl(string rawUrl) {
            return new WithUsernameItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes privateUser, publicUser
        /// </summary>
        public class WithUsernameGetResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type privateUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type publicUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static WithUsernameGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new WithUsernameGetResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PrivateUser = new GitHub.Octokit.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PublicUser = new GitHub.Octokit.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(PrivateUser != null) {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null) {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PublicUser>(null, PublicUser);
                }
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithUsernameItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithUsernameItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithUsernameItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Composed type wrapper for classes privateUser, publicUser
        /// </summary>
        public class WithUsernameResponse : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type privateUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PrivateUser? PrivateUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PrivateUser PrivateUser { get; set; }
#endif
            /// <summary>Composed type representation for type publicUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.PublicUser? PublicUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.PublicUser PublicUser { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static WithUsernameResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new WithUsernameResponse();
                if("private-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PrivateUser = new GitHub.Octokit.Models.PrivateUser();
                }
                else if("public-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.PublicUser = new GitHub.Octokit.Models.PublicUser();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(PrivateUser != null) {
                    return PrivateUser.GetFieldDeserializers();
                }
                else if(PublicUser != null) {
                    return PublicUser.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(PrivateUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PrivateUser>(null, PrivateUser);
                }
                else if(PublicUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.PublicUser>(null, PublicUser);
                }
            }
        }
    }
}

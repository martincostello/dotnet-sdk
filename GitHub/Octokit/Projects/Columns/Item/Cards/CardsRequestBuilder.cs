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
namespace GitHub.Octokit.Projects.Columns.Item.Cards {
    /// <summary>
    /// Builds and executes requests for operations under \projects\columns\{column_id}\cards
    /// </summary>
    public class CardsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new CardsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/{column_id}/cards{?archived_state*,per_page*,page*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CardsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/projects/columns/{column_id}/cards{?archived_state*,per_page*,page*}", rawUrl) {
        }
        /// <summary>
        /// Lists the project cards in a project.
        /// API method documentation <see href="https://docs.github.com/rest/projects/cards#list-project-cards" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<ProjectCard>?> GetAsync(Action<CardsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<ProjectCard>> GetAsync(Action<CardsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<ProjectCard>(requestInfo, ProjectCard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Create a project card
        /// API method documentation <see href="https://docs.github.com/rest/projects/cards#create-a-project-card" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ProjectCard?> PostAsync(CardsPostRequestBody body, Action<CardsRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ProjectCard> PostAsync(CardsPostRequestBody body, Action<CardsRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"401", BasicError.CreateFromDiscriminatorValue},
                {"403", BasicError.CreateFromDiscriminatorValue},
                {"422", ProjectCard422Error.CreateFromDiscriminatorValue},
                {"503", ProjectCard503Error.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ProjectCard>(requestInfo, ProjectCard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists the project cards in a project.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<CardsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<CardsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CardsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CardsPostRequestBody body, Action<CardsRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CardsPostRequestBody body, Action<CardsRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new CardsRequestBuilderPostRequestConfiguration();
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
        public CardsRequestBuilder WithUrl(string rawUrl) {
            return new CardsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Composed type wrapper for classes cardsPostRequestBodyMember1, cardsPostRequestBodyMember2
        /// </summary>
        public class CardsPostRequestBody : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type cardsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1? CardsPostRequestBodyCardsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1 CardsPostRequestBodyCardsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type cardsPostRequestBodyMember2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2? CardsPostRequestBodyCardsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2 CardsPostRequestBodyCardsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>Composed type representation for type cardsPostRequestBodyMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1? CardsPostRequestBodyMember1 { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1 CardsPostRequestBodyMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type cardsPostRequestBodyMember2</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2? CardsPostRequestBodyMember2 { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2 CardsPostRequestBodyMember2 { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static CardsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new CardsPostRequestBody();
                if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.CardsPostRequestBodyCardsPostRequestBodyMember1 = new GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.CardsPostRequestBodyCardsPostRequestBodyMember2 = new GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.CardsPostRequestBodyMember1 = new GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1();
                }
                else if("".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.CardsPostRequestBodyMember2 = new GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(CardsPostRequestBodyCardsPostRequestBodyMember1 != null) {
                    return CardsPostRequestBodyCardsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CardsPostRequestBodyCardsPostRequestBodyMember2 != null) {
                    return CardsPostRequestBodyCardsPostRequestBodyMember2.GetFieldDeserializers();
                }
                else if(CardsPostRequestBodyMember1 != null) {
                    return CardsPostRequestBodyMember1.GetFieldDeserializers();
                }
                else if(CardsPostRequestBodyMember2 != null) {
                    return CardsPostRequestBodyMember2.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(CardsPostRequestBodyCardsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1>(null, CardsPostRequestBodyCardsPostRequestBodyMember1);
                }
                else if(CardsPostRequestBodyCardsPostRequestBodyMember2 != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2>(null, CardsPostRequestBodyCardsPostRequestBodyMember2);
                }
                else if(CardsPostRequestBodyMember1 != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember1>(null, CardsPostRequestBodyMember1);
                }
                else if(CardsPostRequestBodyMember2 != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Projects.Columns.Item.Cards.CardsPostRequestBodyMember2>(null, CardsPostRequestBodyMember2);
                }
            }
        }
        /// <summary>
        /// Lists the project cards in a project.
        /// </summary>
        public class CardsRequestBuilderGetQueryParameters {
            /// <summary>Filters the project cards that are returned by the card&apos;s state.</summary>
            [Obsolete("This property is deprecated, use archived_stateAsGetArchived_stateQueryParameterType instead")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("archived_state")]
            public string? ArchivedState { get; set; }
#nullable restore
#else
            [QueryParameter("archived_state")]
            public string ArchivedState { get; set; }
#endif
            /// <summary>Filters the project cards that are returned by the card&apos;s state.</summary>
            [QueryParameter("archived_state")]
            public GetArchived_stateQueryParameterType? ArchivedStateAsGetArchivedStateQueryParameterType { get; set; }
            /// <summary>Page number of the results to fetch.</summary>
            [QueryParameter("page")]
            public int? Page { get; set; }
            /// <summary>The number of results per page (max 100).</summary>
            [QueryParameter("per_page")]
            public int? PerPage { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CardsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public CardsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CardsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new cardsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CardsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class CardsRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new cardsRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public CardsRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Composed type wrapper for classes validationError, validationErrorSimple
        /// </summary>
        public class ProjectCard422Error : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type validationError</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ValidationError? ValidationError { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ValidationError ValidationError { get; set; }
#endif
            /// <summary>Composed type representation for type validationErrorSimple</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.ValidationErrorSimple? ValidationErrorSimple { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.ValidationErrorSimple ValidationErrorSimple { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static ProjectCard422Error CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new ProjectCard422Error();
                if("validation-error".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ValidationError = new GitHub.Octokit.Models.ValidationError();
                }
                else if("validation-error-simple".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.ValidationErrorSimple = new GitHub.Octokit.Models.ValidationErrorSimple();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(ValidationError != null) {
                    return ValidationError.GetFieldDeserializers();
                }
                else if(ValidationErrorSimple != null) {
                    return ValidationErrorSimple.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(ValidationError != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.ValidationError>(null, ValidationError);
                }
                else if(ValidationErrorSimple != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.ValidationErrorSimple>(null, ValidationErrorSimple);
                }
            }
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Timeline Comment Event
    /// </summary>
    public class TimelineCommentEvent : IAdditionalDataHolder, IParsable {
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? Actor { get; set; }
#nullable restore
#else
        public SimpleUser Actor { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Octokit.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>Contents of the issue comment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The body_html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyHtml { get; set; }
#nullable restore
#else
        public string BodyHtml { get; set; }
#endif
        /// <summary>The body_text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>Unique identifier of the issue comment</summary>
        public int? Id { get; set; }
        /// <summary>The issue_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueUrl { get; set; }
#nullable restore
#else
        public string IssueUrl { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>GitHub apps are a new way to extend GitHub. They can be installed directly on organizations and user accounts and granted access to specific repositories. They come with granular permissions and built-in webhooks. GitHub apps are first class actors within GitHub.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableIntegration? PerformedViaGithubApp { get; set; }
#nullable restore
#else
        public NullableIntegration PerformedViaGithubApp { get; set; }
#endif
        /// <summary>The reactions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ReactionRollup? Reactions { get; set; }
#nullable restore
#else
        public ReactionRollup Reactions { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>URL for the issue comment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? User { get; set; }
#nullable restore
#else
        public SimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new timelineCommentEvent and sets the default values.
        /// </summary>
        public TimelineCommentEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimelineCommentEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimelineCommentEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actor", n => { Actor = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"body_html", n => { BodyHtml = n.GetStringValue(); } },
                {"body_text", n => { BodyText = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"issue_url", n => { IssueUrl = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"performed_via_github_app", n => { PerformedViaGithubApp = n.GetObjectValue<NullableIntegration>(NullableIntegration.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetObjectValue<ReactionRollup>(ReactionRollup.CreateFromDiscriminatorValue); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SimpleUser>("actor", Actor);
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteStringValue("body", Body);
            writer.WriteStringValue("body_html", BodyHtml);
            writer.WriteStringValue("body_text", BodyText);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("event", Event);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issue_url", IssueUrl);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteObjectValue<NullableIntegration>("performed_via_github_app", PerformedViaGithubApp);
            writer.WriteObjectValue<ReactionRollup>("reactions", Reactions);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<SimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

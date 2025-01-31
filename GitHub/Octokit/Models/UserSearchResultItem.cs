// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// User Search Result Item
    /// </summary>
    public class UserSearchResultItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The avatar_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarUrl { get; set; }
#nullable restore
#else
        public string AvatarUrl { get; set; }
#endif
        /// <summary>The bio property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Bio { get; set; }
#nullable restore
#else
        public string Bio { get; set; }
#endif
        /// <summary>The blog property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Blog { get; set; }
#nullable restore
#else
        public string Blog { get; set; }
#endif
        /// <summary>The company property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventsUrl { get; set; }
#nullable restore
#else
        public string EventsUrl { get; set; }
#endif
        /// <summary>The followers property</summary>
        public int? Followers { get; set; }
        /// <summary>The followers_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FollowersUrl { get; set; }
#nullable restore
#else
        public string FollowersUrl { get; set; }
#endif
        /// <summary>The following property</summary>
        public int? Following { get; set; }
        /// <summary>The following_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FollowingUrl { get; set; }
#nullable restore
#else
        public string FollowingUrl { get; set; }
#endif
        /// <summary>The gists_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GistsUrl { get; set; }
#nullable restore
#else
        public string GistsUrl { get; set; }
#endif
        /// <summary>The gravatar_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GravatarId { get; set; }
#nullable restore
#else
        public string GravatarId { get; set; }
#endif
        /// <summary>The hireable property</summary>
        public bool? Hireable { get; set; }
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The location property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login { get; set; }
#nullable restore
#else
        public string Login { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The organizations_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationsUrl { get; set; }
#nullable restore
#else
        public string OrganizationsUrl { get; set; }
#endif
        /// <summary>The public_gists property</summary>
        public int? PublicGists { get; set; }
        /// <summary>The public_repos property</summary>
        public int? PublicRepos { get; set; }
        /// <summary>The received_events_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReceivedEventsUrl { get; set; }
#nullable restore
#else
        public string ReceivedEventsUrl { get; set; }
#endif
        /// <summary>The repos_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReposUrl { get; set; }
#nullable restore
#else
        public string ReposUrl { get; set; }
#endif
        /// <summary>The score property</summary>
        public double? Score { get; set; }
        /// <summary>The site_admin property</summary>
        public bool? SiteAdmin { get; set; }
        /// <summary>The starred_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StarredUrl { get; set; }
#nullable restore
#else
        public string StarredUrl { get; set; }
#endif
        /// <summary>The subscriptions_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionsUrl { get; set; }
#nullable restore
#else
        public string SubscriptionsUrl { get; set; }
#endif
        /// <summary>The suspended_at property</summary>
        public DateTimeOffset? SuspendedAt { get; set; }
        /// <summary>The text_matches property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Users>? TextMatches { get; set; }
#nullable restore
#else
        public List<Users> TextMatches { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The updated_at property</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new userSearchResultItem and sets the default values.
        /// </summary>
        public UserSearchResultItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSearchResultItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSearchResultItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"avatar_url", n => { AvatarUrl = n.GetStringValue(); } },
                {"bio", n => { Bio = n.GetStringValue(); } },
                {"blog", n => { Blog = n.GetStringValue(); } },
                {"company", n => { Company = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"events_url", n => { EventsUrl = n.GetStringValue(); } },
                {"followers", n => { Followers = n.GetIntValue(); } },
                {"followers_url", n => { FollowersUrl = n.GetStringValue(); } },
                {"following", n => { Following = n.GetIntValue(); } },
                {"following_url", n => { FollowingUrl = n.GetStringValue(); } },
                {"gists_url", n => { GistsUrl = n.GetStringValue(); } },
                {"gravatar_id", n => { GravatarId = n.GetStringValue(); } },
                {"hireable", n => { Hireable = n.GetBoolValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"location", n => { Location = n.GetStringValue(); } },
                {"login", n => { Login = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"organizations_url", n => { OrganizationsUrl = n.GetStringValue(); } },
                {"public_gists", n => { PublicGists = n.GetIntValue(); } },
                {"public_repos", n => { PublicRepos = n.GetIntValue(); } },
                {"received_events_url", n => { ReceivedEventsUrl = n.GetStringValue(); } },
                {"repos_url", n => { ReposUrl = n.GetStringValue(); } },
                {"score", n => { Score = n.GetDoubleValue(); } },
                {"site_admin", n => { SiteAdmin = n.GetBoolValue(); } },
                {"starred_url", n => { StarredUrl = n.GetStringValue(); } },
                {"subscriptions_url", n => { SubscriptionsUrl = n.GetStringValue(); } },
                {"suspended_at", n => { SuspendedAt = n.GetDateTimeOffsetValue(); } },
                {"text_matches", n => { TextMatches = n.GetCollectionOfObjectValues<Users>(Users.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("avatar_url", AvatarUrl);
            writer.WriteStringValue("bio", Bio);
            writer.WriteStringValue("blog", Blog);
            writer.WriteStringValue("company", Company);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("events_url", EventsUrl);
            writer.WriteIntValue("followers", Followers);
            writer.WriteStringValue("followers_url", FollowersUrl);
            writer.WriteIntValue("following", Following);
            writer.WriteStringValue("following_url", FollowingUrl);
            writer.WriteStringValue("gists_url", GistsUrl);
            writer.WriteStringValue("gravatar_id", GravatarId);
            writer.WriteBoolValue("hireable", Hireable);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("location", Location);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteStringValue("organizations_url", OrganizationsUrl);
            writer.WriteIntValue("public_gists", PublicGists);
            writer.WriteIntValue("public_repos", PublicRepos);
            writer.WriteStringValue("received_events_url", ReceivedEventsUrl);
            writer.WriteStringValue("repos_url", ReposUrl);
            writer.WriteDoubleValue("score", Score);
            writer.WriteBoolValue("site_admin", SiteAdmin);
            writer.WriteStringValue("starred_url", StarredUrl);
            writer.WriteStringValue("subscriptions_url", SubscriptionsUrl);
            writer.WriteDateTimeOffsetValue("suspended_at", SuspendedAt);
            writer.WriteCollectionOfObjectValues<Users>("text_matches", TextMatches);
            writer.WriteStringValue("type", Type);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

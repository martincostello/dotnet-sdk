// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Pull Request Simple
    /// </summary>
    public class PullRequestSimple : IAdditionalDataHolder, IParsable {
        /// <summary>The active_lock_reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveLockReason { get; set; }
#nullable restore
#else
        public string ActiveLockReason { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? Assignee { get; set; }
#nullable restore
#else
        public NullableSimpleUser Assignee { get; set; }
#endif
        /// <summary>The assignees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? Assignees { get; set; }
#nullable restore
#else
        public List<SimpleUser> Assignees { get; set; }
#endif
        /// <summary>How the author is associated with the repository.</summary>
        public GitHub.Octokit.Models.AuthorAssociation? AuthorAssociation { get; set; }
        /// <summary>The status of auto merging a pull request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHub.Octokit.Models.AutoMerge? AutoMerge { get; set; }
#nullable restore
#else
        public GitHub.Octokit.Models.AutoMerge AutoMerge { get; set; }
#endif
        /// <summary>The base property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequestSimple_base? Base { get; set; }
#nullable restore
#else
        public PullRequestSimple_base Base { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Body { get; set; }
#nullable restore
#else
        public string Body { get; set; }
#endif
        /// <summary>The closed_at property</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentsUrl { get; set; }
#nullable restore
#else
        public string CommentsUrl { get; set; }
#endif
        /// <summary>The commits_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitsUrl { get; set; }
#nullable restore
#else
        public string CommitsUrl { get; set; }
#endif
        /// <summary>The created_at property</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The diff_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DiffUrl { get; set; }
#nullable restore
#else
        public string DiffUrl { get; set; }
#endif
        /// <summary>Indicates whether or not the pull request is a draft.</summary>
        public bool? Draft { get; set; }
        /// <summary>The head property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequestSimple_head? Head { get; set; }
#nullable restore
#else
        public PullRequestSimple_head Head { get; set; }
#endif
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
        /// <summary>The issue_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueUrl { get; set; }
#nullable restore
#else
        public string IssueUrl { get; set; }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PullRequestSimple_labels>? Labels { get; set; }
#nullable restore
#else
        public List<PullRequestSimple_labels> Labels { get; set; }
#endif
        /// <summary>The _links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PullRequestSimple__links? Links { get; set; }
#nullable restore
#else
        public PullRequestSimple__links Links { get; set; }
#endif
        /// <summary>The locked property</summary>
        public bool? Locked { get; set; }
        /// <summary>The merge_commit_sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MergeCommitSha { get; set; }
#nullable restore
#else
        public string MergeCommitSha { get; set; }
#endif
        /// <summary>The merged_at property</summary>
        public DateTimeOffset? MergedAt { get; set; }
        /// <summary>A collection of related issues and pull requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableMilestone? Milestone { get; set; }
#nullable restore
#else
        public NullableMilestone Milestone { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>The number property</summary>
        public int? Number { get; set; }
        /// <summary>The patch_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatchUrl { get; set; }
#nullable restore
#else
        public string PatchUrl { get; set; }
#endif
        /// <summary>The requested_reviewers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleUser>? RequestedReviewers { get; set; }
#nullable restore
#else
        public List<SimpleUser> RequestedReviewers { get; set; }
#endif
        /// <summary>The requested_teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Team>? RequestedTeams { get; set; }
#nullable restore
#else
        public List<Team> RequestedTeams { get; set; }
#endif
        /// <summary>The review_comments_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCommentsUrl { get; set; }
#nullable restore
#else
        public string ReviewCommentsUrl { get; set; }
#endif
        /// <summary>The review_comment_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReviewCommentUrl { get; set; }
#nullable restore
#else
        public string ReviewCommentUrl { get; set; }
#endif
        /// <summary>The state property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>The statuses_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusesUrl { get; set; }
#nullable restore
#else
        public string StatusesUrl { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
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
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? User { get; set; }
#nullable restore
#else
        public NullableSimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pullRequestSimple and sets the default values.
        /// </summary>
        public PullRequestSimple() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequestSimple CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequestSimple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"active_lock_reason", n => { ActiveLockReason = n.GetStringValue(); } },
                {"assignee", n => { Assignee = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"assignees", n => { Assignees = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"author_association", n => { AuthorAssociation = n.GetEnumValue<AuthorAssociation>(); } },
                {"auto_merge", n => { AutoMerge = n.GetObjectValue<GitHub.Octokit.Models.AutoMerge>(GitHub.Octokit.Models.AutoMerge.CreateFromDiscriminatorValue); } },
                {"base", n => { Base = n.GetObjectValue<PullRequestSimple_base>(PullRequestSimple_base.CreateFromDiscriminatorValue); } },
                {"body", n => { Body = n.GetStringValue(); } },
                {"closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                {"comments_url", n => { CommentsUrl = n.GetStringValue(); } },
                {"commits_url", n => { CommitsUrl = n.GetStringValue(); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"diff_url", n => { DiffUrl = n.GetStringValue(); } },
                {"draft", n => { Draft = n.GetBoolValue(); } },
                {"head", n => { Head = n.GetObjectValue<PullRequestSimple_head>(PullRequestSimple_head.CreateFromDiscriminatorValue); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"issue_url", n => { IssueUrl = n.GetStringValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<PullRequestSimple_labels>(PullRequestSimple_labels.CreateFromDiscriminatorValue)?.ToList(); } },
                {"_links", n => { Links = n.GetObjectValue<PullRequestSimple__links>(PullRequestSimple__links.CreateFromDiscriminatorValue); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
                {"merge_commit_sha", n => { MergeCommitSha = n.GetStringValue(); } },
                {"merged_at", n => { MergedAt = n.GetDateTimeOffsetValue(); } },
                {"milestone", n => { Milestone = n.GetObjectValue<NullableMilestone>(NullableMilestone.CreateFromDiscriminatorValue); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
                {"number", n => { Number = n.GetIntValue(); } },
                {"patch_url", n => { PatchUrl = n.GetStringValue(); } },
                {"requested_reviewers", n => { RequestedReviewers = n.GetCollectionOfObjectValues<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"requested_teams", n => { RequestedTeams = n.GetCollectionOfObjectValues<Team>(Team.CreateFromDiscriminatorValue)?.ToList(); } },
                {"review_comment_url", n => { ReviewCommentUrl = n.GetStringValue(); } },
                {"review_comments_url", n => { ReviewCommentsUrl = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"statuses_url", n => { StatusesUrl = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("active_lock_reason", ActiveLockReason);
            writer.WriteObjectValue<NullableSimpleUser>("assignee", Assignee);
            writer.WriteCollectionOfObjectValues<SimpleUser>("assignees", Assignees);
            writer.WriteEnumValue<AuthorAssociation>("author_association", AuthorAssociation);
            writer.WriteObjectValue<GitHub.Octokit.Models.AutoMerge>("auto_merge", AutoMerge);
            writer.WriteObjectValue<PullRequestSimple_base>("base", Base);
            writer.WriteStringValue("body", Body);
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteStringValue("comments_url", CommentsUrl);
            writer.WriteStringValue("commits_url", CommitsUrl);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("diff_url", DiffUrl);
            writer.WriteBoolValue("draft", Draft);
            writer.WriteObjectValue<PullRequestSimple_head>("head", Head);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("issue_url", IssueUrl);
            writer.WriteCollectionOfObjectValues<PullRequestSimple_labels>("labels", Labels);
            writer.WriteObjectValue<PullRequestSimple__links>("_links", Links);
            writer.WriteBoolValue("locked", Locked);
            writer.WriteStringValue("merge_commit_sha", MergeCommitSha);
            writer.WriteDateTimeOffsetValue("merged_at", MergedAt);
            writer.WriteObjectValue<NullableMilestone>("milestone", Milestone);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("number", Number);
            writer.WriteStringValue("patch_url", PatchUrl);
            writer.WriteCollectionOfObjectValues<SimpleUser>("requested_reviewers", RequestedReviewers);
            writer.WriteCollectionOfObjectValues<Team>("requested_teams", RequestedTeams);
            writer.WriteStringValue("review_comments_url", ReviewCommentsUrl);
            writer.WriteStringValue("review_comment_url", ReviewCommentUrl);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("statuses_url", StatusesUrl);
            writer.WriteStringValue("title", Title);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

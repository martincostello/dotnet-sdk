// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Information about a Copilot Business seat assignment for a user, team, or organization.
    /// </summary>
    public class CopilotSeatDetails : IParsable {
        /// <summary>The assignee that has been granted access to GitHub Copilot.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CopilotSeatDetails_assignee? Assignee { get; set; }
#nullable restore
#else
        public CopilotSeatDetails_assignee Assignee { get; set; }
#endif
        /// <summary>The team that granted access to GitHub Copilot to the assignee. This will be null if the user was assigned a seat individually.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Team? AssigningTeam { get; set; }
#nullable restore
#else
        public Team AssigningTeam { get; set; }
#endif
        /// <summary>Timestamp of when the assignee was last granted access to GitHub Copilot, in ISO 8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>Timestamp of user&apos;s last GitHub Copilot activity, in ISO 8601 format.</summary>
        public DateTimeOffset? LastActivityAt { get; set; }
        /// <summary>Last editor that was used by the user for a GitHub Copilot completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActivityEditor { get; set; }
#nullable restore
#else
        public string LastActivityEditor { get; set; }
#endif
        /// <summary>The pending cancellation date for the seat, in `YYYY-MM-DD` format. This will be null unless the assignee&apos;s Copilot access has been canceled during the current billing cycle. If the seat has been cancelled, this corresponds to the start of the organization&apos;s next billing cycle.</summary>
        public Date? PendingCancellationDate { get; set; }
        /// <summary>Timestamp of when the assignee&apos;s GitHub Copilot access was last updated, in ISO 8601 format.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CopilotSeatDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopilotSeatDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignee", n => { Assignee = n.GetObjectValue<CopilotSeatDetails_assignee>(CopilotSeatDetails_assignee.CreateFromDiscriminatorValue); } },
                {"assigning_team", n => { AssigningTeam = n.GetObjectValue<Team>(Team.CreateFromDiscriminatorValue); } },
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"last_activity_at", n => { LastActivityAt = n.GetDateTimeOffsetValue(); } },
                {"last_activity_editor", n => { LastActivityEditor = n.GetStringValue(); } },
                {"pending_cancellation_date", n => { PendingCancellationDate = n.GetDateValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<CopilotSeatDetails_assignee>("assignee", Assignee);
            writer.WriteObjectValue<Team>("assigning_team", AssigningTeam);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteDateTimeOffsetValue("last_activity_at", LastActivityAt);
            writer.WriteStringValue("last_activity_editor", LastActivityEditor);
            writer.WriteDateValue("pending_cancellation_date", PendingCancellationDate);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
        }
        /// <summary>
        /// Composed type wrapper for classes organization, simpleUser, team
        /// </summary>
        public class CopilotSeatDetails_assignee : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.Organization? Organization { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.Organization Organization { get; set; }
#endif
            /// <summary>Composed type representation for type simpleUser</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.SimpleUser? SimpleUser { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.SimpleUser SimpleUser { get; set; }
#endif
            /// <summary>Composed type representation for type team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public GitHub.Octokit.Models.Team? Team { get; set; }
#nullable restore
#else
            public GitHub.Octokit.Models.Team Team { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static CopilotSeatDetails_assignee CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var mappingValue = parseNode.GetChildNode("")?.GetStringValue();
                var result = new CopilotSeatDetails_assignee();
                if("organization".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.Organization = new GitHub.Octokit.Models.Organization();
                }
                else if("simple-user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.SimpleUser = new GitHub.Octokit.Models.SimpleUser();
                }
                else if("team".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                    result.Team = new GitHub.Octokit.Models.Team();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(Organization != null) {
                    return Organization.GetFieldDeserializers();
                }
                else if(SimpleUser != null) {
                    return SimpleUser.GetFieldDeserializers();
                }
                else if(Team != null) {
                    return Team.GetFieldDeserializers();
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(Organization != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.Organization>(null, Organization);
                }
                else if(SimpleUser != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.SimpleUser>(null, SimpleUser);
                }
                else if(Team != null) {
                    writer.WriteObjectValue<GitHub.Octokit.Models.Team>(null, Team);
                }
            }
        }
    }
}

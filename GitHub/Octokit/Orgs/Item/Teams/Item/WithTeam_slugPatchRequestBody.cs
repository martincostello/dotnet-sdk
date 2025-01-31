// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Orgs.Item.Teams.Item {
    public class WithTeam_slugPatchRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are:  * `notifications_enabled` - team members receive notifications when the team is @mentioned.   * `notifications_disabled` - no one receives notifications.</summary>
        public WithTeam_slugPatchRequestBody_notification_setting? NotificationSetting { get; set; }
        /// <summary>The ID of a team to set as the parent team.</summary>
        public int? ParentTeamId { get; set; }
        /// <summary>**Deprecated**. The permission that new repositories will be added to the team with when none is specified.</summary>
        public WithTeam_slugPatchRequestBody_permission? Permission { get; set; }
        /// <summary>The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  **For a non-nested team:**   * `secret` - only visible to organization owners and members of this team.   * `closed` - visible to all members of this organization.  **For a parent or child team:**   * `closed` - visible to all members of this organization.</summary>
        public WithTeam_slugPatchRequestBody_privacy? Privacy { get; set; }
        /// <summary>
        /// Instantiates a new WithTeam_slugPatchRequestBody and sets the default values.
        /// </summary>
        public WithTeam_slugPatchRequestBody() {
            AdditionalData = new Dictionary<string, object>();
            Permission = WithTeam_slugPatchRequestBody_permission.Pull;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithTeam_slugPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithTeam_slugPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notification_setting", n => { NotificationSetting = n.GetEnumValue<WithTeam_slugPatchRequestBody_notification_setting>(); } },
                {"parent_team_id", n => { ParentTeamId = n.GetIntValue(); } },
                {"permission", n => { Permission = n.GetEnumValue<WithTeam_slugPatchRequestBody_permission>(); } },
                {"privacy", n => { Privacy = n.GetEnumValue<WithTeam_slugPatchRequestBody_privacy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<WithTeam_slugPatchRequestBody_notification_setting>("notification_setting", NotificationSetting);
            writer.WriteIntValue("parent_team_id", ParentTeamId);
            writer.WriteEnumValue<WithTeam_slugPatchRequestBody_permission>("permission", Permission);
            writer.WriteEnumValue<WithTeam_slugPatchRequestBody_privacy>("privacy", Privacy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

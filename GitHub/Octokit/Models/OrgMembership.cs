// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Org Membership
    /// </summary>
    public class OrgMembership : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrganizationSimple? Organization { get; set; }
#nullable restore
#else
        public OrganizationSimple Organization { get; set; }
#endif
        /// <summary>The organization_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationUrl { get; set; }
#nullable restore
#else
        public string OrganizationUrl { get; set; }
#endif
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrgMembership_permissions? Permissions { get; set; }
#nullable restore
#else
        public OrgMembership_permissions Permissions { get; set; }
#endif
        /// <summary>The user&apos;s membership type in the organization.</summary>
        public OrgMembership_role? Role { get; set; }
        /// <summary>The state of the member in the organization. The `pending` state indicates the user has not yet accepted an invitation.</summary>
        public OrgMembership_state? State { get; set; }
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
        /// Instantiates a new orgMembership and sets the default values.
        /// </summary>
        public OrgMembership() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrgMembership CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrgMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"organization", n => { Organization = n.GetObjectValue<OrganizationSimple>(OrganizationSimple.CreateFromDiscriminatorValue); } },
                {"organization_url", n => { OrganizationUrl = n.GetStringValue(); } },
                {"permissions", n => { Permissions = n.GetObjectValue<OrgMembership_permissions>(OrgMembership_permissions.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetEnumValue<OrgMembership_role>(); } },
                {"state", n => { State = n.GetEnumValue<OrgMembership_state>(); } },
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
            writer.WriteObjectValue<OrganizationSimple>("organization", Organization);
            writer.WriteStringValue("organization_url", OrganizationUrl);
            writer.WriteObjectValue<OrgMembership_permissions>("permissions", Permissions);
            writer.WriteEnumValue<OrgMembership_role>("role", Role);
            writer.WriteEnumValue<OrgMembership_state>("state", State);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<NullableSimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

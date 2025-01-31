// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Branch Restriction Policy
    /// </summary>
    public class BranchRestrictionPolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The apps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BranchRestrictionPolicy_apps>? Apps { get; set; }
#nullable restore
#else
        public List<BranchRestrictionPolicy_apps> Apps { get; set; }
#endif
        /// <summary>The apps_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppsUrl { get; set; }
#nullable restore
#else
        public string AppsUrl { get; set; }
#endif
        /// <summary>The teams property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BranchRestrictionPolicy_teams>? Teams { get; set; }
#nullable restore
#else
        public List<BranchRestrictionPolicy_teams> Teams { get; set; }
#endif
        /// <summary>The teams_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsUrl { get; set; }
#nullable restore
#else
        public string TeamsUrl { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BranchRestrictionPolicy_users>? Users { get; set; }
#nullable restore
#else
        public List<BranchRestrictionPolicy_users> Users { get; set; }
#endif
        /// <summary>The users_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UsersUrl { get; set; }
#nullable restore
#else
        public string UsersUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new branchRestrictionPolicy and sets the default values.
        /// </summary>
        public BranchRestrictionPolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BranchRestrictionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BranchRestrictionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<BranchRestrictionPolicy_apps>(BranchRestrictionPolicy_apps.CreateFromDiscriminatorValue)?.ToList(); } },
                {"apps_url", n => { AppsUrl = n.GetStringValue(); } },
                {"teams", n => { Teams = n.GetCollectionOfObjectValues<BranchRestrictionPolicy_teams>(BranchRestrictionPolicy_teams.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teams_url", n => { TeamsUrl = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<BranchRestrictionPolicy_users>(BranchRestrictionPolicy_users.CreateFromDiscriminatorValue)?.ToList(); } },
                {"users_url", n => { UsersUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<BranchRestrictionPolicy_apps>("apps", Apps);
            writer.WriteStringValue("apps_url", AppsUrl);
            writer.WriteCollectionOfObjectValues<BranchRestrictionPolicy_teams>("teams", Teams);
            writer.WriteStringValue("teams_url", TeamsUrl);
            writer.WriteStringValue("url", Url);
            writer.WriteCollectionOfObjectValues<BranchRestrictionPolicy_users>("users", Users);
            writer.WriteStringValue("users_url", UsersUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

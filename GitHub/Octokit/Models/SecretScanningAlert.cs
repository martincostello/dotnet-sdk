// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class SecretScanningAlert : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The time that the alert was created in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? CreatedAt { get; private set; }
        /// <summary>The GitHub URL of the alert resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; private set; }
#nullable restore
#else
        public string HtmlUrl { get; private set; }
#endif
        /// <summary>The REST API URL of the code locations for this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocationsUrl { get; set; }
#nullable restore
#else
        public string LocationsUrl { get; set; }
#endif
        /// <summary>The security alert number.</summary>
        public int? Number { get; private set; }
        /// <summary>Whether push protection was bypassed for the detected secret.</summary>
        public bool? PushProtectionBypassed { get; set; }
        /// <summary>The time that push protection was bypassed in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? PushProtectionBypassedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? PushProtectionBypassedBy { get; set; }
#nullable restore
#else
        public NullableSimpleUser PushProtectionBypassedBy { get; set; }
#endif
        /// <summary>**Required when the `state` is `resolved`.** The reason for resolving the alert.</summary>
        public SecretScanningAlertResolution? Resolution { get; set; }
        /// <summary>An optional comment to resolve an alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResolutionComment { get; set; }
#nullable restore
#else
        public string ResolutionComment { get; set; }
#endif
        /// <summary>The time that the alert was resolved in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? ResolvedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NullableSimpleUser? ResolvedBy { get; set; }
#nullable restore
#else
        public NullableSimpleUser ResolvedBy { get; set; }
#endif
        /// <summary>The secret that was detected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Secret { get; set; }
#nullable restore
#else
        public string Secret { get; set; }
#endif
        /// <summary>The type of secret that secret scanning detected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretType { get; set; }
#nullable restore
#else
        public string SecretType { get; set; }
#endif
        /// <summary>User-friendly name for the detected secret, matching the `secret_type`.For a list of built-in patterns, see &quot;[Secret scanning patterns](https://docs.github.com/code-security/secret-scanning/secret-scanning-patterns#supported-secrets-for-advanced-security).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecretTypeDisplayName { get; set; }
#nullable restore
#else
        public string SecretTypeDisplayName { get; set; }
#endif
        /// <summary>Sets the state of the secret scanning alert. You must provide `resolution` when you set the state to `resolved`.</summary>
        public SecretScanningAlertState? State { get; set; }
        /// <summary>The time that the alert was last updated in ISO 8601 format: `YYYY-MM-DDTHH:MM:SSZ`.</summary>
        public DateTimeOffset? UpdatedAt { get; private set; }
        /// <summary>The REST API URL of the alert resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>The token status as of the latest validity check.</summary>
        public SecretScanningAlert_validity? Validity { get; set; }
        /// <summary>
        /// Instantiates a new secretScanningAlert and sets the default values.
        /// </summary>
        public SecretScanningAlert() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecretScanningAlert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecretScanningAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                {"html_url", n => { HtmlUrl = n.GetStringValue(); } },
                {"locations_url", n => { LocationsUrl = n.GetStringValue(); } },
                {"number", n => { Number = n.GetIntValue(); } },
                {"push_protection_bypassed", n => { PushProtectionBypassed = n.GetBoolValue(); } },
                {"push_protection_bypassed_at", n => { PushProtectionBypassedAt = n.GetDateTimeOffsetValue(); } },
                {"push_protection_bypassed_by", n => { PushProtectionBypassedBy = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"resolution", n => { Resolution = n.GetEnumValue<SecretScanningAlertResolution>(); } },
                {"resolution_comment", n => { ResolutionComment = n.GetStringValue(); } },
                {"resolved_at", n => { ResolvedAt = n.GetDateTimeOffsetValue(); } },
                {"resolved_by", n => { ResolvedBy = n.GetObjectValue<NullableSimpleUser>(NullableSimpleUser.CreateFromDiscriminatorValue); } },
                {"secret", n => { Secret = n.GetStringValue(); } },
                {"secret_type", n => { SecretType = n.GetStringValue(); } },
                {"secret_type_display_name", n => { SecretTypeDisplayName = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<SecretScanningAlertState>(); } },
                {"updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"validity", n => { Validity = n.GetEnumValue<SecretScanningAlert_validity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("locations_url", LocationsUrl);
            writer.WriteBoolValue("push_protection_bypassed", PushProtectionBypassed);
            writer.WriteDateTimeOffsetValue("push_protection_bypassed_at", PushProtectionBypassedAt);
            writer.WriteObjectValue<NullableSimpleUser>("push_protection_bypassed_by", PushProtectionBypassedBy);
            writer.WriteEnumValue<SecretScanningAlertResolution>("resolution", Resolution);
            writer.WriteStringValue("resolution_comment", ResolutionComment);
            writer.WriteDateTimeOffsetValue("resolved_at", ResolvedAt);
            writer.WriteObjectValue<NullableSimpleUser>("resolved_by", ResolvedBy);
            writer.WriteStringValue("secret", Secret);
            writer.WriteStringValue("secret_type", SecretType);
            writer.WriteStringValue("secret_type_display_name", SecretTypeDisplayName);
            writer.WriteEnumValue<SecretScanningAlertState>("state", State);
            writer.WriteEnumValue<SecretScanningAlert_validity>("validity", Validity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

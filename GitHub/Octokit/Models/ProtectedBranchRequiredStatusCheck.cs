// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Protected Branch Required Status Check
    /// </summary>
    public class ProtectedBranchRequiredStatusCheck : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The checks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProtectedBranchRequiredStatusCheck_checks>? Checks { get; set; }
#nullable restore
#else
        public List<ProtectedBranchRequiredStatusCheck_checks> Checks { get; set; }
#endif
        /// <summary>The contexts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Contexts { get; set; }
#nullable restore
#else
        public List<string> Contexts { get; set; }
#endif
        /// <summary>The contexts_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextsUrl { get; set; }
#nullable restore
#else
        public string ContextsUrl { get; set; }
#endif
        /// <summary>The enforcement_level property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnforcementLevel { get; set; }
#nullable restore
#else
        public string EnforcementLevel { get; set; }
#endif
        /// <summary>The strict property</summary>
        public bool? Strict { get; set; }
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new protectedBranchRequiredStatusCheck and sets the default values.
        /// </summary>
        public ProtectedBranchRequiredStatusCheck() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProtectedBranchRequiredStatusCheck CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectedBranchRequiredStatusCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"checks", n => { Checks = n.GetCollectionOfObjectValues<ProtectedBranchRequiredStatusCheck_checks>(ProtectedBranchRequiredStatusCheck_checks.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contexts", n => { Contexts = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"contexts_url", n => { ContextsUrl = n.GetStringValue(); } },
                {"enforcement_level", n => { EnforcementLevel = n.GetStringValue(); } },
                {"strict", n => { Strict = n.GetBoolValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ProtectedBranchRequiredStatusCheck_checks>("checks", Checks);
            writer.WriteCollectionOfPrimitiveValues<string>("contexts", Contexts);
            writer.WriteStringValue("contexts_url", ContextsUrl);
            writer.WriteStringValue("enforcement_level", EnforcementLevel);
            writer.WriteBoolValue("strict", Strict);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

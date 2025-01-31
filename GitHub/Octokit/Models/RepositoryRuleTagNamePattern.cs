// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Parameters to be used for the tag_name_pattern rule
    /// </summary>
    public class RepositoryRuleTagNamePattern : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The parameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleTagNamePattern_parameters? Parameters { get; set; }
#nullable restore
#else
        public RepositoryRuleTagNamePattern_parameters Parameters { get; set; }
#endif
        /// <summary>The type property</summary>
        public RepositoryRuleTagNamePattern_type? Type { get; set; }
        /// <summary>
        /// Instantiates a new repositoryRuleTagNamePattern and sets the default values.
        /// </summary>
        public RepositoryRuleTagNamePattern() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleTagNamePattern CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleTagNamePattern();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"parameters", n => { Parameters = n.GetObjectValue<RepositoryRuleTagNamePattern_parameters>(RepositoryRuleTagNamePattern_parameters.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<RepositoryRuleTagNamePattern_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RepositoryRuleTagNamePattern_parameters>("parameters", Parameters);
            writer.WriteEnumValue<RepositoryRuleTagNamePattern_type>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

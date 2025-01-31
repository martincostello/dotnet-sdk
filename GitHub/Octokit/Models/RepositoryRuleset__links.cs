// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class RepositoryRuleset__links : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The html property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleset__links_html? Html { get; set; }
#nullable restore
#else
        public RepositoryRuleset__links_html Html { get; set; }
#endif
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RepositoryRuleset__links_self? Self { get; set; }
#nullable restore
#else
        public RepositoryRuleset__links_self Self { get; set; }
#endif
        /// <summary>
        /// Instantiates a new repositoryRuleset__links and sets the default values.
        /// </summary>
        public RepositoryRuleset__links() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RepositoryRuleset__links CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RepositoryRuleset__links();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"html", n => { Html = n.GetObjectValue<RepositoryRuleset__links_html>(RepositoryRuleset__links_html.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetObjectValue<RepositoryRuleset__links_self>(RepositoryRuleset__links_self.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RepositoryRuleset__links_html>("html", Html);
            writer.WriteObjectValue<RepositoryRuleset__links_self>("self", Self);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

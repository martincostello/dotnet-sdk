// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// The set of permissions for the GitHub app
    /// </summary>
    public class Integration_permissions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The checks property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Checks { get; set; }
#nullable restore
#else
        public string Checks { get; set; }
#endif
        /// <summary>The contents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Contents { get; set; }
#nullable restore
#else
        public string Contents { get; set; }
#endif
        /// <summary>The deployments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Deployments { get; set; }
#nullable restore
#else
        public string Deployments { get; set; }
#endif
        /// <summary>The issues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issues { get; set; }
#nullable restore
#else
        public string Issues { get; set; }
#endif
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>
        /// Instantiates a new integration_permissions and sets the default values.
        /// </summary>
        public Integration_permissions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Integration_permissions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Integration_permissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"checks", n => { Checks = n.GetStringValue(); } },
                {"contents", n => { Contents = n.GetStringValue(); } },
                {"deployments", n => { Deployments = n.GetStringValue(); } },
                {"issues", n => { Issues = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("checks", Checks);
            writer.WriteStringValue("contents", Contents);
            writer.WriteStringValue("deployments", Deployments);
            writer.WriteStringValue("issues", Issues);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

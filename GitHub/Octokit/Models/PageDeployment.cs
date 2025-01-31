// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// The GitHub Pages deployment status.
    /// </summary>
    public class PageDeployment : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URI to the deployed GitHub Pages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PageUrl { get; set; }
#nullable restore
#else
        public string PageUrl { get; set; }
#endif
        /// <summary>The URI to the deployed GitHub Pages preview.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreviewUrl { get; set; }
#nullable restore
#else
        public string PreviewUrl { get; set; }
#endif
        /// <summary>The URI to monitor GitHub Pages deployment status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusUrl { get; set; }
#nullable restore
#else
        public string StatusUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pageDeployment and sets the default values.
        /// </summary>
        public PageDeployment() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PageDeployment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PageDeployment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"page_url", n => { PageUrl = n.GetStringValue(); } },
                {"preview_url", n => { PreviewUrl = n.GetStringValue(); } },
                {"status_url", n => { StatusUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("page_url", PageUrl);
            writer.WriteStringValue("preview_url", PreviewUrl);
            writer.WriteStringValue("status_url", StatusUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

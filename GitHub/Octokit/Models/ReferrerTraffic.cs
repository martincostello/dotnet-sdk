// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Referrer Traffic
    /// </summary>
    public class ReferrerTraffic : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The referrer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Referrer { get; set; }
#nullable restore
#else
        public string Referrer { get; set; }
#endif
        /// <summary>The uniques property</summary>
        public int? Uniques { get; set; }
        /// <summary>
        /// Instantiates a new referrerTraffic and sets the default values.
        /// </summary>
        public ReferrerTraffic() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReferrerTraffic CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReferrerTraffic();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"count", n => { Count = n.GetIntValue(); } },
                {"referrer", n => { Referrer = n.GetStringValue(); } },
                {"uniques", n => { Uniques = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("referrer", Referrer);
            writer.WriteIntValue("uniques", Uniques);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

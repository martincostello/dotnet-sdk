// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Interaction limit settings.
    /// </summary>
    public class InteractionLimitResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expires_at property</summary>
        public DateTimeOffset? ExpiresAt { get; set; }
        /// <summary>The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.</summary>
        public InteractionGroup? Limit { get; set; }
        /// <summary>The origin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Origin { get; set; }
#nullable restore
#else
        public string Origin { get; set; }
#endif
        /// <summary>
        /// Instantiates a new interactionLimitResponse and sets the default values.
        /// </summary>
        public InteractionLimitResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InteractionLimitResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InteractionLimitResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expires_at", n => { ExpiresAt = n.GetDateTimeOffsetValue(); } },
                {"limit", n => { Limit = n.GetEnumValue<InteractionGroup>(); } },
                {"origin", n => { Origin = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expires_at", ExpiresAt);
            writer.WriteEnumValue<InteractionGroup>("limit", Limit);
            writer.WriteStringValue("origin", Origin);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

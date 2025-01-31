// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Limit interactions to a specific type of user for a specified duration
    /// </summary>
    public class InteractionLimit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The duration of the interaction restriction. Default: `one_day`.</summary>
        public InteractionExpiry? Expiry { get; set; }
        /// <summary>The type of GitHub user that can comment, open issues, or create pull requests while the interaction limit is in effect.</summary>
        public InteractionGroup? Limit { get; set; }
        /// <summary>
        /// Instantiates a new interactionLimit and sets the default values.
        /// </summary>
        public InteractionLimit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InteractionLimit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InteractionLimit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"expiry", n => { Expiry = n.GetEnumValue<InteractionExpiry>(); } },
                {"limit", n => { Limit = n.GetEnumValue<InteractionGroup>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<InteractionExpiry>("expiry", Expiry);
            writer.WriteEnumValue<InteractionGroup>("limit", Limit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

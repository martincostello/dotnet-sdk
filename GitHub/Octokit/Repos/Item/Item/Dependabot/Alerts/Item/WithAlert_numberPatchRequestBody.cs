// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Dependabot.Alerts.Item {
    public class WithAlert_numberPatchRequestBody : IParsable {
        /// <summary>An optional comment associated with dismissing the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DismissedComment { get; set; }
#nullable restore
#else
        public string DismissedComment { get; set; }
#endif
        /// <summary>**Required when `state` is `dismissed`.** A reason for dismissing the alert.</summary>
        public WithAlert_numberPatchRequestBody_dismissed_reason? DismissedReason { get; set; }
        /// <summary>The state of the Dependabot alert.A `dismissed_reason` must be provided when setting the state to `dismissed`.</summary>
        public WithAlert_numberPatchRequestBody_state? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithAlert_numberPatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithAlert_numberPatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dismissed_comment", n => { DismissedComment = n.GetStringValue(); } },
                {"dismissed_reason", n => { DismissedReason = n.GetEnumValue<WithAlert_numberPatchRequestBody_dismissed_reason>(); } },
                {"state", n => { State = n.GetEnumValue<WithAlert_numberPatchRequestBody_state>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dismissed_comment", DismissedComment);
            writer.WriteEnumValue<WithAlert_numberPatchRequestBody_dismissed_reason>("dismissed_reason", DismissedReason);
            writer.WriteEnumValue<WithAlert_numberPatchRequestBody_state>("state", State);
        }
    }
}

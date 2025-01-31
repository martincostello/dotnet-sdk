// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Statuses.Item {
    public class WithShaPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A string label to differentiate this status from the status of other systems. This field is case-insensitive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Context { get; set; }
#nullable restore
#else
        public string Context { get; set; }
#endif
        /// <summary>A short description of the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The state of the status.</summary>
        public WithShaPostRequestBody_state? State { get; set; }
        /// <summary>The target URL to associate with this status. This URL will be linked from the GitHub UI to allow users to easily see the source of the status.  For example, if your continuous integration system is posting build status, you would want to provide the deep link for the build output for this specific SHA:  `http://ci.example.com/user/repo/build/sha`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetUrl { get; set; }
#nullable restore
#else
        public string TargetUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WithShaPostRequestBody and sets the default values.
        /// </summary>
        public WithShaPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
            Context = "default";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithShaPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithShaPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"context", n => { Context = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<WithShaPostRequestBody_state>(); } },
                {"target_url", n => { TargetUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("context", Context);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<WithShaPostRequestBody_state>("state", State);
            writer.WriteStringValue("target_url", TargetUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

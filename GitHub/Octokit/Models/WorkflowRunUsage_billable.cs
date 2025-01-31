// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class WorkflowRunUsage_billable : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The MACOS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowRunUsage_billable_MACOS? MACOS { get; set; }
#nullable restore
#else
        public WorkflowRunUsage_billable_MACOS MACOS { get; set; }
#endif
        /// <summary>The UBUNTU property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowRunUsage_billable_UBUNTU? UBUNTU { get; set; }
#nullable restore
#else
        public WorkflowRunUsage_billable_UBUNTU UBUNTU { get; set; }
#endif
        /// <summary>The WINDOWS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowRunUsage_billable_WINDOWS? WINDOWS { get; set; }
#nullable restore
#else
        public WorkflowRunUsage_billable_WINDOWS WINDOWS { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workflowRunUsage_billable and sets the default values.
        /// </summary>
        public WorkflowRunUsage_billable() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowRunUsage_billable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowRunUsage_billable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"MACOS", n => { MACOS = n.GetObjectValue<WorkflowRunUsage_billable_MACOS>(WorkflowRunUsage_billable_MACOS.CreateFromDiscriminatorValue); } },
                {"UBUNTU", n => { UBUNTU = n.GetObjectValue<WorkflowRunUsage_billable_UBUNTU>(WorkflowRunUsage_billable_UBUNTU.CreateFromDiscriminatorValue); } },
                {"WINDOWS", n => { WINDOWS = n.GetObjectValue<WorkflowRunUsage_billable_WINDOWS>(WorkflowRunUsage_billable_WINDOWS.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WorkflowRunUsage_billable_MACOS>("MACOS", MACOS);
            writer.WriteObjectValue<WorkflowRunUsage_billable_UBUNTU>("UBUNTU", UBUNTU);
            writer.WriteObjectValue<WorkflowRunUsage_billable_WINDOWS>("WINDOWS", WINDOWS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

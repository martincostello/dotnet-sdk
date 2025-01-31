// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Actions.Workflows {
    public class WorkflowsGetResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>The workflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHub.Octokit.Models.Workflow>? Workflows { get; set; }
#nullable restore
#else
        public List<GitHub.Octokit.Models.Workflow> Workflows { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workflowsGetResponse and sets the default values.
        /// </summary>
        public WorkflowsGetResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"total_count", n => { TotalCount = n.GetIntValue(); } },
                {"workflows", n => { Workflows = n.GetCollectionOfObjectValues<GitHub.Octokit.Models.Workflow>(GitHub.Octokit.Models.Workflow.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteCollectionOfObjectValues<GitHub.Octokit.Models.Workflow>("workflows", Workflows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

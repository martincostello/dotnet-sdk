// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// A self hosted runner
    /// </summary>
    public class Runner : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The busy property</summary>
        public bool? Busy { get; set; }
        /// <summary>The id of the runner.</summary>
        public int? Id { get; set; }
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RunnerLabel>? Labels { get; set; }
#nullable restore
#else
        public List<RunnerLabel> Labels { get; set; }
#endif
        /// <summary>The name of the runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The Operating System of the runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os { get; set; }
#nullable restore
#else
        public string Os { get; set; }
#endif
        /// <summary>The id of the runner group.</summary>
        public int? RunnerGroupId { get; set; }
        /// <summary>The status of the runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>
        /// Instantiates a new runner and sets the default values.
        /// </summary>
        public Runner() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Runner CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Runner();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"busy", n => { Busy = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"labels", n => { Labels = n.GetCollectionOfObjectValues<RunnerLabel>(RunnerLabel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"os", n => { Os = n.GetStringValue(); } },
                {"runner_group_id", n => { RunnerGroupId = n.GetIntValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("busy", Busy);
            writer.WriteIntValue("id", Id);
            writer.WriteCollectionOfObjectValues<RunnerLabel>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("os", Os);
            writer.WriteIntValue("runner_group_id", RunnerGroupId);
            writer.WriteStringValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

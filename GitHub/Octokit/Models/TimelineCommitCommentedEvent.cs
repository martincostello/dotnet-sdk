// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Timeline Commit Commented Event
    /// </summary>
    public class TimelineCommitCommentedEvent : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommitComment>? Comments { get; set; }
#nullable restore
#else
        public List<CommitComment> Comments { get; set; }
#endif
        /// <summary>The commit_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitId { get; set; }
#nullable restore
#else
        public string CommitId { get; set; }
#endif
        /// <summary>The event property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Event { get; set; }
#nullable restore
#else
        public string Event { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new timelineCommitCommentedEvent and sets the default values.
        /// </summary>
        public TimelineCommitCommentedEvent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimelineCommitCommentedEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimelineCommitCommentedEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<CommitComment>(CommitComment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"commit_id", n => { CommitId = n.GetStringValue(); } },
                {"event", n => { Event = n.GetStringValue(); } },
                {"node_id", n => { NodeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CommitComment>("comments", Comments);
            writer.WriteStringValue("commit_id", CommitId);
            writer.WriteStringValue("event", Event);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

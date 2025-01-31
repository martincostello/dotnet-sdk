// <auto-generated/>
using GitHub.Octokit.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Environments.Item {
    public class WithEnvironment_namePutRequestBody : IParsable {
        /// <summary>The type of deployment branch policy for this environment. To allow all branches to deploy, set to `null`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeploymentBranchPolicySettings? DeploymentBranchPolicy { get; set; }
#nullable restore
#else
        public DeploymentBranchPolicySettings DeploymentBranchPolicy { get; set; }
#endif
        /// <summary>Whether or not a user who created the job is prevented from approving their own job.</summary>
        public bool? PreventSelfReview { get; set; }
        /// <summary>The people or teams that may review jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WithEnvironment_namePutRequestBody_reviewers>? Reviewers { get; set; }
#nullable restore
#else
        public List<WithEnvironment_namePutRequestBody_reviewers> Reviewers { get; set; }
#endif
        /// <summary>The amount of time to delay a job after the job is initially triggered. The time (in minutes) must be an integer between 0 and 43,200 (30 days).</summary>
        public int? WaitTimer { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WithEnvironment_namePutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WithEnvironment_namePutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deployment_branch_policy", n => { DeploymentBranchPolicy = n.GetObjectValue<DeploymentBranchPolicySettings>(DeploymentBranchPolicySettings.CreateFromDiscriminatorValue); } },
                {"prevent_self_review", n => { PreventSelfReview = n.GetBoolValue(); } },
                {"reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<WithEnvironment_namePutRequestBody_reviewers>(WithEnvironment_namePutRequestBody_reviewers.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wait_timer", n => { WaitTimer = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeploymentBranchPolicySettings>("deployment_branch_policy", DeploymentBranchPolicy);
            writer.WriteBoolValue("prevent_self_review", PreventSelfReview);
            writer.WriteCollectionOfObjectValues<WithEnvironment_namePutRequestBody_reviewers>("reviewers", Reviewers);
            writer.WriteIntValue("wait_timer", WaitTimer);
        }
    }
}

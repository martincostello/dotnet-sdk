// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>The state of the status.</summary>
    public enum DeploymentStatus_state {
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "in_progress")]
        In_progress,
    }
}

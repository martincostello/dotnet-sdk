// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>The operator to use for matching.</summary>
    public enum RepositoryRuleTagNamePattern_parameters_operator {
        [EnumMember(Value = "starts_with")]
        Starts_with,
        [EnumMember(Value = "ends_with")]
        Ends_with,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "regex")]
        Regex,
    }
}

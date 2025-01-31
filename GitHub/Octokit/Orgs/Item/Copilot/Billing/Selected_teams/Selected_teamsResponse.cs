// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Orgs.Item.Copilot.Billing.Selected_teams {
    /// <summary>
    /// The total number of seat assignments created.
    /// </summary>
    [Obsolete("This class is obsolete. Use selected_teamsPostResponse instead.")]
    public class Selected_teamsResponse : Selected_teamsPostResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Selected_teamsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Selected_teamsResponse();
        }
    }
}

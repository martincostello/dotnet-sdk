// <auto-generated/>
using GitHub.Octokit.Orgs.Item.Copilot.Billing;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Orgs.Item.Copilot {
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\copilot
    /// </summary>
    public class CopilotRequestBuilder : BaseRequestBuilder {
        /// <summary>The billing property</summary>
        public BillingRequestBuilder Billing { get =>
            new BillingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new CopilotRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CopilotRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CopilotRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CopilotRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/copilot", rawUrl) {
        }
    }
}

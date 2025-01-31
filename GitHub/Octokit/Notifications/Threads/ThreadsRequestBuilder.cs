// <auto-generated/>
using GitHub.Octokit.Notifications.Threads.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Notifications.Threads {
    /// <summary>
    /// Builds and executes requests for operations under \notifications\threads
    /// </summary>
    public class ThreadsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the GitHub.Octokit.notifications.threads.item collection</summary>
        /// <param name="position">The unique identifier of the notification thread. This corresponds to the value returned in the `id` field when you retrieve notifications (for example with the [`GET /notifications` operation](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user)).</param>
        public WithThread_ItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("thread_id", position);
            return new WithThread_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the GitHub.Octokit.notifications.threads.item collection</summary>
        /// <param name="position">The unique identifier of the notification thread. This corresponds to the value returned in the `id` field when you retrieve notifications (for example with the [`GET /notifications` operation](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user)).</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithThread_ItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("thread_id", position);
            return new WithThread_ItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ThreadsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreadsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notifications/threads", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ThreadsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreadsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/notifications/threads", rawUrl) {
        }
    }
}

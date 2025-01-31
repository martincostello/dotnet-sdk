// <auto-generated/>
using GitHub.Octokit.Repos.Item.Item.Git.Blobs;
using GitHub.Octokit.Repos.Item.Item.Git.Commits;
using GitHub.Octokit.Repos.Item.Item.Git.MatchingRefs;
using GitHub.Octokit.Repos.Item.Item.Git.Ref;
using GitHub.Octokit.Repos.Item.Item.Git.Refs;
using GitHub.Octokit.Repos.Item.Item.Git.Tags;
using GitHub.Octokit.Repos.Item.Item.Git.Trees;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Git {
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner}\{repo}\git
    /// </summary>
    public class GitRequestBuilder : BaseRequestBuilder {
        /// <summary>The blobs property</summary>
        public BlobsRequestBuilder Blobs { get =>
            new BlobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commits property</summary>
        public CommitsRequestBuilder Commits { get =>
            new CommitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The matchingRefs property</summary>
        public MatchingRefsRequestBuilder MatchingRefs { get =>
            new MatchingRefsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ref property</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The refs property</summary>
        public RefsRequestBuilder Refs { get =>
            new RefsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The tags property</summary>
        public TagsRequestBuilder Tags { get =>
            new TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The trees property</summary>
        public TreesRequestBuilder Trees { get =>
            new TreesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GitRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/git", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GitRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GitRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner}/{repo}/git", rawUrl) {
        }
    }
}

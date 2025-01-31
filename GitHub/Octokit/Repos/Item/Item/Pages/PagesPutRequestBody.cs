// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Repos.Item.Item.Pages {
    public class PagesPutRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The process by which the GitHub Pages site will be built. `workflow` means that the site is built by a custom GitHub Actions workflow. `legacy` means that the site is built by GitHub when changes are pushed to a specific branch.</summary>
        public PagesPutRequestBody_build_type? BuildType { get; set; }
        /// <summary>Specify a custom domain for the repository. Sending a `null` value will remove the custom domain. For more about custom domains, see &quot;[Using a custom domain with GitHub Pages](https://docs.github.com/articles/using-a-custom-domain-with-github-pages/).&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Cname { get; set; }
#nullable restore
#else
        public string Cname { get; set; }
#endif
        /// <summary>Specify whether HTTPS should be enforced for the repository.</summary>
        public bool? HttpsEnforced { get; set; }
        /// <summary>The source property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PagesPutRequestBody_source? Source { get; set; }
#nullable restore
#else
        public PagesPutRequestBody_source Source { get; set; }
#endif
        /// <summary>
        /// Instantiates a new pagesPutRequestBody and sets the default values.
        /// </summary>
        public PagesPutRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PagesPutRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PagesPutRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"build_type", n => { BuildType = n.GetEnumValue<PagesPutRequestBody_build_type>(); } },
                {"cname", n => { Cname = n.GetStringValue(); } },
                {"https_enforced", n => { HttpsEnforced = n.GetBoolValue(); } },
                {"source", n => { Source = n.GetObjectValue<PagesPutRequestBody_source>(PagesPutRequestBody_source.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<PagesPutRequestBody_build_type>("build_type", BuildType);
            writer.WriteStringValue("cname", Cname);
            writer.WriteBoolValue("https_enforced", HttpsEnforced);
            writer.WriteObjectValue<PagesPutRequestBody_source>("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
        /// <summary>
        /// Composed type wrapper for classes pagesPutRequestBody_sourceMember1, string
        /// </summary>
        public class PagesPutRequestBody_source : IComposedTypeWrapper, IParsable {
            /// <summary>Composed type representation for type pagesPutRequestBody_sourceMember1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public PagesPutRequestBody_sourceMember1? PagesPutRequestBodySourceMember1 { get; set; }
#nullable restore
#else
            public PagesPutRequestBody_sourceMember1 PagesPutRequestBodySourceMember1 { get; set; }
#endif
            /// <summary>Composed type representation for type string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? String { get; set; }
#nullable restore
#else
            public string String { get; set; }
#endif
            /// <summary>
            /// Creates a new instance of the appropriate class based on discriminator value
            /// </summary>
            /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
            public static PagesPutRequestBody_source CreateFromDiscriminatorValue(IParseNode parseNode) {
                _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
                var result = new PagesPutRequestBody_source();
                if(parseNode.GetStringValue() is string stringValue) {
                    result.String = stringValue;
                }
                else {
                    result.PagesPutRequestBodySourceMember1 = new PagesPutRequestBody_sourceMember1();
                }
                return result;
            }
            /// <summary>
            /// The deserialization information for the current model
            /// </summary>
            public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
                if(PagesPutRequestBodySourceMember1 != null) {
                    return ParseNodeHelper.MergeDeserializersForIntersectionWrapper(PagesPutRequestBodySourceMember1);
                }
                return new Dictionary<string, Action<IParseNode>>();
            }
            /// <summary>
            /// Serializes information the current object
            /// </summary>
            /// <param name="writer">Serialization writer to use to serialize this model</param>
            public virtual void Serialize(ISerializationWriter writer) {
                _ = writer ?? throw new ArgumentNullException(nameof(writer));
                if(String != null) {
                    writer.WriteStringValue(null, String);
                }
                else {
                    writer.WriteObjectValue<PagesPutRequestBody_sourceMember1>(null, PagesPutRequestBodySourceMember1);
                }
            }
        }
    }
}

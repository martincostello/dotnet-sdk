// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    /// <summary>
    /// Marketplace Purchase
    /// </summary>
    public class MarketplacePurchase : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login { get; set; }
#nullable restore
#else
        public string Login { get; set; }
#endif
        /// <summary>The marketplace_pending_change property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketplacePurchase_marketplace_pending_change? MarketplacePendingChange { get; set; }
#nullable restore
#else
        public MarketplacePurchase_marketplace_pending_change MarketplacePendingChange { get; set; }
#endif
        /// <summary>The marketplace_purchase property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketplacePurchase_marketplace_purchase? MarketplacePurchaseProp { get; set; }
#nullable restore
#else
        public MarketplacePurchase_marketplace_purchase MarketplacePurchaseProp { get; set; }
#endif
        /// <summary>The organization_billing_email property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationBillingEmail { get; set; }
#nullable restore
#else
        public string OrganizationBillingEmail { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new marketplacePurchase and sets the default values.
        /// </summary>
        public MarketplacePurchase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MarketplacePurchase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MarketplacePurchase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"email", n => { Email = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"login", n => { Login = n.GetStringValue(); } },
                {"marketplace_pending_change", n => { MarketplacePendingChange = n.GetObjectValue<MarketplacePurchase_marketplace_pending_change>(MarketplacePurchase_marketplace_pending_change.CreateFromDiscriminatorValue); } },
                {"marketplace_purchase", n => { MarketplacePurchaseProp = n.GetObjectValue<MarketplacePurchase_marketplace_purchase>(MarketplacePurchase_marketplace_purchase.CreateFromDiscriminatorValue); } },
                {"organization_billing_email", n => { OrganizationBillingEmail = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("email", Email);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("login", Login);
            writer.WriteObjectValue<MarketplacePurchase_marketplace_pending_change>("marketplace_pending_change", MarketplacePendingChange);
            writer.WriteObjectValue<MarketplacePurchase_marketplace_purchase>("marketplace_purchase", MarketplacePurchaseProp);
            writer.WriteStringValue("organization_billing_email", OrganizationBillingEmail);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

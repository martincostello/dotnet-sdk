// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class MarketplacePurchase_marketplace_purchase : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The billing_cycle property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BillingCycle { get; set; }
#nullable restore
#else
        public string BillingCycle { get; set; }
#endif
        /// <summary>The free_trial_ends_on property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FreeTrialEndsOn { get; set; }
#nullable restore
#else
        public string FreeTrialEndsOn { get; set; }
#endif
        /// <summary>The is_installed property</summary>
        public bool? IsInstalled { get; set; }
        /// <summary>The next_billing_date property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NextBillingDate { get; set; }
#nullable restore
#else
        public string NextBillingDate { get; set; }
#endif
        /// <summary>The on_free_trial property</summary>
        public bool? OnFreeTrial { get; set; }
        /// <summary>Marketplace Listing Plan</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MarketplaceListingPlan? Plan { get; set; }
#nullable restore
#else
        public MarketplaceListingPlan Plan { get; set; }
#endif
        /// <summary>The unit_count property</summary>
        public int? UnitCount { get; set; }
        /// <summary>The updated_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpdatedAt { get; set; }
#nullable restore
#else
        public string UpdatedAt { get; set; }
#endif
        /// <summary>
        /// Instantiates a new marketplacePurchase_marketplace_purchase and sets the default values.
        /// </summary>
        public MarketplacePurchase_marketplace_purchase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MarketplacePurchase_marketplace_purchase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MarketplacePurchase_marketplace_purchase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"billing_cycle", n => { BillingCycle = n.GetStringValue(); } },
                {"free_trial_ends_on", n => { FreeTrialEndsOn = n.GetStringValue(); } },
                {"is_installed", n => { IsInstalled = n.GetBoolValue(); } },
                {"next_billing_date", n => { NextBillingDate = n.GetStringValue(); } },
                {"on_free_trial", n => { OnFreeTrial = n.GetBoolValue(); } },
                {"plan", n => { Plan = n.GetObjectValue<MarketplaceListingPlan>(MarketplaceListingPlan.CreateFromDiscriminatorValue); } },
                {"unit_count", n => { UnitCount = n.GetIntValue(); } },
                {"updated_at", n => { UpdatedAt = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("billing_cycle", BillingCycle);
            writer.WriteStringValue("free_trial_ends_on", FreeTrialEndsOn);
            writer.WriteBoolValue("is_installed", IsInstalled);
            writer.WriteStringValue("next_billing_date", NextBillingDate);
            writer.WriteBoolValue("on_free_trial", OnFreeTrial);
            writer.WriteObjectValue<MarketplaceListingPlan>("plan", Plan);
            writer.WriteIntValue("unit_count", UnitCount);
            writer.WriteStringValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

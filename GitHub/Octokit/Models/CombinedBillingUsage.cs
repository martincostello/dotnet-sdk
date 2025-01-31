// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace GitHub.Octokit.Models {
    public class CombinedBillingUsage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Numbers of days left in billing cycle.</summary>
        public int? DaysLeftInBillingCycle { get; set; }
        /// <summary>Estimated storage space (GB) used in billing cycle.</summary>
        public int? EstimatedPaidStorageForMonth { get; set; }
        /// <summary>Estimated sum of free and paid storage space (GB) used in billing cycle.</summary>
        public int? EstimatedStorageForMonth { get; set; }
        /// <summary>
        /// Instantiates a new combinedBillingUsage and sets the default values.
        /// </summary>
        public CombinedBillingUsage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CombinedBillingUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CombinedBillingUsage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"days_left_in_billing_cycle", n => { DaysLeftInBillingCycle = n.GetIntValue(); } },
                {"estimated_paid_storage_for_month", n => { EstimatedPaidStorageForMonth = n.GetIntValue(); } },
                {"estimated_storage_for_month", n => { EstimatedStorageForMonth = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("days_left_in_billing_cycle", DaysLeftInBillingCycle);
            writer.WriteIntValue("estimated_paid_storage_for_month", EstimatedPaidStorageForMonth);
            writer.WriteIntValue("estimated_storage_for_month", EstimatedStorageForMonth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}

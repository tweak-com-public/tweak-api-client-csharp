/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.12
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TweakApi.Model
{
    /// <summary>
    /// BillingSubscription
    /// </summary>
    [DataContract]
    public partial class BillingSubscription :  IEquatable<BillingSubscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSubscription" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Coupon">Coupon.</param>
        /// <param name="TaxPercent">TaxPercent.</param>
        /// <param name="TrialPeriodDays">TrialPeriodDays.</param>
        /// <param name="SubscribedPlans">SubscribedPlans (required).</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CancelAtPeriodEnd">CancelAtPeriodEnd.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Start">Start.</param>
        /// <param name="EndedAt">EndedAt.</param>
        /// <param name="TrialEnd">TrialEnd.</param>
        /// <param name="TrialStart">TrialStart.</param>
        /// <param name="CurrentPeriodEnd">CurrentPeriodEnd.</param>
        /// <param name="CurrentPeriodStart">CurrentPeriodStart.</param>
        /// <param name="CanceledAt">CanceledAt.</param>
        public BillingSubscription(string Id = null, string Coupon = null, double? TaxPercent = null, double? TrialPeriodDays = null, List<BillingSubscriptionItem> SubscribedPlans = null, double? Discount = null, string Status = null, bool? CancelAtPeriodEnd = null, DateTime? Created = null, DateTime? Start = null, DateTime? EndedAt = null, DateTime? TrialEnd = null, DateTime? TrialStart = null, DateTime? CurrentPeriodEnd = null, DateTime? CurrentPeriodStart = null, DateTime? CanceledAt = null)
        {
            // to ensure "SubscribedPlans" is required (not null)
            if (SubscribedPlans == null)
            {
                throw new InvalidDataException("SubscribedPlans is a required property for BillingSubscription and cannot be null");
            }
            else
            {
                this.SubscribedPlans = SubscribedPlans;
            }
            this.Id = Id;
            this.Coupon = Coupon;
            this.TaxPercent = TaxPercent;
            this.TrialPeriodDays = TrialPeriodDays;
            this.Discount = Discount;
            this.Status = Status;
            this.CancelAtPeriodEnd = CancelAtPeriodEnd;
            this.Created = Created;
            this.Start = Start;
            this.EndedAt = EndedAt;
            this.TrialEnd = TrialEnd;
            this.TrialStart = TrialStart;
            this.CurrentPeriodEnd = CurrentPeriodEnd;
            this.CurrentPeriodStart = CurrentPeriodStart;
            this.CanceledAt = CanceledAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Coupon
        /// </summary>
        [DataMember(Name="coupon", EmitDefaultValue=false)]
        public string Coupon { get; set; }
        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name="taxPercent", EmitDefaultValue=false)]
        public double? TaxPercent { get; set; }
        /// <summary>
        /// Gets or Sets TrialPeriodDays
        /// </summary>
        [DataMember(Name="trialPeriodDays", EmitDefaultValue=false)]
        public double? TrialPeriodDays { get; set; }
        /// <summary>
        /// Gets or Sets SubscribedPlans
        /// </summary>
        [DataMember(Name="subscribedPlans", EmitDefaultValue=false)]
        public List<BillingSubscriptionItem> SubscribedPlans { get; set; }
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets CancelAtPeriodEnd
        /// </summary>
        [DataMember(Name="cancelAtPeriodEnd", EmitDefaultValue=false)]
        public bool? CancelAtPeriodEnd { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public DateTime? Start { get; set; }
        /// <summary>
        /// Gets or Sets EndedAt
        /// </summary>
        [DataMember(Name="endedAt", EmitDefaultValue=false)]
        public DateTime? EndedAt { get; set; }
        /// <summary>
        /// Gets or Sets TrialEnd
        /// </summary>
        [DataMember(Name="trialEnd", EmitDefaultValue=false)]
        public DateTime? TrialEnd { get; set; }
        /// <summary>
        /// Gets or Sets TrialStart
        /// </summary>
        [DataMember(Name="trialStart", EmitDefaultValue=false)]
        public DateTime? TrialStart { get; set; }
        /// <summary>
        /// Gets or Sets CurrentPeriodEnd
        /// </summary>
        [DataMember(Name="currentPeriodEnd", EmitDefaultValue=false)]
        public DateTime? CurrentPeriodEnd { get; set; }
        /// <summary>
        /// Gets or Sets CurrentPeriodStart
        /// </summary>
        [DataMember(Name="currentPeriodStart", EmitDefaultValue=false)]
        public DateTime? CurrentPeriodStart { get; set; }
        /// <summary>
        /// Gets or Sets CanceledAt
        /// </summary>
        [DataMember(Name="canceledAt", EmitDefaultValue=false)]
        public DateTime? CanceledAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingSubscription {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Coupon: ").Append(Coupon).Append("\n");
            sb.Append("  TaxPercent: ").Append(TaxPercent).Append("\n");
            sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");
            sb.Append("  SubscribedPlans: ").Append(SubscribedPlans).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CancelAtPeriodEnd: ").Append(CancelAtPeriodEnd).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  EndedAt: ").Append(EndedAt).Append("\n");
            sb.Append("  TrialEnd: ").Append(TrialEnd).Append("\n");
            sb.Append("  TrialStart: ").Append(TrialStart).Append("\n");
            sb.Append("  CurrentPeriodEnd: ").Append(CurrentPeriodEnd).Append("\n");
            sb.Append("  CurrentPeriodStart: ").Append(CurrentPeriodStart).Append("\n");
            sb.Append("  CanceledAt: ").Append(CanceledAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BillingSubscription);
        }

        /// <summary>
        /// Returns true if BillingSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Coupon == other.Coupon ||
                    this.Coupon != null &&
                    this.Coupon.Equals(other.Coupon)
                ) && 
                (
                    this.TaxPercent == other.TaxPercent ||
                    this.TaxPercent != null &&
                    this.TaxPercent.Equals(other.TaxPercent)
                ) && 
                (
                    this.TrialPeriodDays == other.TrialPeriodDays ||
                    this.TrialPeriodDays != null &&
                    this.TrialPeriodDays.Equals(other.TrialPeriodDays)
                ) && 
                (
                    this.SubscribedPlans == other.SubscribedPlans ||
                    this.SubscribedPlans != null &&
                    this.SubscribedPlans.SequenceEqual(other.SubscribedPlans)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CancelAtPeriodEnd == other.CancelAtPeriodEnd ||
                    this.CancelAtPeriodEnd != null &&
                    this.CancelAtPeriodEnd.Equals(other.CancelAtPeriodEnd)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Start == other.Start ||
                    this.Start != null &&
                    this.Start.Equals(other.Start)
                ) && 
                (
                    this.EndedAt == other.EndedAt ||
                    this.EndedAt != null &&
                    this.EndedAt.Equals(other.EndedAt)
                ) && 
                (
                    this.TrialEnd == other.TrialEnd ||
                    this.TrialEnd != null &&
                    this.TrialEnd.Equals(other.TrialEnd)
                ) && 
                (
                    this.TrialStart == other.TrialStart ||
                    this.TrialStart != null &&
                    this.TrialStart.Equals(other.TrialStart)
                ) && 
                (
                    this.CurrentPeriodEnd == other.CurrentPeriodEnd ||
                    this.CurrentPeriodEnd != null &&
                    this.CurrentPeriodEnd.Equals(other.CurrentPeriodEnd)
                ) && 
                (
                    this.CurrentPeriodStart == other.CurrentPeriodStart ||
                    this.CurrentPeriodStart != null &&
                    this.CurrentPeriodStart.Equals(other.CurrentPeriodStart)
                ) && 
                (
                    this.CanceledAt == other.CanceledAt ||
                    this.CanceledAt != null &&
                    this.CanceledAt.Equals(other.CanceledAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Coupon != null)
                    hash = hash * 59 + this.Coupon.GetHashCode();
                if (this.TaxPercent != null)
                    hash = hash * 59 + this.TaxPercent.GetHashCode();
                if (this.TrialPeriodDays != null)
                    hash = hash * 59 + this.TrialPeriodDays.GetHashCode();
                if (this.SubscribedPlans != null)
                    hash = hash * 59 + this.SubscribedPlans.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CancelAtPeriodEnd != null)
                    hash = hash * 59 + this.CancelAtPeriodEnd.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Start != null)
                    hash = hash * 59 + this.Start.GetHashCode();
                if (this.EndedAt != null)
                    hash = hash * 59 + this.EndedAt.GetHashCode();
                if (this.TrialEnd != null)
                    hash = hash * 59 + this.TrialEnd.GetHashCode();
                if (this.TrialStart != null)
                    hash = hash * 59 + this.TrialStart.GetHashCode();
                if (this.CurrentPeriodEnd != null)
                    hash = hash * 59 + this.CurrentPeriodEnd.GetHashCode();
                if (this.CurrentPeriodStart != null)
                    hash = hash * 59 + this.CurrentPeriodStart.GetHashCode();
                if (this.CanceledAt != null)
                    hash = hash * 59 + this.CanceledAt.GetHashCode();
                return hash;
            }
        }
    }

}

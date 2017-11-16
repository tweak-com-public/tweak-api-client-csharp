/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.4
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
    /// Billing
    /// </summary>
    [DataContract]
    public partial class Billing :  IEquatable<Billing>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Billing" /> class.
        /// </summary>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="CompanyEmail">CompanyEmail.</param>
        /// <param name="CompanyVat">CompanyVat.</param>
        /// <param name="CompanyCard">CompanyCard.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="TaxPercent">TaxPercent (default to 0.0).</param>
        /// <param name="StripeCustomerId">StripeCustomerId.</param>
        /// <param name="StripeCardId">StripeCardId.</param>
        /// <param name="StripeSubscriptionId">StripeSubscriptionId.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        public Billing(string CompanyName = null, string CompanyEmail = null, string CompanyVat = null, BillingCard CompanyCard = null, BillingSubscription Subscription = null, BillingLimit Limit = null, double? TaxPercent = null, string StripeCustomerId = null, string StripeCardId = null, string StripeSubscriptionId = null, string Id = null, string TeamId = null, Team Team = null)
        {
            this.CompanyName = CompanyName;
            this.CompanyEmail = CompanyEmail;
            this.CompanyVat = CompanyVat;
            this.CompanyCard = CompanyCard;
            this.Subscription = Subscription;
            this.Limit = Limit;
            // use default value if no "TaxPercent" provided
            if (TaxPercent == null)
            {
                this.TaxPercent = 0.0;
            }
            else
            {
                this.TaxPercent = TaxPercent;
            }
            this.StripeCustomerId = StripeCustomerId;
            this.StripeCardId = StripeCardId;
            this.StripeSubscriptionId = StripeSubscriptionId;
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
        }
        
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or Sets CompanyEmail
        /// </summary>
        [DataMember(Name="companyEmail", EmitDefaultValue=false)]
        public string CompanyEmail { get; set; }
        /// <summary>
        /// Gets or Sets CompanyVat
        /// </summary>
        [DataMember(Name="companyVat", EmitDefaultValue=false)]
        public string CompanyVat { get; set; }
        /// <summary>
        /// Gets or Sets CompanyCard
        /// </summary>
        [DataMember(Name="companyCard", EmitDefaultValue=false)]
        public BillingCard CompanyCard { get; set; }
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public BillingSubscription Subscription { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public BillingLimit Limit { get; set; }
        /// <summary>
        /// Gets or Sets TaxPercent
        /// </summary>
        [DataMember(Name="taxPercent", EmitDefaultValue=false)]
        public double? TaxPercent { get; set; }
        /// <summary>
        /// Gets or Sets StripeCustomerId
        /// </summary>
        [DataMember(Name="stripeCustomerId", EmitDefaultValue=false)]
        public string StripeCustomerId { get; set; }
        /// <summary>
        /// Gets or Sets StripeCardId
        /// </summary>
        [DataMember(Name="stripeCardId", EmitDefaultValue=false)]
        public string StripeCardId { get; set; }
        /// <summary>
        /// Gets or Sets StripeSubscriptionId
        /// </summary>
        [DataMember(Name="stripeSubscriptionId", EmitDefaultValue=false)]
        public string StripeSubscriptionId { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Billing {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CompanyEmail: ").Append(CompanyEmail).Append("\n");
            sb.Append("  CompanyVat: ").Append(CompanyVat).Append("\n");
            sb.Append("  CompanyCard: ").Append(CompanyCard).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TaxPercent: ").Append(TaxPercent).Append("\n");
            sb.Append("  StripeCustomerId: ").Append(StripeCustomerId).Append("\n");
            sb.Append("  StripeCardId: ").Append(StripeCardId).Append("\n");
            sb.Append("  StripeSubscriptionId: ").Append(StripeSubscriptionId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(obj as Billing);
        }

        /// <summary>
        /// Returns true if Billing instances are equal
        /// </summary>
        /// <param name="other">Instance of Billing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Billing other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.CompanyEmail == other.CompanyEmail ||
                    this.CompanyEmail != null &&
                    this.CompanyEmail.Equals(other.CompanyEmail)
                ) && 
                (
                    this.CompanyVat == other.CompanyVat ||
                    this.CompanyVat != null &&
                    this.CompanyVat.Equals(other.CompanyVat)
                ) && 
                (
                    this.CompanyCard == other.CompanyCard ||
                    this.CompanyCard != null &&
                    this.CompanyCard.Equals(other.CompanyCard)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.TaxPercent == other.TaxPercent ||
                    this.TaxPercent != null &&
                    this.TaxPercent.Equals(other.TaxPercent)
                ) && 
                (
                    this.StripeCustomerId == other.StripeCustomerId ||
                    this.StripeCustomerId != null &&
                    this.StripeCustomerId.Equals(other.StripeCustomerId)
                ) && 
                (
                    this.StripeCardId == other.StripeCardId ||
                    this.StripeCardId != null &&
                    this.StripeCardId.Equals(other.StripeCardId)
                ) && 
                (
                    this.StripeSubscriptionId == other.StripeSubscriptionId ||
                    this.StripeSubscriptionId != null &&
                    this.StripeSubscriptionId.Equals(other.StripeSubscriptionId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
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
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.CompanyEmail != null)
                    hash = hash * 59 + this.CompanyEmail.GetHashCode();
                if (this.CompanyVat != null)
                    hash = hash * 59 + this.CompanyVat.GetHashCode();
                if (this.CompanyCard != null)
                    hash = hash * 59 + this.CompanyCard.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.TaxPercent != null)
                    hash = hash * 59 + this.TaxPercent.GetHashCode();
                if (this.StripeCustomerId != null)
                    hash = hash * 59 + this.StripeCustomerId.GetHashCode();
                if (this.StripeCardId != null)
                    hash = hash * 59 + this.StripeCardId.GetHashCode();
                if (this.StripeSubscriptionId != null)
                    hash = hash * 59 + this.StripeSubscriptionId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                return hash;
            }
        }
    }

}

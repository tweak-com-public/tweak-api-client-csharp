/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.15
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
    /// BillingPlan
    /// </summary>
    [DataContract]
    public partial class BillingPlan :  IEquatable<BillingPlan>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Plan for "plan"
            /// </summary>
            [EnumMember(Value = "plan")]
            Plan,
            
            /// <summary>
            /// Enum Additional for "additional"
            /// </summary>
            [EnumMember(Value = "additional")]
            Additional
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingPlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlan" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Name">Name.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Interval">Interval.</param>
        /// <param name="IntervalCount">IntervalCount.</param>
        /// <param name="StatementDescriptor">StatementDescriptor.</param>
        /// <param name="StatementDescription">StatementDescription.</param>
        /// <param name="TrialPeriodDays">TrialPeriodDays.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Created">Created.</param>
        public BillingPlan(string Id = null, string Name = null, double? Amount = null, string Currency = null, string Interval = null, double? IntervalCount = null, string StatementDescriptor = null, string StatementDescription = null, double? TrialPeriodDays = null, TypeEnum? Type = null, BillingLimit Limit = null, DateTime? Created = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for BillingPlan and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Name = Name;
            this.Amount = Amount;
            this.Currency = Currency;
            this.Interval = Interval;
            this.IntervalCount = IntervalCount;
            this.StatementDescriptor = StatementDescriptor;
            this.StatementDescription = StatementDescription;
            this.TrialPeriodDays = TrialPeriodDays;
            this.Type = Type;
            this.Limit = Limit;
            this.Created = Created;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name="interval", EmitDefaultValue=false)]
        public string Interval { get; set; }
        /// <summary>
        /// Gets or Sets IntervalCount
        /// </summary>
        [DataMember(Name="intervalCount", EmitDefaultValue=false)]
        public double? IntervalCount { get; set; }
        /// <summary>
        /// Gets or Sets StatementDescriptor
        /// </summary>
        [DataMember(Name="statementDescriptor", EmitDefaultValue=false)]
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets StatementDescription
        /// </summary>
        [DataMember(Name="statementDescription", EmitDefaultValue=false)]
        public string StatementDescription { get; set; }
        /// <summary>
        /// Gets or Sets TrialPeriodDays
        /// </summary>
        [DataMember(Name="trialPeriodDays", EmitDefaultValue=false)]
        public double? TrialPeriodDays { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public BillingLimit Limit { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlan {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  IntervalCount: ").Append(IntervalCount).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  StatementDescription: ").Append(StatementDescription).Append("\n");
            sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(obj as BillingPlan);
        }

        /// <summary>
        /// Returns true if BillingPlan instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlan other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Interval == other.Interval ||
                    this.Interval != null &&
                    this.Interval.Equals(other.Interval)
                ) && 
                (
                    this.IntervalCount == other.IntervalCount ||
                    this.IntervalCount != null &&
                    this.IntervalCount.Equals(other.IntervalCount)
                ) && 
                (
                    this.StatementDescriptor == other.StatementDescriptor ||
                    this.StatementDescriptor != null &&
                    this.StatementDescriptor.Equals(other.StatementDescriptor)
                ) && 
                (
                    this.StatementDescription == other.StatementDescription ||
                    this.StatementDescription != null &&
                    this.StatementDescription.Equals(other.StatementDescription)
                ) && 
                (
                    this.TrialPeriodDays == other.TrialPeriodDays ||
                    this.TrialPeriodDays != null &&
                    this.TrialPeriodDays.Equals(other.TrialPeriodDays)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Interval != null)
                    hash = hash * 59 + this.Interval.GetHashCode();
                if (this.IntervalCount != null)
                    hash = hash * 59 + this.IntervalCount.GetHashCode();
                if (this.StatementDescriptor != null)
                    hash = hash * 59 + this.StatementDescriptor.GetHashCode();
                if (this.StatementDescription != null)
                    hash = hash * 59 + this.StatementDescription.GetHashCode();
                if (this.TrialPeriodDays != null)
                    hash = hash * 59 + this.TrialPeriodDays.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                return hash;
            }
        }
    }

}

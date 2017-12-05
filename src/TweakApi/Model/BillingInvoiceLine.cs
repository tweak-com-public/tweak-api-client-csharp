/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.2
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
    /// BillingInvoiceLine
    /// </summary>
    [DataContract]
    public partial class BillingInvoiceLine :  IEquatable<BillingInvoiceLine>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoiceLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingInvoiceLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoiceLine" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="Date">Date.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Discountable">Discountable.</param>
        /// <param name="Invoice">Invoice.</param>
        /// <param name="Period">Period.</param>
        /// <param name="Plan">Plan.</param>
        /// <param name="Proration">Proration.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="SubscriptionItem">SubscriptionItem.</param>
        public BillingInvoiceLine(string Id = null, double? Amount = null, string Currency = null, string Customer = null, DateTime? Date = null, string Description = null, bool? Discountable = null, string Invoice = null, Object Period = null, BillingPlan Plan = null, bool? Proration = null, double? Quantity = null, string Subscription = null, string SubscriptionItem = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for BillingInvoiceLine and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Amount = Amount;
            this.Currency = Currency;
            this.Customer = Customer;
            this.Date = Date;
            this.Description = Description;
            this.Discountable = Discountable;
            this.Invoice = Invoice;
            this.Period = Period;
            this.Plan = Plan;
            this.Proration = Proration;
            this.Quantity = Quantity;
            this.Subscription = Subscription;
            this.SubscriptionItem = SubscriptionItem;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
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
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; set; }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Discountable
        /// </summary>
        [DataMember(Name="discountable", EmitDefaultValue=false)]
        public bool? Discountable { get; set; }
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public string Invoice { get; set; }
        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public Object Period { get; set; }
        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name="plan", EmitDefaultValue=false)]
        public BillingPlan Plan { get; set; }
        /// <summary>
        /// Gets or Sets Proration
        /// </summary>
        [DataMember(Name="proration", EmitDefaultValue=false)]
        public bool? Proration { get; set; }
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public double? Quantity { get; set; }
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; set; }
        /// <summary>
        /// Gets or Sets SubscriptionItem
        /// </summary>
        [DataMember(Name="subscriptionItem", EmitDefaultValue=false)]
        public string SubscriptionItem { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInvoiceLine {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Discountable: ").Append(Discountable).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  Proration: ").Append(Proration).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SubscriptionItem: ").Append(SubscriptionItem).Append("\n");
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
            return this.Equals(obj as BillingInvoiceLine);
        }

        /// <summary>
        /// Returns true if BillingInvoiceLine instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingInvoiceLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInvoiceLine other)
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
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Discountable == other.Discountable ||
                    this.Discountable != null &&
                    this.Discountable.Equals(other.Discountable)
                ) && 
                (
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.Period == other.Period ||
                    this.Period != null &&
                    this.Period.Equals(other.Period)
                ) && 
                (
                    this.Plan == other.Plan ||
                    this.Plan != null &&
                    this.Plan.Equals(other.Plan)
                ) && 
                (
                    this.Proration == other.Proration ||
                    this.Proration != null &&
                    this.Proration.Equals(other.Proration)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.SubscriptionItem == other.SubscriptionItem ||
                    this.SubscriptionItem != null &&
                    this.SubscriptionItem.Equals(other.SubscriptionItem)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Discountable != null)
                    hash = hash * 59 + this.Discountable.GetHashCode();
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.Period != null)
                    hash = hash * 59 + this.Period.GetHashCode();
                if (this.Plan != null)
                    hash = hash * 59 + this.Plan.GetHashCode();
                if (this.Proration != null)
                    hash = hash * 59 + this.Proration.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.SubscriptionItem != null)
                    hash = hash * 59 + this.SubscriptionItem.GetHashCode();
                return hash;
            }
        }
    }

}

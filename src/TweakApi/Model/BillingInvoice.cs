/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.10
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
    /// BillingInvoice
    /// </summary>
    [DataContract]
    public partial class BillingInvoice :  IEquatable<BillingInvoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BillingInvoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingInvoice" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AmountDue">AmountDue.</param>
        /// <param name="AttemptCount">AttemptCount.</param>
        /// <param name="Attempted">Attempted.</param>
        /// <param name="Charged">Charged.</param>
        /// <param name="Closed">Closed.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="Date">Date.</param>
        /// <param name="Description">Description.</param>
        /// <param name="EndingBalance">EndingBalance.</param>
        /// <param name="Forgiven">Forgiven.</param>
        /// <param name="Lines">Lines.</param>
        /// <param name="NextPaymentAttempt">NextPaymentAttempt.</param>
        /// <param name="Paid">Paid.</param>
        /// <param name="PeriodEnd">PeriodEnd.</param>
        /// <param name="PeriodStart">PeriodStart.</param>
        /// <param name="Number">Number.</param>
        /// <param name="ReciptNumber">ReciptNumber.</param>
        /// <param name="StartingBalance">StartingBalance.</param>
        /// <param name="StatementDescriptor">StatementDescriptor.</param>
        /// <param name="Subscription">Subscription.</param>
        /// <param name="SubscriptionProrationDate">SubscriptionProrationDate.</param>
        /// <param name="Subtotal">Subtotal.</param>
        /// <param name="Tax">Tax.</param>
        /// <param name="Total">Total.</param>
        public BillingInvoice(string Id = null, double? AmountDue = null, double? AttemptCount = null, bool? Attempted = null, bool? Charged = null, bool? Closed = null, string Currency = null, string Customer = null, DateTime? Date = null, string Description = null, double? EndingBalance = null, bool? Forgiven = null, List<BillingInvoiceLine> Lines = null, DateTime? NextPaymentAttempt = null, bool? Paid = null, DateTime? PeriodEnd = null, DateTime? PeriodStart = null, string Number = null, string ReciptNumber = null, double? StartingBalance = null, string StatementDescriptor = null, string Subscription = null, double? SubscriptionProrationDate = null, double? Subtotal = null, double? Tax = null, double? Total = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for BillingInvoice and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AmountDue = AmountDue;
            this.AttemptCount = AttemptCount;
            this.Attempted = Attempted;
            this.Charged = Charged;
            this.Closed = Closed;
            this.Currency = Currency;
            this.Customer = Customer;
            this.Date = Date;
            this.Description = Description;
            this.EndingBalance = EndingBalance;
            this.Forgiven = Forgiven;
            this.Lines = Lines;
            this.NextPaymentAttempt = NextPaymentAttempt;
            this.Paid = Paid;
            this.PeriodEnd = PeriodEnd;
            this.PeriodStart = PeriodStart;
            this.Number = Number;
            this.ReciptNumber = ReciptNumber;
            this.StartingBalance = StartingBalance;
            this.StatementDescriptor = StatementDescriptor;
            this.Subscription = Subscription;
            this.SubscriptionProrationDate = SubscriptionProrationDate;
            this.Subtotal = Subtotal;
            this.Tax = Tax;
            this.Total = Total;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets AmountDue
        /// </summary>
        [DataMember(Name="amountDue", EmitDefaultValue=false)]
        public double? AmountDue { get; set; }
        /// <summary>
        /// Gets or Sets AttemptCount
        /// </summary>
        [DataMember(Name="attemptCount", EmitDefaultValue=false)]
        public double? AttemptCount { get; set; }
        /// <summary>
        /// Gets or Sets Attempted
        /// </summary>
        [DataMember(Name="attempted", EmitDefaultValue=false)]
        public bool? Attempted { get; set; }
        /// <summary>
        /// Gets or Sets Charged
        /// </summary>
        [DataMember(Name="charged", EmitDefaultValue=false)]
        public bool? Charged { get; set; }
        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name="closed", EmitDefaultValue=false)]
        public bool? Closed { get; set; }
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
        /// Gets or Sets EndingBalance
        /// </summary>
        [DataMember(Name="endingBalance", EmitDefaultValue=false)]
        public double? EndingBalance { get; set; }
        /// <summary>
        /// Gets or Sets Forgiven
        /// </summary>
        [DataMember(Name="forgiven", EmitDefaultValue=false)]
        public bool? Forgiven { get; set; }
        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="lines", EmitDefaultValue=false)]
        public List<BillingInvoiceLine> Lines { get; set; }
        /// <summary>
        /// Gets or Sets NextPaymentAttempt
        /// </summary>
        [DataMember(Name="nextPaymentAttempt", EmitDefaultValue=false)]
        public DateTime? NextPaymentAttempt { get; set; }
        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name="paid", EmitDefaultValue=false)]
        public bool? Paid { get; set; }
        /// <summary>
        /// Gets or Sets PeriodEnd
        /// </summary>
        [DataMember(Name="periodEnd", EmitDefaultValue=false)]
        public DateTime? PeriodEnd { get; set; }
        /// <summary>
        /// Gets or Sets PeriodStart
        /// </summary>
        [DataMember(Name="periodStart", EmitDefaultValue=false)]
        public DateTime? PeriodStart { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }
        /// <summary>
        /// Gets or Sets ReciptNumber
        /// </summary>
        [DataMember(Name="reciptNumber", EmitDefaultValue=false)]
        public string ReciptNumber { get; set; }
        /// <summary>
        /// Gets or Sets StartingBalance
        /// </summary>
        [DataMember(Name="startingBalance", EmitDefaultValue=false)]
        public double? StartingBalance { get; set; }
        /// <summary>
        /// Gets or Sets StatementDescriptor
        /// </summary>
        [DataMember(Name="statementDescriptor", EmitDefaultValue=false)]
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public string Subscription { get; set; }
        /// <summary>
        /// Gets or Sets SubscriptionProrationDate
        /// </summary>
        [DataMember(Name="subscriptionProrationDate", EmitDefaultValue=false)]
        public double? SubscriptionProrationDate { get; set; }
        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=false)]
        public double? Subtotal { get; set; }
        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public double? Tax { get; set; }
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public double? Total { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingInvoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountDue: ").Append(AmountDue).Append("\n");
            sb.Append("  AttemptCount: ").Append(AttemptCount).Append("\n");
            sb.Append("  Attempted: ").Append(Attempted).Append("\n");
            sb.Append("  Charged: ").Append(Charged).Append("\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndingBalance: ").Append(EndingBalance).Append("\n");
            sb.Append("  Forgiven: ").Append(Forgiven).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  NextPaymentAttempt: ").Append(NextPaymentAttempt).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ReciptNumber: ").Append(ReciptNumber).Append("\n");
            sb.Append("  StartingBalance: ").Append(StartingBalance).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SubscriptionProrationDate: ").Append(SubscriptionProrationDate).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as BillingInvoice);
        }

        /// <summary>
        /// Returns true if BillingInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingInvoice other)
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
                    this.AmountDue == other.AmountDue ||
                    this.AmountDue != null &&
                    this.AmountDue.Equals(other.AmountDue)
                ) && 
                (
                    this.AttemptCount == other.AttemptCount ||
                    this.AttemptCount != null &&
                    this.AttemptCount.Equals(other.AttemptCount)
                ) && 
                (
                    this.Attempted == other.Attempted ||
                    this.Attempted != null &&
                    this.Attempted.Equals(other.Attempted)
                ) && 
                (
                    this.Charged == other.Charged ||
                    this.Charged != null &&
                    this.Charged.Equals(other.Charged)
                ) && 
                (
                    this.Closed == other.Closed ||
                    this.Closed != null &&
                    this.Closed.Equals(other.Closed)
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
                    this.EndingBalance == other.EndingBalance ||
                    this.EndingBalance != null &&
                    this.EndingBalance.Equals(other.EndingBalance)
                ) && 
                (
                    this.Forgiven == other.Forgiven ||
                    this.Forgiven != null &&
                    this.Forgiven.Equals(other.Forgiven)
                ) && 
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(other.Lines)
                ) && 
                (
                    this.NextPaymentAttempt == other.NextPaymentAttempt ||
                    this.NextPaymentAttempt != null &&
                    this.NextPaymentAttempt.Equals(other.NextPaymentAttempt)
                ) && 
                (
                    this.Paid == other.Paid ||
                    this.Paid != null &&
                    this.Paid.Equals(other.Paid)
                ) && 
                (
                    this.PeriodEnd == other.PeriodEnd ||
                    this.PeriodEnd != null &&
                    this.PeriodEnd.Equals(other.PeriodEnd)
                ) && 
                (
                    this.PeriodStart == other.PeriodStart ||
                    this.PeriodStart != null &&
                    this.PeriodStart.Equals(other.PeriodStart)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.ReciptNumber == other.ReciptNumber ||
                    this.ReciptNumber != null &&
                    this.ReciptNumber.Equals(other.ReciptNumber)
                ) && 
                (
                    this.StartingBalance == other.StartingBalance ||
                    this.StartingBalance != null &&
                    this.StartingBalance.Equals(other.StartingBalance)
                ) && 
                (
                    this.StatementDescriptor == other.StatementDescriptor ||
                    this.StatementDescriptor != null &&
                    this.StatementDescriptor.Equals(other.StatementDescriptor)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.SubscriptionProrationDate == other.SubscriptionProrationDate ||
                    this.SubscriptionProrationDate != null &&
                    this.SubscriptionProrationDate.Equals(other.SubscriptionProrationDate)
                ) && 
                (
                    this.Subtotal == other.Subtotal ||
                    this.Subtotal != null &&
                    this.Subtotal.Equals(other.Subtotal)
                ) && 
                (
                    this.Tax == other.Tax ||
                    this.Tax != null &&
                    this.Tax.Equals(other.Tax)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.AmountDue != null)
                    hash = hash * 59 + this.AmountDue.GetHashCode();
                if (this.AttemptCount != null)
                    hash = hash * 59 + this.AttemptCount.GetHashCode();
                if (this.Attempted != null)
                    hash = hash * 59 + this.Attempted.GetHashCode();
                if (this.Charged != null)
                    hash = hash * 59 + this.Charged.GetHashCode();
                if (this.Closed != null)
                    hash = hash * 59 + this.Closed.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.EndingBalance != null)
                    hash = hash * 59 + this.EndingBalance.GetHashCode();
                if (this.Forgiven != null)
                    hash = hash * 59 + this.Forgiven.GetHashCode();
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
                if (this.NextPaymentAttempt != null)
                    hash = hash * 59 + this.NextPaymentAttempt.GetHashCode();
                if (this.Paid != null)
                    hash = hash * 59 + this.Paid.GetHashCode();
                if (this.PeriodEnd != null)
                    hash = hash * 59 + this.PeriodEnd.GetHashCode();
                if (this.PeriodStart != null)
                    hash = hash * 59 + this.PeriodStart.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.ReciptNumber != null)
                    hash = hash * 59 + this.ReciptNumber.GetHashCode();
                if (this.StartingBalance != null)
                    hash = hash * 59 + this.StartingBalance.GetHashCode();
                if (this.StatementDescriptor != null)
                    hash = hash * 59 + this.StatementDescriptor.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.SubscriptionProrationDate != null)
                    hash = hash * 59 + this.SubscriptionProrationDate.GetHashCode();
                if (this.Subtotal != null)
                    hash = hash * 59 + this.Subtotal.GetHashCode();
                if (this.Tax != null)
                    hash = hash * 59 + this.Tax.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }
    }

}

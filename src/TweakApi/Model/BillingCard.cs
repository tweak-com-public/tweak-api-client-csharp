/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.6
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
    /// BillingCard
    /// </summary>
    [DataContract]
    public partial class BillingCard :  IEquatable<BillingCard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCard" /> class.
        /// </summary>
        /// <param name="CardholderName">CardholderName.</param>
        /// <param name="ExpMonth">ExpMonth.</param>
        /// <param name="ExpYear">ExpYear.</param>
        /// <param name="Token">Token.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Cvc">Cvc.</param>
        /// <param name="CvcCheck">CvcCheck.</param>
        /// <param name="Last4">Last4.</param>
        /// <param name="Brand">Brand.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Funding">Funding.</param>
        /// <param name="Type">Type.</param>
        /// <param name="AddressCity">AddressCity.</param>
        /// <param name="AddressCountry">AddressCountry.</param>
        /// <param name="AddressLine1">AddressLine1.</param>
        /// <param name="AddressLine2">AddressLine2.</param>
        /// <param name="AddressState">AddressState.</param>
        /// <param name="AddressZip">AddressZip.</param>
        /// <param name="StripeCardId">StripeCardId.</param>
        /// <param name="Id">Id.</param>
        public BillingCard(string CardholderName = null, double? ExpMonth = null, double? ExpYear = null, string Token = null, string Number = null, string Cvc = null, string CvcCheck = null, string Last4 = null, string Brand = null, string Country = null, string Funding = null, string Type = null, string AddressCity = null, string AddressCountry = null, string AddressLine1 = null, string AddressLine2 = null, string AddressState = null, string AddressZip = null, string StripeCardId = null, string Id = null)
        {
            this.CardholderName = CardholderName;
            this.ExpMonth = ExpMonth;
            this.ExpYear = ExpYear;
            this.Token = Token;
            this.Number = Number;
            this.Cvc = Cvc;
            this.CvcCheck = CvcCheck;
            this.Last4 = Last4;
            this.Brand = Brand;
            this.Country = Country;
            this.Funding = Funding;
            this.Type = Type;
            this.AddressCity = AddressCity;
            this.AddressCountry = AddressCountry;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AddressState = AddressState;
            this.AddressZip = AddressZip;
            this.StripeCardId = StripeCardId;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets CardholderName
        /// </summary>
        [DataMember(Name="cardholderName", EmitDefaultValue=false)]
        public string CardholderName { get; set; }
        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name="expMonth", EmitDefaultValue=false)]
        public double? ExpMonth { get; set; }
        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name="expYear", EmitDefaultValue=false)]
        public double? ExpYear { get; set; }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }
        /// <summary>
        /// Gets or Sets Cvc
        /// </summary>
        [DataMember(Name="cvc", EmitDefaultValue=false)]
        public string Cvc { get; set; }
        /// <summary>
        /// Gets or Sets CvcCheck
        /// </summary>
        [DataMember(Name="cvcCheck", EmitDefaultValue=false)]
        public string CvcCheck { get; set; }
        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        public string Last4 { get; set; }
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets Funding
        /// </summary>
        [DataMember(Name="funding", EmitDefaultValue=false)]
        public string Funding { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="addressCity", EmitDefaultValue=false)]
        public string AddressCity { get; set; }
        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name="addressCountry", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Gets or Sets AddressState
        /// </summary>
        [DataMember(Name="addressState", EmitDefaultValue=false)]
        public string AddressState { get; set; }
        /// <summary>
        /// Gets or Sets AddressZip
        /// </summary>
        [DataMember(Name="addressZip", EmitDefaultValue=false)]
        public string AddressZip { get; set; }
        /// <summary>
        /// Gets or Sets StripeCardId
        /// </summary>
        [DataMember(Name="stripeCardId", EmitDefaultValue=false)]
        public string StripeCardId { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingCard {\n");
            sb.Append("  CardholderName: ").Append(CardholderName).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  CvcCheck: ").Append(CvcCheck).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Funding: ").Append(Funding).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
            sb.Append("  StripeCardId: ").Append(StripeCardId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as BillingCard);
        }

        /// <summary>
        /// Returns true if BillingCard instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardholderName == other.CardholderName ||
                    this.CardholderName != null &&
                    this.CardholderName.Equals(other.CardholderName)
                ) && 
                (
                    this.ExpMonth == other.ExpMonth ||
                    this.ExpMonth != null &&
                    this.ExpMonth.Equals(other.ExpMonth)
                ) && 
                (
                    this.ExpYear == other.ExpYear ||
                    this.ExpYear != null &&
                    this.ExpYear.Equals(other.ExpYear)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.Cvc == other.Cvc ||
                    this.Cvc != null &&
                    this.Cvc.Equals(other.Cvc)
                ) && 
                (
                    this.CvcCheck == other.CvcCheck ||
                    this.CvcCheck != null &&
                    this.CvcCheck.Equals(other.CvcCheck)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Funding == other.Funding ||
                    this.Funding != null &&
                    this.Funding.Equals(other.Funding)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.AddressCity == other.AddressCity ||
                    this.AddressCity != null &&
                    this.AddressCity.Equals(other.AddressCity)
                ) && 
                (
                    this.AddressCountry == other.AddressCountry ||
                    this.AddressCountry != null &&
                    this.AddressCountry.Equals(other.AddressCountry)
                ) && 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.AddressState == other.AddressState ||
                    this.AddressState != null &&
                    this.AddressState.Equals(other.AddressState)
                ) && 
                (
                    this.AddressZip == other.AddressZip ||
                    this.AddressZip != null &&
                    this.AddressZip.Equals(other.AddressZip)
                ) && 
                (
                    this.StripeCardId == other.StripeCardId ||
                    this.StripeCardId != null &&
                    this.StripeCardId.Equals(other.StripeCardId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.CardholderName != null)
                    hash = hash * 59 + this.CardholderName.GetHashCode();
                if (this.ExpMonth != null)
                    hash = hash * 59 + this.ExpMonth.GetHashCode();
                if (this.ExpYear != null)
                    hash = hash * 59 + this.ExpYear.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Cvc != null)
                    hash = hash * 59 + this.Cvc.GetHashCode();
                if (this.CvcCheck != null)
                    hash = hash * 59 + this.CvcCheck.GetHashCode();
                if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Funding != null)
                    hash = hash * 59 + this.Funding.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.AddressCity != null)
                    hash = hash * 59 + this.AddressCity.GetHashCode();
                if (this.AddressCountry != null)
                    hash = hash * 59 + this.AddressCountry.GetHashCode();
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressState != null)
                    hash = hash * 59 + this.AddressState.GetHashCode();
                if (this.AddressZip != null)
                    hash = hash * 59 + this.AddressZip.GetHashCode();
                if (this.StripeCardId != null)
                    hash = hash * 59 + this.StripeCardId.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

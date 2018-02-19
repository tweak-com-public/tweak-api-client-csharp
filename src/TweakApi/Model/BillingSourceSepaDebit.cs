/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.13
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
    /// BillingSourceSepaDebit
    /// </summary>
    [DataContract]
    public partial class BillingSourceSepaDebit :  IEquatable<BillingSourceSepaDebit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSourceSepaDebit" /> class.
        /// </summary>
        /// <param name="BankCode">BankCode.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Fingerprint">Fingerprint.</param>
        /// <param name="Last4">Last4.</param>
        /// <param name="MandateReference">MandateReference.</param>
        /// <param name="MandateUrl">MandateUrl.</param>
        /// <param name="Id">Id.</param>
        public BillingSourceSepaDebit(string BankCode = null, string Country = null, string Fingerprint = null, string Last4 = null, string MandateReference = null, string MandateUrl = null, string Id = null)
        {
            this.BankCode = BankCode;
            this.Country = Country;
            this.Fingerprint = Fingerprint;
            this.Last4 = Last4;
            this.MandateReference = MandateReference;
            this.MandateUrl = MandateUrl;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [DataMember(Name="bankCode", EmitDefaultValue=false)]
        public string BankCode { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }
        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name="last4", EmitDefaultValue=false)]
        public string Last4 { get; set; }
        /// <summary>
        /// Gets or Sets MandateReference
        /// </summary>
        [DataMember(Name="mandateReference", EmitDefaultValue=false)]
        public string MandateReference { get; set; }
        /// <summary>
        /// Gets or Sets MandateUrl
        /// </summary>
        [DataMember(Name="mandateUrl", EmitDefaultValue=false)]
        public string MandateUrl { get; set; }
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
            sb.Append("class BillingSourceSepaDebit {\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  MandateReference: ").Append(MandateReference).Append("\n");
            sb.Append("  MandateUrl: ").Append(MandateUrl).Append("\n");
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
            return this.Equals(obj as BillingSourceSepaDebit);
        }

        /// <summary>
        /// Returns true if BillingSourceSepaDebit instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingSourceSepaDebit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingSourceSepaDebit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BankCode == other.BankCode ||
                    this.BankCode != null &&
                    this.BankCode.Equals(other.BankCode)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
                ) && 
                (
                    this.Last4 == other.Last4 ||
                    this.Last4 != null &&
                    this.Last4.Equals(other.Last4)
                ) && 
                (
                    this.MandateReference == other.MandateReference ||
                    this.MandateReference != null &&
                    this.MandateReference.Equals(other.MandateReference)
                ) && 
                (
                    this.MandateUrl == other.MandateUrl ||
                    this.MandateUrl != null &&
                    this.MandateUrl.Equals(other.MandateUrl)
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
                if (this.BankCode != null)
                    hash = hash * 59 + this.BankCode.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();
                if (this.Last4 != null)
                    hash = hash * 59 + this.Last4.GetHashCode();
                if (this.MandateReference != null)
                    hash = hash * 59 + this.MandateReference.GetHashCode();
                if (this.MandateUrl != null)
                    hash = hash * 59 + this.MandateUrl.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

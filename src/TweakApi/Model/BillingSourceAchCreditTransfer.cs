/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-beta.0
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
    /// BillingSourceAchCreditTransfer
    /// </summary>
    [DataContract]
    public partial class BillingSourceAchCreditTransfer :  IEquatable<BillingSourceAchCreditTransfer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSourceAchCreditTransfer" /> class.
        /// </summary>
        /// <param name="AccountNumber">AccountNumber.</param>
        /// <param name="RoutingNumber">RoutingNumber.</param>
        /// <param name="Fingerprint">Fingerprint.</param>
        /// <param name="BankName">BankName.</param>
        /// <param name="SwiftCode">SwiftCode.</param>
        /// <param name="Id">Id.</param>
        public BillingSourceAchCreditTransfer(string AccountNumber = null, string RoutingNumber = null, string Fingerprint = null, string BankName = null, string SwiftCode = null, string Id = null)
        {
            this.AccountNumber = AccountNumber;
            this.RoutingNumber = RoutingNumber;
            this.Fingerprint = Fingerprint;
            this.BankName = BankName;
            this.SwiftCode = SwiftCode;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }
        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }
        /// <summary>
        /// Gets or Sets Fingerprint
        /// </summary>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }
        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bankName", EmitDefaultValue=false)]
        public string BankName { get; set; }
        /// <summary>
        /// Gets or Sets SwiftCode
        /// </summary>
        [DataMember(Name="swiftCode", EmitDefaultValue=false)]
        public string SwiftCode { get; set; }
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
            sb.Append("class BillingSourceAchCreditTransfer {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
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
            return this.Equals(obj as BillingSourceAchCreditTransfer);
        }

        /// <summary>
        /// Returns true if BillingSourceAchCreditTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingSourceAchCreditTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingSourceAchCreditTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
                ) && 
                (
                    this.BankName == other.BankName ||
                    this.BankName != null &&
                    this.BankName.Equals(other.BankName)
                ) && 
                (
                    this.SwiftCode == other.SwiftCode ||
                    this.SwiftCode != null &&
                    this.SwiftCode.Equals(other.SwiftCode)
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
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();
                if (this.BankName != null)
                    hash = hash * 59 + this.BankName.GetHashCode();
                if (this.SwiftCode != null)
                    hash = hash * 59 + this.SwiftCode.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

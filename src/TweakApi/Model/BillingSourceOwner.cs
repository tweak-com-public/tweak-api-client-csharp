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
    /// BillingSourceOwner
    /// </summary>
    [DataContract]
    public partial class BillingSourceOwner :  IEquatable<BillingSourceOwner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSourceOwner" /> class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="VerifiedAddress">VerifiedAddress.</param>
        /// <param name="VerifiedEmail">VerifiedEmail.</param>
        /// <param name="VerifiedName">VerifiedName.</param>
        /// <param name="VerifiedPhone">VerifiedPhone.</param>
        /// <param name="Id">Id.</param>
        public BillingSourceOwner(BillingAddress Address = null, string Email = null, string Name = null, string Phone = null, BillingAddress VerifiedAddress = null, string VerifiedEmail = null, string VerifiedName = null, string VerifiedPhone = null, string Id = null)
        {
            this.Address = Address;
            this.Email = Email;
            this.Name = Name;
            this.Phone = Phone;
            this.VerifiedAddress = VerifiedAddress;
            this.VerifiedEmail = VerifiedEmail;
            this.VerifiedName = VerifiedName;
            this.VerifiedPhone = VerifiedPhone;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public BillingAddress Address { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets VerifiedAddress
        /// </summary>
        [DataMember(Name="verifiedAddress", EmitDefaultValue=false)]
        public BillingAddress VerifiedAddress { get; set; }
        /// <summary>
        /// Gets or Sets VerifiedEmail
        /// </summary>
        [DataMember(Name="verifiedEmail", EmitDefaultValue=false)]
        public string VerifiedEmail { get; set; }
        /// <summary>
        /// Gets or Sets VerifiedName
        /// </summary>
        [DataMember(Name="verifiedName", EmitDefaultValue=false)]
        public string VerifiedName { get; set; }
        /// <summary>
        /// Gets or Sets VerifiedPhone
        /// </summary>
        [DataMember(Name="verifiedPhone", EmitDefaultValue=false)]
        public string VerifiedPhone { get; set; }
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
            sb.Append("class BillingSourceOwner {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  VerifiedAddress: ").Append(VerifiedAddress).Append("\n");
            sb.Append("  VerifiedEmail: ").Append(VerifiedEmail).Append("\n");
            sb.Append("  VerifiedName: ").Append(VerifiedName).Append("\n");
            sb.Append("  VerifiedPhone: ").Append(VerifiedPhone).Append("\n");
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
            return this.Equals(obj as BillingSourceOwner);
        }

        /// <summary>
        /// Returns true if BillingSourceOwner instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingSourceOwner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingSourceOwner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.VerifiedAddress == other.VerifiedAddress ||
                    this.VerifiedAddress != null &&
                    this.VerifiedAddress.Equals(other.VerifiedAddress)
                ) && 
                (
                    this.VerifiedEmail == other.VerifiedEmail ||
                    this.VerifiedEmail != null &&
                    this.VerifiedEmail.Equals(other.VerifiedEmail)
                ) && 
                (
                    this.VerifiedName == other.VerifiedName ||
                    this.VerifiedName != null &&
                    this.VerifiedName.Equals(other.VerifiedName)
                ) && 
                (
                    this.VerifiedPhone == other.VerifiedPhone ||
                    this.VerifiedPhone != null &&
                    this.VerifiedPhone.Equals(other.VerifiedPhone)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.VerifiedAddress != null)
                    hash = hash * 59 + this.VerifiedAddress.GetHashCode();
                if (this.VerifiedEmail != null)
                    hash = hash * 59 + this.VerifiedEmail.GetHashCode();
                if (this.VerifiedName != null)
                    hash = hash * 59 + this.VerifiedName.GetHashCode();
                if (this.VerifiedPhone != null)
                    hash = hash * 59 + this.VerifiedPhone.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

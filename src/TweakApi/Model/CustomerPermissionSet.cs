/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.1
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
    /// CustomerPermissionSet
    /// </summary>
    [DataContract]
    public partial class CustomerPermissionSet :  IEquatable<CustomerPermissionSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPermissionSet" /> class.
        /// </summary>
        /// <param name="TweakEmail">TweakEmail (default to true).</param>
        /// <param name="Id">Id.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="Customer">Customer.</param>
        public CustomerPermissionSet(bool? TweakEmail = null, string Id = null, string CustomerId = null, Customer Customer = null)
        {
            // use default value if no "TweakEmail" provided
            if (TweakEmail == null)
            {
                this.TweakEmail = true;
            }
            else
            {
                this.TweakEmail = TweakEmail;
            }
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.Customer = Customer;
        }
        
        /// <summary>
        /// Gets or Sets TweakEmail
        /// </summary>
        [DataMember(Name="tweakEmail", EmitDefaultValue=false)]
        public bool? TweakEmail { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Customer Customer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPermissionSet {\n");
            sb.Append("  TweakEmail: ").Append(TweakEmail).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
            return this.Equals(obj as CustomerPermissionSet);
        }

        /// <summary>
        /// Returns true if CustomerPermissionSet instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerPermissionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerPermissionSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TweakEmail == other.TweakEmail ||
                    this.TweakEmail != null &&
                    this.TweakEmail.Equals(other.TweakEmail)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
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
                if (this.TweakEmail != null)
                    hash = hash * 59 + this.TweakEmail.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                return hash;
            }
        }
    }

}

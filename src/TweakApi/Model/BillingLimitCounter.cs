/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.2
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
    /// BillingLimitCounter
    /// </summary>
    [DataContract]
    public partial class BillingLimitCounter :  IEquatable<BillingLimitCounter>
    {
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitTypeEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Binary for "binary"
            /// </summary>
            [EnumMember(Value = "binary")]
            Binary
        }

        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public UnitTypeEnum? UnitType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingLimitCounter" /> class.
        /// </summary>
        /// <param name="Limit">Limit (default to 0.0).</param>
        /// <param name="Count">Count (default to 0.0).</param>
        /// <param name="UnitType">UnitType.</param>
        /// <param name="UnitPrefix">UnitPrefix.</param>
        /// <param name="Id">Id.</param>
        public BillingLimitCounter(double? Limit = null, double? Count = null, UnitTypeEnum? UnitType = null, string UnitPrefix = null, string Id = null)
        {
            // use default value if no "Limit" provided
            if (Limit == null)
            {
                this.Limit = 0.0;
            }
            else
            {
                this.Limit = Limit;
            }
            // use default value if no "Count" provided
            if (Count == null)
            {
                this.Count = 0.0;
            }
            else
            {
                this.Count = Count;
            }
            this.UnitType = UnitType;
            this.UnitPrefix = UnitPrefix;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public double? Limit { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public double? Count { get; set; }
        /// <summary>
        /// Gets or Sets UnitPrefix
        /// </summary>
        [DataMember(Name="unitPrefix", EmitDefaultValue=false)]
        public string UnitPrefix { get; set; }
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
            sb.Append("class BillingLimitCounter {\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitPrefix: ").Append(UnitPrefix).Append("\n");
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
            return this.Equals(obj as BillingLimitCounter);
        }

        /// <summary>
        /// Returns true if BillingLimitCounter instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingLimitCounter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingLimitCounter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.UnitType == other.UnitType ||
                    this.UnitType != null &&
                    this.UnitType.Equals(other.UnitType)
                ) && 
                (
                    this.UnitPrefix == other.UnitPrefix ||
                    this.UnitPrefix != null &&
                    this.UnitPrefix.Equals(other.UnitPrefix)
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
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.UnitType != null)
                    hash = hash * 59 + this.UnitType.GetHashCode();
                if (this.UnitPrefix != null)
                    hash = hash * 59 + this.UnitPrefix.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

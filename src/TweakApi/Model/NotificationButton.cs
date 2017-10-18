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
    /// NotificationButton
    /// </summary>
    [DataContract]
    public partial class NotificationButton :  IEquatable<NotificationButton>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Default for "default"
            /// </summary>
            [EnumMember(Value = "default")]
            Default,
            
            /// <summary>
            /// Enum Info for "info"
            /// </summary>
            [EnumMember(Value = "info")]
            Info,
            
            /// <summary>
            /// Enum Success for "success"
            /// </summary>
            [EnumMember(Value = "success")]
            Success,
            
            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning,
            
            /// <summary>
            /// Enum Danger for "danger"
            /// </summary>
            [EnumMember(Value = "danger")]
            Danger
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum NotificationMarkAsRead for "notification.markAs.read"
            /// </summary>
            [EnumMember(Value = "notification.markAs.read")]
            NotificationMarkAsRead,
            
            /// <summary>
            /// Enum TeamBillingDetails for "team.billing.details"
            /// </summary>
            [EnumMember(Value = "team.billing.details")]
            TeamBillingDetails,
            
            /// <summary>
            /// Enum TeamBillingUpgrade for "team.billing.upgrade"
            /// </summary>
            [EnumMember(Value = "team.billing.upgrade")]
            TeamBillingUpgrade,
            
            /// <summary>
            /// Enum TeamBillingInvoiceDetails for "team.billing.invoice.details"
            /// </summary>
            [EnumMember(Value = "team.billing.invoice.details")]
            TeamBillingInvoiceDetails,
            
            /// <summary>
            /// Enum TeamBillingCard for "team.billing.card"
            /// </summary>
            [EnumMember(Value = "team.billing.card")]
            TeamBillingCard
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationButton" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationButton() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationButton" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Label">Label (required).</param>
        /// <param name="Action">Action (required).</param>
        /// <param name="Id">Id.</param>
        public NotificationButton(TypeEnum? Type = null, string Label = null, ActionEnum? Action = null, string Id = null)
        {
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for NotificationButton and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "Action" is required (not null)
            if (Action == null)
            {
                throw new InvalidDataException("Action is a required property for NotificationButton and cannot be null");
            }
            else
            {
                this.Action = Action;
            }
            this.Type = Type;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
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
            sb.Append("class NotificationButton {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(obj as NotificationButton);
        }

        /// <summary>
        /// Returns true if NotificationButton instances are equal
        /// </summary>
        /// <param name="other">Instance of NotificationButton to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationButton other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

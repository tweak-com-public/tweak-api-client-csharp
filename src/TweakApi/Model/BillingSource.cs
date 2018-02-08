/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-beta.3
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
    /// BillingSource
    /// </summary>
    [DataContract]
    public partial class BillingSource :  IEquatable<BillingSource>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Sepadebit for "sepa_debit"
            /// </summary>
            [EnumMember(Value = "sepa_debit")]
            Sepadebit,
            
            /// <summary>
            /// Enum Sofort for "sofort"
            /// </summary>
            [EnumMember(Value = "sofort")]
            Sofort
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSource" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="_Object">_Object (default to &quot;source&quot;).</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="ClientSecret">ClientSecret.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Flow">Flow.</param>
        /// <param name="Livemode">Livemode.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Receiver">Receiver.</param>
        /// <param name="StatementDescriptor">StatementDescriptor.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Usage">Usage.</param>
        /// <param name="AchCreditTransfer">AchCreditTransfer.</param>
        /// <param name="SepaDebit">SepaDebit.</param>
        /// <param name="Sofort">Sofort.</param>
        /// <param name="Redirect">Redirect.</param>
        /// <param name="Token">Token.</param>
        public BillingSource(string Id = null, string _Object = null, double? Amount = null, string ClientSecret = null, double? Created = null, string Currency = null, string Flow = null, bool? Livemode = null, BillingSourceOwner Owner = null, BillingSourceReceiver Receiver = null, string StatementDescriptor = null, string Status = null, TypeEnum? Type = null, string Usage = null, BillingSourceAchCreditTransfer AchCreditTransfer = null, BillingSourceSepaDebit SepaDebit = null, BillingSourceSofort Sofort = null, BillingSourceRedirect Redirect = null, string Token = null)
        {
            this.Id = Id;
            // use default value if no "_Object" provided
            if (_Object == null)
            {
                this._Object = "source";
            }
            else
            {
                this._Object = _Object;
            }
            this.Amount = Amount;
            this.ClientSecret = ClientSecret;
            this.Created = Created;
            this.Currency = Currency;
            this.Flow = Flow;
            this.Livemode = Livemode;
            this.Owner = Owner;
            this.Receiver = Receiver;
            this.StatementDescriptor = StatementDescriptor;
            this.Status = Status;
            this.Type = Type;
            this.Usage = Usage;
            this.AchCreditTransfer = AchCreditTransfer;
            this.SepaDebit = SepaDebit;
            this.Sofort = Sofort;
            this.Redirect = Redirect;
            this.Token = Token;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; set; }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public double? Created { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Flow
        /// </summary>
        [DataMember(Name="flow", EmitDefaultValue=false)]
        public string Flow { get; set; }
        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name="livemode", EmitDefaultValue=false)]
        public bool? Livemode { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public BillingSourceOwner Owner { get; set; }
        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name="receiver", EmitDefaultValue=false)]
        public BillingSourceReceiver Receiver { get; set; }
        /// <summary>
        /// Gets or Sets StatementDescriptor
        /// </summary>
        [DataMember(Name="statementDescriptor", EmitDefaultValue=false)]
        public string StatementDescriptor { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public string Usage { get; set; }
        /// <summary>
        /// Gets or Sets AchCreditTransfer
        /// </summary>
        [DataMember(Name="achCreditTransfer", EmitDefaultValue=false)]
        public BillingSourceAchCreditTransfer AchCreditTransfer { get; set; }
        /// <summary>
        /// Gets or Sets SepaDebit
        /// </summary>
        [DataMember(Name="sepaDebit", EmitDefaultValue=false)]
        public BillingSourceSepaDebit SepaDebit { get; set; }
        /// <summary>
        /// Gets or Sets Sofort
        /// </summary>
        [DataMember(Name="sofort", EmitDefaultValue=false)]
        public BillingSourceSofort Sofort { get; set; }
        /// <summary>
        /// Gets or Sets Redirect
        /// </summary>
        [DataMember(Name="redirect", EmitDefaultValue=false)]
        public BillingSourceRedirect Redirect { get; set; }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingSource {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Flow: ").Append(Flow).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  AchCreditTransfer: ").Append(AchCreditTransfer).Append("\n");
            sb.Append("  SepaDebit: ").Append(SepaDebit).Append("\n");
            sb.Append("  Sofort: ").Append(Sofort).Append("\n");
            sb.Append("  Redirect: ").Append(Redirect).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as BillingSource);
        }

        /// <summary>
        /// Returns true if BillingSource instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingSource other)
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
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Flow == other.Flow ||
                    this.Flow != null &&
                    this.Flow.Equals(other.Flow)
                ) && 
                (
                    this.Livemode == other.Livemode ||
                    this.Livemode != null &&
                    this.Livemode.Equals(other.Livemode)
                ) && 
                (
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Receiver == other.Receiver ||
                    this.Receiver != null &&
                    this.Receiver.Equals(other.Receiver)
                ) && 
                (
                    this.StatementDescriptor == other.StatementDescriptor ||
                    this.StatementDescriptor != null &&
                    this.StatementDescriptor.Equals(other.StatementDescriptor)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Usage == other.Usage ||
                    this.Usage != null &&
                    this.Usage.Equals(other.Usage)
                ) && 
                (
                    this.AchCreditTransfer == other.AchCreditTransfer ||
                    this.AchCreditTransfer != null &&
                    this.AchCreditTransfer.Equals(other.AchCreditTransfer)
                ) && 
                (
                    this.SepaDebit == other.SepaDebit ||
                    this.SepaDebit != null &&
                    this.SepaDebit.Equals(other.SepaDebit)
                ) && 
                (
                    this.Sofort == other.Sofort ||
                    this.Sofort != null &&
                    this.Sofort.Equals(other.Sofort)
                ) && 
                (
                    this.Redirect == other.Redirect ||
                    this.Redirect != null &&
                    this.Redirect.Equals(other.Redirect)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Flow != null)
                    hash = hash * 59 + this.Flow.GetHashCode();
                if (this.Livemode != null)
                    hash = hash * 59 + this.Livemode.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Receiver != null)
                    hash = hash * 59 + this.Receiver.GetHashCode();
                if (this.StatementDescriptor != null)
                    hash = hash * 59 + this.StatementDescriptor.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Usage != null)
                    hash = hash * 59 + this.Usage.GetHashCode();
                if (this.AchCreditTransfer != null)
                    hash = hash * 59 + this.AchCreditTransfer.GetHashCode();
                if (this.SepaDebit != null)
                    hash = hash * 59 + this.SepaDebit.GetHashCode();
                if (this.Sofort != null)
                    hash = hash * 59 + this.Sofort.GetHashCode();
                if (this.Redirect != null)
                    hash = hash * 59 + this.Redirect.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                return hash;
            }
        }
    }

}
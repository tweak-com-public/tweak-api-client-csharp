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
    /// BillingLimit
    /// </summary>
    [DataContract]
    public partial class BillingLimit :  IEquatable<BillingLimit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingLimit" /> class.
        /// </summary>
        /// <param name="TeamMember">TeamMember.</param>
        /// <param name="Uploader">Uploader.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="Jpeg">Jpeg.</param>
        /// <param name="Proof">Proof.</param>
        /// <param name="HighResPdf">HighResPdf.</param>
        /// <param name="Storage">Storage.</param>
        /// <param name="StockImageLibrary">StockImageLibrary.</param>
        /// <param name="ProductDbRecord">ProductDbRecord.</param>
        /// <param name="AccountSupport">AccountSupport (default to false).</param>
        /// <param name="SupportResponse">SupportResponse.</param>
        /// <param name="Bandwidth">Bandwidth.</param>
        /// <param name="PrinterApi">PrinterApi.</param>
        /// <param name="Id">Id.</param>
        public BillingLimit(BillingLimitCounter TeamMember = null, BillingLimitCounter Uploader = null, BillingLimitCounter Portal = null, BillingLimitCounter Jpeg = null, BillingLimitCounter Proof = null, BillingLimitCounter HighResPdf = null, BillingLimitCounter Storage = null, BillingLimitCounter StockImageLibrary = null, BillingLimitCounter ProductDbRecord = null, bool? AccountSupport = null, string SupportResponse = null, BillingLimitCounter Bandwidth = null, BillingLimitCounter PrinterApi = null, string Id = null)
        {
            this.TeamMember = TeamMember;
            this.Uploader = Uploader;
            this.Portal = Portal;
            this.Jpeg = Jpeg;
            this.Proof = Proof;
            this.HighResPdf = HighResPdf;
            this.Storage = Storage;
            this.StockImageLibrary = StockImageLibrary;
            this.ProductDbRecord = ProductDbRecord;
            // use default value if no "AccountSupport" provided
            if (AccountSupport == null)
            {
                this.AccountSupport = false;
            }
            else
            {
                this.AccountSupport = AccountSupport;
            }
            this.SupportResponse = SupportResponse;
            this.Bandwidth = Bandwidth;
            this.PrinterApi = PrinterApi;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets TeamMember
        /// </summary>
        [DataMember(Name="teamMember", EmitDefaultValue=false)]
        public BillingLimitCounter TeamMember { get; set; }
        /// <summary>
        /// Gets or Sets Uploader
        /// </summary>
        [DataMember(Name="uploader", EmitDefaultValue=false)]
        public BillingLimitCounter Uploader { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public BillingLimitCounter Portal { get; set; }
        /// <summary>
        /// Gets or Sets Jpeg
        /// </summary>
        [DataMember(Name="jpeg", EmitDefaultValue=false)]
        public BillingLimitCounter Jpeg { get; set; }
        /// <summary>
        /// Gets or Sets Proof
        /// </summary>
        [DataMember(Name="proof", EmitDefaultValue=false)]
        public BillingLimitCounter Proof { get; set; }
        /// <summary>
        /// Gets or Sets HighResPdf
        /// </summary>
        [DataMember(Name="highResPdf", EmitDefaultValue=false)]
        public BillingLimitCounter HighResPdf { get; set; }
        /// <summary>
        /// Gets or Sets Storage
        /// </summary>
        [DataMember(Name="storage", EmitDefaultValue=false)]
        public BillingLimitCounter Storage { get; set; }
        /// <summary>
        /// Gets or Sets StockImageLibrary
        /// </summary>
        [DataMember(Name="stockImageLibrary", EmitDefaultValue=false)]
        public BillingLimitCounter StockImageLibrary { get; set; }
        /// <summary>
        /// Gets or Sets ProductDbRecord
        /// </summary>
        [DataMember(Name="productDbRecord", EmitDefaultValue=false)]
        public BillingLimitCounter ProductDbRecord { get; set; }
        /// <summary>
        /// Gets or Sets AccountSupport
        /// </summary>
        [DataMember(Name="accountSupport", EmitDefaultValue=false)]
        public bool? AccountSupport { get; set; }
        /// <summary>
        /// Gets or Sets SupportResponse
        /// </summary>
        [DataMember(Name="supportResponse", EmitDefaultValue=false)]
        public string SupportResponse { get; set; }
        /// <summary>
        /// Gets or Sets Bandwidth
        /// </summary>
        [DataMember(Name="bandwidth", EmitDefaultValue=false)]
        public BillingLimitCounter Bandwidth { get; set; }
        /// <summary>
        /// Gets or Sets PrinterApi
        /// </summary>
        [DataMember(Name="printerApi", EmitDefaultValue=false)]
        public BillingLimitCounter PrinterApi { get; set; }
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
            sb.Append("class BillingLimit {\n");
            sb.Append("  TeamMember: ").Append(TeamMember).Append("\n");
            sb.Append("  Uploader: ").Append(Uploader).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  Jpeg: ").Append(Jpeg).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  HighResPdf: ").Append(HighResPdf).Append("\n");
            sb.Append("  Storage: ").Append(Storage).Append("\n");
            sb.Append("  StockImageLibrary: ").Append(StockImageLibrary).Append("\n");
            sb.Append("  ProductDbRecord: ").Append(ProductDbRecord).Append("\n");
            sb.Append("  AccountSupport: ").Append(AccountSupport).Append("\n");
            sb.Append("  SupportResponse: ").Append(SupportResponse).Append("\n");
            sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  PrinterApi: ").Append(PrinterApi).Append("\n");
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
            return this.Equals(obj as BillingLimit);
        }

        /// <summary>
        /// Returns true if BillingLimit instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingLimit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TeamMember == other.TeamMember ||
                    this.TeamMember != null &&
                    this.TeamMember.Equals(other.TeamMember)
                ) && 
                (
                    this.Uploader == other.Uploader ||
                    this.Uploader != null &&
                    this.Uploader.Equals(other.Uploader)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.Jpeg == other.Jpeg ||
                    this.Jpeg != null &&
                    this.Jpeg.Equals(other.Jpeg)
                ) && 
                (
                    this.Proof == other.Proof ||
                    this.Proof != null &&
                    this.Proof.Equals(other.Proof)
                ) && 
                (
                    this.HighResPdf == other.HighResPdf ||
                    this.HighResPdf != null &&
                    this.HighResPdf.Equals(other.HighResPdf)
                ) && 
                (
                    this.Storage == other.Storage ||
                    this.Storage != null &&
                    this.Storage.Equals(other.Storage)
                ) && 
                (
                    this.StockImageLibrary == other.StockImageLibrary ||
                    this.StockImageLibrary != null &&
                    this.StockImageLibrary.Equals(other.StockImageLibrary)
                ) && 
                (
                    this.ProductDbRecord == other.ProductDbRecord ||
                    this.ProductDbRecord != null &&
                    this.ProductDbRecord.Equals(other.ProductDbRecord)
                ) && 
                (
                    this.AccountSupport == other.AccountSupport ||
                    this.AccountSupport != null &&
                    this.AccountSupport.Equals(other.AccountSupport)
                ) && 
                (
                    this.SupportResponse == other.SupportResponse ||
                    this.SupportResponse != null &&
                    this.SupportResponse.Equals(other.SupportResponse)
                ) && 
                (
                    this.Bandwidth == other.Bandwidth ||
                    this.Bandwidth != null &&
                    this.Bandwidth.Equals(other.Bandwidth)
                ) && 
                (
                    this.PrinterApi == other.PrinterApi ||
                    this.PrinterApi != null &&
                    this.PrinterApi.Equals(other.PrinterApi)
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
                if (this.TeamMember != null)
                    hash = hash * 59 + this.TeamMember.GetHashCode();
                if (this.Uploader != null)
                    hash = hash * 59 + this.Uploader.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.Jpeg != null)
                    hash = hash * 59 + this.Jpeg.GetHashCode();
                if (this.Proof != null)
                    hash = hash * 59 + this.Proof.GetHashCode();
                if (this.HighResPdf != null)
                    hash = hash * 59 + this.HighResPdf.GetHashCode();
                if (this.Storage != null)
                    hash = hash * 59 + this.Storage.GetHashCode();
                if (this.StockImageLibrary != null)
                    hash = hash * 59 + this.StockImageLibrary.GetHashCode();
                if (this.ProductDbRecord != null)
                    hash = hash * 59 + this.ProductDbRecord.GetHashCode();
                if (this.AccountSupport != null)
                    hash = hash * 59 + this.AccountSupport.GetHashCode();
                if (this.SupportResponse != null)
                    hash = hash * 59 + this.SupportResponse.GetHashCode();
                if (this.Bandwidth != null)
                    hash = hash * 59 + this.Bandwidth.GetHashCode();
                if (this.PrinterApi != null)
                    hash = hash * 59 + this.PrinterApi.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

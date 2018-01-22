/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.2
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
    /// TeamBuilderConfigProductSizeMaterial
    /// </summary>
    [DataContract]
    public partial class TeamBuilderConfigProductSizeMaterial :  IEquatable<TeamBuilderConfigProductSizeMaterial>
    {
        /// <summary>
        /// Gets or Sets BindingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BindingTypeEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Saddlestitched for "saddle-stitched"
            /// </summary>
            [EnumMember(Value = "saddle-stitched")]
            Saddlestitched,
            
            /// <summary>
            /// Enum Perfect for "perfect"
            /// </summary>
            [EnumMember(Value = "perfect")]
            Perfect,
            
            /// <summary>
            /// Enum Sectionsewn for "section-sewn"
            /// </summary>
            [EnumMember(Value = "section-sewn")]
            Sectionsewn,
            
            /// <summary>
            /// Enum Wiro for "wiro"
            /// </summary>
            [EnumMember(Value = "wiro")]
            Wiro,
            
            /// <summary>
            /// Enum Casedinwiro for "cased-in-wiro"
            /// </summary>
            [EnumMember(Value = "cased-in-wiro")]
            Casedinwiro,
            
            /// <summary>
            /// Enum Pamphletstitched for "pamphlet-stitched"
            /// </summary>
            [EnumMember(Value = "pamphlet-stitched")]
            Pamphletstitched,
            
            /// <summary>
            /// Enum Coptic for "coptic"
            /// </summary>
            [EnumMember(Value = "coptic")]
            Coptic,
            
            /// <summary>
            /// Enum Japanese for "japanese"
            /// </summary>
            [EnumMember(Value = "japanese")]
            Japanese,
            
            /// <summary>
            /// Enum Screwpost for "screw-post"
            /// </summary>
            [EnumMember(Value = "screw-post")]
            Screwpost
        }

        /// <summary>
        /// Gets or Sets PrintProfile
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrintProfileEnum
        {
            
            /// <summary>
            /// Enum PDFX1A for "PDFX1A"
            /// </summary>
            [EnumMember(Value = "PDFX1A")]
            PDFX1A,
            
            /// <summary>
            /// Enum PDFX3A for "PDFX3A"
            /// </summary>
            [EnumMember(Value = "PDFX3A")]
            PDFX3A
        }

        /// <summary>
        /// Gets or Sets BindingType
        /// </summary>
        [DataMember(Name="bindingType", EmitDefaultValue=false)]
        public BindingTypeEnum? BindingType { get; set; }
        /// <summary>
        /// Gets or Sets PrintProfile
        /// </summary>
        [DataMember(Name="printProfile", EmitDefaultValue=false)]
        public PrintProfileEnum? PrintProfile { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamBuilderConfigProductSizeMaterial" /> class.
        /// </summary>
        /// <param name="BindingType">BindingType.</param>
        /// <param name="DefaultBleed">DefaultBleed.</param>
        /// <param name="PrintProfile">PrintProfile.</param>
        /// <param name="CustomerTitle">CustomerTitle (default to &quot;&quot;).</param>
        /// <param name="CustomerDescription">CustomerDescription (default to &quot;&quot;).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ProductSizeMaterialId">ProductSizeMaterialId.</param>
        /// <param name="PdfColorProfileId">PdfColorProfileId.</param>
        /// <param name="BuilderConfigId">BuilderConfigId.</param>
        /// <param name="BuilderConfig">BuilderConfig.</param>
        /// <param name="ProductSizeMaterial">ProductSizeMaterial.</param>
        /// <param name="PdfColorProfile">PdfColorProfile.</param>
        public TeamBuilderConfigProductSizeMaterial(BindingTypeEnum? BindingType = null, Bounds DefaultBleed = null, PrintProfileEnum? PrintProfile = null, string CustomerTitle = null, string CustomerDescription = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string ProductSizeMaterialId = null, string PdfColorProfileId = null, string BuilderConfigId = null, TeamBuilderConfig BuilderConfig = null, ProductSizeMaterial ProductSizeMaterial = null, ProductPdfColorProfile PdfColorProfile = null)
        {
            this.BindingType = BindingType;
            this.DefaultBleed = DefaultBleed;
            this.PrintProfile = PrintProfile;
            // use default value if no "CustomerTitle" provided
            if (CustomerTitle == null)
            {
                this.CustomerTitle = "";
            }
            else
            {
                this.CustomerTitle = CustomerTitle;
            }
            // use default value if no "CustomerDescription" provided
            if (CustomerDescription == null)
            {
                this.CustomerDescription = "";
            }
            else
            {
                this.CustomerDescription = CustomerDescription;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.ProductSizeMaterialId = ProductSizeMaterialId;
            this.PdfColorProfileId = PdfColorProfileId;
            this.BuilderConfigId = BuilderConfigId;
            this.BuilderConfig = BuilderConfig;
            this.ProductSizeMaterial = ProductSizeMaterial;
            this.PdfColorProfile = PdfColorProfile;
        }
        
        /// <summary>
        /// Gets or Sets DefaultBleed
        /// </summary>
        [DataMember(Name="defaultBleed", EmitDefaultValue=false)]
        public Bounds DefaultBleed { get; set; }
        /// <summary>
        /// Gets or Sets CustomerTitle
        /// </summary>
        [DataMember(Name="customerTitle", EmitDefaultValue=false)]
        public string CustomerTitle { get; set; }
        /// <summary>
        /// Gets or Sets CustomerDescription
        /// </summary>
        [DataMember(Name="customerDescription", EmitDefaultValue=false)]
        public string CustomerDescription { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public DateTime? Modified { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizeMaterialId
        /// </summary>
        [DataMember(Name="productSizeMaterialId", EmitDefaultValue=false)]
        public string ProductSizeMaterialId { get; set; }
        /// <summary>
        /// Gets or Sets PdfColorProfileId
        /// </summary>
        [DataMember(Name="pdfColorProfileId", EmitDefaultValue=false)]
        public string PdfColorProfileId { get; set; }
        /// <summary>
        /// Gets or Sets BuilderConfigId
        /// </summary>
        [DataMember(Name="builderConfigId", EmitDefaultValue=false)]
        public string BuilderConfigId { get; set; }
        /// <summary>
        /// Gets or Sets BuilderConfig
        /// </summary>
        [DataMember(Name="builderConfig", EmitDefaultValue=false)]
        public TeamBuilderConfig BuilderConfig { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizeMaterial
        /// </summary>
        [DataMember(Name="productSizeMaterial", EmitDefaultValue=false)]
        public ProductSizeMaterial ProductSizeMaterial { get; set; }
        /// <summary>
        /// Gets or Sets PdfColorProfile
        /// </summary>
        [DataMember(Name="pdfColorProfile", EmitDefaultValue=false)]
        public ProductPdfColorProfile PdfColorProfile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamBuilderConfigProductSizeMaterial {\n");
            sb.Append("  BindingType: ").Append(BindingType).Append("\n");
            sb.Append("  DefaultBleed: ").Append(DefaultBleed).Append("\n");
            sb.Append("  PrintProfile: ").Append(PrintProfile).Append("\n");
            sb.Append("  CustomerTitle: ").Append(CustomerTitle).Append("\n");
            sb.Append("  CustomerDescription: ").Append(CustomerDescription).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductSizeMaterialId: ").Append(ProductSizeMaterialId).Append("\n");
            sb.Append("  PdfColorProfileId: ").Append(PdfColorProfileId).Append("\n");
            sb.Append("  BuilderConfigId: ").Append(BuilderConfigId).Append("\n");
            sb.Append("  BuilderConfig: ").Append(BuilderConfig).Append("\n");
            sb.Append("  ProductSizeMaterial: ").Append(ProductSizeMaterial).Append("\n");
            sb.Append("  PdfColorProfile: ").Append(PdfColorProfile).Append("\n");
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
            return this.Equals(obj as TeamBuilderConfigProductSizeMaterial);
        }

        /// <summary>
        /// Returns true if TeamBuilderConfigProductSizeMaterial instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamBuilderConfigProductSizeMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamBuilderConfigProductSizeMaterial other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BindingType == other.BindingType ||
                    this.BindingType != null &&
                    this.BindingType.Equals(other.BindingType)
                ) && 
                (
                    this.DefaultBleed == other.DefaultBleed ||
                    this.DefaultBleed != null &&
                    this.DefaultBleed.Equals(other.DefaultBleed)
                ) && 
                (
                    this.PrintProfile == other.PrintProfile ||
                    this.PrintProfile != null &&
                    this.PrintProfile.Equals(other.PrintProfile)
                ) && 
                (
                    this.CustomerTitle == other.CustomerTitle ||
                    this.CustomerTitle != null &&
                    this.CustomerTitle.Equals(other.CustomerTitle)
                ) && 
                (
                    this.CustomerDescription == other.CustomerDescription ||
                    this.CustomerDescription != null &&
                    this.CustomerDescription.Equals(other.CustomerDescription)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ProductSizeMaterialId == other.ProductSizeMaterialId ||
                    this.ProductSizeMaterialId != null &&
                    this.ProductSizeMaterialId.Equals(other.ProductSizeMaterialId)
                ) && 
                (
                    this.PdfColorProfileId == other.PdfColorProfileId ||
                    this.PdfColorProfileId != null &&
                    this.PdfColorProfileId.Equals(other.PdfColorProfileId)
                ) && 
                (
                    this.BuilderConfigId == other.BuilderConfigId ||
                    this.BuilderConfigId != null &&
                    this.BuilderConfigId.Equals(other.BuilderConfigId)
                ) && 
                (
                    this.BuilderConfig == other.BuilderConfig ||
                    this.BuilderConfig != null &&
                    this.BuilderConfig.Equals(other.BuilderConfig)
                ) && 
                (
                    this.ProductSizeMaterial == other.ProductSizeMaterial ||
                    this.ProductSizeMaterial != null &&
                    this.ProductSizeMaterial.Equals(other.ProductSizeMaterial)
                ) && 
                (
                    this.PdfColorProfile == other.PdfColorProfile ||
                    this.PdfColorProfile != null &&
                    this.PdfColorProfile.Equals(other.PdfColorProfile)
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
                if (this.BindingType != null)
                    hash = hash * 59 + this.BindingType.GetHashCode();
                if (this.DefaultBleed != null)
                    hash = hash * 59 + this.DefaultBleed.GetHashCode();
                if (this.PrintProfile != null)
                    hash = hash * 59 + this.PrintProfile.GetHashCode();
                if (this.CustomerTitle != null)
                    hash = hash * 59 + this.CustomerTitle.GetHashCode();
                if (this.CustomerDescription != null)
                    hash = hash * 59 + this.CustomerDescription.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ProductSizeMaterialId != null)
                    hash = hash * 59 + this.ProductSizeMaterialId.GetHashCode();
                if (this.PdfColorProfileId != null)
                    hash = hash * 59 + this.PdfColorProfileId.GetHashCode();
                if (this.BuilderConfigId != null)
                    hash = hash * 59 + this.BuilderConfigId.GetHashCode();
                if (this.BuilderConfig != null)
                    hash = hash * 59 + this.BuilderConfig.GetHashCode();
                if (this.ProductSizeMaterial != null)
                    hash = hash * 59 + this.ProductSizeMaterial.GetHashCode();
                if (this.PdfColorProfile != null)
                    hash = hash * 59 + this.PdfColorProfile.GetHashCode();
                return hash;
            }
        }
    }

}

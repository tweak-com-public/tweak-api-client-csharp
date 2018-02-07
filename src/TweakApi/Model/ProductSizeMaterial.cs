/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-alpha.4
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
    /// ProductSizeMaterial
    /// </summary>
    [DataContract]
    public partial class ProductSizeMaterial :  IEquatable<ProductSizeMaterial>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Public for "public"
            /// </summary>
            [EnumMember(Value = "public")]
            Public,
            
            /// <summary>
            /// Enum Private for "private"
            /// </summary>
            [EnumMember(Value = "private")]
            Private
        }

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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
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
        /// Initializes a new instance of the <see cref="ProductSizeMaterial" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductSizeMaterial() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSizeMaterial" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="LegacyCode">LegacyCode.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Status">Status.</param>
        /// <param name="BindingType">BindingType.</param>
        /// <param name="DefaultBleed">DefaultBleed.</param>
        /// <param name="PrintProfile">PrintProfile.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MaterialId">MaterialId.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="PdfColorProfileId">PdfColorProfileId.</param>
        /// <param name="SizeId">SizeId.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Material">Material.</param>
        /// <param name="Team">Team.</param>
        /// <param name="PdfColorProfile">PdfColorProfile.</param>
        public ProductSizeMaterial(string Code = null, string LegacyCode = null, string Description = null, CloudinaryImage Thumbnail = null, StatusEnum? Status = null, BindingTypeEnum? BindingType = null, Bounds DefaultBleed = null, PrintProfileEnum? PrintProfile = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string MaterialId = null, string TeamId = null, string PdfColorProfileId = null, string SizeId = null, ProductSize Size = null, ProductMaterial Material = null, Team Team = null, ProductPdfColorProfile PdfColorProfile = null)
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for ProductSizeMaterial and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            this.LegacyCode = LegacyCode;
            this.Description = Description;
            this.Thumbnail = Thumbnail;
            this.Status = Status;
            this.BindingType = BindingType;
            this.DefaultBleed = DefaultBleed;
            this.PrintProfile = PrintProfile;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.MaterialId = MaterialId;
            this.TeamId = TeamId;
            this.PdfColorProfileId = PdfColorProfileId;
            this.SizeId = SizeId;
            this.Size = Size;
            this.Material = Material;
            this.Team = Team;
            this.PdfColorProfile = PdfColorProfile;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// Gets or Sets LegacyCode
        /// </summary>
        [DataMember(Name="legacyCode", EmitDefaultValue=false)]
        public string LegacyCode { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public CloudinaryImage Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets DefaultBleed
        /// </summary>
        [DataMember(Name="defaultBleed", EmitDefaultValue=false)]
        public Bounds DefaultBleed { get; set; }
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
        /// Gets or Sets MaterialId
        /// </summary>
        [DataMember(Name="materialId", EmitDefaultValue=false)]
        public string MaterialId { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets PdfColorProfileId
        /// </summary>
        [DataMember(Name="pdfColorProfileId", EmitDefaultValue=false)]
        public string PdfColorProfileId { get; set; }
        /// <summary>
        /// Gets or Sets SizeId
        /// </summary>
        [DataMember(Name="sizeId", EmitDefaultValue=false)]
        public string SizeId { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public ProductSize Size { get; set; }
        /// <summary>
        /// Gets or Sets Material
        /// </summary>
        [DataMember(Name="material", EmitDefaultValue=false)]
        public ProductMaterial Material { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
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
            sb.Append("class ProductSizeMaterial {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  LegacyCode: ").Append(LegacyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BindingType: ").Append(BindingType).Append("\n");
            sb.Append("  DefaultBleed: ").Append(DefaultBleed).Append("\n");
            sb.Append("  PrintProfile: ").Append(PrintProfile).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  PdfColorProfileId: ").Append(PdfColorProfileId).Append("\n");
            sb.Append("  SizeId: ").Append(SizeId).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Material: ").Append(Material).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(obj as ProductSizeMaterial);
        }

        /// <summary>
        /// Returns true if ProductSizeMaterial instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductSizeMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSizeMaterial other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.LegacyCode == other.LegacyCode ||
                    this.LegacyCode != null &&
                    this.LegacyCode.Equals(other.LegacyCode)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
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
                    this.MaterialId == other.MaterialId ||
                    this.MaterialId != null &&
                    this.MaterialId.Equals(other.MaterialId)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.PdfColorProfileId == other.PdfColorProfileId ||
                    this.PdfColorProfileId != null &&
                    this.PdfColorProfileId.Equals(other.PdfColorProfileId)
                ) && 
                (
                    this.SizeId == other.SizeId ||
                    this.SizeId != null &&
                    this.SizeId.Equals(other.SizeId)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Material == other.Material ||
                    this.Material != null &&
                    this.Material.Equals(other.Material)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.LegacyCode != null)
                    hash = hash * 59 + this.LegacyCode.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.BindingType != null)
                    hash = hash * 59 + this.BindingType.GetHashCode();
                if (this.DefaultBleed != null)
                    hash = hash * 59 + this.DefaultBleed.GetHashCode();
                if (this.PrintProfile != null)
                    hash = hash * 59 + this.PrintProfile.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MaterialId != null)
                    hash = hash * 59 + this.MaterialId.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.PdfColorProfileId != null)
                    hash = hash * 59 + this.PdfColorProfileId.GetHashCode();
                if (this.SizeId != null)
                    hash = hash * 59 + this.SizeId.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Material != null)
                    hash = hash * 59 + this.Material.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.PdfColorProfile != null)
                    hash = hash * 59 + this.PdfColorProfile.GetHashCode();
                return hash;
            }
        }
    }

}

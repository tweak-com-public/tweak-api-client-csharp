/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.5
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
    /// TeamBuilderConfig
    /// </summary>
    [DataContract]
    public partial class TeamBuilderConfig :  IEquatable<TeamBuilderConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamBuilderConfig" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DebugMode">DebugMode (default to false).</param>
        /// <param name="Features">Features.</param>
        /// <param name="Ui">Ui.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="ProductGroups">ProductGroups.</param>
        /// <param name="ProductTypes">ProductTypes.</param>
        /// <param name="ProductSizes">ProductSizes.</param>
        /// <param name="ProductSizeMaterials">ProductSizeMaterials.</param>
        /// <param name="ProductSizeMaterialsRel">ProductSizeMaterialsRel.</param>
        public TeamBuilderConfig(string Name = null, bool? DebugMode = null, Object Features = null, Object Ui = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string TeamId = null, Team Team = null, List<ProductGroup> ProductGroups = null, List<ProductType> ProductTypes = null, List<ProductSize> ProductSizes = null, List<ProductSizeMaterial> ProductSizeMaterials = null, List<TeamBuilderConfigProductSizeMaterial> ProductSizeMaterialsRel = null)
        {
            this.Name = Name;
            // use default value if no "DebugMode" provided
            if (DebugMode == null)
            {
                this.DebugMode = false;
            }
            else
            {
                this.DebugMode = DebugMode;
            }
            this.Features = Features;
            this.Ui = Ui;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
            this.ProductGroups = ProductGroups;
            this.ProductTypes = ProductTypes;
            this.ProductSizes = ProductSizes;
            this.ProductSizeMaterials = ProductSizeMaterials;
            this.ProductSizeMaterialsRel = ProductSizeMaterialsRel;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets DebugMode
        /// </summary>
        [DataMember(Name="debugMode", EmitDefaultValue=false)]
        public bool? DebugMode { get; set; }
        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features", EmitDefaultValue=false)]
        public Object Features { get; set; }
        /// <summary>
        /// Gets or Sets Ui
        /// </summary>
        [DataMember(Name="ui", EmitDefaultValue=false)]
        public Object Ui { get; set; }
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
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets ProductGroups
        /// </summary>
        [DataMember(Name="productGroups", EmitDefaultValue=false)]
        public List<ProductGroup> ProductGroups { get; set; }
        /// <summary>
        /// Gets or Sets ProductTypes
        /// </summary>
        [DataMember(Name="productTypes", EmitDefaultValue=false)]
        public List<ProductType> ProductTypes { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizes
        /// </summary>
        [DataMember(Name="productSizes", EmitDefaultValue=false)]
        public List<ProductSize> ProductSizes { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizeMaterials
        /// </summary>
        [DataMember(Name="productSizeMaterials", EmitDefaultValue=false)]
        public List<ProductSizeMaterial> ProductSizeMaterials { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizeMaterialsRel
        /// </summary>
        [DataMember(Name="productSizeMaterialsRel", EmitDefaultValue=false)]
        public List<TeamBuilderConfigProductSizeMaterial> ProductSizeMaterialsRel { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamBuilderConfig {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DebugMode: ").Append(DebugMode).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Ui: ").Append(Ui).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  ProductGroups: ").Append(ProductGroups).Append("\n");
            sb.Append("  ProductTypes: ").Append(ProductTypes).Append("\n");
            sb.Append("  ProductSizes: ").Append(ProductSizes).Append("\n");
            sb.Append("  ProductSizeMaterials: ").Append(ProductSizeMaterials).Append("\n");
            sb.Append("  ProductSizeMaterialsRel: ").Append(ProductSizeMaterialsRel).Append("\n");
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
            return this.Equals(obj as TeamBuilderConfig);
        }

        /// <summary>
        /// Returns true if TeamBuilderConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamBuilderConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamBuilderConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DebugMode == other.DebugMode ||
                    this.DebugMode != null &&
                    this.DebugMode.Equals(other.DebugMode)
                ) && 
                (
                    this.Features == other.Features ||
                    this.Features != null &&
                    this.Features.Equals(other.Features)
                ) && 
                (
                    this.Ui == other.Ui ||
                    this.Ui != null &&
                    this.Ui.Equals(other.Ui)
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
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.ProductGroups == other.ProductGroups ||
                    this.ProductGroups != null &&
                    this.ProductGroups.SequenceEqual(other.ProductGroups)
                ) && 
                (
                    this.ProductTypes == other.ProductTypes ||
                    this.ProductTypes != null &&
                    this.ProductTypes.SequenceEqual(other.ProductTypes)
                ) && 
                (
                    this.ProductSizes == other.ProductSizes ||
                    this.ProductSizes != null &&
                    this.ProductSizes.SequenceEqual(other.ProductSizes)
                ) && 
                (
                    this.ProductSizeMaterials == other.ProductSizeMaterials ||
                    this.ProductSizeMaterials != null &&
                    this.ProductSizeMaterials.SequenceEqual(other.ProductSizeMaterials)
                ) && 
                (
                    this.ProductSizeMaterialsRel == other.ProductSizeMaterialsRel ||
                    this.ProductSizeMaterialsRel != null &&
                    this.ProductSizeMaterialsRel.SequenceEqual(other.ProductSizeMaterialsRel)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DebugMode != null)
                    hash = hash * 59 + this.DebugMode.GetHashCode();
                if (this.Features != null)
                    hash = hash * 59 + this.Features.GetHashCode();
                if (this.Ui != null)
                    hash = hash * 59 + this.Ui.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.ProductGroups != null)
                    hash = hash * 59 + this.ProductGroups.GetHashCode();
                if (this.ProductTypes != null)
                    hash = hash * 59 + this.ProductTypes.GetHashCode();
                if (this.ProductSizes != null)
                    hash = hash * 59 + this.ProductSizes.GetHashCode();
                if (this.ProductSizeMaterials != null)
                    hash = hash * 59 + this.ProductSizeMaterials.GetHashCode();
                if (this.ProductSizeMaterialsRel != null)
                    hash = hash * 59 + this.ProductSizeMaterialsRel.GetHashCode();
                return hash;
            }
        }
    }

}

/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.13
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
    /// TeamBuilderConfigProductSize
    /// </summary>
    [DataContract]
    public partial class TeamBuilderConfigProductSize :  IEquatable<TeamBuilderConfigProductSize>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamBuilderConfigProductSize" /> class.
        /// </summary>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ProductSizeId">ProductSizeId.</param>
        /// <param name="BuilderConfigId">BuilderConfigId.</param>
        /// <param name="BuilderConfig">BuilderConfig.</param>
        /// <param name="ProductSize">ProductSize.</param>
        public TeamBuilderConfigProductSize(DateTime? Created = null, DateTime? Modified = null, string Id = null, string ProductSizeId = null, string BuilderConfigId = null, TeamBuilderConfig BuilderConfig = null, ProductSize ProductSize = null)
        {
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.ProductSizeId = ProductSizeId;
            this.BuilderConfigId = BuilderConfigId;
            this.BuilderConfig = BuilderConfig;
            this.ProductSize = ProductSize;
        }
        
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
        /// Gets or Sets ProductSizeId
        /// </summary>
        [DataMember(Name="productSizeId", EmitDefaultValue=false)]
        public string ProductSizeId { get; set; }
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
        /// Gets or Sets ProductSize
        /// </summary>
        [DataMember(Name="productSize", EmitDefaultValue=false)]
        public ProductSize ProductSize { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamBuilderConfigProductSize {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductSizeId: ").Append(ProductSizeId).Append("\n");
            sb.Append("  BuilderConfigId: ").Append(BuilderConfigId).Append("\n");
            sb.Append("  BuilderConfig: ").Append(BuilderConfig).Append("\n");
            sb.Append("  ProductSize: ").Append(ProductSize).Append("\n");
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
            return this.Equals(obj as TeamBuilderConfigProductSize);
        }

        /// <summary>
        /// Returns true if TeamBuilderConfigProductSize instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamBuilderConfigProductSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamBuilderConfigProductSize other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ProductSizeId == other.ProductSizeId ||
                    this.ProductSizeId != null &&
                    this.ProductSizeId.Equals(other.ProductSizeId)
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
                    this.ProductSize == other.ProductSize ||
                    this.ProductSize != null &&
                    this.ProductSize.Equals(other.ProductSize)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ProductSizeId != null)
                    hash = hash * 59 + this.ProductSizeId.GetHashCode();
                if (this.BuilderConfigId != null)
                    hash = hash * 59 + this.BuilderConfigId.GetHashCode();
                if (this.BuilderConfig != null)
                    hash = hash * 59 + this.BuilderConfig.GetHashCode();
                if (this.ProductSize != null)
                    hash = hash * 59 + this.ProductSize.GetHashCode();
                return hash;
            }
        }
    }

}

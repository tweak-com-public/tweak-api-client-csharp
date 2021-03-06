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
    /// ProductTag
    /// </summary>
    [DataContract]
    public partial class ProductTag :  IEquatable<ProductTag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTag" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="TagId">TagId.</param>
        /// <param name="ProductId">ProductId.</param>
        /// <param name="Product">Product.</param>
        /// <param name="Tag">Tag.</param>
        public ProductTag(string Id = null, string TagId = null, string ProductId = null, Product Product = null, Tag Tag = null)
        {
            this.Id = Id;
            this.TagId = TagId;
            this.ProductId = ProductId;
            this.Product = Product;
            this.Tag = Tag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId", EmitDefaultValue=false)]
        public string TagId { get; set; }
        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public Product Product { get; set; }
        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public Tag Tag { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductTag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(obj as ProductTag);
        }

        /// <summary>
        /// Returns true if ProductTag instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductTag other)
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
                    this.TagId == other.TagId ||
                    this.TagId != null &&
                    this.TagId.Equals(other.TagId)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
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
                if (this.TagId != null)
                    hash = hash * 59 + this.TagId.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
                return hash;
            }
        }
    }

}

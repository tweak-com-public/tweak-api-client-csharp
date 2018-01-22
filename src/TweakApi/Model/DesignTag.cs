/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.4
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
    /// DesignTag
    /// </summary>
    [DataContract]
    public partial class DesignTag :  IEquatable<DesignTag>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignTag" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="DesignId">DesignId.</param>
        /// <param name="TagId">TagId.</param>
        /// <param name="Design">Design.</param>
        /// <param name="Tag">Tag.</param>
        public DesignTag(string Id = null, string DesignId = null, string TagId = null, Design Design = null, Tag Tag = null)
        {
            this.Id = Id;
            this.DesignId = DesignId;
            this.TagId = TagId;
            this.Design = Design;
            this.Tag = Tag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets DesignId
        /// </summary>
        [DataMember(Name="designId", EmitDefaultValue=false)]
        public string DesignId { get; set; }
        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name="tagId", EmitDefaultValue=false)]
        public string TagId { get; set; }
        /// <summary>
        /// Gets or Sets Design
        /// </summary>
        [DataMember(Name="design", EmitDefaultValue=false)]
        public Design Design { get; set; }
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
            sb.Append("class DesignTag {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DesignId: ").Append(DesignId).Append("\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
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
            return this.Equals(obj as DesignTag);
        }

        /// <summary>
        /// Returns true if DesignTag instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignTag to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignTag other)
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
                    this.DesignId == other.DesignId ||
                    this.DesignId != null &&
                    this.DesignId.Equals(other.DesignId)
                ) && 
                (
                    this.TagId == other.TagId ||
                    this.TagId != null &&
                    this.TagId.Equals(other.TagId)
                ) && 
                (
                    this.Design == other.Design ||
                    this.Design != null &&
                    this.Design.Equals(other.Design)
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
                if (this.DesignId != null)
                    hash = hash * 59 + this.DesignId.GetHashCode();
                if (this.TagId != null)
                    hash = hash * 59 + this.TagId.GetHashCode();
                if (this.Design != null)
                    hash = hash * 59 + this.Design.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
                return hash;
            }
        }
    }

}

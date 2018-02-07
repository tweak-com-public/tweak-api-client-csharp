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
    /// DesignExport
    /// </summary>
    [DataContract]
    public partial class DesignExport :  IEquatable<DesignExport>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Proof for "proof"
            /// </summary>
            [EnumMember(Value = "proof")]
            Proof,
            
            /// <summary>
            /// Enum Pdf for "pdf"
            /// </summary>
            [EnumMember(Value = "pdf")]
            Pdf
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignExport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DesignExport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignExport" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Id">Id.</param>
        /// <param name="DesignId">DesignId.</param>
        /// <param name="RequesterId">RequesterId.</param>
        /// <param name="Designs">Designs.</param>
        /// <param name="Requester">Requester.</param>
        public DesignExport(TypeEnum? Type = null, DateTime? Created = null, string Id = null, string DesignId = null, string RequesterId = null, Design Designs = null, TeamMember Requester = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for DesignExport and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Created = Created;
            this.Id = Id;
            this.DesignId = DesignId;
            this.RequesterId = RequesterId;
            this.Designs = Designs;
            this.Requester = Requester;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
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
        /// Gets or Sets RequesterId
        /// </summary>
        [DataMember(Name="requesterId", EmitDefaultValue=false)]
        public string RequesterId { get; set; }
        /// <summary>
        /// Gets or Sets Designs
        /// </summary>
        [DataMember(Name="designs", EmitDefaultValue=false)]
        public Design Designs { get; set; }
        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name="requester", EmitDefaultValue=false)]
        public TeamMember Requester { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignExport {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DesignId: ").Append(DesignId).Append("\n");
            sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
            sb.Append("  Designs: ").Append(Designs).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
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
            return this.Equals(obj as DesignExport);
        }

        /// <summary>
        /// Returns true if DesignExport instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignExport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignExport other)
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
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
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
                    this.RequesterId == other.RequesterId ||
                    this.RequesterId != null &&
                    this.RequesterId.Equals(other.RequesterId)
                ) && 
                (
                    this.Designs == other.Designs ||
                    this.Designs != null &&
                    this.Designs.Equals(other.Designs)
                ) && 
                (
                    this.Requester == other.Requester ||
                    this.Requester != null &&
                    this.Requester.Equals(other.Requester)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DesignId != null)
                    hash = hash * 59 + this.DesignId.GetHashCode();
                if (this.RequesterId != null)
                    hash = hash * 59 + this.RequesterId.GetHashCode();
                if (this.Designs != null)
                    hash = hash * 59 + this.Designs.GetHashCode();
                if (this.Requester != null)
                    hash = hash * 59 + this.Requester.GetHashCode();
                return hash;
            }
        }
    }

}

/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.4-alpha.4
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
    /// BuilderAssetBackgroundFolder
    /// </summary>
    [DataContract]
    public partial class BuilderAssetBackgroundFolder :  IEquatable<BuilderAssetBackgroundFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderAssetBackgroundFolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuilderAssetBackgroundFolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderAssetBackgroundFolder" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Path">Path (required).</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Id">Id.</param>
        public BuilderAssetBackgroundFolder(string Name = null, string Path = null, CloudinaryImage Thumbnail = null, string Id = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for BuilderAssetBackgroundFolder and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for BuilderAssetBackgroundFolder and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
            this.Thumbnail = Thumbnail;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public CloudinaryImage Thumbnail { get; set; }
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
            sb.Append("class BuilderAssetBackgroundFolder {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
            return this.Equals(obj as BuilderAssetBackgroundFolder);
        }

        /// <summary>
        /// Returns true if BuilderAssetBackgroundFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of BuilderAssetBackgroundFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuilderAssetBackgroundFolder other)
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
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
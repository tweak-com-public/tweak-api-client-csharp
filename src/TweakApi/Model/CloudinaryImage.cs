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
    /// CloudinaryImage
    /// </summary>
    [DataContract]
    public partial class CloudinaryImage :  IEquatable<CloudinaryImage>
    {
        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResourceTypeEnum
        {
            
            /// <summary>
            /// Enum Image for "image"
            /// </summary>
            [EnumMember(Value = "image")]
            Image
        }

        /// <summary>
        /// Gets or Sets ResourceType
        /// </summary>
        [DataMember(Name="resourceType", EmitDefaultValue=false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudinaryImage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloudinaryImage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudinaryImage" /> class.
        /// </summary>
        /// <param name="PublicId">PublicId.</param>
        /// <param name="Version">Version.</param>
        /// <param name="Signature">Signature.</param>
        /// <param name="Width">Width.</param>
        /// <param name="Height">Height.</param>
        /// <param name="Format">Format.</param>
        /// <param name="ResourceType">ResourceType.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Bytes">Bytes.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Etag">Etag.</param>
        /// <param name="Url">Url (required).</param>
        /// <param name="SecureUrl">SecureUrl (required).</param>
        /// <param name="ThumbnailUrl">ThumbnailUrl.</param>
        /// <param name="ThumbnailSecureUrl">ThumbnailSecureUrl.</param>
        /// <param name="OriginalFilename">OriginalFilename.</param>
        /// <param name="IsBase64">IsBase64 (default to false).</param>
        /// <param name="Resp">Resp.</param>
        /// <param name="Id">Id.</param>
        public CloudinaryImage(string PublicId = null, string Version = null, string Signature = null, double? Width = null, double? Height = null, string Format = null, ResourceTypeEnum? ResourceType = null, string CreatedAt = null, List<string> Tags = null, double? Bytes = null, string Type = null, string Etag = null, string Url = null, string SecureUrl = null, string ThumbnailUrl = null, string ThumbnailSecureUrl = null, string OriginalFilename = null, bool? IsBase64 = null, Object Resp = null, string Id = null)
        {
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for CloudinaryImage and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "SecureUrl" is required (not null)
            if (SecureUrl == null)
            {
                throw new InvalidDataException("SecureUrl is a required property for CloudinaryImage and cannot be null");
            }
            else
            {
                this.SecureUrl = SecureUrl;
            }
            this.PublicId = PublicId;
            this.Version = Version;
            this.Signature = Signature;
            this.Width = Width;
            this.Height = Height;
            this.Format = Format;
            this.ResourceType = ResourceType;
            this.CreatedAt = CreatedAt;
            this.Tags = Tags;
            this.Bytes = Bytes;
            this.Type = Type;
            this.Etag = Etag;
            this.ThumbnailUrl = ThumbnailUrl;
            this.ThumbnailSecureUrl = ThumbnailSecureUrl;
            this.OriginalFilename = OriginalFilename;
            // use default value if no "IsBase64" provided
            if (IsBase64 == null)
            {
                this.IsBase64 = false;
            }
            else
            {
                this.IsBase64 = IsBase64;
            }
            this.Resp = Resp;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets PublicId
        /// </summary>
        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public string Signature { get; set; }
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }
        /// <summary>
        /// Gets or Sets Bytes
        /// </summary>
        [DataMember(Name="bytes", EmitDefaultValue=false)]
        public double? Bytes { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Etag
        /// </summary>
        [DataMember(Name="etag", EmitDefaultValue=false)]
        public string Etag { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets SecureUrl
        /// </summary>
        [DataMember(Name="secureUrl", EmitDefaultValue=false)]
        public string SecureUrl { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailUrl
        /// </summary>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailSecureUrl
        /// </summary>
        [DataMember(Name="thumbnailSecureUrl", EmitDefaultValue=false)]
        public string ThumbnailSecureUrl { get; set; }
        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [DataMember(Name="originalFilename", EmitDefaultValue=false)]
        public string OriginalFilename { get; set; }
        /// <summary>
        /// Gets or Sets IsBase64
        /// </summary>
        [DataMember(Name="isBase64", EmitDefaultValue=false)]
        public bool? IsBase64 { get; set; }
        /// <summary>
        /// Gets or Sets Resp
        /// </summary>
        [DataMember(Name="resp", EmitDefaultValue=false)]
        public Object Resp { get; set; }
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
            sb.Append("class CloudinaryImage {\n");
            sb.Append("  PublicId: ").Append(PublicId).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SecureUrl: ").Append(SecureUrl).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  ThumbnailSecureUrl: ").Append(ThumbnailSecureUrl).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
            sb.Append("  IsBase64: ").Append(IsBase64).Append("\n");
            sb.Append("  Resp: ").Append(Resp).Append("\n");
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
            return this.Equals(obj as CloudinaryImage);
        }

        /// <summary>
        /// Returns true if CloudinaryImage instances are equal
        /// </summary>
        /// <param name="other">Instance of CloudinaryImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudinaryImage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PublicId == other.PublicId ||
                    this.PublicId != null &&
                    this.PublicId.Equals(other.PublicId)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.ResourceType == other.ResourceType ||
                    this.ResourceType != null &&
                    this.ResourceType.Equals(other.ResourceType)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Bytes == other.Bytes ||
                    this.Bytes != null &&
                    this.Bytes.Equals(other.Bytes)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Etag == other.Etag ||
                    this.Etag != null &&
                    this.Etag.Equals(other.Etag)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.SecureUrl == other.SecureUrl ||
                    this.SecureUrl != null &&
                    this.SecureUrl.Equals(other.SecureUrl)
                ) && 
                (
                    this.ThumbnailUrl == other.ThumbnailUrl ||
                    this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(other.ThumbnailUrl)
                ) && 
                (
                    this.ThumbnailSecureUrl == other.ThumbnailSecureUrl ||
                    this.ThumbnailSecureUrl != null &&
                    this.ThumbnailSecureUrl.Equals(other.ThumbnailSecureUrl)
                ) && 
                (
                    this.OriginalFilename == other.OriginalFilename ||
                    this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(other.OriginalFilename)
                ) && 
                (
                    this.IsBase64 == other.IsBase64 ||
                    this.IsBase64 != null &&
                    this.IsBase64.Equals(other.IsBase64)
                ) && 
                (
                    this.Resp == other.Resp ||
                    this.Resp != null &&
                    this.Resp.Equals(other.Resp)
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
                if (this.PublicId != null)
                    hash = hash * 59 + this.PublicId.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.ResourceType != null)
                    hash = hash * 59 + this.ResourceType.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Bytes != null)
                    hash = hash * 59 + this.Bytes.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Etag != null)
                    hash = hash * 59 + this.Etag.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.SecureUrl != null)
                    hash = hash * 59 + this.SecureUrl.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hash = hash * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.ThumbnailSecureUrl != null)
                    hash = hash * 59 + this.ThumbnailSecureUrl.GetHashCode();
                if (this.OriginalFilename != null)
                    hash = hash * 59 + this.OriginalFilename.GetHashCode();
                if (this.IsBase64 != null)
                    hash = hash * 59 + this.IsBase64.GetHashCode();
                if (this.Resp != null)
                    hash = hash * 59 + this.Resp.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
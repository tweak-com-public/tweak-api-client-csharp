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
    /// DesignFolder
    /// </summary>
    [DataContract]
    public partial class DesignFolder :  IEquatable<DesignFolder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignFolder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DesignFolder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignFolder" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description (default to &quot;&quot;).</param>
        /// <param name="Path">Path (default to &quot;/&quot;).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MemberId">MemberId.</param>
        /// <param name="ParentId">ParentId.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="Member">Member.</param>
        /// <param name="Children">Children.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="Designs">Designs.</param>
        /// <param name="Portal">Portal.</param>
        public DesignFolder(string Name = null, string Description = null, string Path = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string MemberId = null, string ParentId = null, string PortalId = null, TeamMember Member = null, List<DesignFolder> Children = null, DesignFolder Parent = null, List<Design> Designs = null, Portal Portal = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DesignFolder and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // use default value if no "Description" provided
            if (Description == null)
            {
                this.Description = "";
            }
            else
            {
                this.Description = Description;
            }
            // use default value if no "Path" provided
            if (Path == null)
            {
                this.Path = "/";
            }
            else
            {
                this.Path = Path;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.MemberId = MemberId;
            this.ParentId = ParentId;
            this.PortalId = PortalId;
            this.Member = Member;
            this.Children = Children;
            this.Parent = Parent;
            this.Designs = Designs;
            this.Portal = Portal;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
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
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="memberId", EmitDefaultValue=false)]
        public string MemberId { get; set; }
        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }
        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name="portalId", EmitDefaultValue=false)]
        public string PortalId { get; set; }
        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public TeamMember Member { get; set; }
        /// <summary>
        /// Gets or Sets Children
        /// </summary>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<DesignFolder> Children { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public DesignFolder Parent { get; set; }
        /// <summary>
        /// Gets or Sets Designs
        /// </summary>
        [DataMember(Name="designs", EmitDefaultValue=false)]
        public List<Design> Designs { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignFolder {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Designs: ").Append(Designs).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
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
            return this.Equals(obj as DesignFolder);
        }

        /// <summary>
        /// Returns true if DesignFolder instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignFolder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignFolder other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                    this.MemberId == other.MemberId ||
                    this.MemberId != null &&
                    this.MemberId.Equals(other.MemberId)
                ) && 
                (
                    this.ParentId == other.ParentId ||
                    this.ParentId != null &&
                    this.ParentId.Equals(other.ParentId)
                ) && 
                (
                    this.PortalId == other.PortalId ||
                    this.PortalId != null &&
                    this.PortalId.Equals(other.PortalId)
                ) && 
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Designs == other.Designs ||
                    this.Designs != null &&
                    this.Designs.SequenceEqual(other.Designs)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MemberId != null)
                    hash = hash * 59 + this.MemberId.GetHashCode();
                if (this.ParentId != null)
                    hash = hash * 59 + this.ParentId.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Designs != null)
                    hash = hash * 59 + this.Designs.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                return hash;
            }
        }
    }

}

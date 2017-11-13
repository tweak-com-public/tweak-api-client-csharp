/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.1
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
    /// PortalMember
    /// </summary>
    [DataContract]
    public partial class PortalMember :  IEquatable<PortalMember>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortalMember() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalMember" /> class.
        /// </summary>
        /// <param name="Roles">Roles (required).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="MemberId">MemberId.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="Member">Member.</param>
        public PortalMember(List<string> Roles = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string PortalId = null, string MemberId = null, Portal Portal = null, TeamMember Member = null)
        {
            // to ensure "Roles" is required (not null)
            if (Roles == null)
            {
                throw new InvalidDataException("Roles is a required property for PortalMember and cannot be null");
            }
            else
            {
                this.Roles = Roles;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.PortalId = PortalId;
            this.MemberId = MemberId;
            this.Portal = Portal;
            this.Member = Member;
        }
        
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
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
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name="portalId", EmitDefaultValue=false)]
        public string PortalId { get; set; }
        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="memberId", EmitDefaultValue=false)]
        public string MemberId { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=false)]
        public TeamMember Member { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortalMember {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
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
            return this.Equals(obj as PortalMember);
        }

        /// <summary>
        /// Returns true if PortalMember instances are equal
        /// </summary>
        /// <param name="other">Instance of PortalMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortalMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
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
                    this.PortalId == other.PortalId ||
                    this.PortalId != null &&
                    this.PortalId.Equals(other.PortalId)
                ) && 
                (
                    this.MemberId == other.MemberId ||
                    this.MemberId != null &&
                    this.MemberId.Equals(other.MemberId)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.Member == other.Member ||
                    this.Member != null &&
                    this.Member.Equals(other.Member)
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
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.MemberId != null)
                    hash = hash * 59 + this.MemberId.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.Member != null)
                    hash = hash * 59 + this.Member.GetHashCode();
                return hash;
            }
        }
    }

}

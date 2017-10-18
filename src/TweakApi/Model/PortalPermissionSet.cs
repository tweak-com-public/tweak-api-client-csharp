/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.1
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
    /// PortalPermissionSet
    /// </summary>
    [DataContract]
    public partial class PortalPermissionSet :  IEquatable<PortalPermissionSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalPermissionSet" /> class.
        /// </summary>
        /// <param name="TemplatePermission">TemplatePermission.</param>
        /// <param name="TweakTemplatePermission">TweakTemplatePermission.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="Portal">Portal.</param>
        public PortalPermissionSet(TemplatePermissionSet TemplatePermission = null, TemplatePermissionSet TweakTemplatePermission = null, string Id = null, string PortalId = null, Portal Portal = null)
        {
            this.TemplatePermission = TemplatePermission;
            this.TweakTemplatePermission = TweakTemplatePermission;
            this.Id = Id;
            this.PortalId = PortalId;
            this.Portal = Portal;
        }
        
        /// <summary>
        /// Gets or Sets TemplatePermission
        /// </summary>
        [DataMember(Name="templatePermission", EmitDefaultValue=false)]
        public TemplatePermissionSet TemplatePermission { get; set; }
        /// <summary>
        /// Gets or Sets TweakTemplatePermission
        /// </summary>
        [DataMember(Name="tweakTemplatePermission", EmitDefaultValue=false)]
        public TemplatePermissionSet TweakTemplatePermission { get; set; }
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
            sb.Append("class PortalPermissionSet {\n");
            sb.Append("  TemplatePermission: ").Append(TemplatePermission).Append("\n");
            sb.Append("  TweakTemplatePermission: ").Append(TweakTemplatePermission).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
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
            return this.Equals(obj as PortalPermissionSet);
        }

        /// <summary>
        /// Returns true if PortalPermissionSet instances are equal
        /// </summary>
        /// <param name="other">Instance of PortalPermissionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortalPermissionSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TemplatePermission == other.TemplatePermission ||
                    this.TemplatePermission != null &&
                    this.TemplatePermission.Equals(other.TemplatePermission)
                ) && 
                (
                    this.TweakTemplatePermission == other.TweakTemplatePermission ||
                    this.TweakTemplatePermission != null &&
                    this.TweakTemplatePermission.Equals(other.TweakTemplatePermission)
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
                if (this.TemplatePermission != null)
                    hash = hash * 59 + this.TemplatePermission.GetHashCode();
                if (this.TweakTemplatePermission != null)
                    hash = hash * 59 + this.TweakTemplatePermission.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                return hash;
            }
        }
    }

}

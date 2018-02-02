/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.7-alpha.2
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
    /// TeamPermissionSet
    /// </summary>
    [DataContract]
    public partial class TeamPermissionSet :  IEquatable<TeamPermissionSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamPermissionSet" /> class.
        /// </summary>
        /// <param name="EmailNotification">EmailNotification (default to true).</param>
        /// <param name="TemplatePermission">TemplatePermission.</param>
        /// <param name="TweakTemplatePermission">TweakTemplatePermission.</param>
        /// <param name="TeamCustomerPermission">TeamCustomerPermission.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        public TeamPermissionSet(bool? EmailNotification = null, TemplatePermissionSet TemplatePermission = null, TemplatePermissionSet TweakTemplatePermission = null, TeamCustomerPermissionSet TeamCustomerPermission = null, string Id = null, string TeamId = null, Team Team = null)
        {
            // use default value if no "EmailNotification" provided
            if (EmailNotification == null)
            {
                this.EmailNotification = true;
            }
            else
            {
                this.EmailNotification = EmailNotification;
            }
            this.TemplatePermission = TemplatePermission;
            this.TweakTemplatePermission = TweakTemplatePermission;
            this.TeamCustomerPermission = TeamCustomerPermission;
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
        }
        
        /// <summary>
        /// Gets or Sets EmailNotification
        /// </summary>
        [DataMember(Name="emailNotification", EmitDefaultValue=false)]
        public bool? EmailNotification { get; set; }
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
        /// Gets or Sets TeamCustomerPermission
        /// </summary>
        [DataMember(Name="teamCustomerPermission", EmitDefaultValue=false)]
        public TeamCustomerPermissionSet TeamCustomerPermission { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamPermissionSet {\n");
            sb.Append("  EmailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  TemplatePermission: ").Append(TemplatePermission).Append("\n");
            sb.Append("  TweakTemplatePermission: ").Append(TweakTemplatePermission).Append("\n");
            sb.Append("  TeamCustomerPermission: ").Append(TeamCustomerPermission).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
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
            return this.Equals(obj as TeamPermissionSet);
        }

        /// <summary>
        /// Returns true if TeamPermissionSet instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamPermissionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamPermissionSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailNotification == other.EmailNotification ||
                    this.EmailNotification != null &&
                    this.EmailNotification.Equals(other.EmailNotification)
                ) && 
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
                    this.TeamCustomerPermission == other.TeamCustomerPermission ||
                    this.TeamCustomerPermission != null &&
                    this.TeamCustomerPermission.Equals(other.TeamCustomerPermission)
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
                if (this.EmailNotification != null)
                    hash = hash * 59 + this.EmailNotification.GetHashCode();
                if (this.TemplatePermission != null)
                    hash = hash * 59 + this.TemplatePermission.GetHashCode();
                if (this.TweakTemplatePermission != null)
                    hash = hash * 59 + this.TweakTemplatePermission.GetHashCode();
                if (this.TeamCustomerPermission != null)
                    hash = hash * 59 + this.TeamCustomerPermission.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                return hash;
            }
        }
    }

}

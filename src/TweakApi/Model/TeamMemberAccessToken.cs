/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.3
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
    /// TeamMemberAccessToken
    /// </summary>
    [DataContract]
    public partial class TeamMemberAccessToken :  IEquatable<TeamMemberAccessToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAccessToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamMemberAccessToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAccessToken" /> class.
        /// </summary>
        /// <param name="Roles">Roles.</param>
        /// <param name="RefreshToken">RefreshToken.</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="Ttl">time to live in seconds (2 weeks by default) (default to 1209600.0).</param>
        /// <param name="Scopes">Array of scopes granted to this access token..</param>
        /// <param name="Created">Created.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="TeamMemberId">TeamMemberId.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="PortalMemberId">PortalMemberId.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="Team">Team.</param>
        /// <param name="TeamMember">TeamMember.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="PortalMember">PortalMember.</param>
        public TeamMemberAccessToken(List<string> Roles = null, string RefreshToken = null, string Id = null, double? Ttl = null, List<string> Scopes = null, DateTime? Created = null, string UserId = null, string TeamId = null, string TeamMemberId = null, string PortalId = null, string PortalMemberId = null, Customer Customer = null, Team Team = null, TeamMember TeamMember = null, Portal Portal = null, PortalMember PortalMember = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TeamMemberAccessToken and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Roles = Roles;
            this.RefreshToken = RefreshToken;
            // use default value if no "Ttl" provided
            if (Ttl == null)
            {
                this.Ttl = 1209600.0;
            }
            else
            {
                this.Ttl = Ttl;
            }
            this.Scopes = Scopes;
            this.Created = Created;
            this.UserId = UserId;
            this.TeamId = TeamId;
            this.TeamMemberId = TeamMemberId;
            this.PortalId = PortalId;
            this.PortalMemberId = PortalMemberId;
            this.Customer = Customer;
            this.Team = Team;
            this.TeamMember = TeamMember;
            this.Portal = Portal;
            this.PortalMember = PortalMember;
        }
        
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Gets or Sets RefreshToken
        /// </summary>
        [DataMember(Name="refreshToken", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// time to live in seconds (2 weeks by default)
        /// </summary>
        /// <value>time to live in seconds (2 weeks by default)</value>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public double? Ttl { get; set; }
        /// <summary>
        /// Array of scopes granted to this access token.
        /// </summary>
        /// <value>Array of scopes granted to this access token.</value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public List<string> Scopes { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets TeamMemberId
        /// </summary>
        [DataMember(Name="teamMemberId", EmitDefaultValue=false)]
        public string TeamMemberId { get; set; }
        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name="portalId", EmitDefaultValue=false)]
        public string PortalId { get; set; }
        /// <summary>
        /// Gets or Sets PortalMemberId
        /// </summary>
        [DataMember(Name="portalMemberId", EmitDefaultValue=false)]
        public string PortalMemberId { get; set; }
        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Customer Customer { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets TeamMember
        /// </summary>
        [DataMember(Name="teamMember", EmitDefaultValue=false)]
        public TeamMember TeamMember { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Gets or Sets PortalMember
        /// </summary>
        [DataMember(Name="portalMember", EmitDefaultValue=false)]
        public PortalMember PortalMember { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMemberAccessToken {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  TeamMemberId: ").Append(TeamMemberId).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  PortalMemberId: ").Append(PortalMemberId).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  TeamMember: ").Append(TeamMember).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  PortalMember: ").Append(PortalMember).Append("\n");
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
            return this.Equals(obj as TeamMemberAccessToken);
        }

        /// <summary>
        /// Returns true if TeamMemberAccessToken instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamMemberAccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMemberAccessToken other)
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
                    this.RefreshToken == other.RefreshToken ||
                    this.RefreshToken != null &&
                    this.RefreshToken.Equals(other.RefreshToken)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Ttl == other.Ttl ||
                    this.Ttl != null &&
                    this.Ttl.Equals(other.Ttl)
                ) && 
                (
                    this.Scopes == other.Scopes ||
                    this.Scopes != null &&
                    this.Scopes.SequenceEqual(other.Scopes)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.TeamMemberId == other.TeamMemberId ||
                    this.TeamMemberId != null &&
                    this.TeamMemberId.Equals(other.TeamMemberId)
                ) && 
                (
                    this.PortalId == other.PortalId ||
                    this.PortalId != null &&
                    this.PortalId.Equals(other.PortalId)
                ) && 
                (
                    this.PortalMemberId == other.PortalMemberId ||
                    this.PortalMemberId != null &&
                    this.PortalMemberId.Equals(other.PortalMemberId)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.TeamMember == other.TeamMember ||
                    this.TeamMember != null &&
                    this.TeamMember.Equals(other.TeamMember)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.PortalMember == other.PortalMember ||
                    this.PortalMember != null &&
                    this.PortalMember.Equals(other.PortalMember)
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
                if (this.RefreshToken != null)
                    hash = hash * 59 + this.RefreshToken.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Ttl != null)
                    hash = hash * 59 + this.Ttl.GetHashCode();
                if (this.Scopes != null)
                    hash = hash * 59 + this.Scopes.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.TeamMemberId != null)
                    hash = hash * 59 + this.TeamMemberId.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.PortalMemberId != null)
                    hash = hash * 59 + this.PortalMemberId.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.TeamMember != null)
                    hash = hash * 59 + this.TeamMember.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.PortalMember != null)
                    hash = hash * 59 + this.PortalMember.GetHashCode();
                return hash;
            }
        }
    }

}

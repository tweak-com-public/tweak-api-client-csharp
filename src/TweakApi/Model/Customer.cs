/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.13
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
    /// Customer
    /// </summary>
    [DataContract]
    public partial class Customer :  IEquatable<Customer>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Godmode for "godmode"
            /// </summary>
            [EnumMember(Value = "godmode")]
            Godmode
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Customer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        /// <param name="ProfilePicture">ProfilePicture.</param>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="Initials">Initials (required).</param>
        /// <param name="Status">Status.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Realm">Realm.</param>
        /// <param name="Username">Username.</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="EmailVerified">EmailVerified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Designs">Designs.</param>
        /// <param name="Teams">Teams.</param>
        /// <param name="InvitationTickets">InvitationTickets.</param>
        /// <param name="AccessTokens">AccessTokens.</param>
        /// <param name="Permission">Permission.</param>
        public Customer(Object ProfilePicture = null, string FirstName = null, string LastName = null, string Initials = null, StatusEnum? Status = null, DateTime? Created = null, DateTime? Modified = null, string Realm = null, string Username = null, string Email = null, bool? EmailVerified = null, string Id = null, List<Design> Designs = null, List<Team> Teams = null, List<InvitationTicket> InvitationTickets = null, List<TeamMemberAccessToken> AccessTokens = null, CustomerPermissionSet Permission = null)
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Customer and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Customer and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "Initials" is required (not null)
            if (Initials == null)
            {
                throw new InvalidDataException("Initials is a required property for Customer and cannot be null");
            }
            else
            {
                this.Initials = Initials;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Customer and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            this.ProfilePicture = ProfilePicture;
            this.Status = Status;
            this.Created = Created;
            this.Modified = Modified;
            this.Realm = Realm;
            this.Username = Username;
            this.EmailVerified = EmailVerified;
            this.Id = Id;
            this.Designs = Designs;
            this.Teams = Teams;
            this.InvitationTickets = InvitationTickets;
            this.AccessTokens = AccessTokens;
            this.Permission = Permission;
        }
        
        /// <summary>
        /// Gets or Sets ProfilePicture
        /// </summary>
        [DataMember(Name="profilePicture", EmitDefaultValue=false)]
        public Object ProfilePicture { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=false)]
        public string Initials { get; set; }
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
        /// Gets or Sets Realm
        /// </summary>
        [DataMember(Name="realm", EmitDefaultValue=false)]
        public string Realm { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailVerified
        /// </summary>
        [DataMember(Name="emailVerified", EmitDefaultValue=false)]
        public bool? EmailVerified { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Designs
        /// </summary>
        [DataMember(Name="designs", EmitDefaultValue=false)]
        public List<Design> Designs { get; set; }
        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name="teams", EmitDefaultValue=false)]
        public List<Team> Teams { get; set; }
        /// <summary>
        /// Gets or Sets InvitationTickets
        /// </summary>
        [DataMember(Name="invitationTickets", EmitDefaultValue=false)]
        public List<InvitationTicket> InvitationTickets { get; set; }
        /// <summary>
        /// Gets or Sets AccessTokens
        /// </summary>
        [DataMember(Name="accessTokens", EmitDefaultValue=false)]
        public List<TeamMemberAccessToken> AccessTokens { get; set; }
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public CustomerPermissionSet Permission { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  ProfilePicture: ").Append(ProfilePicture).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Realm: ").Append(Realm).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Designs: ").Append(Designs).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
            sb.Append("  InvitationTickets: ").Append(InvitationTickets).Append("\n");
            sb.Append("  AccessTokens: ").Append(AccessTokens).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            return this.Equals(obj as Customer);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="other">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProfilePicture == other.ProfilePicture ||
                    this.ProfilePicture != null &&
                    this.ProfilePicture.Equals(other.ProfilePicture)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Initials == other.Initials ||
                    this.Initials != null &&
                    this.Initials.Equals(other.Initials)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                    this.Realm == other.Realm ||
                    this.Realm != null &&
                    this.Realm.Equals(other.Realm)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailVerified == other.EmailVerified ||
                    this.EmailVerified != null &&
                    this.EmailVerified.Equals(other.EmailVerified)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Designs == other.Designs ||
                    this.Designs != null &&
                    this.Designs.SequenceEqual(other.Designs)
                ) && 
                (
                    this.Teams == other.Teams ||
                    this.Teams != null &&
                    this.Teams.SequenceEqual(other.Teams)
                ) && 
                (
                    this.InvitationTickets == other.InvitationTickets ||
                    this.InvitationTickets != null &&
                    this.InvitationTickets.SequenceEqual(other.InvitationTickets)
                ) && 
                (
                    this.AccessTokens == other.AccessTokens ||
                    this.AccessTokens != null &&
                    this.AccessTokens.SequenceEqual(other.AccessTokens)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
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
                if (this.ProfilePicture != null)
                    hash = hash * 59 + this.ProfilePicture.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Initials != null)
                    hash = hash * 59 + this.Initials.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Realm != null)
                    hash = hash * 59 + this.Realm.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailVerified != null)
                    hash = hash * 59 + this.EmailVerified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Designs != null)
                    hash = hash * 59 + this.Designs.GetHashCode();
                if (this.Teams != null)
                    hash = hash * 59 + this.Teams.GetHashCode();
                if (this.InvitationTickets != null)
                    hash = hash * 59 + this.InvitationTickets.GetHashCode();
                if (this.AccessTokens != null)
                    hash = hash * 59 + this.AccessTokens.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                return hash;
            }
        }
    }

}

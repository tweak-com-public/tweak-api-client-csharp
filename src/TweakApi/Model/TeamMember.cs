/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 0.0.4
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
    /// TeamMember
    /// </summary>
    [DataContract]
    public partial class TeamMember :  IEquatable<TeamMember>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamMember() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMember" /> class.
        /// </summary>
        /// <param name="Roles">Roles (required).</param>
        /// <param name="Position">Position.</param>
        /// <param name="OfficePhone">OfficePhone.</param>
        /// <param name="MobilePhone">MobilePhone.</param>
        /// <param name="Website">Website.</param>
        /// <param name="AddressCity">AddressCity.</param>
        /// <param name="AddressCountry">AddressCountry.</param>
        /// <param name="AddressLine1">AddressLine1.</param>
        /// <param name="AddressLine2">AddressLine2.</param>
        /// <param name="AddressState">AddressState.</param>
        /// <param name="AddressZip">AddressZip.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="CustomerId">CustomerId.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Portals">Portals.</param>
        /// <param name="UploadedTemplates">UploadedTemplates.</param>
        /// <param name="Templates">Templates.</param>
        /// <param name="InvitationTickets">InvitationTickets.</param>
        /// <param name="RequestedDesigns">RequestedDesigns.</param>
        /// <param name="RequestedDesignExports">RequestedDesignExports.</param>
        /// <param name="AssignedDesigns">AssignedDesigns.</param>
        /// <param name="ReviewedDesigns">ReviewedDesigns.</param>
        /// <param name="CommentedDesigns">CommentedDesigns.</param>
        /// <param name="DesignComments">DesignComments.</param>
        /// <param name="DesignFolders">DesignFolders.</param>
        /// <param name="Workflows">Workflows.</param>
        /// <param name="ImageFolders">ImageFolders.</param>
        public TeamMember(List<string> Roles = null, string Position = null, string OfficePhone = null, string MobilePhone = null, string Website = null, string AddressCity = null, string AddressCountry = null, string AddressLine1 = null, string AddressLine2 = null, string AddressState = null, string AddressZip = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string CustomerId = null, string TeamId = null, Customer Customer = null, Team Team = null, List<Portal> Portals = null, List<Template> UploadedTemplates = null, List<Template> Templates = null, List<InvitationTicket> InvitationTickets = null, List<Design> RequestedDesigns = null, List<DesignExport> RequestedDesignExports = null, List<Design> AssignedDesigns = null, List<Design> ReviewedDesigns = null, List<Design> CommentedDesigns = null, List<DesignComment> DesignComments = null, List<DesignFolder> DesignFolders = null, List<Workflow> Workflows = null, List<ImageFolder> ImageFolders = null)
        {
            // to ensure "Roles" is required (not null)
            if (Roles == null)
            {
                throw new InvalidDataException("Roles is a required property for TeamMember and cannot be null");
            }
            else
            {
                this.Roles = Roles;
            }
            this.Position = Position;
            this.OfficePhone = OfficePhone;
            this.MobilePhone = MobilePhone;
            this.Website = Website;
            this.AddressCity = AddressCity;
            this.AddressCountry = AddressCountry;
            this.AddressLine1 = AddressLine1;
            this.AddressLine2 = AddressLine2;
            this.AddressState = AddressState;
            this.AddressZip = AddressZip;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.CustomerId = CustomerId;
            this.TeamId = TeamId;
            this.Customer = Customer;
            this.Team = Team;
            this.Portals = Portals;
            this.UploadedTemplates = UploadedTemplates;
            this.Templates = Templates;
            this.InvitationTickets = InvitationTickets;
            this.RequestedDesigns = RequestedDesigns;
            this.RequestedDesignExports = RequestedDesignExports;
            this.AssignedDesigns = AssignedDesigns;
            this.ReviewedDesigns = ReviewedDesigns;
            this.CommentedDesigns = CommentedDesigns;
            this.DesignComments = DesignComments;
            this.DesignFolders = DesignFolders;
            this.Workflows = Workflows;
            this.ImageFolders = ImageFolders;
        }
        
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }
        /// <summary>
        /// Gets or Sets OfficePhone
        /// </summary>
        [DataMember(Name="officePhone", EmitDefaultValue=false)]
        public string OfficePhone { get; set; }
        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }
        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Gets or Sets AddressCity
        /// </summary>
        [DataMember(Name="addressCity", EmitDefaultValue=false)]
        public string AddressCity { get; set; }
        /// <summary>
        /// Gets or Sets AddressCountry
        /// </summary>
        [DataMember(Name="addressCountry", EmitDefaultValue=false)]
        public string AddressCountry { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Gets or Sets AddressState
        /// </summary>
        [DataMember(Name="addressState", EmitDefaultValue=false)]
        public string AddressState { get; set; }
        /// <summary>
        /// Gets or Sets AddressZip
        /// </summary>
        [DataMember(Name="addressZip", EmitDefaultValue=false)]
        public string AddressZip { get; set; }
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
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
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
        /// Gets or Sets Portals
        /// </summary>
        [DataMember(Name="portals", EmitDefaultValue=false)]
        public List<Portal> Portals { get; set; }
        /// <summary>
        /// Gets or Sets UploadedTemplates
        /// </summary>
        [DataMember(Name="uploadedTemplates", EmitDefaultValue=false)]
        public List<Template> UploadedTemplates { get; set; }
        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        public List<Template> Templates { get; set; }
        /// <summary>
        /// Gets or Sets InvitationTickets
        /// </summary>
        [DataMember(Name="invitationTickets", EmitDefaultValue=false)]
        public List<InvitationTicket> InvitationTickets { get; set; }
        /// <summary>
        /// Gets or Sets RequestedDesigns
        /// </summary>
        [DataMember(Name="requestedDesigns", EmitDefaultValue=false)]
        public List<Design> RequestedDesigns { get; set; }
        /// <summary>
        /// Gets or Sets RequestedDesignExports
        /// </summary>
        [DataMember(Name="requestedDesignExports", EmitDefaultValue=false)]
        public List<DesignExport> RequestedDesignExports { get; set; }
        /// <summary>
        /// Gets or Sets AssignedDesigns
        /// </summary>
        [DataMember(Name="assignedDesigns", EmitDefaultValue=false)]
        public List<Design> AssignedDesigns { get; set; }
        /// <summary>
        /// Gets or Sets ReviewedDesigns
        /// </summary>
        [DataMember(Name="reviewedDesigns", EmitDefaultValue=false)]
        public List<Design> ReviewedDesigns { get; set; }
        /// <summary>
        /// Gets or Sets CommentedDesigns
        /// </summary>
        [DataMember(Name="commentedDesigns", EmitDefaultValue=false)]
        public List<Design> CommentedDesigns { get; set; }
        /// <summary>
        /// Gets or Sets DesignComments
        /// </summary>
        [DataMember(Name="designComments", EmitDefaultValue=false)]
        public List<DesignComment> DesignComments { get; set; }
        /// <summary>
        /// Gets or Sets DesignFolders
        /// </summary>
        [DataMember(Name="designFolders", EmitDefaultValue=false)]
        public List<DesignFolder> DesignFolders { get; set; }
        /// <summary>
        /// Gets or Sets Workflows
        /// </summary>
        [DataMember(Name="workflows", EmitDefaultValue=false)]
        public List<Workflow> Workflows { get; set; }
        /// <summary>
        /// Gets or Sets ImageFolders
        /// </summary>
        [DataMember(Name="imageFolders", EmitDefaultValue=false)]
        public List<ImageFolder> ImageFolders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamMember {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  OfficePhone: ").Append(OfficePhone).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  AddressCity: ").Append(AddressCity).Append("\n");
            sb.Append("  AddressCountry: ").Append(AddressCountry).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressState: ").Append(AddressState).Append("\n");
            sb.Append("  AddressZip: ").Append(AddressZip).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Portals: ").Append(Portals).Append("\n");
            sb.Append("  UploadedTemplates: ").Append(UploadedTemplates).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  InvitationTickets: ").Append(InvitationTickets).Append("\n");
            sb.Append("  RequestedDesigns: ").Append(RequestedDesigns).Append("\n");
            sb.Append("  RequestedDesignExports: ").Append(RequestedDesignExports).Append("\n");
            sb.Append("  AssignedDesigns: ").Append(AssignedDesigns).Append("\n");
            sb.Append("  ReviewedDesigns: ").Append(ReviewedDesigns).Append("\n");
            sb.Append("  CommentedDesigns: ").Append(CommentedDesigns).Append("\n");
            sb.Append("  DesignComments: ").Append(DesignComments).Append("\n");
            sb.Append("  DesignFolders: ").Append(DesignFolders).Append("\n");
            sb.Append("  Workflows: ").Append(Workflows).Append("\n");
            sb.Append("  ImageFolders: ").Append(ImageFolders).Append("\n");
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
            return this.Equals(obj as TeamMember);
        }

        /// <summary>
        /// Returns true if TeamMember instances are equal
        /// </summary>
        /// <param name="other">Instance of TeamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamMember other)
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
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.OfficePhone == other.OfficePhone ||
                    this.OfficePhone != null &&
                    this.OfficePhone.Equals(other.OfficePhone)
                ) && 
                (
                    this.MobilePhone == other.MobilePhone ||
                    this.MobilePhone != null &&
                    this.MobilePhone.Equals(other.MobilePhone)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.AddressCity == other.AddressCity ||
                    this.AddressCity != null &&
                    this.AddressCity.Equals(other.AddressCity)
                ) && 
                (
                    this.AddressCountry == other.AddressCountry ||
                    this.AddressCountry != null &&
                    this.AddressCountry.Equals(other.AddressCountry)
                ) && 
                (
                    this.AddressLine1 == other.AddressLine1 ||
                    this.AddressLine1 != null &&
                    this.AddressLine1.Equals(other.AddressLine1)
                ) && 
                (
                    this.AddressLine2 == other.AddressLine2 ||
                    this.AddressLine2 != null &&
                    this.AddressLine2.Equals(other.AddressLine2)
                ) && 
                (
                    this.AddressState == other.AddressState ||
                    this.AddressState != null &&
                    this.AddressState.Equals(other.AddressState)
                ) && 
                (
                    this.AddressZip == other.AddressZip ||
                    this.AddressZip != null &&
                    this.AddressZip.Equals(other.AddressZip)
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
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
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
                    this.Portals == other.Portals ||
                    this.Portals != null &&
                    this.Portals.SequenceEqual(other.Portals)
                ) && 
                (
                    this.UploadedTemplates == other.UploadedTemplates ||
                    this.UploadedTemplates != null &&
                    this.UploadedTemplates.SequenceEqual(other.UploadedTemplates)
                ) && 
                (
                    this.Templates == other.Templates ||
                    this.Templates != null &&
                    this.Templates.SequenceEqual(other.Templates)
                ) && 
                (
                    this.InvitationTickets == other.InvitationTickets ||
                    this.InvitationTickets != null &&
                    this.InvitationTickets.SequenceEqual(other.InvitationTickets)
                ) && 
                (
                    this.RequestedDesigns == other.RequestedDesigns ||
                    this.RequestedDesigns != null &&
                    this.RequestedDesigns.SequenceEqual(other.RequestedDesigns)
                ) && 
                (
                    this.RequestedDesignExports == other.RequestedDesignExports ||
                    this.RequestedDesignExports != null &&
                    this.RequestedDesignExports.SequenceEqual(other.RequestedDesignExports)
                ) && 
                (
                    this.AssignedDesigns == other.AssignedDesigns ||
                    this.AssignedDesigns != null &&
                    this.AssignedDesigns.SequenceEqual(other.AssignedDesigns)
                ) && 
                (
                    this.ReviewedDesigns == other.ReviewedDesigns ||
                    this.ReviewedDesigns != null &&
                    this.ReviewedDesigns.SequenceEqual(other.ReviewedDesigns)
                ) && 
                (
                    this.CommentedDesigns == other.CommentedDesigns ||
                    this.CommentedDesigns != null &&
                    this.CommentedDesigns.SequenceEqual(other.CommentedDesigns)
                ) && 
                (
                    this.DesignComments == other.DesignComments ||
                    this.DesignComments != null &&
                    this.DesignComments.SequenceEqual(other.DesignComments)
                ) && 
                (
                    this.DesignFolders == other.DesignFolders ||
                    this.DesignFolders != null &&
                    this.DesignFolders.SequenceEqual(other.DesignFolders)
                ) && 
                (
                    this.Workflows == other.Workflows ||
                    this.Workflows != null &&
                    this.Workflows.SequenceEqual(other.Workflows)
                ) && 
                (
                    this.ImageFolders == other.ImageFolders ||
                    this.ImageFolders != null &&
                    this.ImageFolders.SequenceEqual(other.ImageFolders)
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
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.OfficePhone != null)
                    hash = hash * 59 + this.OfficePhone.GetHashCode();
                if (this.MobilePhone != null)
                    hash = hash * 59 + this.MobilePhone.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.AddressCity != null)
                    hash = hash * 59 + this.AddressCity.GetHashCode();
                if (this.AddressCountry != null)
                    hash = hash * 59 + this.AddressCountry.GetHashCode();
                if (this.AddressLine1 != null)
                    hash = hash * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hash = hash * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressState != null)
                    hash = hash * 59 + this.AddressState.GetHashCode();
                if (this.AddressZip != null)
                    hash = hash * 59 + this.AddressZip.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.Portals != null)
                    hash = hash * 59 + this.Portals.GetHashCode();
                if (this.UploadedTemplates != null)
                    hash = hash * 59 + this.UploadedTemplates.GetHashCode();
                if (this.Templates != null)
                    hash = hash * 59 + this.Templates.GetHashCode();
                if (this.InvitationTickets != null)
                    hash = hash * 59 + this.InvitationTickets.GetHashCode();
                if (this.RequestedDesigns != null)
                    hash = hash * 59 + this.RequestedDesigns.GetHashCode();
                if (this.RequestedDesignExports != null)
                    hash = hash * 59 + this.RequestedDesignExports.GetHashCode();
                if (this.AssignedDesigns != null)
                    hash = hash * 59 + this.AssignedDesigns.GetHashCode();
                if (this.ReviewedDesigns != null)
                    hash = hash * 59 + this.ReviewedDesigns.GetHashCode();
                if (this.CommentedDesigns != null)
                    hash = hash * 59 + this.CommentedDesigns.GetHashCode();
                if (this.DesignComments != null)
                    hash = hash * 59 + this.DesignComments.GetHashCode();
                if (this.DesignFolders != null)
                    hash = hash * 59 + this.DesignFolders.GetHashCode();
                if (this.Workflows != null)
                    hash = hash * 59 + this.Workflows.GetHashCode();
                if (this.ImageFolders != null)
                    hash = hash * 59 + this.ImageFolders.GetHashCode();
                return hash;
            }
        }
    }

}

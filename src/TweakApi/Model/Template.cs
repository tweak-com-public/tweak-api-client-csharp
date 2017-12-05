/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.2
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
    /// Template
    /// </summary>
    [DataContract]
    public partial class Template :  IEquatable<Template>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PendingApproval for "pendingApproval"
            /// </summary>
            [EnumMember(Value = "pendingApproval")]
            PendingApproval,
            
            /// <summary>
            /// Enum Approved for "approved"
            /// </summary>
            [EnumMember(Value = "approved")]
            Approved,
            
            /// <summary>
            /// Enum Rejected for "rejected"
            /// </summary>
            [EnumMember(Value = "rejected")]
            Rejected
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Template() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Template" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="_Object">_Object (required).</param>
        /// <param name="Description">Description (default to &quot;&quot;).</param>
        /// <param name="Edited">Edited.</param>
        /// <param name="Path">Path (default to &quot;/&quot;).</param>
        /// <param name="Status">Status.</param>
        /// <param name="Shared">Shared.</param>
        /// <param name="PermissionSetUpdated">PermissionSetUpdated.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="UploaderId">UploaderId.</param>
        /// <param name="TeamFolderId">TeamFolderId.</param>
        /// <param name="WorkflowId">WorkflowId.</param>
        /// <param name="Portals">Portals.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Members">Members.</param>
        /// <param name="TemplateMembers">TemplateMembers.</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="Designs">Designs.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="TeamFolder">TeamFolder.</param>
        /// <param name="PortalFolders">PortalFolders.</param>
        /// <param name="Workflow">Workflow.</param>
        /// <param name="Uploader">Uploader.</param>
        public Template(string Name = null, string Thumbnail = null, Object _Object = null, string Description = null, DateTime? Edited = null, string Path = null, StatusEnum? Status = null, DateTime? Shared = null, DateTime? PermissionSetUpdated = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string TeamId = null, string UploaderId = null, string TeamFolderId = null, string WorkflowId = null, List<Portal> Portals = null, Team Team = null, List<TeamMember> Members = null, List<TemplateMember> TemplateMembers = null, TemplatePermissionSet Permission = null, List<Design> Designs = null, List<Tag> Tags = null, TeamTemplateFolder TeamFolder = null, List<PortalTemplateFolder> PortalFolders = null, Workflow Workflow = null, TeamMember Uploader = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Template and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for Template and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            this.Thumbnail = Thumbnail;
            // use default value if no "Description" provided
            if (Description == null)
            {
                this.Description = "";
            }
            else
            {
                this.Description = Description;
            }
            this.Edited = Edited;
            // use default value if no "Path" provided
            if (Path == null)
            {
                this.Path = "/";
            }
            else
            {
                this.Path = Path;
            }
            this.Status = Status;
            this.Shared = Shared;
            this.PermissionSetUpdated = PermissionSetUpdated;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.TeamId = TeamId;
            this.UploaderId = UploaderId;
            this.TeamFolderId = TeamFolderId;
            this.WorkflowId = WorkflowId;
            this.Portals = Portals;
            this.Team = Team;
            this.Members = Members;
            this.TemplateMembers = TemplateMembers;
            this.Permission = Permission;
            this.Designs = Designs;
            this.Tags = Tags;
            this.TeamFolder = TeamFolder;
            this.PortalFolders = PortalFolders;
            this.Workflow = Workflow;
            this.Uploader = Uploader;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public Object _Object { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Edited
        /// </summary>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public DateTime? Edited { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public DateTime? Shared { get; set; }
        /// <summary>
        /// Gets or Sets PermissionSetUpdated
        /// </summary>
        [DataMember(Name="permissionSetUpdated", EmitDefaultValue=false)]
        public DateTime? PermissionSetUpdated { get; set; }
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
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets UploaderId
        /// </summary>
        [DataMember(Name="uploaderId", EmitDefaultValue=false)]
        public string UploaderId { get; set; }
        /// <summary>
        /// Gets or Sets TeamFolderId
        /// </summary>
        [DataMember(Name="teamFolderId", EmitDefaultValue=false)]
        public string TeamFolderId { get; set; }
        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId", EmitDefaultValue=false)]
        public string WorkflowId { get; set; }
        /// <summary>
        /// Gets or Sets Portals
        /// </summary>
        [DataMember(Name="portals", EmitDefaultValue=false)]
        public List<Portal> Portals { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<TeamMember> Members { get; set; }
        /// <summary>
        /// Gets or Sets TemplateMembers
        /// </summary>
        [DataMember(Name="templateMembers", EmitDefaultValue=false)]
        public List<TemplateMember> TemplateMembers { get; set; }
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public TemplatePermissionSet Permission { get; set; }
        /// <summary>
        /// Gets or Sets Designs
        /// </summary>
        [DataMember(Name="designs", EmitDefaultValue=false)]
        public List<Design> Designs { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Gets or Sets TeamFolder
        /// </summary>
        [DataMember(Name="teamFolder", EmitDefaultValue=false)]
        public TeamTemplateFolder TeamFolder { get; set; }
        /// <summary>
        /// Gets or Sets PortalFolders
        /// </summary>
        [DataMember(Name="portalFolders", EmitDefaultValue=false)]
        public List<PortalTemplateFolder> PortalFolders { get; set; }
        /// <summary>
        /// Gets or Sets Workflow
        /// </summary>
        [DataMember(Name="workflow", EmitDefaultValue=false)]
        public Workflow Workflow { get; set; }
        /// <summary>
        /// Gets or Sets Uploader
        /// </summary>
        [DataMember(Name="uploader", EmitDefaultValue=false)]
        public TeamMember Uploader { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Template {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  PermissionSetUpdated: ").Append(PermissionSetUpdated).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  UploaderId: ").Append(UploaderId).Append("\n");
            sb.Append("  TeamFolderId: ").Append(TeamFolderId).Append("\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  Portals: ").Append(Portals).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  TemplateMembers: ").Append(TemplateMembers).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Designs: ").Append(Designs).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TeamFolder: ").Append(TeamFolder).Append("\n");
            sb.Append("  PortalFolders: ").Append(PortalFolders).Append("\n");
            sb.Append("  Workflow: ").Append(Workflow).Append("\n");
            sb.Append("  Uploader: ").Append(Uploader).Append("\n");
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
            return this.Equals(obj as Template);
        }

        /// <summary>
        /// Returns true if Template instances are equal
        /// </summary>
        /// <param name="other">Instance of Template to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Template other)
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
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
                ) && 
                (
                    this.PermissionSetUpdated == other.PermissionSetUpdated ||
                    this.PermissionSetUpdated != null &&
                    this.PermissionSetUpdated.Equals(other.PermissionSetUpdated)
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
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.UploaderId == other.UploaderId ||
                    this.UploaderId != null &&
                    this.UploaderId.Equals(other.UploaderId)
                ) && 
                (
                    this.TeamFolderId == other.TeamFolderId ||
                    this.TeamFolderId != null &&
                    this.TeamFolderId.Equals(other.TeamFolderId)
                ) && 
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
                ) && 
                (
                    this.Portals == other.Portals ||
                    this.Portals != null &&
                    this.Portals.SequenceEqual(other.Portals)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) && 
                (
                    this.TemplateMembers == other.TemplateMembers ||
                    this.TemplateMembers != null &&
                    this.TemplateMembers.SequenceEqual(other.TemplateMembers)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.Designs == other.Designs ||
                    this.Designs != null &&
                    this.Designs.SequenceEqual(other.Designs)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.TeamFolder == other.TeamFolder ||
                    this.TeamFolder != null &&
                    this.TeamFolder.Equals(other.TeamFolder)
                ) && 
                (
                    this.PortalFolders == other.PortalFolders ||
                    this.PortalFolders != null &&
                    this.PortalFolders.SequenceEqual(other.PortalFolders)
                ) && 
                (
                    this.Workflow == other.Workflow ||
                    this.Workflow != null &&
                    this.Workflow.Equals(other.Workflow)
                ) && 
                (
                    this.Uploader == other.Uploader ||
                    this.Uploader != null &&
                    this.Uploader.Equals(other.Uploader)
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
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.PermissionSetUpdated != null)
                    hash = hash * 59 + this.PermissionSetUpdated.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.UploaderId != null)
                    hash = hash * 59 + this.UploaderId.GetHashCode();
                if (this.TeamFolderId != null)
                    hash = hash * 59 + this.TeamFolderId.GetHashCode();
                if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();
                if (this.Portals != null)
                    hash = hash * 59 + this.Portals.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.TemplateMembers != null)
                    hash = hash * 59 + this.TemplateMembers.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.Designs != null)
                    hash = hash * 59 + this.Designs.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.TeamFolder != null)
                    hash = hash * 59 + this.TeamFolder.GetHashCode();
                if (this.PortalFolders != null)
                    hash = hash * 59 + this.PortalFolders.GetHashCode();
                if (this.Workflow != null)
                    hash = hash * 59 + this.Workflow.GetHashCode();
                if (this.Uploader != null)
                    hash = hash * 59 + this.Uploader.GetHashCode();
                return hash;
            }
        }
    }

}

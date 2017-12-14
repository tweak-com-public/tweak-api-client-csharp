/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.15
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
    /// Design
    /// </summary>
    [DataContract]
    public partial class Design :  IEquatable<Design>
    {
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PurposeEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum PrintOrder for "printOrder"
            /// </summary>
            [EnumMember(Value = "printOrder")]
            PrintOrder
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PendingAction for "pendingAction"
            /// </summary>
            [EnumMember(Value = "pendingAction")]
            PendingAction,
            
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
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum? Purpose { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Design" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Design() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Design" /> class.
        /// </summary>
        /// <param name="Colors">Colors.</param>
        /// <param name="Image">Image.</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="_Object">_Object (required).</param>
        /// <param name="Thumbnail">Thumbnail.</param>
        /// <param name="Description">Description (default to &quot;&quot;).</param>
        /// <param name="Purpose">Purpose.</param>
        /// <param name="Status">Status.</param>
        /// <param name="FormData">FormData.</param>
        /// <param name="HighResPdfUrl">HighResPdfUrl (default to &quot;&quot;).</param>
        /// <param name="ProofPdfUrl">ProofPdfUrl (default to &quot;&quot;).</param>
        /// <param name="JpegsUrl">JpegsUrl (default to &quot;&quot;).</param>
        /// <param name="Edited">Edited.</param>
        /// <param name="Expired">Expired.</param>
        /// <param name="Path">Path (default to &quot;/&quot;).</param>
        /// <param name="SentForApproval">SentForApproval.</param>
        /// <param name="Approved">Approved.</param>
        /// <param name="Shared">Shared.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="DynamicDataId">DynamicDataId.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="RequesterId">RequesterId.</param>
        /// <param name="AssigneeId">AssigneeId.</param>
        /// <param name="ReviewerId">ReviewerId.</param>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="RejectionCommentId">RejectionCommentId.</param>
        /// <param name="FolderId">FolderId.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Template">Template.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Comments">Comments.</param>
        /// <param name="RejectionComment">RejectionComment.</param>
        /// <param name="Exports">Exports.</param>
        /// <param name="Requester">Requester.</param>
        /// <param name="Assignee">Assignee.</param>
        /// <param name="Reviewer">Reviewer.</param>
        /// <param name="Commenters">Commenters.</param>
        /// <param name="Folder">Folder.</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="Members">Members.</param>
        /// <param name="DesignMembers">DesignMembers.</param>
        /// <param name="DynamicData">DynamicData.</param>
        public Design(List<string> Colors = null, string Image = null, string Name = null, Object _Object = null, string Thumbnail = null, string Description = null, PurposeEnum? Purpose = null, StatusEnum? Status = null, List<Object> FormData = null, string HighResPdfUrl = null, string ProofPdfUrl = null, string JpegsUrl = null, DateTime? Edited = null, DateTime? Expired = null, string Path = null, DateTime? SentForApproval = null, DateTime? Approved = null, DateTime? Shared = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string DynamicDataId = null, string TeamId = null, string RequesterId = null, string AssigneeId = null, string ReviewerId = null, string TemplateId = null, string PortalId = null, string RejectionCommentId = null, string FolderId = null, List<Tag> Tags = null, Template Template = null, Portal Portal = null, Team Team = null, List<DesignComment> Comments = null, DesignComment RejectionComment = null, List<DesignExport> Exports = null, TeamMember Requester = null, TeamMember Assignee = null, TeamMember Reviewer = null, List<TeamMember> Commenters = null, DesignFolder Folder = null, DesignPermissionSet Permission = null, List<TeamMember> Members = null, List<DesignMember> DesignMembers = null, DynamicData DynamicData = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Design and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for Design and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
            this.Colors = Colors;
            this.Image = Image;
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
            this.Purpose = Purpose;
            this.Status = Status;
            this.FormData = FormData;
            // use default value if no "HighResPdfUrl" provided
            if (HighResPdfUrl == null)
            {
                this.HighResPdfUrl = "";
            }
            else
            {
                this.HighResPdfUrl = HighResPdfUrl;
            }
            // use default value if no "ProofPdfUrl" provided
            if (ProofPdfUrl == null)
            {
                this.ProofPdfUrl = "";
            }
            else
            {
                this.ProofPdfUrl = ProofPdfUrl;
            }
            // use default value if no "JpegsUrl" provided
            if (JpegsUrl == null)
            {
                this.JpegsUrl = "";
            }
            else
            {
                this.JpegsUrl = JpegsUrl;
            }
            this.Edited = Edited;
            this.Expired = Expired;
            // use default value if no "Path" provided
            if (Path == null)
            {
                this.Path = "/";
            }
            else
            {
                this.Path = Path;
            }
            this.SentForApproval = SentForApproval;
            this.Approved = Approved;
            this.Shared = Shared;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.DynamicDataId = DynamicDataId;
            this.TeamId = TeamId;
            this.RequesterId = RequesterId;
            this.AssigneeId = AssigneeId;
            this.ReviewerId = ReviewerId;
            this.TemplateId = TemplateId;
            this.PortalId = PortalId;
            this.RejectionCommentId = RejectionCommentId;
            this.FolderId = FolderId;
            this.Tags = Tags;
            this.Template = Template;
            this.Portal = Portal;
            this.Team = Team;
            this.Comments = Comments;
            this.RejectionComment = RejectionComment;
            this.Exports = Exports;
            this.Requester = Requester;
            this.Assignee = Assignee;
            this.Reviewer = Reviewer;
            this.Commenters = Commenters;
            this.Folder = Folder;
            this.Permission = Permission;
            this.Members = Members;
            this.DesignMembers = DesignMembers;
            this.DynamicData = DynamicData;
        }
        
        /// <summary>
        /// Gets or Sets Colors
        /// </summary>
        [DataMember(Name="colors", EmitDefaultValue=false)]
        public List<string> Colors { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets _Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public Object _Object { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public List<Object> FormData { get; set; }
        /// <summary>
        /// Gets or Sets HighResPdfUrl
        /// </summary>
        [DataMember(Name="highResPdfUrl", EmitDefaultValue=false)]
        public string HighResPdfUrl { get; set; }
        /// <summary>
        /// Gets or Sets ProofPdfUrl
        /// </summary>
        [DataMember(Name="proofPdfUrl", EmitDefaultValue=false)]
        public string ProofPdfUrl { get; set; }
        /// <summary>
        /// Gets or Sets JpegsUrl
        /// </summary>
        [DataMember(Name="jpegsUrl", EmitDefaultValue=false)]
        public string JpegsUrl { get; set; }
        /// <summary>
        /// Gets or Sets Edited
        /// </summary>
        [DataMember(Name="edited", EmitDefaultValue=false)]
        public DateTime? Edited { get; set; }
        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public DateTime? Expired { get; set; }
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Gets or Sets SentForApproval
        /// </summary>
        [DataMember(Name="sentForApproval", EmitDefaultValue=false)]
        public DateTime? SentForApproval { get; set; }
        /// <summary>
        /// Gets or Sets Approved
        /// </summary>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public DateTime? Approved { get; set; }
        /// <summary>
        /// Gets or Sets Shared
        /// </summary>
        [DataMember(Name="shared", EmitDefaultValue=false)]
        public DateTime? Shared { get; set; }
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
        /// Gets or Sets DynamicDataId
        /// </summary>
        [DataMember(Name="dynamicDataId", EmitDefaultValue=false)]
        public string DynamicDataId { get; set; }
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }
        /// <summary>
        /// Gets or Sets RequesterId
        /// </summary>
        [DataMember(Name="requesterId", EmitDefaultValue=false)]
        public string RequesterId { get; set; }
        /// <summary>
        /// Gets or Sets AssigneeId
        /// </summary>
        [DataMember(Name="assigneeId", EmitDefaultValue=false)]
        public string AssigneeId { get; set; }
        /// <summary>
        /// Gets or Sets ReviewerId
        /// </summary>
        [DataMember(Name="reviewerId", EmitDefaultValue=false)]
        public string ReviewerId { get; set; }
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name="portalId", EmitDefaultValue=false)]
        public string PortalId { get; set; }
        /// <summary>
        /// Gets or Sets RejectionCommentId
        /// </summary>
        [DataMember(Name="rejectionCommentId", EmitDefaultValue=false)]
        public string RejectionCommentId { get; set; }
        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }
        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public Template Template { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<DesignComment> Comments { get; set; }
        /// <summary>
        /// Gets or Sets RejectionComment
        /// </summary>
        [DataMember(Name="rejectionComment", EmitDefaultValue=false)]
        public DesignComment RejectionComment { get; set; }
        /// <summary>
        /// Gets or Sets Exports
        /// </summary>
        [DataMember(Name="exports", EmitDefaultValue=false)]
        public List<DesignExport> Exports { get; set; }
        /// <summary>
        /// Gets or Sets Requester
        /// </summary>
        [DataMember(Name="requester", EmitDefaultValue=false)]
        public TeamMember Requester { get; set; }
        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public TeamMember Assignee { get; set; }
        /// <summary>
        /// Gets or Sets Reviewer
        /// </summary>
        [DataMember(Name="reviewer", EmitDefaultValue=false)]
        public TeamMember Reviewer { get; set; }
        /// <summary>
        /// Gets or Sets Commenters
        /// </summary>
        [DataMember(Name="commenters", EmitDefaultValue=false)]
        public List<TeamMember> Commenters { get; set; }
        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public DesignFolder Folder { get; set; }
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public DesignPermissionSet Permission { get; set; }
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<TeamMember> Members { get; set; }
        /// <summary>
        /// Gets or Sets DesignMembers
        /// </summary>
        [DataMember(Name="designMembers", EmitDefaultValue=false)]
        public List<DesignMember> DesignMembers { get; set; }
        /// <summary>
        /// Gets or Sets DynamicData
        /// </summary>
        [DataMember(Name="dynamicData", EmitDefaultValue=false)]
        public DynamicData DynamicData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Design {\n");
            sb.Append("  Colors: ").Append(Colors).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
            sb.Append("  HighResPdfUrl: ").Append(HighResPdfUrl).Append("\n");
            sb.Append("  ProofPdfUrl: ").Append(ProofPdfUrl).Append("\n");
            sb.Append("  JpegsUrl: ").Append(JpegsUrl).Append("\n");
            sb.Append("  Edited: ").Append(Edited).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  SentForApproval: ").Append(SentForApproval).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DynamicDataId: ").Append(DynamicDataId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  ReviewerId: ").Append(ReviewerId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  RejectionCommentId: ").Append(RejectionCommentId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  RejectionComment: ").Append(RejectionComment).Append("\n");
            sb.Append("  Exports: ").Append(Exports).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  Commenters: ").Append(Commenters).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  DesignMembers: ").Append(DesignMembers).Append("\n");
            sb.Append("  DynamicData: ").Append(DynamicData).Append("\n");
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
            return this.Equals(obj as Design);
        }

        /// <summary>
        /// Returns true if Design instances are equal
        /// </summary>
        /// <param name="other">Instance of Design to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Design other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Colors == other.Colors ||
                    this.Colors != null &&
                    this.Colors.SequenceEqual(other.Colors)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this.Thumbnail == other.Thumbnail ||
                    this.Thumbnail != null &&
                    this.Thumbnail.Equals(other.Thumbnail)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.FormData == other.FormData ||
                    this.FormData != null &&
                    this.FormData.SequenceEqual(other.FormData)
                ) && 
                (
                    this.HighResPdfUrl == other.HighResPdfUrl ||
                    this.HighResPdfUrl != null &&
                    this.HighResPdfUrl.Equals(other.HighResPdfUrl)
                ) && 
                (
                    this.ProofPdfUrl == other.ProofPdfUrl ||
                    this.ProofPdfUrl != null &&
                    this.ProofPdfUrl.Equals(other.ProofPdfUrl)
                ) && 
                (
                    this.JpegsUrl == other.JpegsUrl ||
                    this.JpegsUrl != null &&
                    this.JpegsUrl.Equals(other.JpegsUrl)
                ) && 
                (
                    this.Edited == other.Edited ||
                    this.Edited != null &&
                    this.Edited.Equals(other.Edited)
                ) && 
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.SentForApproval == other.SentForApproval ||
                    this.SentForApproval != null &&
                    this.SentForApproval.Equals(other.SentForApproval)
                ) && 
                (
                    this.Approved == other.Approved ||
                    this.Approved != null &&
                    this.Approved.Equals(other.Approved)
                ) && 
                (
                    this.Shared == other.Shared ||
                    this.Shared != null &&
                    this.Shared.Equals(other.Shared)
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
                    this.DynamicDataId == other.DynamicDataId ||
                    this.DynamicDataId != null &&
                    this.DynamicDataId.Equals(other.DynamicDataId)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
                ) && 
                (
                    this.RequesterId == other.RequesterId ||
                    this.RequesterId != null &&
                    this.RequesterId.Equals(other.RequesterId)
                ) && 
                (
                    this.AssigneeId == other.AssigneeId ||
                    this.AssigneeId != null &&
                    this.AssigneeId.Equals(other.AssigneeId)
                ) && 
                (
                    this.ReviewerId == other.ReviewerId ||
                    this.ReviewerId != null &&
                    this.ReviewerId.Equals(other.ReviewerId)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.PortalId == other.PortalId ||
                    this.PortalId != null &&
                    this.PortalId.Equals(other.PortalId)
                ) && 
                (
                    this.RejectionCommentId == other.RejectionCommentId ||
                    this.RejectionCommentId != null &&
                    this.RejectionCommentId.Equals(other.RejectionCommentId)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(other.Comments)
                ) && 
                (
                    this.RejectionComment == other.RejectionComment ||
                    this.RejectionComment != null &&
                    this.RejectionComment.Equals(other.RejectionComment)
                ) && 
                (
                    this.Exports == other.Exports ||
                    this.Exports != null &&
                    this.Exports.SequenceEqual(other.Exports)
                ) && 
                (
                    this.Requester == other.Requester ||
                    this.Requester != null &&
                    this.Requester.Equals(other.Requester)
                ) && 
                (
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.Equals(other.Assignee)
                ) && 
                (
                    this.Reviewer == other.Reviewer ||
                    this.Reviewer != null &&
                    this.Reviewer.Equals(other.Reviewer)
                ) && 
                (
                    this.Commenters == other.Commenters ||
                    this.Commenters != null &&
                    this.Commenters.SequenceEqual(other.Commenters)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) && 
                (
                    this.DesignMembers == other.DesignMembers ||
                    this.DesignMembers != null &&
                    this.DesignMembers.SequenceEqual(other.DesignMembers)
                ) && 
                (
                    this.DynamicData == other.DynamicData ||
                    this.DynamicData != null &&
                    this.DynamicData.Equals(other.DynamicData)
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
                if (this.Colors != null)
                    hash = hash * 59 + this.Colors.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this.Thumbnail != null)
                    hash = hash * 59 + this.Thumbnail.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.FormData != null)
                    hash = hash * 59 + this.FormData.GetHashCode();
                if (this.HighResPdfUrl != null)
                    hash = hash * 59 + this.HighResPdfUrl.GetHashCode();
                if (this.ProofPdfUrl != null)
                    hash = hash * 59 + this.ProofPdfUrl.GetHashCode();
                if (this.JpegsUrl != null)
                    hash = hash * 59 + this.JpegsUrl.GetHashCode();
                if (this.Edited != null)
                    hash = hash * 59 + this.Edited.GetHashCode();
                if (this.Expired != null)
                    hash = hash * 59 + this.Expired.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.SentForApproval != null)
                    hash = hash * 59 + this.SentForApproval.GetHashCode();
                if (this.Approved != null)
                    hash = hash * 59 + this.Approved.GetHashCode();
                if (this.Shared != null)
                    hash = hash * 59 + this.Shared.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DynamicDataId != null)
                    hash = hash * 59 + this.DynamicDataId.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.RequesterId != null)
                    hash = hash * 59 + this.RequesterId.GetHashCode();
                if (this.AssigneeId != null)
                    hash = hash * 59 + this.AssigneeId.GetHashCode();
                if (this.ReviewerId != null)
                    hash = hash * 59 + this.ReviewerId.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.RejectionCommentId != null)
                    hash = hash * 59 + this.RejectionCommentId.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.RejectionComment != null)
                    hash = hash * 59 + this.RejectionComment.GetHashCode();
                if (this.Exports != null)
                    hash = hash * 59 + this.Exports.GetHashCode();
                if (this.Requester != null)
                    hash = hash * 59 + this.Requester.GetHashCode();
                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();
                if (this.Reviewer != null)
                    hash = hash * 59 + this.Reviewer.GetHashCode();
                if (this.Commenters != null)
                    hash = hash * 59 + this.Commenters.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.DesignMembers != null)
                    hash = hash * 59 + this.DesignMembers.GetHashCode();
                if (this.DynamicData != null)
                    hash = hash * 59 + this.DynamicData.GetHashCode();
                return hash;
            }
        }
    }

}

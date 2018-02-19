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
    /// InvitationTicket
    /// </summary>
    [DataContract]
    public partial class InvitationTicket :  IEquatable<InvitationTicket>
    {
        /// <summary>
        /// Gets or Sets TargetModel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetModelEnum
        {
            
            /// <summary>
            /// Enum Team for "Team"
            /// </summary>
            [EnumMember(Value = "Team")]
            Team,
            
            /// <summary>
            /// Enum Portal for "Portal"
            /// </summary>
            [EnumMember(Value = "Portal")]
            Portal,
            
            /// <summary>
            /// Enum Template for "Template"
            /// </summary>
            [EnumMember(Value = "Template")]
            Template,
            
            /// <summary>
            /// Enum ImageFolder for "ImageFolder"
            /// </summary>
            [EnumMember(Value = "ImageFolder")]
            ImageFolder,
            
            /// <summary>
            /// Enum Design for "Design"
            /// </summary>
            [EnumMember(Value = "Design")]
            Design
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Accepted for "accepted"
            /// </summary>
            [EnumMember(Value = "accepted")]
            Accepted
        }

        /// <summary>
        /// Gets or Sets TargetModel
        /// </summary>
        [DataMember(Name="targetModel", EmitDefaultValue=false)]
        public TargetModelEnum? TargetModel { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationTicket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationTicket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationTicket" /> class.
        /// </summary>
        /// <param name="Message">Message (default to &quot;&quot;).</param>
        /// <param name="Token">Token.</param>
        /// <param name="InviteeEmail">InviteeEmail.</param>
        /// <param name="TargetModel">TargetModel (required).</param>
        /// <param name="TargetId">TargetId (required).</param>
        /// <param name="TargetAttrs">TargetAttrs.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Notify">Notify (default to true).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InviteeId">InviteeId.</param>
        /// <param name="InviterId">InviterId.</param>
        /// <param name="TargetTeamId">TargetTeamId.</param>
        /// <param name="TargetTeamMemberId">TargetTeamMemberId.</param>
        /// <param name="TargetPortalId">TargetPortalId.</param>
        /// <param name="TargetPortalMemberId">TargetPortalMemberId.</param>
        /// <param name="TargetTemplateId">TargetTemplateId.</param>
        /// <param name="TargetDesignId">TargetDesignId.</param>
        /// <param name="TargetTemplateMemberId">TargetTemplateMemberId.</param>
        /// <param name="TargetDesignMemberId">TargetDesignMemberId.</param>
        /// <param name="TargetImageFolderId">TargetImageFolderId.</param>
        /// <param name="TargetImageFolderMemberId">TargetImageFolderMemberId.</param>
        /// <param name="Invitee">Invitee.</param>
        /// <param name="Inviter">Inviter.</param>
        /// <param name="TargetTeam">TargetTeam.</param>
        /// <param name="TargetTeamMember">TargetTeamMember.</param>
        /// <param name="TargetPortal">TargetPortal.</param>
        /// <param name="TargetPortalMember">TargetPortalMember.</param>
        /// <param name="TargetTemplate">TargetTemplate.</param>
        /// <param name="TargetTemplateMember">TargetTemplateMember.</param>
        /// <param name="TargetImageFolder">TargetImageFolder.</param>
        /// <param name="TargetImageFolderMember">TargetImageFolderMember.</param>
        /// <param name="TargetDesign">TargetDesign.</param>
        /// <param name="TargetDesignMember">TargetDesignMember.</param>
        public InvitationTicket(string Message = null, string Token = null, string InviteeEmail = null, TargetModelEnum? TargetModel = null, string TargetId = null, Object TargetAttrs = null, StatusEnum? Status = null, bool? Notify = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string InviteeId = null, string InviterId = null, string TargetTeamId = null, string TargetTeamMemberId = null, string TargetPortalId = null, string TargetPortalMemberId = null, string TargetTemplateId = null, string TargetDesignId = null, string TargetTemplateMemberId = null, string TargetDesignMemberId = null, string TargetImageFolderId = null, string TargetImageFolderMemberId = null, Customer Invitee = null, TeamMember Inviter = null, Team TargetTeam = null, TeamMember TargetTeamMember = null, Portal TargetPortal = null, PortalMember TargetPortalMember = null, Template TargetTemplate = null, TemplateMember TargetTemplateMember = null, ImageFolder TargetImageFolder = null, ImageFolderMember TargetImageFolderMember = null, Design TargetDesign = null, DesignMember TargetDesignMember = null)
        {
            // to ensure "TargetModel" is required (not null)
            if (TargetModel == null)
            {
                throw new InvalidDataException("TargetModel is a required property for InvitationTicket and cannot be null");
            }
            else
            {
                this.TargetModel = TargetModel;
            }
            // to ensure "TargetId" is required (not null)
            if (TargetId == null)
            {
                throw new InvalidDataException("TargetId is a required property for InvitationTicket and cannot be null");
            }
            else
            {
                this.TargetId = TargetId;
            }
            // use default value if no "Message" provided
            if (Message == null)
            {
                this.Message = "";
            }
            else
            {
                this.Message = Message;
            }
            this.Token = Token;
            this.InviteeEmail = InviteeEmail;
            this.TargetAttrs = TargetAttrs;
            this.Status = Status;
            // use default value if no "Notify" provided
            if (Notify == null)
            {
                this.Notify = true;
            }
            else
            {
                this.Notify = Notify;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.InviteeId = InviteeId;
            this.InviterId = InviterId;
            this.TargetTeamId = TargetTeamId;
            this.TargetTeamMemberId = TargetTeamMemberId;
            this.TargetPortalId = TargetPortalId;
            this.TargetPortalMemberId = TargetPortalMemberId;
            this.TargetTemplateId = TargetTemplateId;
            this.TargetDesignId = TargetDesignId;
            this.TargetTemplateMemberId = TargetTemplateMemberId;
            this.TargetDesignMemberId = TargetDesignMemberId;
            this.TargetImageFolderId = TargetImageFolderId;
            this.TargetImageFolderMemberId = TargetImageFolderMemberId;
            this.Invitee = Invitee;
            this.Inviter = Inviter;
            this.TargetTeam = TargetTeam;
            this.TargetTeamMember = TargetTeamMember;
            this.TargetPortal = TargetPortal;
            this.TargetPortalMember = TargetPortalMember;
            this.TargetTemplate = TargetTemplate;
            this.TargetTemplateMember = TargetTemplateMember;
            this.TargetImageFolder = TargetImageFolder;
            this.TargetImageFolderMember = TargetImageFolderMember;
            this.TargetDesign = TargetDesign;
            this.TargetDesignMember = TargetDesignMember;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Gets or Sets InviteeEmail
        /// </summary>
        [DataMember(Name="inviteeEmail", EmitDefaultValue=false)]
        public string InviteeEmail { get; set; }
        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name="targetId", EmitDefaultValue=false)]
        public string TargetId { get; set; }
        /// <summary>
        /// Gets or Sets TargetAttrs
        /// </summary>
        [DataMember(Name="targetAttrs", EmitDefaultValue=false)]
        public Object TargetAttrs { get; set; }
        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        [DataMember(Name="notify", EmitDefaultValue=false)]
        public bool? Notify { get; set; }
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
        /// Gets or Sets InviteeId
        /// </summary>
        [DataMember(Name="inviteeId", EmitDefaultValue=false)]
        public string InviteeId { get; set; }
        /// <summary>
        /// Gets or Sets InviterId
        /// </summary>
        [DataMember(Name="inviterId", EmitDefaultValue=false)]
        public string InviterId { get; set; }
        /// <summary>
        /// Gets or Sets TargetTeamId
        /// </summary>
        [DataMember(Name="targetTeamId", EmitDefaultValue=false)]
        public string TargetTeamId { get; set; }
        /// <summary>
        /// Gets or Sets TargetTeamMemberId
        /// </summary>
        [DataMember(Name="targetTeamMemberId", EmitDefaultValue=false)]
        public string TargetTeamMemberId { get; set; }
        /// <summary>
        /// Gets or Sets TargetPortalId
        /// </summary>
        [DataMember(Name="targetPortalId", EmitDefaultValue=false)]
        public string TargetPortalId { get; set; }
        /// <summary>
        /// Gets or Sets TargetPortalMemberId
        /// </summary>
        [DataMember(Name="targetPortalMemberId", EmitDefaultValue=false)]
        public string TargetPortalMemberId { get; set; }
        /// <summary>
        /// Gets or Sets TargetTemplateId
        /// </summary>
        [DataMember(Name="targetTemplateId", EmitDefaultValue=false)]
        public string TargetTemplateId { get; set; }
        /// <summary>
        /// Gets or Sets TargetDesignId
        /// </summary>
        [DataMember(Name="targetDesignId", EmitDefaultValue=false)]
        public string TargetDesignId { get; set; }
        /// <summary>
        /// Gets or Sets TargetTemplateMemberId
        /// </summary>
        [DataMember(Name="targetTemplateMemberId", EmitDefaultValue=false)]
        public string TargetTemplateMemberId { get; set; }
        /// <summary>
        /// Gets or Sets TargetDesignMemberId
        /// </summary>
        [DataMember(Name="targetDesignMemberId", EmitDefaultValue=false)]
        public string TargetDesignMemberId { get; set; }
        /// <summary>
        /// Gets or Sets TargetImageFolderId
        /// </summary>
        [DataMember(Name="targetImageFolderId", EmitDefaultValue=false)]
        public string TargetImageFolderId { get; set; }
        /// <summary>
        /// Gets or Sets TargetImageFolderMemberId
        /// </summary>
        [DataMember(Name="targetImageFolderMemberId", EmitDefaultValue=false)]
        public string TargetImageFolderMemberId { get; set; }
        /// <summary>
        /// Gets or Sets Invitee
        /// </summary>
        [DataMember(Name="invitee", EmitDefaultValue=false)]
        public Customer Invitee { get; set; }
        /// <summary>
        /// Gets or Sets Inviter
        /// </summary>
        [DataMember(Name="inviter", EmitDefaultValue=false)]
        public TeamMember Inviter { get; set; }
        /// <summary>
        /// Gets or Sets TargetTeam
        /// </summary>
        [DataMember(Name="targetTeam", EmitDefaultValue=false)]
        public Team TargetTeam { get; set; }
        /// <summary>
        /// Gets or Sets TargetTeamMember
        /// </summary>
        [DataMember(Name="targetTeamMember", EmitDefaultValue=false)]
        public TeamMember TargetTeamMember { get; set; }
        /// <summary>
        /// Gets or Sets TargetPortal
        /// </summary>
        [DataMember(Name="targetPortal", EmitDefaultValue=false)]
        public Portal TargetPortal { get; set; }
        /// <summary>
        /// Gets or Sets TargetPortalMember
        /// </summary>
        [DataMember(Name="targetPortalMember", EmitDefaultValue=false)]
        public PortalMember TargetPortalMember { get; set; }
        /// <summary>
        /// Gets or Sets TargetTemplate
        /// </summary>
        [DataMember(Name="targetTemplate", EmitDefaultValue=false)]
        public Template TargetTemplate { get; set; }
        /// <summary>
        /// Gets or Sets TargetTemplateMember
        /// </summary>
        [DataMember(Name="targetTemplateMember", EmitDefaultValue=false)]
        public TemplateMember TargetTemplateMember { get; set; }
        /// <summary>
        /// Gets or Sets TargetImageFolder
        /// </summary>
        [DataMember(Name="targetImageFolder", EmitDefaultValue=false)]
        public ImageFolder TargetImageFolder { get; set; }
        /// <summary>
        /// Gets or Sets TargetImageFolderMember
        /// </summary>
        [DataMember(Name="targetImageFolderMember", EmitDefaultValue=false)]
        public ImageFolderMember TargetImageFolderMember { get; set; }
        /// <summary>
        /// Gets or Sets TargetDesign
        /// </summary>
        [DataMember(Name="targetDesign", EmitDefaultValue=false)]
        public Design TargetDesign { get; set; }
        /// <summary>
        /// Gets or Sets TargetDesignMember
        /// </summary>
        [DataMember(Name="targetDesignMember", EmitDefaultValue=false)]
        public DesignMember TargetDesignMember { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationTicket {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  InviteeEmail: ").Append(InviteeEmail).Append("\n");
            sb.Append("  TargetModel: ").Append(TargetModel).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetAttrs: ").Append(TargetAttrs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InviteeId: ").Append(InviteeId).Append("\n");
            sb.Append("  InviterId: ").Append(InviterId).Append("\n");
            sb.Append("  TargetTeamId: ").Append(TargetTeamId).Append("\n");
            sb.Append("  TargetTeamMemberId: ").Append(TargetTeamMemberId).Append("\n");
            sb.Append("  TargetPortalId: ").Append(TargetPortalId).Append("\n");
            sb.Append("  TargetPortalMemberId: ").Append(TargetPortalMemberId).Append("\n");
            sb.Append("  TargetTemplateId: ").Append(TargetTemplateId).Append("\n");
            sb.Append("  TargetDesignId: ").Append(TargetDesignId).Append("\n");
            sb.Append("  TargetTemplateMemberId: ").Append(TargetTemplateMemberId).Append("\n");
            sb.Append("  TargetDesignMemberId: ").Append(TargetDesignMemberId).Append("\n");
            sb.Append("  TargetImageFolderId: ").Append(TargetImageFolderId).Append("\n");
            sb.Append("  TargetImageFolderMemberId: ").Append(TargetImageFolderMemberId).Append("\n");
            sb.Append("  Invitee: ").Append(Invitee).Append("\n");
            sb.Append("  Inviter: ").Append(Inviter).Append("\n");
            sb.Append("  TargetTeam: ").Append(TargetTeam).Append("\n");
            sb.Append("  TargetTeamMember: ").Append(TargetTeamMember).Append("\n");
            sb.Append("  TargetPortal: ").Append(TargetPortal).Append("\n");
            sb.Append("  TargetPortalMember: ").Append(TargetPortalMember).Append("\n");
            sb.Append("  TargetTemplate: ").Append(TargetTemplate).Append("\n");
            sb.Append("  TargetTemplateMember: ").Append(TargetTemplateMember).Append("\n");
            sb.Append("  TargetImageFolder: ").Append(TargetImageFolder).Append("\n");
            sb.Append("  TargetImageFolderMember: ").Append(TargetImageFolderMember).Append("\n");
            sb.Append("  TargetDesign: ").Append(TargetDesign).Append("\n");
            sb.Append("  TargetDesignMember: ").Append(TargetDesignMember).Append("\n");
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
            return this.Equals(obj as InvitationTicket);
        }

        /// <summary>
        /// Returns true if InvitationTicket instances are equal
        /// </summary>
        /// <param name="other">Instance of InvitationTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationTicket other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.InviteeEmail == other.InviteeEmail ||
                    this.InviteeEmail != null &&
                    this.InviteeEmail.Equals(other.InviteeEmail)
                ) && 
                (
                    this.TargetModel == other.TargetModel ||
                    this.TargetModel != null &&
                    this.TargetModel.Equals(other.TargetModel)
                ) && 
                (
                    this.TargetId == other.TargetId ||
                    this.TargetId != null &&
                    this.TargetId.Equals(other.TargetId)
                ) && 
                (
                    this.TargetAttrs == other.TargetAttrs ||
                    this.TargetAttrs != null &&
                    this.TargetAttrs.Equals(other.TargetAttrs)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Notify == other.Notify ||
                    this.Notify != null &&
                    this.Notify.Equals(other.Notify)
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
                    this.InviteeId == other.InviteeId ||
                    this.InviteeId != null &&
                    this.InviteeId.Equals(other.InviteeId)
                ) && 
                (
                    this.InviterId == other.InviterId ||
                    this.InviterId != null &&
                    this.InviterId.Equals(other.InviterId)
                ) && 
                (
                    this.TargetTeamId == other.TargetTeamId ||
                    this.TargetTeamId != null &&
                    this.TargetTeamId.Equals(other.TargetTeamId)
                ) && 
                (
                    this.TargetTeamMemberId == other.TargetTeamMemberId ||
                    this.TargetTeamMemberId != null &&
                    this.TargetTeamMemberId.Equals(other.TargetTeamMemberId)
                ) && 
                (
                    this.TargetPortalId == other.TargetPortalId ||
                    this.TargetPortalId != null &&
                    this.TargetPortalId.Equals(other.TargetPortalId)
                ) && 
                (
                    this.TargetPortalMemberId == other.TargetPortalMemberId ||
                    this.TargetPortalMemberId != null &&
                    this.TargetPortalMemberId.Equals(other.TargetPortalMemberId)
                ) && 
                (
                    this.TargetTemplateId == other.TargetTemplateId ||
                    this.TargetTemplateId != null &&
                    this.TargetTemplateId.Equals(other.TargetTemplateId)
                ) && 
                (
                    this.TargetDesignId == other.TargetDesignId ||
                    this.TargetDesignId != null &&
                    this.TargetDesignId.Equals(other.TargetDesignId)
                ) && 
                (
                    this.TargetTemplateMemberId == other.TargetTemplateMemberId ||
                    this.TargetTemplateMemberId != null &&
                    this.TargetTemplateMemberId.Equals(other.TargetTemplateMemberId)
                ) && 
                (
                    this.TargetDesignMemberId == other.TargetDesignMemberId ||
                    this.TargetDesignMemberId != null &&
                    this.TargetDesignMemberId.Equals(other.TargetDesignMemberId)
                ) && 
                (
                    this.TargetImageFolderId == other.TargetImageFolderId ||
                    this.TargetImageFolderId != null &&
                    this.TargetImageFolderId.Equals(other.TargetImageFolderId)
                ) && 
                (
                    this.TargetImageFolderMemberId == other.TargetImageFolderMemberId ||
                    this.TargetImageFolderMemberId != null &&
                    this.TargetImageFolderMemberId.Equals(other.TargetImageFolderMemberId)
                ) && 
                (
                    this.Invitee == other.Invitee ||
                    this.Invitee != null &&
                    this.Invitee.Equals(other.Invitee)
                ) && 
                (
                    this.Inviter == other.Inviter ||
                    this.Inviter != null &&
                    this.Inviter.Equals(other.Inviter)
                ) && 
                (
                    this.TargetTeam == other.TargetTeam ||
                    this.TargetTeam != null &&
                    this.TargetTeam.Equals(other.TargetTeam)
                ) && 
                (
                    this.TargetTeamMember == other.TargetTeamMember ||
                    this.TargetTeamMember != null &&
                    this.TargetTeamMember.Equals(other.TargetTeamMember)
                ) && 
                (
                    this.TargetPortal == other.TargetPortal ||
                    this.TargetPortal != null &&
                    this.TargetPortal.Equals(other.TargetPortal)
                ) && 
                (
                    this.TargetPortalMember == other.TargetPortalMember ||
                    this.TargetPortalMember != null &&
                    this.TargetPortalMember.Equals(other.TargetPortalMember)
                ) && 
                (
                    this.TargetTemplate == other.TargetTemplate ||
                    this.TargetTemplate != null &&
                    this.TargetTemplate.Equals(other.TargetTemplate)
                ) && 
                (
                    this.TargetTemplateMember == other.TargetTemplateMember ||
                    this.TargetTemplateMember != null &&
                    this.TargetTemplateMember.Equals(other.TargetTemplateMember)
                ) && 
                (
                    this.TargetImageFolder == other.TargetImageFolder ||
                    this.TargetImageFolder != null &&
                    this.TargetImageFolder.Equals(other.TargetImageFolder)
                ) && 
                (
                    this.TargetImageFolderMember == other.TargetImageFolderMember ||
                    this.TargetImageFolderMember != null &&
                    this.TargetImageFolderMember.Equals(other.TargetImageFolderMember)
                ) && 
                (
                    this.TargetDesign == other.TargetDesign ||
                    this.TargetDesign != null &&
                    this.TargetDesign.Equals(other.TargetDesign)
                ) && 
                (
                    this.TargetDesignMember == other.TargetDesignMember ||
                    this.TargetDesignMember != null &&
                    this.TargetDesignMember.Equals(other.TargetDesignMember)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.InviteeEmail != null)
                    hash = hash * 59 + this.InviteeEmail.GetHashCode();
                if (this.TargetModel != null)
                    hash = hash * 59 + this.TargetModel.GetHashCode();
                if (this.TargetId != null)
                    hash = hash * 59 + this.TargetId.GetHashCode();
                if (this.TargetAttrs != null)
                    hash = hash * 59 + this.TargetAttrs.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Notify != null)
                    hash = hash * 59 + this.Notify.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InviteeId != null)
                    hash = hash * 59 + this.InviteeId.GetHashCode();
                if (this.InviterId != null)
                    hash = hash * 59 + this.InviterId.GetHashCode();
                if (this.TargetTeamId != null)
                    hash = hash * 59 + this.TargetTeamId.GetHashCode();
                if (this.TargetTeamMemberId != null)
                    hash = hash * 59 + this.TargetTeamMemberId.GetHashCode();
                if (this.TargetPortalId != null)
                    hash = hash * 59 + this.TargetPortalId.GetHashCode();
                if (this.TargetPortalMemberId != null)
                    hash = hash * 59 + this.TargetPortalMemberId.GetHashCode();
                if (this.TargetTemplateId != null)
                    hash = hash * 59 + this.TargetTemplateId.GetHashCode();
                if (this.TargetDesignId != null)
                    hash = hash * 59 + this.TargetDesignId.GetHashCode();
                if (this.TargetTemplateMemberId != null)
                    hash = hash * 59 + this.TargetTemplateMemberId.GetHashCode();
                if (this.TargetDesignMemberId != null)
                    hash = hash * 59 + this.TargetDesignMemberId.GetHashCode();
                if (this.TargetImageFolderId != null)
                    hash = hash * 59 + this.TargetImageFolderId.GetHashCode();
                if (this.TargetImageFolderMemberId != null)
                    hash = hash * 59 + this.TargetImageFolderMemberId.GetHashCode();
                if (this.Invitee != null)
                    hash = hash * 59 + this.Invitee.GetHashCode();
                if (this.Inviter != null)
                    hash = hash * 59 + this.Inviter.GetHashCode();
                if (this.TargetTeam != null)
                    hash = hash * 59 + this.TargetTeam.GetHashCode();
                if (this.TargetTeamMember != null)
                    hash = hash * 59 + this.TargetTeamMember.GetHashCode();
                if (this.TargetPortal != null)
                    hash = hash * 59 + this.TargetPortal.GetHashCode();
                if (this.TargetPortalMember != null)
                    hash = hash * 59 + this.TargetPortalMember.GetHashCode();
                if (this.TargetTemplate != null)
                    hash = hash * 59 + this.TargetTemplate.GetHashCode();
                if (this.TargetTemplateMember != null)
                    hash = hash * 59 + this.TargetTemplateMember.GetHashCode();
                if (this.TargetImageFolder != null)
                    hash = hash * 59 + this.TargetImageFolder.GetHashCode();
                if (this.TargetImageFolderMember != null)
                    hash = hash * 59 + this.TargetImageFolderMember.GetHashCode();
                if (this.TargetDesign != null)
                    hash = hash * 59 + this.TargetDesign.GetHashCode();
                if (this.TargetDesignMember != null)
                    hash = hash * 59 + this.TargetDesignMember.GetHashCode();
                return hash;
            }
        }
    }

}

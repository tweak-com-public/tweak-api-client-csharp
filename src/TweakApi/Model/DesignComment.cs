/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.6
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
    /// DesignComment
    /// </summary>
    [DataContract]
    public partial class DesignComment :  IEquatable<DesignComment>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Unsolved for "unsolved"
            /// </summary>
            [EnumMember(Value = "unsolved")]
            Unsolved,
            
            /// <summary>
            /// Enum Resolved for "resolved"
            /// </summary>
            [EnumMember(Value = "resolved")]
            Resolved
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Comment for "comment"
            /// </summary>
            [EnumMember(Value = "comment")]
            Comment,
            
            /// <summary>
            /// Enum Rejection for "rejection"
            /// </summary>
            [EnumMember(Value = "rejection")]
            Rejection,
            
            /// <summary>
            /// Enum Reaction for "reaction"
            /// </summary>
            [EnumMember(Value = "reaction")]
            Reaction
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignComment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DesignComment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignComment" /> class.
        /// </summary>
        /// <param name="Comment">Comment (required).</param>
        /// <param name="Position">Position.</param>
        /// <param name="PageIndex">PageIndex (default to 0.0).</param>
        /// <param name="Status">Status.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="DesignId">DesignId.</param>
        /// <param name="CommentId">CommentId.</param>
        /// <param name="CommenterId">CommenterId.</param>
        /// <param name="Design">Design.</param>
        /// <param name="Replies">Replies.</param>
        /// <param name="Commenter">Commenter.</param>
        /// <param name="ReplyOf">ReplyOf.</param>
        public DesignComment(string Comment = null, Axes Position = null, double? PageIndex = null, StatusEnum? Status = null, TypeEnum? Type = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string DesignId = null, string CommentId = null, string CommenterId = null, Design Design = null, List<DesignComment> Replies = null, TeamMember Commenter = null, DesignComment ReplyOf = null)
        {
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for DesignComment and cannot be null");
            }
            else
            {
                this.Comment = Comment;
            }
            this.Position = Position;
            // use default value if no "PageIndex" provided
            if (PageIndex == null)
            {
                this.PageIndex = 0.0;
            }
            else
            {
                this.PageIndex = PageIndex;
            }
            this.Status = Status;
            this.Type = Type;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.DesignId = DesignId;
            this.CommentId = CommentId;
            this.CommenterId = CommenterId;
            this.Design = Design;
            this.Replies = Replies;
            this.Commenter = Commenter;
            this.ReplyOf = ReplyOf;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public Axes Position { get; set; }
        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name="pageIndex", EmitDefaultValue=false)]
        public double? PageIndex { get; set; }
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
        /// Gets or Sets DesignId
        /// </summary>
        [DataMember(Name="designId", EmitDefaultValue=false)]
        public string DesignId { get; set; }
        /// <summary>
        /// Gets or Sets CommentId
        /// </summary>
        [DataMember(Name="commentId", EmitDefaultValue=false)]
        public string CommentId { get; set; }
        /// <summary>
        /// Gets or Sets CommenterId
        /// </summary>
        [DataMember(Name="commenterId", EmitDefaultValue=false)]
        public string CommenterId { get; set; }
        /// <summary>
        /// Gets or Sets Design
        /// </summary>
        [DataMember(Name="design", EmitDefaultValue=false)]
        public Design Design { get; set; }
        /// <summary>
        /// Gets or Sets Replies
        /// </summary>
        [DataMember(Name="replies", EmitDefaultValue=false)]
        public List<DesignComment> Replies { get; set; }
        /// <summary>
        /// Gets or Sets Commenter
        /// </summary>
        [DataMember(Name="commenter", EmitDefaultValue=false)]
        public TeamMember Commenter { get; set; }
        /// <summary>
        /// Gets or Sets ReplyOf
        /// </summary>
        [DataMember(Name="replyOf", EmitDefaultValue=false)]
        public DesignComment ReplyOf { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignComment {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DesignId: ").Append(DesignId).Append("\n");
            sb.Append("  CommentId: ").Append(CommentId).Append("\n");
            sb.Append("  CommenterId: ").Append(CommenterId).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
            sb.Append("  Replies: ").Append(Replies).Append("\n");
            sb.Append("  Commenter: ").Append(Commenter).Append("\n");
            sb.Append("  ReplyOf: ").Append(ReplyOf).Append("\n");
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
            return this.Equals(obj as DesignComment);
        }

        /// <summary>
        /// Returns true if DesignComment instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignComment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Position == other.Position ||
                    this.Position != null &&
                    this.Position.Equals(other.Position)
                ) && 
                (
                    this.PageIndex == other.PageIndex ||
                    this.PageIndex != null &&
                    this.PageIndex.Equals(other.PageIndex)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                    this.DesignId == other.DesignId ||
                    this.DesignId != null &&
                    this.DesignId.Equals(other.DesignId)
                ) && 
                (
                    this.CommentId == other.CommentId ||
                    this.CommentId != null &&
                    this.CommentId.Equals(other.CommentId)
                ) && 
                (
                    this.CommenterId == other.CommenterId ||
                    this.CommenterId != null &&
                    this.CommenterId.Equals(other.CommenterId)
                ) && 
                (
                    this.Design == other.Design ||
                    this.Design != null &&
                    this.Design.Equals(other.Design)
                ) && 
                (
                    this.Replies == other.Replies ||
                    this.Replies != null &&
                    this.Replies.SequenceEqual(other.Replies)
                ) && 
                (
                    this.Commenter == other.Commenter ||
                    this.Commenter != null &&
                    this.Commenter.Equals(other.Commenter)
                ) && 
                (
                    this.ReplyOf == other.ReplyOf ||
                    this.ReplyOf != null &&
                    this.ReplyOf.Equals(other.ReplyOf)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Position != null)
                    hash = hash * 59 + this.Position.GetHashCode();
                if (this.PageIndex != null)
                    hash = hash * 59 + this.PageIndex.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DesignId != null)
                    hash = hash * 59 + this.DesignId.GetHashCode();
                if (this.CommentId != null)
                    hash = hash * 59 + this.CommentId.GetHashCode();
                if (this.CommenterId != null)
                    hash = hash * 59 + this.CommenterId.GetHashCode();
                if (this.Design != null)
                    hash = hash * 59 + this.Design.GetHashCode();
                if (this.Replies != null)
                    hash = hash * 59 + this.Replies.GetHashCode();
                if (this.Commenter != null)
                    hash = hash * 59 + this.Commenter.GetHashCode();
                if (this.ReplyOf != null)
                    hash = hash * 59 + this.ReplyOf.GetHashCode();
                return hash;
            }
        }
    }

}

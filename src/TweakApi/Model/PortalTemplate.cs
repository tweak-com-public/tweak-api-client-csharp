/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.12
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
    /// PortalTemplate
    /// </summary>
    [DataContract]
    public partial class PortalTemplate :  IEquatable<PortalTemplate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortalTemplate" /> class.
        /// </summary>
        /// <param name="Path">Path (default to &quot;/&quot;).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="FolderId">FolderId.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="Template">Template.</param>
        /// <param name="Folder">Folder.</param>
        public PortalTemplate(string Path = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string PortalId = null, string TemplateId = null, string FolderId = null, Portal Portal = null, Template Template = null, PortalTemplateFolder Folder = null)
        {
            // use default value if no "Path" provided
            if (Path == null)
            {
                this.Path = "/";
            }
            else
            {
                this.Path = Path;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.PortalId = PortalId;
            this.TemplateId = TemplateId;
            this.FolderId = FolderId;
            this.Portal = Portal;
            this.Template = Template;
            this.Folder = Folder;
        }
        
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
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
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public Template Template { get; set; }
        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public PortalTemplateFolder Folder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortalTemplate {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
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
            return this.Equals(obj as PortalTemplate);
        }

        /// <summary>
        /// Returns true if PortalTemplate instances are equal
        /// </summary>
        /// <param name="other">Instance of PortalTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortalTemplate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
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
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                return hash;
            }
        }
    }

}

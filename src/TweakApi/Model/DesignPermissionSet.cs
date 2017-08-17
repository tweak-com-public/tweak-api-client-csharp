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
    /// DesignPermissionSet
    /// </summary>
    [DataContract]
    public partial class DesignPermissionSet :  IEquatable<DesignPermissionSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesignPermissionSet" /> class.
        /// </summary>
        /// <param name="HighResPdf">HighResPdf (default to false).</param>
        /// <param name="ProofPdf">ProofPdf (default to false).</param>
        /// <param name="Jpegs">Jpegs (default to false).</param>
        /// <param name="SocialSharing">SocialSharing (default to false).</param>
        /// <param name="CanEdit">CanEdit (default to false).</param>
        /// <param name="NeedAdminApproval">NeedAdminApproval (default to false).</param>
        /// <param name="Id">Id.</param>
        /// <param name="DesignId">DesignId.</param>
        /// <param name="Design">Design.</param>
        public DesignPermissionSet(bool? HighResPdf = null, bool? ProofPdf = null, bool? Jpegs = null, bool? SocialSharing = null, bool? CanEdit = null, bool? NeedAdminApproval = null, string Id = null, string DesignId = null, Design Design = null)
        {
            // use default value if no "HighResPdf" provided
            if (HighResPdf == null)
            {
                this.HighResPdf = false;
            }
            else
            {
                this.HighResPdf = HighResPdf;
            }
            // use default value if no "ProofPdf" provided
            if (ProofPdf == null)
            {
                this.ProofPdf = false;
            }
            else
            {
                this.ProofPdf = ProofPdf;
            }
            // use default value if no "Jpegs" provided
            if (Jpegs == null)
            {
                this.Jpegs = false;
            }
            else
            {
                this.Jpegs = Jpegs;
            }
            // use default value if no "SocialSharing" provided
            if (SocialSharing == null)
            {
                this.SocialSharing = false;
            }
            else
            {
                this.SocialSharing = SocialSharing;
            }
            // use default value if no "CanEdit" provided
            if (CanEdit == null)
            {
                this.CanEdit = false;
            }
            else
            {
                this.CanEdit = CanEdit;
            }
            // use default value if no "NeedAdminApproval" provided
            if (NeedAdminApproval == null)
            {
                this.NeedAdminApproval = false;
            }
            else
            {
                this.NeedAdminApproval = NeedAdminApproval;
            }
            this.Id = Id;
            this.DesignId = DesignId;
            this.Design = Design;
        }
        
        /// <summary>
        /// Gets or Sets HighResPdf
        /// </summary>
        [DataMember(Name="highResPdf", EmitDefaultValue=false)]
        public bool? HighResPdf { get; set; }
        /// <summary>
        /// Gets or Sets ProofPdf
        /// </summary>
        [DataMember(Name="proofPdf", EmitDefaultValue=false)]
        public bool? ProofPdf { get; set; }
        /// <summary>
        /// Gets or Sets Jpegs
        /// </summary>
        [DataMember(Name="jpegs", EmitDefaultValue=false)]
        public bool? Jpegs { get; set; }
        /// <summary>
        /// Gets or Sets SocialSharing
        /// </summary>
        [DataMember(Name="socialSharing", EmitDefaultValue=false)]
        public bool? SocialSharing { get; set; }
        /// <summary>
        /// Gets or Sets CanEdit
        /// </summary>
        [DataMember(Name="canEdit", EmitDefaultValue=false)]
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Gets or Sets NeedAdminApproval
        /// </summary>
        [DataMember(Name="needAdminApproval", EmitDefaultValue=false)]
        public bool? NeedAdminApproval { get; set; }
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
        /// Gets or Sets Design
        /// </summary>
        [DataMember(Name="design", EmitDefaultValue=false)]
        public Design Design { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesignPermissionSet {\n");
            sb.Append("  HighResPdf: ").Append(HighResPdf).Append("\n");
            sb.Append("  ProofPdf: ").Append(ProofPdf).Append("\n");
            sb.Append("  Jpegs: ").Append(Jpegs).Append("\n");
            sb.Append("  SocialSharing: ").Append(SocialSharing).Append("\n");
            sb.Append("  CanEdit: ").Append(CanEdit).Append("\n");
            sb.Append("  NeedAdminApproval: ").Append(NeedAdminApproval).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DesignId: ").Append(DesignId).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
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
            return this.Equals(obj as DesignPermissionSet);
        }

        /// <summary>
        /// Returns true if DesignPermissionSet instances are equal
        /// </summary>
        /// <param name="other">Instance of DesignPermissionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesignPermissionSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HighResPdf == other.HighResPdf ||
                    this.HighResPdf != null &&
                    this.HighResPdf.Equals(other.HighResPdf)
                ) && 
                (
                    this.ProofPdf == other.ProofPdf ||
                    this.ProofPdf != null &&
                    this.ProofPdf.Equals(other.ProofPdf)
                ) && 
                (
                    this.Jpegs == other.Jpegs ||
                    this.Jpegs != null &&
                    this.Jpegs.Equals(other.Jpegs)
                ) && 
                (
                    this.SocialSharing == other.SocialSharing ||
                    this.SocialSharing != null &&
                    this.SocialSharing.Equals(other.SocialSharing)
                ) && 
                (
                    this.CanEdit == other.CanEdit ||
                    this.CanEdit != null &&
                    this.CanEdit.Equals(other.CanEdit)
                ) && 
                (
                    this.NeedAdminApproval == other.NeedAdminApproval ||
                    this.NeedAdminApproval != null &&
                    this.NeedAdminApproval.Equals(other.NeedAdminApproval)
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
                    this.Design == other.Design ||
                    this.Design != null &&
                    this.Design.Equals(other.Design)
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
                if (this.HighResPdf != null)
                    hash = hash * 59 + this.HighResPdf.GetHashCode();
                if (this.ProofPdf != null)
                    hash = hash * 59 + this.ProofPdf.GetHashCode();
                if (this.Jpegs != null)
                    hash = hash * 59 + this.Jpegs.GetHashCode();
                if (this.SocialSharing != null)
                    hash = hash * 59 + this.SocialSharing.GetHashCode();
                if (this.CanEdit != null)
                    hash = hash * 59 + this.CanEdit.GetHashCode();
                if (this.NeedAdminApproval != null)
                    hash = hash * 59 + this.NeedAdminApproval.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.DesignId != null)
                    hash = hash * 59 + this.DesignId.GetHashCode();
                if (this.Design != null)
                    hash = hash * 59 + this.Design.GetHashCode();
                return hash;
            }
        }
    }

}
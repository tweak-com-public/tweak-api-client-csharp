/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.14
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
    /// DynamicData
    /// </summary>
    [DataContract]
    public partial class DynamicData :  IEquatable<DynamicData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicData" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="PropertiesOrder">PropertiesOrder.</param>
        /// <param name="Properties">Properties.</param>
        /// <param name="Relations">Relations.</param>
        /// <param name="Validations">Validations.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="RecordCount">RecordCount (default to 0.0).</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Designs">Designs.</param>
        public DynamicData(string Name = null, List<string> PropertiesOrder = null, Object Properties = null, Object Relations = null, Object Validations = null, DateTime? Created = null, DateTime? Modified = null, double? RecordCount = null, string Id = null, string TeamId = null, Team Team = null, List<Design> Designs = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DynamicData and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.PropertiesOrder = PropertiesOrder;
            this.Properties = Properties;
            this.Relations = Relations;
            this.Validations = Validations;
            this.Created = Created;
            this.Modified = Modified;
            // use default value if no "RecordCount" provided
            if (RecordCount == null)
            {
                this.RecordCount = 0.0;
            }
            else
            {
                this.RecordCount = RecordCount;
            }
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
            this.Designs = Designs;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PropertiesOrder
        /// </summary>
        [DataMember(Name="propertiesOrder", EmitDefaultValue=false)]
        public List<string> PropertiesOrder { get; set; }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public Object Properties { get; set; }
        /// <summary>
        /// Gets or Sets Relations
        /// </summary>
        [DataMember(Name="relations", EmitDefaultValue=false)]
        public Object Relations { get; set; }
        /// <summary>
        /// Gets or Sets Validations
        /// </summary>
        [DataMember(Name="validations", EmitDefaultValue=false)]
        public Object Validations { get; set; }
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
        /// Gets or Sets RecordCount
        /// </summary>
        [DataMember(Name="recordCount", EmitDefaultValue=false)]
        public double? RecordCount { get; set; }
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
        /// Gets or Sets Designs
        /// </summary>
        [DataMember(Name="designs", EmitDefaultValue=false)]
        public List<Design> Designs { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertiesOrder: ").Append(PropertiesOrder).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Validations: ").Append(Validations).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Designs: ").Append(Designs).Append("\n");
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
            return this.Equals(obj as DynamicData);
        }

        /// <summary>
        /// Returns true if DynamicData instances are equal
        /// </summary>
        /// <param name="other">Instance of DynamicData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicData other)
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
                    this.PropertiesOrder == other.PropertiesOrder ||
                    this.PropertiesOrder != null &&
                    this.PropertiesOrder.SequenceEqual(other.PropertiesOrder)
                ) && 
                (
                    this.Properties == other.Properties ||
                    this.Properties != null &&
                    this.Properties.Equals(other.Properties)
                ) && 
                (
                    this.Relations == other.Relations ||
                    this.Relations != null &&
                    this.Relations.Equals(other.Relations)
                ) && 
                (
                    this.Validations == other.Validations ||
                    this.Validations != null &&
                    this.Validations.Equals(other.Validations)
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
                    this.RecordCount == other.RecordCount ||
                    this.RecordCount != null &&
                    this.RecordCount.Equals(other.RecordCount)
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
                ) && 
                (
                    this.Designs == other.Designs ||
                    this.Designs != null &&
                    this.Designs.SequenceEqual(other.Designs)
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
                if (this.PropertiesOrder != null)
                    hash = hash * 59 + this.PropertiesOrder.GetHashCode();
                if (this.Properties != null)
                    hash = hash * 59 + this.Properties.GetHashCode();
                if (this.Relations != null)
                    hash = hash * 59 + this.Relations.GetHashCode();
                if (this.Validations != null)
                    hash = hash * 59 + this.Validations.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.RecordCount != null)
                    hash = hash * 59 + this.RecordCount.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.Designs != null)
                    hash = hash * 59 + this.Designs.GetHashCode();
                return hash;
            }
        }
    }

}

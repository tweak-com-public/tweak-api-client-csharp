/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.6-alpha.2
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
    /// DataSource
    /// </summary>
    [DataContract]
    public partial class DataSource :  IEquatable<DataSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSource" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="Keys">Keys.</param>
        public DataSource(string Name = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string TeamId = null, Team Team = null, List<DataSourceKey> Keys = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DataSource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
            this.Keys = Keys;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
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
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets Keys
        /// </summary>
        [DataMember(Name="keys", EmitDefaultValue=false)]
        public List<DataSourceKey> Keys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSource {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Keys: ").Append(Keys).Append("\n");
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
            return this.Equals(obj as DataSource);
        }

        /// <summary>
        /// Returns true if DataSource instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSource other)
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
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.Keys == other.Keys ||
                    this.Keys != null &&
                    this.Keys.SequenceEqual(other.Keys)
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
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.Keys != null)
                    hash = hash * 59 + this.Keys.GetHashCode();
                return hash;
            }
        }
    }

}

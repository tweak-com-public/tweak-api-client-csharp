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
    /// DataSourceRecord
    /// </summary>
    [DataContract]
    public partial class DataSourceRecord :  IEquatable<DataSourceRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSourceRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceRecord" /> class.
        /// </summary>
        /// <param name="Line">Line (required).</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="DataSourceId">DataSourceId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="DataSource">DataSource.</param>
        /// <param name="Values">Values.</param>
        public DataSourceRecord(double? Line = null, string Id = null, string TeamId = null, string DataSourceId = null, Team Team = null, DataSource DataSource = null, List<DataSourceRecordValue> Values = null)
        {
            // to ensure "Line" is required (not null)
            if (Line == null)
            {
                throw new InvalidDataException("Line is a required property for DataSourceRecord and cannot be null");
            }
            else
            {
                this.Line = Line;
            }
            this.Id = Id;
            this.TeamId = TeamId;
            this.DataSourceId = DataSourceId;
            this.Team = Team;
            this.DataSource = DataSource;
            this.Values = Values;
        }
        
        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public double? Line { get; set; }
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
        /// Gets or Sets DataSourceId
        /// </summary>
        [DataMember(Name="dataSourceId", EmitDefaultValue=false)]
        public string DataSourceId { get; set; }
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public Team Team { get; set; }
        /// <summary>
        /// Gets or Sets DataSource
        /// </summary>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public DataSource DataSource { get; set; }
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<DataSourceRecordValue> Values { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSourceRecord {\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as DataSourceRecord);
        }

        /// <summary>
        /// Returns true if DataSourceRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSourceRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Line == other.Line ||
                    this.Line != null &&
                    this.Line.Equals(other.Line)
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
                    this.DataSourceId == other.DataSourceId ||
                    this.DataSourceId != null &&
                    this.DataSourceId.Equals(other.DataSourceId)
                ) && 
                (
                    this.Team == other.Team ||
                    this.Team != null &&
                    this.Team.Equals(other.Team)
                ) && 
                (
                    this.DataSource == other.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.Equals(other.DataSource)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Line != null)
                    hash = hash * 59 + this.Line.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.DataSourceId != null)
                    hash = hash * 59 + this.DataSourceId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.DataSource != null)
                    hash = hash * 59 + this.DataSource.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                return hash;
            }
        }
    }

}
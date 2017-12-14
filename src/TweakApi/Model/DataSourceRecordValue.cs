/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3
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
    /// DataSourceRecordValue
    /// </summary>
    [DataContract]
    public partial class DataSourceRecordValue :  IEquatable<DataSourceRecordValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceRecordValue" /> class.
        /// </summary>
        /// <param name="Value">Value.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="DataSourceId">DataSourceId.</param>
        /// <param name="RecordId">RecordId.</param>
        /// <param name="KeyId">KeyId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="DataSource">DataSource.</param>
        /// <param name="Values">Values.</param>
        /// <param name="Key">Key.</param>
        public DataSourceRecordValue(string Value = null, string Id = null, string TeamId = null, string DataSourceId = null, string RecordId = null, string KeyId = null, Team Team = null, DataSource DataSource = null, DataSourceRecord Values = null, DataSourceKey Key = null)
        {
            this.Value = Value;
            this.Id = Id;
            this.TeamId = TeamId;
            this.DataSourceId = DataSourceId;
            this.RecordId = RecordId;
            this.KeyId = KeyId;
            this.Team = Team;
            this.DataSource = DataSource;
            this.Values = Values;
            this.Key = Key;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
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
        /// Gets or Sets RecordId
        /// </summary>
        [DataMember(Name="recordId", EmitDefaultValue=false)]
        public string RecordId { get; set; }
        /// <summary>
        /// Gets or Sets KeyId
        /// </summary>
        [DataMember(Name="keyId", EmitDefaultValue=false)]
        public string KeyId { get; set; }
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
        public DataSourceRecord Values { get; set; }
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public DataSourceKey Key { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSourceRecordValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  RecordId: ").Append(RecordId).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(obj as DataSourceRecordValue);
        }

        /// <summary>
        /// Returns true if DataSourceRecordValue instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSourceRecordValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceRecordValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                    this.RecordId == other.RecordId ||
                    this.RecordId != null &&
                    this.RecordId.Equals(other.RecordId)
                ) && 
                (
                    this.KeyId == other.KeyId ||
                    this.KeyId != null &&
                    this.KeyId.Equals(other.KeyId)
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
                    this.Values.Equals(other.Values)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
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
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.DataSourceId != null)
                    hash = hash * 59 + this.DataSourceId.GetHashCode();
                if (this.RecordId != null)
                    hash = hash * 59 + this.RecordId.GetHashCode();
                if (this.KeyId != null)
                    hash = hash * 59 + this.KeyId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.DataSource != null)
                    hash = hash * 59 + this.DataSource.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                return hash;
            }
        }
    }

}

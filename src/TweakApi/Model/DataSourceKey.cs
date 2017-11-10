/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.13
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
    /// DataSourceKey
    /// </summary>
    [DataContract]
    public partial class DataSourceKey :  IEquatable<DataSourceKey>
    {
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            
            /// <summary>
            /// Enum String for "string"
            /// </summary>
            [EnumMember(Value = "string")]
            String,
            
            /// <summary>
            /// Enum Boolean for "boolean"
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean,
            
            /// <summary>
            /// Enum Number for "number"
            /// </summary>
            [EnumMember(Value = "number")]
            Number,
            
            /// <summary>
            /// Enum Date for "date"
            /// </summary>
            [EnumMember(Value = "date")]
            Date
        }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSourceKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceKey" /> class.
        /// </summary>
        /// <param name="Label">Label (required).</param>
        /// <param name="Column">Column (required).</param>
        /// <param name="ValueDefault">ValueDefault.</param>
        /// <param name="PrimaryKey">PrimaryKey (default to false).</param>
        /// <param name="ValueRequired">ValueRequired (default to false).</param>
        /// <param name="ValueMin">ValueMin (default to 0.0).</param>
        /// <param name="ValueMax">ValueMax (default to 0.0).</param>
        /// <param name="ValueType">ValueType.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="DataSourceId">DataSourceId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="DataSource">DataSource.</param>
        /// <param name="RecordValues">RecordValues.</param>
        public DataSourceKey(string Label = null, double? Column = null, string ValueDefault = null, bool? PrimaryKey = null, bool? ValueRequired = null, double? ValueMin = null, double? ValueMax = null, ValueTypeEnum? ValueType = null, string Id = null, string TeamId = null, string DataSourceId = null, Team Team = null, DataSource DataSource = null, List<DataSourceRecordValue> RecordValues = null)
        {
            // to ensure "Label" is required (not null)
            if (Label == null)
            {
                throw new InvalidDataException("Label is a required property for DataSourceKey and cannot be null");
            }
            else
            {
                this.Label = Label;
            }
            // to ensure "Column" is required (not null)
            if (Column == null)
            {
                throw new InvalidDataException("Column is a required property for DataSourceKey and cannot be null");
            }
            else
            {
                this.Column = Column;
            }
            this.ValueDefault = ValueDefault;
            // use default value if no "PrimaryKey" provided
            if (PrimaryKey == null)
            {
                this.PrimaryKey = false;
            }
            else
            {
                this.PrimaryKey = PrimaryKey;
            }
            // use default value if no "ValueRequired" provided
            if (ValueRequired == null)
            {
                this.ValueRequired = false;
            }
            else
            {
                this.ValueRequired = ValueRequired;
            }
            // use default value if no "ValueMin" provided
            if (ValueMin == null)
            {
                this.ValueMin = 0.0;
            }
            else
            {
                this.ValueMin = ValueMin;
            }
            // use default value if no "ValueMax" provided
            if (ValueMax == null)
            {
                this.ValueMax = 0.0;
            }
            else
            {
                this.ValueMax = ValueMax;
            }
            this.ValueType = ValueType;
            this.Id = Id;
            this.TeamId = TeamId;
            this.DataSourceId = DataSourceId;
            this.Team = Team;
            this.DataSource = DataSource;
            this.RecordValues = RecordValues;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// Gets or Sets Column
        /// </summary>
        [DataMember(Name="column", EmitDefaultValue=false)]
        public double? Column { get; set; }
        /// <summary>
        /// Gets or Sets ValueDefault
        /// </summary>
        [DataMember(Name="valueDefault", EmitDefaultValue=false)]
        public string ValueDefault { get; set; }
        /// <summary>
        /// Gets or Sets PrimaryKey
        /// </summary>
        [DataMember(Name="primaryKey", EmitDefaultValue=false)]
        public bool? PrimaryKey { get; set; }
        /// <summary>
        /// Gets or Sets ValueRequired
        /// </summary>
        [DataMember(Name="valueRequired", EmitDefaultValue=false)]
        public bool? ValueRequired { get; set; }
        /// <summary>
        /// Gets or Sets ValueMin
        /// </summary>
        [DataMember(Name="valueMin", EmitDefaultValue=false)]
        public double? ValueMin { get; set; }
        /// <summary>
        /// Gets or Sets ValueMax
        /// </summary>
        [DataMember(Name="valueMax", EmitDefaultValue=false)]
        public double? ValueMax { get; set; }
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
        /// Gets or Sets RecordValues
        /// </summary>
        [DataMember(Name="recordValues", EmitDefaultValue=false)]
        public List<DataSourceRecordValue> RecordValues { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSourceKey {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
            sb.Append("  ValueDefault: ").Append(ValueDefault).Append("\n");
            sb.Append("  PrimaryKey: ").Append(PrimaryKey).Append("\n");
            sb.Append("  ValueRequired: ").Append(ValueRequired).Append("\n");
            sb.Append("  ValueMin: ").Append(ValueMin).Append("\n");
            sb.Append("  ValueMax: ").Append(ValueMax).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  RecordValues: ").Append(RecordValues).Append("\n");
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
            return this.Equals(obj as DataSourceKey);
        }

        /// <summary>
        /// Returns true if DataSourceKey instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSourceKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceKey other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Column == other.Column ||
                    this.Column != null &&
                    this.Column.Equals(other.Column)
                ) && 
                (
                    this.ValueDefault == other.ValueDefault ||
                    this.ValueDefault != null &&
                    this.ValueDefault.Equals(other.ValueDefault)
                ) && 
                (
                    this.PrimaryKey == other.PrimaryKey ||
                    this.PrimaryKey != null &&
                    this.PrimaryKey.Equals(other.PrimaryKey)
                ) && 
                (
                    this.ValueRequired == other.ValueRequired ||
                    this.ValueRequired != null &&
                    this.ValueRequired.Equals(other.ValueRequired)
                ) && 
                (
                    this.ValueMin == other.ValueMin ||
                    this.ValueMin != null &&
                    this.ValueMin.Equals(other.ValueMin)
                ) && 
                (
                    this.ValueMax == other.ValueMax ||
                    this.ValueMax != null &&
                    this.ValueMax.Equals(other.ValueMax)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
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
                    this.RecordValues == other.RecordValues ||
                    this.RecordValues != null &&
                    this.RecordValues.SequenceEqual(other.RecordValues)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Column != null)
                    hash = hash * 59 + this.Column.GetHashCode();
                if (this.ValueDefault != null)
                    hash = hash * 59 + this.ValueDefault.GetHashCode();
                if (this.PrimaryKey != null)
                    hash = hash * 59 + this.PrimaryKey.GetHashCode();
                if (this.ValueRequired != null)
                    hash = hash * 59 + this.ValueRequired.GetHashCode();
                if (this.ValueMin != null)
                    hash = hash * 59 + this.ValueMin.GetHashCode();
                if (this.ValueMax != null)
                    hash = hash * 59 + this.ValueMax.GetHashCode();
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
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
                if (this.RecordValues != null)
                    hash = hash * 59 + this.RecordValues.GetHashCode();
                return hash;
            }
        }
    }

}

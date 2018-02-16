/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.10
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
    /// DataSourceSoap
    /// </summary>
    [DataContract]
    public partial class DataSourceSoap :  IEquatable<DataSourceSoap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceSoap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DataSourceSoap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceSoap" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Url">Url (required).</param>
        /// <param name="Wsdl">Wsdl (required).</param>
        /// <param name="WsdlOptions">WsdlOptions.</param>
        /// <param name="Security">Security.</param>
        /// <param name="SoapHeaders">SoapHeaders.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="DynamicDatas">DynamicDatas.</param>
        public DataSourceSoap(string Name = null, string Url = null, string Wsdl = null, Object WsdlOptions = null, Object Security = null, List<Object> SoapHeaders = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string TeamId = null, Team Team = null, List<DynamicData> DynamicDatas = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DataSourceSoap and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Url" is required (not null)
            if (Url == null)
            {
                throw new InvalidDataException("Url is a required property for DataSourceSoap and cannot be null");
            }
            else
            {
                this.Url = Url;
            }
            // to ensure "Wsdl" is required (not null)
            if (Wsdl == null)
            {
                throw new InvalidDataException("Wsdl is a required property for DataSourceSoap and cannot be null");
            }
            else
            {
                this.Wsdl = Wsdl;
            }
            this.WsdlOptions = WsdlOptions;
            this.Security = Security;
            this.SoapHeaders = SoapHeaders;
            this.Created = Created;
            this.Modified = Modified;
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
            this.DynamicDatas = DynamicDatas;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets Wsdl
        /// </summary>
        [DataMember(Name="wsdl", EmitDefaultValue=false)]
        public string Wsdl { get; set; }
        /// <summary>
        /// Gets or Sets WsdlOptions
        /// </summary>
        [DataMember(Name="wsdl_options", EmitDefaultValue=false)]
        public Object WsdlOptions { get; set; }
        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name="security", EmitDefaultValue=false)]
        public Object Security { get; set; }
        /// <summary>
        /// Gets or Sets SoapHeaders
        /// </summary>
        [DataMember(Name="soapHeaders", EmitDefaultValue=false)]
        public List<Object> SoapHeaders { get; set; }
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
        /// Gets or Sets DynamicDatas
        /// </summary>
        [DataMember(Name="dynamicDatas", EmitDefaultValue=false)]
        public List<DynamicData> DynamicDatas { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataSourceSoap {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Wsdl: ").Append(Wsdl).Append("\n");
            sb.Append("  WsdlOptions: ").Append(WsdlOptions).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  SoapHeaders: ").Append(SoapHeaders).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  DynamicDatas: ").Append(DynamicDatas).Append("\n");
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
            return this.Equals(obj as DataSourceSoap);
        }

        /// <summary>
        /// Returns true if DataSourceSoap instances are equal
        /// </summary>
        /// <param name="other">Instance of DataSourceSoap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSourceSoap other)
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
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Wsdl == other.Wsdl ||
                    this.Wsdl != null &&
                    this.Wsdl.Equals(other.Wsdl)
                ) && 
                (
                    this.WsdlOptions == other.WsdlOptions ||
                    this.WsdlOptions != null &&
                    this.WsdlOptions.Equals(other.WsdlOptions)
                ) && 
                (
                    this.Security == other.Security ||
                    this.Security != null &&
                    this.Security.Equals(other.Security)
                ) && 
                (
                    this.SoapHeaders == other.SoapHeaders ||
                    this.SoapHeaders != null &&
                    this.SoapHeaders.SequenceEqual(other.SoapHeaders)
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
                    this.DynamicDatas == other.DynamicDatas ||
                    this.DynamicDatas != null &&
                    this.DynamicDatas.SequenceEqual(other.DynamicDatas)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Wsdl != null)
                    hash = hash * 59 + this.Wsdl.GetHashCode();
                if (this.WsdlOptions != null)
                    hash = hash * 59 + this.WsdlOptions.GetHashCode();
                if (this.Security != null)
                    hash = hash * 59 + this.Security.GetHashCode();
                if (this.SoapHeaders != null)
                    hash = hash * 59 + this.SoapHeaders.GetHashCode();
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
                if (this.DynamicDatas != null)
                    hash = hash * 59 + this.DynamicDatas.GetHashCode();
                return hash;
            }
        }
    }

}

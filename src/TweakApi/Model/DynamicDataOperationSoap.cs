/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-beta.0
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
    /// DynamicDataOperationSoap
    /// </summary>
    [DataContract]
    public partial class DynamicDataOperationSoap :  IEquatable<DynamicDataOperationSoap>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDataOperationSoap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicDataOperationSoap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicDataOperationSoap" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="_Params">_Params.</param>
        /// <param name="Root">Root.</param>
        /// <param name="ParseRootXml">ParseRootXml (default to false).</param>
        /// <param name="Map">Map.</param>
        /// <param name="Id">Id.</param>
        public DynamicDataOperationSoap(string Name = null, Object _Params = null, XAny Root = null, bool? ParseRootXml = null, XAny Map = null, string Id = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for DynamicDataOperationSoap and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this._Params = _Params;
            this.Root = Root;
            // use default value if no "ParseRootXml" provided
            if (ParseRootXml == null)
            {
                this.ParseRootXml = false;
            }
            else
            {
                this.ParseRootXml = ParseRootXml;
            }
            this.Map = Map;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets _Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object _Params { get; set; }
        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name="root", EmitDefaultValue=false)]
        public XAny Root { get; set; }
        /// <summary>
        /// Gets or Sets ParseRootXml
        /// </summary>
        [DataMember(Name="parseRootXml", EmitDefaultValue=false)]
        public bool? ParseRootXml { get; set; }
        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [DataMember(Name="map", EmitDefaultValue=false)]
        public XAny Map { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DynamicDataOperationSoap {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
            sb.Append("  ParseRootXml: ").Append(ParseRootXml).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as DynamicDataOperationSoap);
        }

        /// <summary>
        /// Returns true if DynamicDataOperationSoap instances are equal
        /// </summary>
        /// <param name="other">Instance of DynamicDataOperationSoap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicDataOperationSoap other)
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
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.Equals(other._Params)
                ) && 
                (
                    this.Root == other.Root ||
                    this.Root != null &&
                    this.Root.Equals(other.Root)
                ) && 
                (
                    this.ParseRootXml == other.ParseRootXml ||
                    this.ParseRootXml != null &&
                    this.ParseRootXml.Equals(other.ParseRootXml)
                ) && 
                (
                    this.Map == other.Map ||
                    this.Map != null &&
                    this.Map.Equals(other.Map)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                if (this.Root != null)
                    hash = hash * 59 + this.Root.GetHashCode();
                if (this.ParseRootXml != null)
                    hash = hash * 59 + this.ParseRootXml.GetHashCode();
                if (this.Map != null)
                    hash = hash * 59 + this.Map.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}
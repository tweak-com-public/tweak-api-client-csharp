/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.4
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
    /// Bounds
    /// </summary>
    [DataContract]
    public partial class Bounds :  IEquatable<Bounds>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bounds" /> class.
        /// </summary>
        /// <param name="Top">Top (default to 0.0).</param>
        /// <param name="Bottom">Bottom (default to 0.0).</param>
        /// <param name="Left">Left (default to 0.0).</param>
        /// <param name="Right">Right (default to 0.0).</param>
        /// <param name="Id">Id.</param>
        public Bounds(double? Top = null, double? Bottom = null, double? Left = null, double? Right = null, string Id = null)
        {
            // use default value if no "Top" provided
            if (Top == null)
            {
                this.Top = 0.0;
            }
            else
            {
                this.Top = Top;
            }
            // use default value if no "Bottom" provided
            if (Bottom == null)
            {
                this.Bottom = 0.0;
            }
            else
            {
                this.Bottom = Bottom;
            }
            // use default value if no "Left" provided
            if (Left == null)
            {
                this.Left = 0.0;
            }
            else
            {
                this.Left = Left;
            }
            // use default value if no "Right" provided
            if (Right == null)
            {
                this.Right = 0.0;
            }
            else
            {
                this.Right = Right;
            }
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Top
        /// </summary>
        [DataMember(Name="top", EmitDefaultValue=false)]
        public double? Top { get; set; }
        /// <summary>
        /// Gets or Sets Bottom
        /// </summary>
        [DataMember(Name="bottom", EmitDefaultValue=false)]
        public double? Bottom { get; set; }
        /// <summary>
        /// Gets or Sets Left
        /// </summary>
        [DataMember(Name="left", EmitDefaultValue=false)]
        public double? Left { get; set; }
        /// <summary>
        /// Gets or Sets Right
        /// </summary>
        [DataMember(Name="right", EmitDefaultValue=false)]
        public double? Right { get; set; }
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
            sb.Append("class Bounds {\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
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
            return this.Equals(obj as Bounds);
        }

        /// <summary>
        /// Returns true if Bounds instances are equal
        /// </summary>
        /// <param name="other">Instance of Bounds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bounds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Top == other.Top ||
                    this.Top != null &&
                    this.Top.Equals(other.Top)
                ) && 
                (
                    this.Bottom == other.Bottom ||
                    this.Bottom != null &&
                    this.Bottom.Equals(other.Bottom)
                ) && 
                (
                    this.Left == other.Left ||
                    this.Left != null &&
                    this.Left.Equals(other.Left)
                ) && 
                (
                    this.Right == other.Right ||
                    this.Right != null &&
                    this.Right.Equals(other.Right)
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
                if (this.Top != null)
                    hash = hash * 59 + this.Top.GetHashCode();
                if (this.Bottom != null)
                    hash = hash * 59 + this.Bottom.GetHashCode();
                if (this.Left != null)
                    hash = hash * 59 + this.Left.GetHashCode();
                if (this.Right != null)
                    hash = hash * 59 + this.Right.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

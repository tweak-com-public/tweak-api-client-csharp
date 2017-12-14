/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.5
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
    /// Team
    /// </summary>
    [DataContract]
    public partial class Team :  IEquatable<Team>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Team() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Team" /> class.
        /// </summary>
        /// <param name="Name">Name (required).</param>
        /// <param name="Logo">Logo.</param>
        /// <param name="Subdomain">Subdomain.</param>
        /// <param name="Country">Country (default to &quot;Ireland&quot;).</param>
        /// <param name="Created">Created.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="Id">Id (required).</param>
        /// <param name="Icon">The icon image url.</param>
        /// <param name="ClientKey">ClientKey.</param>
        /// <param name="JavaScriptKey">JavaScriptKey.</param>
        /// <param name="RestApiKey">RestApiKey.</param>
        /// <param name="WindowsKey">WindowsKey.</param>
        /// <param name="MasterKey">MasterKey.</param>
        /// <param name="Status">Status of the application, production/sandbox/disabled (default to &quot;sandbox&quot;).</param>
        /// <param name="TeamDataId">TeamDataId.</param>
        /// <param name="Members">Members.</param>
        /// <param name="BuilderConfigs">BuilderConfigs.</param>
        /// <param name="DataSources">DataSources.</param>
        /// <param name="DynamicDatas">DynamicDatas.</param>
        /// <param name="TeamMembers">TeamMembers.</param>
        /// <param name="Portals">Portals.</param>
        /// <param name="Templates">Templates.</param>
        /// <param name="Brand">Brand.</param>
        /// <param name="TemplateFolders">TemplateFolders.</param>
        /// <param name="Workflows">Workflows.</param>
        /// <param name="Images">Images.</param>
        /// <param name="ImageFolders">ImageFolders.</param>
        /// <param name="Billing">Billing.</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="ProductMaterials">ProductMaterials.</param>
        /// <param name="ProductSizeMaterials">ProductSizeMaterials.</param>
        /// <param name="ProductPdfColorProfiles">ProductPdfColorProfiles.</param>
        /// <param name="TeamData">TeamData.</param>
        public Team(string Name = null, CloudinaryImage Logo = null, string Subdomain = null, string Country = null, DateTime? Created = null, DateTime? Modified = null, string Id = null, string Icon = null, string ClientKey = null, string JavaScriptKey = null, string RestApiKey = null, string WindowsKey = null, string MasterKey = null, string Status = null, string TeamDataId = null, List<Customer> Members = null, List<TeamBuilderConfig> BuilderConfigs = null, List<DataSource> DataSources = null, List<DynamicData> DynamicDatas = null, List<TeamMember> TeamMembers = null, List<Portal> Portals = null, List<Template> Templates = null, TeamBrand Brand = null, List<TeamTemplateFolder> TemplateFolders = null, List<Workflow> Workflows = null, List<Image> Images = null, List<ImageFolder> ImageFolders = null, Billing Billing = null, TeamPermissionSet Permission = null, List<ProductMaterial> ProductMaterials = null, List<ProductSizeMaterial> ProductSizeMaterials = null, List<ProductPdfColorProfile> ProductPdfColorProfiles = null, DynamicData TeamData = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Team and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Team and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Logo = Logo;
            this.Subdomain = Subdomain;
            // use default value if no "Country" provided
            if (Country == null)
            {
                this.Country = "Ireland";
            }
            else
            {
                this.Country = Country;
            }
            this.Created = Created;
            this.Modified = Modified;
            this.Icon = Icon;
            this.ClientKey = ClientKey;
            this.JavaScriptKey = JavaScriptKey;
            this.RestApiKey = RestApiKey;
            this.WindowsKey = WindowsKey;
            this.MasterKey = MasterKey;
            // use default value if no "Status" provided
            if (Status == null)
            {
                this.Status = "sandbox";
            }
            else
            {
                this.Status = Status;
            }
            this.TeamDataId = TeamDataId;
            this.Members = Members;
            this.BuilderConfigs = BuilderConfigs;
            this.DataSources = DataSources;
            this.DynamicDatas = DynamicDatas;
            this.TeamMembers = TeamMembers;
            this.Portals = Portals;
            this.Templates = Templates;
            this.Brand = Brand;
            this.TemplateFolders = TemplateFolders;
            this.Workflows = Workflows;
            this.Images = Images;
            this.ImageFolders = ImageFolders;
            this.Billing = Billing;
            this.Permission = Permission;
            this.ProductMaterials = ProductMaterials;
            this.ProductSizeMaterials = ProductSizeMaterials;
            this.ProductPdfColorProfiles = ProductPdfColorProfiles;
            this.TeamData = TeamData;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public CloudinaryImage Logo { get; set; }
        /// <summary>
        /// Gets or Sets Subdomain
        /// </summary>
        [DataMember(Name="subdomain", EmitDefaultValue=false)]
        public string Subdomain { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
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
        /// The icon image url
        /// </summary>
        /// <value>The icon image url</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }
        /// <summary>
        /// Gets or Sets ClientKey
        /// </summary>
        [DataMember(Name="clientKey", EmitDefaultValue=false)]
        public string ClientKey { get; set; }
        /// <summary>
        /// Gets or Sets JavaScriptKey
        /// </summary>
        [DataMember(Name="javaScriptKey", EmitDefaultValue=false)]
        public string JavaScriptKey { get; set; }
        /// <summary>
        /// Gets or Sets RestApiKey
        /// </summary>
        [DataMember(Name="restApiKey", EmitDefaultValue=false)]
        public string RestApiKey { get; set; }
        /// <summary>
        /// Gets or Sets WindowsKey
        /// </summary>
        [DataMember(Name="windowsKey", EmitDefaultValue=false)]
        public string WindowsKey { get; set; }
        /// <summary>
        /// Gets or Sets MasterKey
        /// </summary>
        [DataMember(Name="masterKey", EmitDefaultValue=false)]
        public string MasterKey { get; set; }
        /// <summary>
        /// Status of the application, production/sandbox/disabled
        /// </summary>
        /// <value>Status of the application, production/sandbox/disabled</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets TeamDataId
        /// </summary>
        [DataMember(Name="teamDataId", EmitDefaultValue=false)]
        public string TeamDataId { get; set; }
        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<Customer> Members { get; set; }
        /// <summary>
        /// Gets or Sets BuilderConfigs
        /// </summary>
        [DataMember(Name="builderConfigs", EmitDefaultValue=false)]
        public List<TeamBuilderConfig> BuilderConfigs { get; set; }
        /// <summary>
        /// Gets or Sets DataSources
        /// </summary>
        [DataMember(Name="dataSources", EmitDefaultValue=false)]
        public List<DataSource> DataSources { get; set; }
        /// <summary>
        /// Gets or Sets DynamicDatas
        /// </summary>
        [DataMember(Name="dynamicDatas", EmitDefaultValue=false)]
        public List<DynamicData> DynamicDatas { get; set; }
        /// <summary>
        /// Gets or Sets TeamMembers
        /// </summary>
        [DataMember(Name="teamMembers", EmitDefaultValue=false)]
        public List<TeamMember> TeamMembers { get; set; }
        /// <summary>
        /// Gets or Sets Portals
        /// </summary>
        [DataMember(Name="portals", EmitDefaultValue=false)]
        public List<Portal> Portals { get; set; }
        /// <summary>
        /// Gets or Sets Templates
        /// </summary>
        [DataMember(Name="templates", EmitDefaultValue=false)]
        public List<Template> Templates { get; set; }
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public TeamBrand Brand { get; set; }
        /// <summary>
        /// Gets or Sets TemplateFolders
        /// </summary>
        [DataMember(Name="templateFolders", EmitDefaultValue=false)]
        public List<TeamTemplateFolder> TemplateFolders { get; set; }
        /// <summary>
        /// Gets or Sets Workflows
        /// </summary>
        [DataMember(Name="workflows", EmitDefaultValue=false)]
        public List<Workflow> Workflows { get; set; }
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<Image> Images { get; set; }
        /// <summary>
        /// Gets or Sets ImageFolders
        /// </summary>
        [DataMember(Name="imageFolders", EmitDefaultValue=false)]
        public List<ImageFolder> ImageFolders { get; set; }
        /// <summary>
        /// Gets or Sets Billing
        /// </summary>
        [DataMember(Name="billing", EmitDefaultValue=false)]
        public Billing Billing { get; set; }
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public TeamPermissionSet Permission { get; set; }
        /// <summary>
        /// Gets or Sets ProductMaterials
        /// </summary>
        [DataMember(Name="productMaterials", EmitDefaultValue=false)]
        public List<ProductMaterial> ProductMaterials { get; set; }
        /// <summary>
        /// Gets or Sets ProductSizeMaterials
        /// </summary>
        [DataMember(Name="productSizeMaterials", EmitDefaultValue=false)]
        public List<ProductSizeMaterial> ProductSizeMaterials { get; set; }
        /// <summary>
        /// Gets or Sets ProductPdfColorProfiles
        /// </summary>
        [DataMember(Name="productPdfColorProfiles", EmitDefaultValue=false)]
        public List<ProductPdfColorProfile> ProductPdfColorProfiles { get; set; }
        /// <summary>
        /// Gets or Sets TeamData
        /// </summary>
        [DataMember(Name="teamData", EmitDefaultValue=false)]
        public DynamicData TeamData { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Team {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Subdomain: ").Append(Subdomain).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
            sb.Append("  JavaScriptKey: ").Append(JavaScriptKey).Append("\n");
            sb.Append("  RestApiKey: ").Append(RestApiKey).Append("\n");
            sb.Append("  WindowsKey: ").Append(WindowsKey).Append("\n");
            sb.Append("  MasterKey: ").Append(MasterKey).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TeamDataId: ").Append(TeamDataId).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  BuilderConfigs: ").Append(BuilderConfigs).Append("\n");
            sb.Append("  DataSources: ").Append(DataSources).Append("\n");
            sb.Append("  DynamicDatas: ").Append(DynamicDatas).Append("\n");
            sb.Append("  TeamMembers: ").Append(TeamMembers).Append("\n");
            sb.Append("  Portals: ").Append(Portals).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  TemplateFolders: ").Append(TemplateFolders).Append("\n");
            sb.Append("  Workflows: ").Append(Workflows).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ImageFolders: ").Append(ImageFolders).Append("\n");
            sb.Append("  Billing: ").Append(Billing).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  ProductMaterials: ").Append(ProductMaterials).Append("\n");
            sb.Append("  ProductSizeMaterials: ").Append(ProductSizeMaterials).Append("\n");
            sb.Append("  ProductPdfColorProfiles: ").Append(ProductPdfColorProfiles).Append("\n");
            sb.Append("  TeamData: ").Append(TeamData).Append("\n");
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
            return this.Equals(obj as Team);
        }

        /// <summary>
        /// Returns true if Team instances are equal
        /// </summary>
        /// <param name="other">Instance of Team to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Team other)
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
                    this.Logo == other.Logo ||
                    this.Logo != null &&
                    this.Logo.Equals(other.Logo)
                ) && 
                (
                    this.Subdomain == other.Subdomain ||
                    this.Subdomain != null &&
                    this.Subdomain.Equals(other.Subdomain)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.ClientKey == other.ClientKey ||
                    this.ClientKey != null &&
                    this.ClientKey.Equals(other.ClientKey)
                ) && 
                (
                    this.JavaScriptKey == other.JavaScriptKey ||
                    this.JavaScriptKey != null &&
                    this.JavaScriptKey.Equals(other.JavaScriptKey)
                ) && 
                (
                    this.RestApiKey == other.RestApiKey ||
                    this.RestApiKey != null &&
                    this.RestApiKey.Equals(other.RestApiKey)
                ) && 
                (
                    this.WindowsKey == other.WindowsKey ||
                    this.WindowsKey != null &&
                    this.WindowsKey.Equals(other.WindowsKey)
                ) && 
                (
                    this.MasterKey == other.MasterKey ||
                    this.MasterKey != null &&
                    this.MasterKey.Equals(other.MasterKey)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TeamDataId == other.TeamDataId ||
                    this.TeamDataId != null &&
                    this.TeamDataId.Equals(other.TeamDataId)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) && 
                (
                    this.BuilderConfigs == other.BuilderConfigs ||
                    this.BuilderConfigs != null &&
                    this.BuilderConfigs.SequenceEqual(other.BuilderConfigs)
                ) && 
                (
                    this.DataSources == other.DataSources ||
                    this.DataSources != null &&
                    this.DataSources.SequenceEqual(other.DataSources)
                ) && 
                (
                    this.DynamicDatas == other.DynamicDatas ||
                    this.DynamicDatas != null &&
                    this.DynamicDatas.SequenceEqual(other.DynamicDatas)
                ) && 
                (
                    this.TeamMembers == other.TeamMembers ||
                    this.TeamMembers != null &&
                    this.TeamMembers.SequenceEqual(other.TeamMembers)
                ) && 
                (
                    this.Portals == other.Portals ||
                    this.Portals != null &&
                    this.Portals.SequenceEqual(other.Portals)
                ) && 
                (
                    this.Templates == other.Templates ||
                    this.Templates != null &&
                    this.Templates.SequenceEqual(other.Templates)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
                ) && 
                (
                    this.TemplateFolders == other.TemplateFolders ||
                    this.TemplateFolders != null &&
                    this.TemplateFolders.SequenceEqual(other.TemplateFolders)
                ) && 
                (
                    this.Workflows == other.Workflows ||
                    this.Workflows != null &&
                    this.Workflows.SequenceEqual(other.Workflows)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) && 
                (
                    this.ImageFolders == other.ImageFolders ||
                    this.ImageFolders != null &&
                    this.ImageFolders.SequenceEqual(other.ImageFolders)
                ) && 
                (
                    this.Billing == other.Billing ||
                    this.Billing != null &&
                    this.Billing.Equals(other.Billing)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.ProductMaterials == other.ProductMaterials ||
                    this.ProductMaterials != null &&
                    this.ProductMaterials.SequenceEqual(other.ProductMaterials)
                ) && 
                (
                    this.ProductSizeMaterials == other.ProductSizeMaterials ||
                    this.ProductSizeMaterials != null &&
                    this.ProductSizeMaterials.SequenceEqual(other.ProductSizeMaterials)
                ) && 
                (
                    this.ProductPdfColorProfiles == other.ProductPdfColorProfiles ||
                    this.ProductPdfColorProfiles != null &&
                    this.ProductPdfColorProfiles.SequenceEqual(other.ProductPdfColorProfiles)
                ) && 
                (
                    this.TeamData == other.TeamData ||
                    this.TeamData != null &&
                    this.TeamData.Equals(other.TeamData)
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
                if (this.Logo != null)
                    hash = hash * 59 + this.Logo.GetHashCode();
                if (this.Subdomain != null)
                    hash = hash * 59 + this.Subdomain.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.ClientKey != null)
                    hash = hash * 59 + this.ClientKey.GetHashCode();
                if (this.JavaScriptKey != null)
                    hash = hash * 59 + this.JavaScriptKey.GetHashCode();
                if (this.RestApiKey != null)
                    hash = hash * 59 + this.RestApiKey.GetHashCode();
                if (this.WindowsKey != null)
                    hash = hash * 59 + this.WindowsKey.GetHashCode();
                if (this.MasterKey != null)
                    hash = hash * 59 + this.MasterKey.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TeamDataId != null)
                    hash = hash * 59 + this.TeamDataId.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.BuilderConfigs != null)
                    hash = hash * 59 + this.BuilderConfigs.GetHashCode();
                if (this.DataSources != null)
                    hash = hash * 59 + this.DataSources.GetHashCode();
                if (this.DynamicDatas != null)
                    hash = hash * 59 + this.DynamicDatas.GetHashCode();
                if (this.TeamMembers != null)
                    hash = hash * 59 + this.TeamMembers.GetHashCode();
                if (this.Portals != null)
                    hash = hash * 59 + this.Portals.GetHashCode();
                if (this.Templates != null)
                    hash = hash * 59 + this.Templates.GetHashCode();
                if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                if (this.TemplateFolders != null)
                    hash = hash * 59 + this.TemplateFolders.GetHashCode();
                if (this.Workflows != null)
                    hash = hash * 59 + this.Workflows.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                if (this.ImageFolders != null)
                    hash = hash * 59 + this.ImageFolders.GetHashCode();
                if (this.Billing != null)
                    hash = hash * 59 + this.Billing.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.ProductMaterials != null)
                    hash = hash * 59 + this.ProductMaterials.GetHashCode();
                if (this.ProductSizeMaterials != null)
                    hash = hash * 59 + this.ProductSizeMaterials.GetHashCode();
                if (this.ProductPdfColorProfiles != null)
                    hash = hash * 59 + this.ProductPdfColorProfiles.GetHashCode();
                if (this.TeamData != null)
                    hash = hash * 59 + this.TeamData.GetHashCode();
                return hash;
            }
        }
    }

}

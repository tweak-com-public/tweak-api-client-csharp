/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.1
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
    /// FlashVar
    /// </summary>
    [DataContract]
    public partial class FlashVar :  IEquatable<FlashVar>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlashVar" /> class.
        /// </summary>
        /// <param name="ApiPartnerAuthUrl">ApiPartnerAuthUrl (default to &quot;&quot;).</param>
        /// <param name="PluginProductId">PluginProductId.</param>
        /// <param name="SavedProductId">SavedProductId.</param>
        /// <param name="AllowAddImage">AllowAddImage (default to false).</param>
        /// <param name="AllowAddText">AllowAddText (default to false).</param>
        /// <param name="AllowJPEG">AllowJPEG (default to false).</param>
        /// <param name="AllowLowResPDF">AllowLowResPDF (default to false).</param>
        /// <param name="AllowHighResPDF">AllowHighResPDF (default to false).</param>
        /// <param name="AllowSaveForLater">AllowSaveForLater (default to false).</param>
        /// <param name="AllowSaveAsTemplate">AllowSaveAsTemplate (default to false).</param>
        /// <param name="AllowDuplicateDesign">AllowDuplicateDesign (default to false).</param>
        /// <param name="BlockEditing">BlockEditing (default to false).</param>
        /// <param name="MakeAllItemsEditable">MakeAllItemsEditable (default to false).</param>
        /// <param name="ShowConfirm">ShowConfirm (default to false).</param>
        /// <param name="AllowApprovePluginProduct">AllowApprovePluginProduct (default to false).</param>
        /// <param name="AllowSendToApprovePluginProduct">AllowSendToApprovePluginProduct (default to false).</param>
        /// <param name="WorkflowForm">WorkflowForm.</param>
        /// <param name="DesignFormData">DesignFormData.</param>
        /// <param name="ShowPluginImages">ShowPluginImages (default to false).</param>
        /// <param name="PluginImageLibraries">PluginImageLibraries.</param>
        /// <param name="IsTweakTemplate">IsTweakTemplate (default to false).</param>
        /// <param name="ShowItemNavigator">ShowItemNavigator (default to false).</param>
        /// <param name="ShowItemCounts">ShowItemCounts (default to false).</param>
        /// <param name="ShowEditableItemToggle">ShowEditableItemToggle (default to false).</param>
        /// <param name="Id">Id.</param>
        /// <param name="TeamId">TeamId.</param>
        /// <param name="Team">Team.</param>
        /// <param name="TeamMemberId">TeamMemberId.</param>
        /// <param name="TeamMember">TeamMember.</param>
        /// <param name="PortalId">PortalId.</param>
        /// <param name="Portal">Portal.</param>
        /// <param name="PortalMemberId">PortalMemberId.</param>
        /// <param name="PortalMember">PortalMember.</param>
        /// <param name="DesignId">DesignId.</param>
        /// <param name="Design">Design.</param>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="Template">Template.</param>
        public FlashVar(string ApiPartnerAuthUrl = null, string PluginProductId = null, string SavedProductId = null, bool? AllowAddImage = null, bool? AllowAddText = null, bool? AllowJPEG = null, bool? AllowLowResPDF = null, bool? AllowHighResPDF = null, bool? AllowSaveForLater = null, bool? AllowSaveAsTemplate = null, bool? AllowDuplicateDesign = null, bool? BlockEditing = null, bool? MakeAllItemsEditable = null, bool? ShowConfirm = null, bool? AllowApprovePluginProduct = null, bool? AllowSendToApprovePluginProduct = null, string WorkflowForm = null, List<Object> DesignFormData = null, bool? ShowPluginImages = null, List<string> PluginImageLibraries = null, bool? IsTweakTemplate = null, bool? ShowItemNavigator = null, bool? ShowItemCounts = null, bool? ShowEditableItemToggle = null, string Id = null, string TeamId = null, Team Team = null, string TeamMemberId = null, TeamMember TeamMember = null, string PortalId = null, Portal Portal = null, string PortalMemberId = null, PortalMember PortalMember = null, string DesignId = null, Design Design = null, string TemplateId = null, Template Template = null)
        {
            // use default value if no "ApiPartnerAuthUrl" provided
            if (ApiPartnerAuthUrl == null)
            {
                this.ApiPartnerAuthUrl = "";
            }
            else
            {
                this.ApiPartnerAuthUrl = ApiPartnerAuthUrl;
            }
            this.PluginProductId = PluginProductId;
            this.SavedProductId = SavedProductId;
            // use default value if no "AllowAddImage" provided
            if (AllowAddImage == null)
            {
                this.AllowAddImage = false;
            }
            else
            {
                this.AllowAddImage = AllowAddImage;
            }
            // use default value if no "AllowAddText" provided
            if (AllowAddText == null)
            {
                this.AllowAddText = false;
            }
            else
            {
                this.AllowAddText = AllowAddText;
            }
            // use default value if no "AllowJPEG" provided
            if (AllowJPEG == null)
            {
                this.AllowJPEG = false;
            }
            else
            {
                this.AllowJPEG = AllowJPEG;
            }
            // use default value if no "AllowLowResPDF" provided
            if (AllowLowResPDF == null)
            {
                this.AllowLowResPDF = false;
            }
            else
            {
                this.AllowLowResPDF = AllowLowResPDF;
            }
            // use default value if no "AllowHighResPDF" provided
            if (AllowHighResPDF == null)
            {
                this.AllowHighResPDF = false;
            }
            else
            {
                this.AllowHighResPDF = AllowHighResPDF;
            }
            // use default value if no "AllowSaveForLater" provided
            if (AllowSaveForLater == null)
            {
                this.AllowSaveForLater = false;
            }
            else
            {
                this.AllowSaveForLater = AllowSaveForLater;
            }
            // use default value if no "AllowSaveAsTemplate" provided
            if (AllowSaveAsTemplate == null)
            {
                this.AllowSaveAsTemplate = false;
            }
            else
            {
                this.AllowSaveAsTemplate = AllowSaveAsTemplate;
            }
            // use default value if no "AllowDuplicateDesign" provided
            if (AllowDuplicateDesign == null)
            {
                this.AllowDuplicateDesign = false;
            }
            else
            {
                this.AllowDuplicateDesign = AllowDuplicateDesign;
            }
            // use default value if no "BlockEditing" provided
            if (BlockEditing == null)
            {
                this.BlockEditing = false;
            }
            else
            {
                this.BlockEditing = BlockEditing;
            }
            // use default value if no "MakeAllItemsEditable" provided
            if (MakeAllItemsEditable == null)
            {
                this.MakeAllItemsEditable = false;
            }
            else
            {
                this.MakeAllItemsEditable = MakeAllItemsEditable;
            }
            // use default value if no "ShowConfirm" provided
            if (ShowConfirm == null)
            {
                this.ShowConfirm = false;
            }
            else
            {
                this.ShowConfirm = ShowConfirm;
            }
            // use default value if no "AllowApprovePluginProduct" provided
            if (AllowApprovePluginProduct == null)
            {
                this.AllowApprovePluginProduct = false;
            }
            else
            {
                this.AllowApprovePluginProduct = AllowApprovePluginProduct;
            }
            // use default value if no "AllowSendToApprovePluginProduct" provided
            if (AllowSendToApprovePluginProduct == null)
            {
                this.AllowSendToApprovePluginProduct = false;
            }
            else
            {
                this.AllowSendToApprovePluginProduct = AllowSendToApprovePluginProduct;
            }
            this.WorkflowForm = WorkflowForm;
            this.DesignFormData = DesignFormData;
            // use default value if no "ShowPluginImages" provided
            if (ShowPluginImages == null)
            {
                this.ShowPluginImages = false;
            }
            else
            {
                this.ShowPluginImages = ShowPluginImages;
            }
            this.PluginImageLibraries = PluginImageLibraries;
            // use default value if no "IsTweakTemplate" provided
            if (IsTweakTemplate == null)
            {
                this.IsTweakTemplate = false;
            }
            else
            {
                this.IsTweakTemplate = IsTweakTemplate;
            }
            // use default value if no "ShowItemNavigator" provided
            if (ShowItemNavigator == null)
            {
                this.ShowItemNavigator = false;
            }
            else
            {
                this.ShowItemNavigator = ShowItemNavigator;
            }
            // use default value if no "ShowItemCounts" provided
            if (ShowItemCounts == null)
            {
                this.ShowItemCounts = false;
            }
            else
            {
                this.ShowItemCounts = ShowItemCounts;
            }
            // use default value if no "ShowEditableItemToggle" provided
            if (ShowEditableItemToggle == null)
            {
                this.ShowEditableItemToggle = false;
            }
            else
            {
                this.ShowEditableItemToggle = ShowEditableItemToggle;
            }
            this.Id = Id;
            this.TeamId = TeamId;
            this.Team = Team;
            this.TeamMemberId = TeamMemberId;
            this.TeamMember = TeamMember;
            this.PortalId = PortalId;
            this.Portal = Portal;
            this.PortalMemberId = PortalMemberId;
            this.PortalMember = PortalMember;
            this.DesignId = DesignId;
            this.Design = Design;
            this.TemplateId = TemplateId;
            this.Template = Template;
        }
        
        /// <summary>
        /// Gets or Sets ApiPartnerAuthUrl
        /// </summary>
        [DataMember(Name="apiPartnerAuthUrl", EmitDefaultValue=false)]
        public string ApiPartnerAuthUrl { get; set; }
        /// <summary>
        /// Gets or Sets PluginProductId
        /// </summary>
        [DataMember(Name="pluginProductId", EmitDefaultValue=false)]
        public string PluginProductId { get; set; }
        /// <summary>
        /// Gets or Sets SavedProductId
        /// </summary>
        [DataMember(Name="savedProductId", EmitDefaultValue=false)]
        public string SavedProductId { get; set; }
        /// <summary>
        /// Gets or Sets AllowAddImage
        /// </summary>
        [DataMember(Name="allowAddImage", EmitDefaultValue=false)]
        public bool? AllowAddImage { get; set; }
        /// <summary>
        /// Gets or Sets AllowAddText
        /// </summary>
        [DataMember(Name="allowAddText", EmitDefaultValue=false)]
        public bool? AllowAddText { get; set; }
        /// <summary>
        /// Gets or Sets AllowJPEG
        /// </summary>
        [DataMember(Name="allowJPEG", EmitDefaultValue=false)]
        public bool? AllowJPEG { get; set; }
        /// <summary>
        /// Gets or Sets AllowLowResPDF
        /// </summary>
        [DataMember(Name="allowLowResPDF", EmitDefaultValue=false)]
        public bool? AllowLowResPDF { get; set; }
        /// <summary>
        /// Gets or Sets AllowHighResPDF
        /// </summary>
        [DataMember(Name="allowHighResPDF", EmitDefaultValue=false)]
        public bool? AllowHighResPDF { get; set; }
        /// <summary>
        /// Gets or Sets AllowSaveForLater
        /// </summary>
        [DataMember(Name="allowSaveForLater", EmitDefaultValue=false)]
        public bool? AllowSaveForLater { get; set; }
        /// <summary>
        /// Gets or Sets AllowSaveAsTemplate
        /// </summary>
        [DataMember(Name="allowSaveAsTemplate", EmitDefaultValue=false)]
        public bool? AllowSaveAsTemplate { get; set; }
        /// <summary>
        /// Gets or Sets AllowDuplicateDesign
        /// </summary>
        [DataMember(Name="allowDuplicateDesign", EmitDefaultValue=false)]
        public bool? AllowDuplicateDesign { get; set; }
        /// <summary>
        /// Gets or Sets BlockEditing
        /// </summary>
        [DataMember(Name="blockEditing", EmitDefaultValue=false)]
        public bool? BlockEditing { get; set; }
        /// <summary>
        /// Gets or Sets MakeAllItemsEditable
        /// </summary>
        [DataMember(Name="makeAllItemsEditable", EmitDefaultValue=false)]
        public bool? MakeAllItemsEditable { get; set; }
        /// <summary>
        /// Gets or Sets ShowConfirm
        /// </summary>
        [DataMember(Name="showConfirm", EmitDefaultValue=false)]
        public bool? ShowConfirm { get; set; }
        /// <summary>
        /// Gets or Sets AllowApprovePluginProduct
        /// </summary>
        [DataMember(Name="allowApprovePluginProduct", EmitDefaultValue=false)]
        public bool? AllowApprovePluginProduct { get; set; }
        /// <summary>
        /// Gets or Sets AllowSendToApprovePluginProduct
        /// </summary>
        [DataMember(Name="allowSendToApprovePluginProduct", EmitDefaultValue=false)]
        public bool? AllowSendToApprovePluginProduct { get; set; }
        /// <summary>
        /// Gets or Sets WorkflowForm
        /// </summary>
        [DataMember(Name="workflowForm", EmitDefaultValue=false)]
        public string WorkflowForm { get; set; }
        /// <summary>
        /// Gets or Sets DesignFormData
        /// </summary>
        [DataMember(Name="designFormData", EmitDefaultValue=false)]
        public List<Object> DesignFormData { get; set; }
        /// <summary>
        /// Gets or Sets ShowPluginImages
        /// </summary>
        [DataMember(Name="showPluginImages", EmitDefaultValue=false)]
        public bool? ShowPluginImages { get; set; }
        /// <summary>
        /// Gets or Sets PluginImageLibraries
        /// </summary>
        [DataMember(Name="pluginImageLibraries", EmitDefaultValue=false)]
        public List<string> PluginImageLibraries { get; set; }
        /// <summary>
        /// Gets or Sets IsTweakTemplate
        /// </summary>
        [DataMember(Name="isTweakTemplate", EmitDefaultValue=false)]
        public bool? IsTweakTemplate { get; set; }
        /// <summary>
        /// Gets or Sets ShowItemNavigator
        /// </summary>
        [DataMember(Name="showItemNavigator", EmitDefaultValue=false)]
        public bool? ShowItemNavigator { get; set; }
        /// <summary>
        /// Gets or Sets ShowItemCounts
        /// </summary>
        [DataMember(Name="showItemCounts", EmitDefaultValue=false)]
        public bool? ShowItemCounts { get; set; }
        /// <summary>
        /// Gets or Sets ShowEditableItemToggle
        /// </summary>
        [DataMember(Name="showEditableItemToggle", EmitDefaultValue=false)]
        public bool? ShowEditableItemToggle { get; set; }
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
        /// Gets or Sets TeamMemberId
        /// </summary>
        [DataMember(Name="teamMemberId", EmitDefaultValue=false)]
        public string TeamMemberId { get; set; }
        /// <summary>
        /// Gets or Sets TeamMember
        /// </summary>
        [DataMember(Name="teamMember", EmitDefaultValue=false)]
        public TeamMember TeamMember { get; set; }
        /// <summary>
        /// Gets or Sets PortalId
        /// </summary>
        [DataMember(Name="portalId", EmitDefaultValue=false)]
        public string PortalId { get; set; }
        /// <summary>
        /// Gets or Sets Portal
        /// </summary>
        [DataMember(Name="portal", EmitDefaultValue=false)]
        public Portal Portal { get; set; }
        /// <summary>
        /// Gets or Sets PortalMemberId
        /// </summary>
        [DataMember(Name="portalMemberId", EmitDefaultValue=false)]
        public string PortalMemberId { get; set; }
        /// <summary>
        /// Gets or Sets PortalMember
        /// </summary>
        [DataMember(Name="portalMember", EmitDefaultValue=false)]
        public PortalMember PortalMember { get; set; }
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
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public Template Template { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlashVar {\n");
            sb.Append("  ApiPartnerAuthUrl: ").Append(ApiPartnerAuthUrl).Append("\n");
            sb.Append("  PluginProductId: ").Append(PluginProductId).Append("\n");
            sb.Append("  SavedProductId: ").Append(SavedProductId).Append("\n");
            sb.Append("  AllowAddImage: ").Append(AllowAddImage).Append("\n");
            sb.Append("  AllowAddText: ").Append(AllowAddText).Append("\n");
            sb.Append("  AllowJPEG: ").Append(AllowJPEG).Append("\n");
            sb.Append("  AllowLowResPDF: ").Append(AllowLowResPDF).Append("\n");
            sb.Append("  AllowHighResPDF: ").Append(AllowHighResPDF).Append("\n");
            sb.Append("  AllowSaveForLater: ").Append(AllowSaveForLater).Append("\n");
            sb.Append("  AllowSaveAsTemplate: ").Append(AllowSaveAsTemplate).Append("\n");
            sb.Append("  AllowDuplicateDesign: ").Append(AllowDuplicateDesign).Append("\n");
            sb.Append("  BlockEditing: ").Append(BlockEditing).Append("\n");
            sb.Append("  MakeAllItemsEditable: ").Append(MakeAllItemsEditable).Append("\n");
            sb.Append("  ShowConfirm: ").Append(ShowConfirm).Append("\n");
            sb.Append("  AllowApprovePluginProduct: ").Append(AllowApprovePluginProduct).Append("\n");
            sb.Append("  AllowSendToApprovePluginProduct: ").Append(AllowSendToApprovePluginProduct).Append("\n");
            sb.Append("  WorkflowForm: ").Append(WorkflowForm).Append("\n");
            sb.Append("  DesignFormData: ").Append(DesignFormData).Append("\n");
            sb.Append("  ShowPluginImages: ").Append(ShowPluginImages).Append("\n");
            sb.Append("  PluginImageLibraries: ").Append(PluginImageLibraries).Append("\n");
            sb.Append("  IsTweakTemplate: ").Append(IsTweakTemplate).Append("\n");
            sb.Append("  ShowItemNavigator: ").Append(ShowItemNavigator).Append("\n");
            sb.Append("  ShowItemCounts: ").Append(ShowItemCounts).Append("\n");
            sb.Append("  ShowEditableItemToggle: ").Append(ShowEditableItemToggle).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  TeamMemberId: ").Append(TeamMemberId).Append("\n");
            sb.Append("  TeamMember: ").Append(TeamMember).Append("\n");
            sb.Append("  PortalId: ").Append(PortalId).Append("\n");
            sb.Append("  Portal: ").Append(Portal).Append("\n");
            sb.Append("  PortalMemberId: ").Append(PortalMemberId).Append("\n");
            sb.Append("  PortalMember: ").Append(PortalMember).Append("\n");
            sb.Append("  DesignId: ").Append(DesignId).Append("\n");
            sb.Append("  Design: ").Append(Design).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
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
            return this.Equals(obj as FlashVar);
        }

        /// <summary>
        /// Returns true if FlashVar instances are equal
        /// </summary>
        /// <param name="other">Instance of FlashVar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlashVar other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiPartnerAuthUrl == other.ApiPartnerAuthUrl ||
                    this.ApiPartnerAuthUrl != null &&
                    this.ApiPartnerAuthUrl.Equals(other.ApiPartnerAuthUrl)
                ) && 
                (
                    this.PluginProductId == other.PluginProductId ||
                    this.PluginProductId != null &&
                    this.PluginProductId.Equals(other.PluginProductId)
                ) && 
                (
                    this.SavedProductId == other.SavedProductId ||
                    this.SavedProductId != null &&
                    this.SavedProductId.Equals(other.SavedProductId)
                ) && 
                (
                    this.AllowAddImage == other.AllowAddImage ||
                    this.AllowAddImage != null &&
                    this.AllowAddImage.Equals(other.AllowAddImage)
                ) && 
                (
                    this.AllowAddText == other.AllowAddText ||
                    this.AllowAddText != null &&
                    this.AllowAddText.Equals(other.AllowAddText)
                ) && 
                (
                    this.AllowJPEG == other.AllowJPEG ||
                    this.AllowJPEG != null &&
                    this.AllowJPEG.Equals(other.AllowJPEG)
                ) && 
                (
                    this.AllowLowResPDF == other.AllowLowResPDF ||
                    this.AllowLowResPDF != null &&
                    this.AllowLowResPDF.Equals(other.AllowLowResPDF)
                ) && 
                (
                    this.AllowHighResPDF == other.AllowHighResPDF ||
                    this.AllowHighResPDF != null &&
                    this.AllowHighResPDF.Equals(other.AllowHighResPDF)
                ) && 
                (
                    this.AllowSaveForLater == other.AllowSaveForLater ||
                    this.AllowSaveForLater != null &&
                    this.AllowSaveForLater.Equals(other.AllowSaveForLater)
                ) && 
                (
                    this.AllowSaveAsTemplate == other.AllowSaveAsTemplate ||
                    this.AllowSaveAsTemplate != null &&
                    this.AllowSaveAsTemplate.Equals(other.AllowSaveAsTemplate)
                ) && 
                (
                    this.AllowDuplicateDesign == other.AllowDuplicateDesign ||
                    this.AllowDuplicateDesign != null &&
                    this.AllowDuplicateDesign.Equals(other.AllowDuplicateDesign)
                ) && 
                (
                    this.BlockEditing == other.BlockEditing ||
                    this.BlockEditing != null &&
                    this.BlockEditing.Equals(other.BlockEditing)
                ) && 
                (
                    this.MakeAllItemsEditable == other.MakeAllItemsEditable ||
                    this.MakeAllItemsEditable != null &&
                    this.MakeAllItemsEditable.Equals(other.MakeAllItemsEditable)
                ) && 
                (
                    this.ShowConfirm == other.ShowConfirm ||
                    this.ShowConfirm != null &&
                    this.ShowConfirm.Equals(other.ShowConfirm)
                ) && 
                (
                    this.AllowApprovePluginProduct == other.AllowApprovePluginProduct ||
                    this.AllowApprovePluginProduct != null &&
                    this.AllowApprovePluginProduct.Equals(other.AllowApprovePluginProduct)
                ) && 
                (
                    this.AllowSendToApprovePluginProduct == other.AllowSendToApprovePluginProduct ||
                    this.AllowSendToApprovePluginProduct != null &&
                    this.AllowSendToApprovePluginProduct.Equals(other.AllowSendToApprovePluginProduct)
                ) && 
                (
                    this.WorkflowForm == other.WorkflowForm ||
                    this.WorkflowForm != null &&
                    this.WorkflowForm.Equals(other.WorkflowForm)
                ) && 
                (
                    this.DesignFormData == other.DesignFormData ||
                    this.DesignFormData != null &&
                    this.DesignFormData.SequenceEqual(other.DesignFormData)
                ) && 
                (
                    this.ShowPluginImages == other.ShowPluginImages ||
                    this.ShowPluginImages != null &&
                    this.ShowPluginImages.Equals(other.ShowPluginImages)
                ) && 
                (
                    this.PluginImageLibraries == other.PluginImageLibraries ||
                    this.PluginImageLibraries != null &&
                    this.PluginImageLibraries.SequenceEqual(other.PluginImageLibraries)
                ) && 
                (
                    this.IsTweakTemplate == other.IsTweakTemplate ||
                    this.IsTweakTemplate != null &&
                    this.IsTweakTemplate.Equals(other.IsTweakTemplate)
                ) && 
                (
                    this.ShowItemNavigator == other.ShowItemNavigator ||
                    this.ShowItemNavigator != null &&
                    this.ShowItemNavigator.Equals(other.ShowItemNavigator)
                ) && 
                (
                    this.ShowItemCounts == other.ShowItemCounts ||
                    this.ShowItemCounts != null &&
                    this.ShowItemCounts.Equals(other.ShowItemCounts)
                ) && 
                (
                    this.ShowEditableItemToggle == other.ShowEditableItemToggle ||
                    this.ShowEditableItemToggle != null &&
                    this.ShowEditableItemToggle.Equals(other.ShowEditableItemToggle)
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
                    this.TeamMemberId == other.TeamMemberId ||
                    this.TeamMemberId != null &&
                    this.TeamMemberId.Equals(other.TeamMemberId)
                ) && 
                (
                    this.TeamMember == other.TeamMember ||
                    this.TeamMember != null &&
                    this.TeamMember.Equals(other.TeamMember)
                ) && 
                (
                    this.PortalId == other.PortalId ||
                    this.PortalId != null &&
                    this.PortalId.Equals(other.PortalId)
                ) && 
                (
                    this.Portal == other.Portal ||
                    this.Portal != null &&
                    this.Portal.Equals(other.Portal)
                ) && 
                (
                    this.PortalMemberId == other.PortalMemberId ||
                    this.PortalMemberId != null &&
                    this.PortalMemberId.Equals(other.PortalMemberId)
                ) && 
                (
                    this.PortalMember == other.PortalMember ||
                    this.PortalMember != null &&
                    this.PortalMember.Equals(other.PortalMember)
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
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
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
                if (this.ApiPartnerAuthUrl != null)
                    hash = hash * 59 + this.ApiPartnerAuthUrl.GetHashCode();
                if (this.PluginProductId != null)
                    hash = hash * 59 + this.PluginProductId.GetHashCode();
                if (this.SavedProductId != null)
                    hash = hash * 59 + this.SavedProductId.GetHashCode();
                if (this.AllowAddImage != null)
                    hash = hash * 59 + this.AllowAddImage.GetHashCode();
                if (this.AllowAddText != null)
                    hash = hash * 59 + this.AllowAddText.GetHashCode();
                if (this.AllowJPEG != null)
                    hash = hash * 59 + this.AllowJPEG.GetHashCode();
                if (this.AllowLowResPDF != null)
                    hash = hash * 59 + this.AllowLowResPDF.GetHashCode();
                if (this.AllowHighResPDF != null)
                    hash = hash * 59 + this.AllowHighResPDF.GetHashCode();
                if (this.AllowSaveForLater != null)
                    hash = hash * 59 + this.AllowSaveForLater.GetHashCode();
                if (this.AllowSaveAsTemplate != null)
                    hash = hash * 59 + this.AllowSaveAsTemplate.GetHashCode();
                if (this.AllowDuplicateDesign != null)
                    hash = hash * 59 + this.AllowDuplicateDesign.GetHashCode();
                if (this.BlockEditing != null)
                    hash = hash * 59 + this.BlockEditing.GetHashCode();
                if (this.MakeAllItemsEditable != null)
                    hash = hash * 59 + this.MakeAllItemsEditable.GetHashCode();
                if (this.ShowConfirm != null)
                    hash = hash * 59 + this.ShowConfirm.GetHashCode();
                if (this.AllowApprovePluginProduct != null)
                    hash = hash * 59 + this.AllowApprovePluginProduct.GetHashCode();
                if (this.AllowSendToApprovePluginProduct != null)
                    hash = hash * 59 + this.AllowSendToApprovePluginProduct.GetHashCode();
                if (this.WorkflowForm != null)
                    hash = hash * 59 + this.WorkflowForm.GetHashCode();
                if (this.DesignFormData != null)
                    hash = hash * 59 + this.DesignFormData.GetHashCode();
                if (this.ShowPluginImages != null)
                    hash = hash * 59 + this.ShowPluginImages.GetHashCode();
                if (this.PluginImageLibraries != null)
                    hash = hash * 59 + this.PluginImageLibraries.GetHashCode();
                if (this.IsTweakTemplate != null)
                    hash = hash * 59 + this.IsTweakTemplate.GetHashCode();
                if (this.ShowItemNavigator != null)
                    hash = hash * 59 + this.ShowItemNavigator.GetHashCode();
                if (this.ShowItemCounts != null)
                    hash = hash * 59 + this.ShowItemCounts.GetHashCode();
                if (this.ShowEditableItemToggle != null)
                    hash = hash * 59 + this.ShowEditableItemToggle.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
                if (this.Team != null)
                    hash = hash * 59 + this.Team.GetHashCode();
                if (this.TeamMemberId != null)
                    hash = hash * 59 + this.TeamMemberId.GetHashCode();
                if (this.TeamMember != null)
                    hash = hash * 59 + this.TeamMember.GetHashCode();
                if (this.PortalId != null)
                    hash = hash * 59 + this.PortalId.GetHashCode();
                if (this.Portal != null)
                    hash = hash * 59 + this.Portal.GetHashCode();
                if (this.PortalMemberId != null)
                    hash = hash * 59 + this.PortalMemberId.GetHashCode();
                if (this.PortalMember != null)
                    hash = hash * 59 + this.PortalMember.GetHashCode();
                if (this.DesignId != null)
                    hash = hash * 59 + this.DesignId.GetHashCode();
                if (this.Design != null)
                    hash = hash * 59 + this.Design.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                return hash;
            }
        }
    }

}

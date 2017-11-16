/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-alpha.3
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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TweakApi.Api;
using TweakApi.Model;
using TweakApi.Client;
using System.Reflection;

namespace TweakApi.Test
{
    /// <summary>
    ///  Class for testing FlashVar
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FlashVarTests
    {
        // TODO uncomment below to declare an instance variable for FlashVar
        //private FlashVar instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FlashVar
            //instance = new FlashVar();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FlashVar
        /// </summary>
        [Test]
        public void FlashVarInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FlashVar
            //Assert.IsInstanceOfType<FlashVar> (instance, "variable 'instance' is a FlashVar");
        }

        /// <summary>
        /// Test the property 'ApiPartnerAuthUrl'
        /// </summary>
        [Test]
        public void ApiPartnerAuthUrlTest()
        {
            // TODO unit test for the property 'ApiPartnerAuthUrl'
        }
        /// <summary>
        /// Test the property 'PluginProductId'
        /// </summary>
        [Test]
        public void PluginProductIdTest()
        {
            // TODO unit test for the property 'PluginProductId'
        }
        /// <summary>
        /// Test the property 'SavedProductId'
        /// </summary>
        [Test]
        public void SavedProductIdTest()
        {
            // TODO unit test for the property 'SavedProductId'
        }
        /// <summary>
        /// Test the property 'AllowAddImage'
        /// </summary>
        [Test]
        public void AllowAddImageTest()
        {
            // TODO unit test for the property 'AllowAddImage'
        }
        /// <summary>
        /// Test the property 'AllowAddText'
        /// </summary>
        [Test]
        public void AllowAddTextTest()
        {
            // TODO unit test for the property 'AllowAddText'
        }
        /// <summary>
        /// Test the property 'AllowJPEG'
        /// </summary>
        [Test]
        public void AllowJPEGTest()
        {
            // TODO unit test for the property 'AllowJPEG'
        }
        /// <summary>
        /// Test the property 'AllowLowResPDF'
        /// </summary>
        [Test]
        public void AllowLowResPDFTest()
        {
            // TODO unit test for the property 'AllowLowResPDF'
        }
        /// <summary>
        /// Test the property 'AllowHighResPDF'
        /// </summary>
        [Test]
        public void AllowHighResPDFTest()
        {
            // TODO unit test for the property 'AllowHighResPDF'
        }
        /// <summary>
        /// Test the property 'AllowSaveForLater'
        /// </summary>
        [Test]
        public void AllowSaveForLaterTest()
        {
            // TODO unit test for the property 'AllowSaveForLater'
        }
        /// <summary>
        /// Test the property 'AllowSaveAsTemplate'
        /// </summary>
        [Test]
        public void AllowSaveAsTemplateTest()
        {
            // TODO unit test for the property 'AllowSaveAsTemplate'
        }
        /// <summary>
        /// Test the property 'AllowDuplicateDesign'
        /// </summary>
        [Test]
        public void AllowDuplicateDesignTest()
        {
            // TODO unit test for the property 'AllowDuplicateDesign'
        }
        /// <summary>
        /// Test the property 'BlockEditing'
        /// </summary>
        [Test]
        public void BlockEditingTest()
        {
            // TODO unit test for the property 'BlockEditing'
        }
        /// <summary>
        /// Test the property 'MakeAllItemsEditable'
        /// </summary>
        [Test]
        public void MakeAllItemsEditableTest()
        {
            // TODO unit test for the property 'MakeAllItemsEditable'
        }
        /// <summary>
        /// Test the property 'ShowConfirm'
        /// </summary>
        [Test]
        public void ShowConfirmTest()
        {
            // TODO unit test for the property 'ShowConfirm'
        }
        /// <summary>
        /// Test the property 'AllowApprovePluginProduct'
        /// </summary>
        [Test]
        public void AllowApprovePluginProductTest()
        {
            // TODO unit test for the property 'AllowApprovePluginProduct'
        }
        /// <summary>
        /// Test the property 'AllowSendToApprovePluginProduct'
        /// </summary>
        [Test]
        public void AllowSendToApprovePluginProductTest()
        {
            // TODO unit test for the property 'AllowSendToApprovePluginProduct'
        }
        /// <summary>
        /// Test the property 'WorkflowForm'
        /// </summary>
        [Test]
        public void WorkflowFormTest()
        {
            // TODO unit test for the property 'WorkflowForm'
        }
        /// <summary>
        /// Test the property 'DesignFormData'
        /// </summary>
        [Test]
        public void DesignFormDataTest()
        {
            // TODO unit test for the property 'DesignFormData'
        }
        /// <summary>
        /// Test the property 'ShowPluginImages'
        /// </summary>
        [Test]
        public void ShowPluginImagesTest()
        {
            // TODO unit test for the property 'ShowPluginImages'
        }
        /// <summary>
        /// Test the property 'PluginImageLibraries'
        /// </summary>
        [Test]
        public void PluginImageLibrariesTest()
        {
            // TODO unit test for the property 'PluginImageLibraries'
        }
        /// <summary>
        /// Test the property 'IsTweakTemplate'
        /// </summary>
        [Test]
        public void IsTweakTemplateTest()
        {
            // TODO unit test for the property 'IsTweakTemplate'
        }
        /// <summary>
        /// Test the property 'ShowItemNavigator'
        /// </summary>
        [Test]
        public void ShowItemNavigatorTest()
        {
            // TODO unit test for the property 'ShowItemNavigator'
        }
        /// <summary>
        /// Test the property 'ShowItemCounts'
        /// </summary>
        [Test]
        public void ShowItemCountsTest()
        {
            // TODO unit test for the property 'ShowItemCounts'
        }
        /// <summary>
        /// Test the property 'ShowEditableItemToggle'
        /// </summary>
        [Test]
        public void ShowEditableItemToggleTest()
        {
            // TODO unit test for the property 'ShowEditableItemToggle'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'TeamId'
        /// </summary>
        [Test]
        public void TeamIdTest()
        {
            // TODO unit test for the property 'TeamId'
        }
        /// <summary>
        /// Test the property 'Team'
        /// </summary>
        [Test]
        public void TeamTest()
        {
            // TODO unit test for the property 'Team'
        }
        /// <summary>
        /// Test the property 'TeamMemberId'
        /// </summary>
        [Test]
        public void TeamMemberIdTest()
        {
            // TODO unit test for the property 'TeamMemberId'
        }
        /// <summary>
        /// Test the property 'TeamMember'
        /// </summary>
        [Test]
        public void TeamMemberTest()
        {
            // TODO unit test for the property 'TeamMember'
        }
        /// <summary>
        /// Test the property 'PortalId'
        /// </summary>
        [Test]
        public void PortalIdTest()
        {
            // TODO unit test for the property 'PortalId'
        }
        /// <summary>
        /// Test the property 'Portal'
        /// </summary>
        [Test]
        public void PortalTest()
        {
            // TODO unit test for the property 'Portal'
        }
        /// <summary>
        /// Test the property 'PortalMemberId'
        /// </summary>
        [Test]
        public void PortalMemberIdTest()
        {
            // TODO unit test for the property 'PortalMemberId'
        }
        /// <summary>
        /// Test the property 'PortalMember'
        /// </summary>
        [Test]
        public void PortalMemberTest()
        {
            // TODO unit test for the property 'PortalMember'
        }
        /// <summary>
        /// Test the property 'DesignId'
        /// </summary>
        [Test]
        public void DesignIdTest()
        {
            // TODO unit test for the property 'DesignId'
        }
        /// <summary>
        /// Test the property 'Design'
        /// </summary>
        [Test]
        public void DesignTest()
        {
            // TODO unit test for the property 'Design'
        }
        /// <summary>
        /// Test the property 'TemplateId'
        /// </summary>
        [Test]
        public void TemplateIdTest()
        {
            // TODO unit test for the property 'TemplateId'
        }
        /// <summary>
        /// Test the property 'Template'
        /// </summary>
        [Test]
        public void TemplateTest()
        {
            // TODO unit test for the property 'Template'
        }

    }

}

/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.0
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
    ///  Class for testing InvitationTicket
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class InvitationTicketTests
    {
        // TODO uncomment below to declare an instance variable for InvitationTicket
        //private InvitationTicket instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of InvitationTicket
            //instance = new InvitationTicket();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvitationTicket
        /// </summary>
        [Test]
        public void InvitationTicketInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" InvitationTicket
            //Assert.IsInstanceOfType<InvitationTicket> (instance, "variable 'instance' is a InvitationTicket");
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'Token'
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO unit test for the property 'Token'
        }
        /// <summary>
        /// Test the property 'InviteeEmail'
        /// </summary>
        [Test]
        public void InviteeEmailTest()
        {
            // TODO unit test for the property 'InviteeEmail'
        }
        /// <summary>
        /// Test the property 'TargetModel'
        /// </summary>
        [Test]
        public void TargetModelTest()
        {
            // TODO unit test for the property 'TargetModel'
        }
        /// <summary>
        /// Test the property 'TargetId'
        /// </summary>
        [Test]
        public void TargetIdTest()
        {
            // TODO unit test for the property 'TargetId'
        }
        /// <summary>
        /// Test the property 'TargetAttrs'
        /// </summary>
        [Test]
        public void TargetAttrsTest()
        {
            // TODO unit test for the property 'TargetAttrs'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Created'
        /// </summary>
        [Test]
        public void CreatedTest()
        {
            // TODO unit test for the property 'Created'
        }
        /// <summary>
        /// Test the property 'Modified'
        /// </summary>
        [Test]
        public void ModifiedTest()
        {
            // TODO unit test for the property 'Modified'
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
        /// Test the property 'InviteeId'
        /// </summary>
        [Test]
        public void InviteeIdTest()
        {
            // TODO unit test for the property 'InviteeId'
        }
        /// <summary>
        /// Test the property 'InviterId'
        /// </summary>
        [Test]
        public void InviterIdTest()
        {
            // TODO unit test for the property 'InviterId'
        }
        /// <summary>
        /// Test the property 'TargetTeamId'
        /// </summary>
        [Test]
        public void TargetTeamIdTest()
        {
            // TODO unit test for the property 'TargetTeamId'
        }
        /// <summary>
        /// Test the property 'TargetTeamMemberId'
        /// </summary>
        [Test]
        public void TargetTeamMemberIdTest()
        {
            // TODO unit test for the property 'TargetTeamMemberId'
        }
        /// <summary>
        /// Test the property 'TargetPortalId'
        /// </summary>
        [Test]
        public void TargetPortalIdTest()
        {
            // TODO unit test for the property 'TargetPortalId'
        }
        /// <summary>
        /// Test the property 'TargetPortalMemberId'
        /// </summary>
        [Test]
        public void TargetPortalMemberIdTest()
        {
            // TODO unit test for the property 'TargetPortalMemberId'
        }
        /// <summary>
        /// Test the property 'TargetTemplateId'
        /// </summary>
        [Test]
        public void TargetTemplateIdTest()
        {
            // TODO unit test for the property 'TargetTemplateId'
        }
        /// <summary>
        /// Test the property 'TargetTemplateMemberId'
        /// </summary>
        [Test]
        public void TargetTemplateMemberIdTest()
        {
            // TODO unit test for the property 'TargetTemplateMemberId'
        }
        /// <summary>
        /// Test the property 'TargetImageFolderId'
        /// </summary>
        [Test]
        public void TargetImageFolderIdTest()
        {
            // TODO unit test for the property 'TargetImageFolderId'
        }
        /// <summary>
        /// Test the property 'TargetImageFolderMemberId'
        /// </summary>
        [Test]
        public void TargetImageFolderMemberIdTest()
        {
            // TODO unit test for the property 'TargetImageFolderMemberId'
        }
        /// <summary>
        /// Test the property 'Invitee'
        /// </summary>
        [Test]
        public void InviteeTest()
        {
            // TODO unit test for the property 'Invitee'
        }
        /// <summary>
        /// Test the property 'Inviter'
        /// </summary>
        [Test]
        public void InviterTest()
        {
            // TODO unit test for the property 'Inviter'
        }
        /// <summary>
        /// Test the property 'TargetTeam'
        /// </summary>
        [Test]
        public void TargetTeamTest()
        {
            // TODO unit test for the property 'TargetTeam'
        }
        /// <summary>
        /// Test the property 'TargetTeamMember'
        /// </summary>
        [Test]
        public void TargetTeamMemberTest()
        {
            // TODO unit test for the property 'TargetTeamMember'
        }
        /// <summary>
        /// Test the property 'TargetPortal'
        /// </summary>
        [Test]
        public void TargetPortalTest()
        {
            // TODO unit test for the property 'TargetPortal'
        }
        /// <summary>
        /// Test the property 'TargetPortalMember'
        /// </summary>
        [Test]
        public void TargetPortalMemberTest()
        {
            // TODO unit test for the property 'TargetPortalMember'
        }
        /// <summary>
        /// Test the property 'TargetTemplate'
        /// </summary>
        [Test]
        public void TargetTemplateTest()
        {
            // TODO unit test for the property 'TargetTemplate'
        }
        /// <summary>
        /// Test the property 'TargetTemplateMember'
        /// </summary>
        [Test]
        public void TargetTemplateMemberTest()
        {
            // TODO unit test for the property 'TargetTemplateMember'
        }
        /// <summary>
        /// Test the property 'TargetImageFolder'
        /// </summary>
        [Test]
        public void TargetImageFolderTest()
        {
            // TODO unit test for the property 'TargetImageFolder'
        }
        /// <summary>
        /// Test the property 'TargetImageFolderMember'
        /// </summary>
        [Test]
        public void TargetImageFolderMemberTest()
        {
            // TODO unit test for the property 'TargetImageFolderMember'
        }

    }

}

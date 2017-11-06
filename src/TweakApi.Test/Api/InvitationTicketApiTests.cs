/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.12
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TweakApi.Client;
using TweakApi.Api;
using TweakApi.Model;

namespace TweakApi.Test
{
    /// <summary>
    ///  Class for testing InvitationTicketApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class InvitationTicketApiTests
    {
        private InvitationTicketApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InvitationTicketApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InvitationTicketApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InvitationTicketApi
            //Assert.IsInstanceOfType(typeof(InvitationTicketApi), instance, "instance is a InvitationTicketApi");
        }

        
        /// <summary>
        /// Test InvitationTicketsChangeStreamGet
        /// </summary>
        [Test]
        public void InvitationTicketsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.InvitationTicketsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test InvitationTicketsChangeStreamPost
        /// </summary>
        [Test]
        public void InvitationTicketsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.InvitationTicketsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test InvitationTicketsCountGet
        /// </summary>
        [Test]
        public void InvitationTicketsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.InvitationTicketsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test InvitationTicketsFindOneGet
        /// </summary>
        [Test]
        public void InvitationTicketsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.InvitationTicketsFindOneGet(filter);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsGet
        /// </summary>
        [Test]
        public void InvitationTicketsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.InvitationTicketsGet(filter);
            //Assert.IsInstanceOf<List<InvitationTicket>> (response, "response is List<InvitationTicket>");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdDelete
        /// </summary>
        [Test]
        public void InvitationTicketsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.InvitationTicketsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdExistsGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.InvitationTicketsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.InvitationTicketsIdGet(id, filter);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdHead
        /// </summary>
        [Test]
        public void InvitationTicketsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.InvitationTicketsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdInviteeGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdInviteeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdInviteeGet(id, refresh);
            //Assert.IsInstanceOf<Customer> (response, "response is Customer");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdInviterGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdInviterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdInviterGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdPatch
        /// </summary>
        [Test]
        public void InvitationTicketsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsIdPatch(id, data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdPut
        /// </summary>
        [Test]
        public void InvitationTicketsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsIdPut(id, data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdReplacePost
        /// </summary>
        [Test]
        public void InvitationTicketsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsIdReplacePost(id, data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetImageFolderGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetImageFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetImageFolderGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetImageFolderMemberGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetImageFolderMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetImageFolderMemberGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetPortalGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetPortalMemberGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetPortalMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetPortalMemberGet(id, refresh);
            //Assert.IsInstanceOf<PortalMember> (response, "response is PortalMember");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetTeamGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetTeamMemberGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetTeamMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetTeamMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetTemplateGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test InvitationTicketsIdTargetTemplateMemberGet
        /// </summary>
        [Test]
        public void InvitationTicketsIdTargetTemplateMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.InvitationTicketsIdTargetTemplateMemberGet(id, refresh);
            //Assert.IsInstanceOf<TemplateMember> (response, "response is TemplateMember");
        }
        
        /// <summary>
        /// Test InvitationTicketsPatch
        /// </summary>
        [Test]
        public void InvitationTicketsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsPatch(data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsPost
        /// </summary>
        [Test]
        public void InvitationTicketsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsPost(data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsPut
        /// </summary>
        [Test]
        public void InvitationTicketsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsPut(data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void InvitationTicketsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test InvitationTicketsUpdatePost
        /// </summary>
        [Test]
        public void InvitationTicketsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test InvitationTicketsUpsertWithWherePost
        /// </summary>
        [Test]
        public void InvitationTicketsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //InvitationTicket data = null;
            //var response = instance.InvitationTicketsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
    }

}

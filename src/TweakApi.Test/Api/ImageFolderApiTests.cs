/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.6
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
    ///  Class for testing ImageFolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ImageFolderApiTests
    {
        private ImageFolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageFolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageFolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ImageFolderApi
            //Assert.IsInstanceOfType(typeof(ImageFolderApi), instance, "instance is a ImageFolderApi");
        }

        
        /// <summary>
        /// Test ImageFoldersChangeStreamGet
        /// </summary>
        [Test]
        public void ImageFoldersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImageFoldersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImageFoldersChangeStreamPost
        /// </summary>
        [Test]
        public void ImageFoldersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.ImageFoldersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test ImageFoldersCountGet
        /// </summary>
        [Test]
        public void ImageFoldersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.ImageFoldersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersFindOneGet
        /// </summary>
        [Test]
        public void ImageFoldersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImageFoldersFindOneGet(filter);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersGet
        /// </summary>
        [Test]
        public void ImageFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.ImageFoldersGet(filter);
            //Assert.IsInstanceOf<List<ImageFolder>> (response, "response is List<ImageFolder>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenCountGet
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ImageFoldersIdChildrenCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ImageFoldersIdChildrenDelete(id);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdChildrenFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdChildrenFkGet(id, fk);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersIdChildrenFkPut(id, fk, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenGet
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdChildrenGet(id, filter);
            //Assert.IsInstanceOf<List<ImageFolder>> (response, "response is List<ImageFolder>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdChildrenPost
        /// </summary>
        [Test]
        public void ImageFoldersIdChildrenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersIdChildrenPost(id, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFoldersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ImageFoldersIdExistsGet
        /// </summary>
        [Test]
        public void ImageFoldersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFoldersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersCountGet
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ImageFoldersIdFolderMembersCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ImageFoldersIdFolderMembersDelete(id);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdFolderMembersFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdFolderMembersFkGet(id, fk);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFoldersIdFolderMembersFkPut(id, fk, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersGet
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdFolderMembersGet(id, filter);
            //Assert.IsInstanceOf<List<ImageFolderMember>> (response, "response is List<ImageFolderMember>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdFolderMembersPost
        /// </summary>
        [Test]
        public void ImageFoldersIdFolderMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFoldersIdFolderMembersPost(id, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdGet
        /// </summary>
        [Test]
        public void ImageFoldersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdGet(id, filter);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdHead
        /// </summary>
        [Test]
        public void ImageFoldersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ImageFoldersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesCountGet
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ImageFoldersIdImagesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ImageFoldersIdImagesDelete(id);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdImagesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdImagesFkGet(id, fk);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Image data = null;
            //var response = instance.ImageFoldersIdImagesFkPut(id, fk, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesGet
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdImagesGet(id, filter);
            //Assert.IsInstanceOf<List<Image>> (response, "response is List<Image>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdImagesPost
        /// </summary>
        [Test]
        public void ImageFoldersIdImagesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Image data = null;
            //var response = instance.ImageFoldersIdImagesPost(id, data);
            //Assert.IsInstanceOf<Image> (response, "response is Image");
        }
        
        /// <summary>
        /// Test ImageFoldersIdInvitationTicketsFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdInvitationTicketsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdInvitationTicketsFkDelete(id, id2, fk);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test ImageFoldersIdInvitationTicketsFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdInvitationTicketsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //string fk = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdInvitationTicketsFkGet(id, id2, fk, filter);
            //Assert.IsInstanceOf<InvitationTicket> (response, "response is InvitationTicket");
        }
        
        /// <summary>
        /// Test ImageFoldersIdInvitationTicketsGet
        /// </summary>
        [Test]
        public void ImageFoldersIdInvitationTicketsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdInvitationTicketsGet(id, id2, filter);
            //Assert.IsInstanceOf<List<InvitationTicket>> (response, "response is List<InvitationTicket>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersCountGet
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ImageFoldersIdMembersCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ImageFoldersIdMembersDelete(id);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdMembersFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdMembersFkGet(id, fk);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //TeamMember data = null;
            //var response = instance.ImageFoldersIdMembersFkPut(id, fk, data);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersGet
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdMembersGet(id, filter);
            //Assert.IsInstanceOf<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersPost
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamMember data = null;
            //var response = instance.ImageFoldersIdMembersPost(id, data);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersRelFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdMembersRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersRelFkHead
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdMembersRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ImageFoldersIdMembersRelFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdMembersRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //ImageFolderMember data = null;
            //var response = instance.ImageFoldersIdMembersRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<ImageFolderMember> (response, "response is ImageFolderMember");
        }
        
        /// <summary>
        /// Test ImageFoldersIdParentGet
        /// </summary>
        [Test]
        public void ImageFoldersIdParentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImageFoldersIdParentGet(id, refresh);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPatch
        /// </summary>
        [Test]
        public void ImageFoldersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersIdPatch(id, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsCountGet
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.ImageFoldersIdPortalsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ImageFoldersIdPortalsDelete(id);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdPortalsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsFkGet
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdPortalsFkGet(id, fk);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Portal data = null;
            //var response = instance.ImageFoldersIdPortalsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsGet
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.ImageFoldersIdPortalsGet(id, filter);
            //Assert.IsInstanceOf<List<Portal>> (response, "response is List<Portal>");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsPost
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Portal data = null;
            //var response = instance.ImageFoldersIdPortalsPost(id, data);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsRelFkDelete
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.ImageFoldersIdPortalsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsRelFkHead
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.ImageFoldersIdPortalsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPortalsRelFkPut
        /// </summary>
        [Test]
        public void ImageFoldersIdPortalsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //PortalImageFolder data = null;
            //var response = instance.ImageFoldersIdPortalsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<PortalImageFolder> (response, "response is PortalImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdPut
        /// </summary>
        [Test]
        public void ImageFoldersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersIdPut(id, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdReplacePost
        /// </summary>
        [Test]
        public void ImageFoldersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersIdReplacePost(id, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersIdTeamGet
        /// </summary>
        [Test]
        public void ImageFoldersIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.ImageFoldersIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test ImageFoldersPatch
        /// </summary>
        [Test]
        public void ImageFoldersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolder data = null;
            //var response = instance.ImageFoldersPatch(data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersPost
        /// </summary>
        [Test]
        public void ImageFoldersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolder data = null;
            //var response = instance.ImageFoldersPost(data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersPut
        /// </summary>
        [Test]
        public void ImageFoldersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolder data = null;
            //var response = instance.ImageFoldersPut(data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void ImageFoldersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ImageFolder data = null;
            //var response = instance.ImageFoldersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
        /// <summary>
        /// Test ImageFoldersUpdatePost
        /// </summary>
        [Test]
        public void ImageFoldersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test ImageFoldersUpsertWithWherePost
        /// </summary>
        [Test]
        public void ImageFoldersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //ImageFolder data = null;
            //var response = instance.ImageFoldersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<ImageFolder> (response, "response is ImageFolder");
        }
        
    }

}

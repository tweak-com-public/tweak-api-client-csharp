/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 0.0.4
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
    ///  Class for testing DesignApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignApiTests
    {
        private DesignApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignApi
            //Assert.IsInstanceOfType(typeof(DesignApi), instance, "instance is a DesignApi");
        }

        
        /// <summary>
        /// Test DesignsChangeStreamGet
        /// </summary>
        [Test]
        public void DesignsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignsChangeStreamPost
        /// </summary>
        [Test]
        public void DesignsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignsCountGet
        /// </summary>
        [Test]
        public void DesignsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsFindOneGet
        /// </summary>
        [Test]
        public void DesignsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignsFindOneGet(filter);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsGet
        /// </summary>
        [Test]
        public void DesignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignsGet(filter);
            //Assert.IsInstanceOf<List<Design>> (response, "response is List<Design>");
        }
        
        /// <summary>
        /// Test DesignsIdApprovePost
        /// </summary>
        [Test]
        public void DesignsIdApprovePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //var response = instance.DesignsIdApprovePost(id, id2);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdAssigneeGet
        /// </summary>
        [Test]
        public void DesignsIdAssigneeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdAssigneeGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersCountGet
        /// </summary>
        [Test]
        public void DesignsIdCommentersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignsIdCommentersCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentersDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignsIdCommentersDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentersFkDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentersFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdCommentersFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentersFkGet
        /// </summary>
        [Test]
        public void DesignsIdCommentersFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdCommentersFkGet(id, fk);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersFkPut
        /// </summary>
        [Test]
        public void DesignsIdCommentersFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //TeamMember data = null;
            //var response = instance.DesignsIdCommentersFkPut(id, fk, data);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersGet
        /// </summary>
        [Test]
        public void DesignsIdCommentersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignsIdCommentersGet(id, filter);
            //Assert.IsInstanceOf<List<TeamMember>> (response, "response is List<TeamMember>");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersPost
        /// </summary>
        [Test]
        public void DesignsIdCommentersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamMember data = null;
            //var response = instance.DesignsIdCommentersPost(id, data);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersRelFkDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentersRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdCommentersRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentersRelFkHead
        /// </summary>
        [Test]
        public void DesignsIdCommentersRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdCommentersRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test DesignsIdCommentersRelFkPut
        /// </summary>
        [Test]
        public void DesignsIdCommentersRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignComment data = null;
            //var response = instance.DesignsIdCommentersRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsCountGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignsIdCommentsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignsIdCommentsDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentsFkDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdCommentsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentsFkGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdCommentsFkGet(id, fk);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsFkPut
        /// </summary>
        [Test]
        public void DesignsIdCommentsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignComment data = null;
            //var response = instance.DesignsIdCommentsFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignsIdCommentsGet(id, filter);
            //Assert.IsInstanceOf<List<DesignComment>> (response, "response is List<DesignComment>");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkCommenterGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkCommenterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdCommentsNkCommenterGet(id, nk, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkDesignGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkDesignGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdCommentsNkDesignGet(id, nk, refresh);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesCountGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //string where = null;
            //var response = instance.DesignsIdCommentsNkRepliesCountGet(id, nk, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //instance.DesignsIdCommentsNkRepliesDelete(id, nk);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesFkDelete
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //string fk = null;
            //instance.DesignsIdCommentsNkRepliesFkDelete(id, nk, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesFkGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //string fk = null;
            //var response = instance.DesignsIdCommentsNkRepliesFkGet(id, nk, fk);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesFkPut
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //string fk = null;
            //DesignComment data = null;
            //var response = instance.DesignsIdCommentsNkRepliesFkPut(id, nk, fk, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //string filter = null;
            //var response = instance.DesignsIdCommentsNkRepliesGet(id, nk, filter);
            //Assert.IsInstanceOf<List<DesignComment>> (response, "response is List<DesignComment>");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkRepliesPost
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkRepliesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //DesignComment data = null;
            //var response = instance.DesignsIdCommentsNkRepliesPost(id, nk, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsNkReplyOfGet
        /// </summary>
        [Test]
        public void DesignsIdCommentsNkReplyOfGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string nk = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdCommentsNkReplyOfGet(id, nk, refresh);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCommentsPost
        /// </summary>
        [Test]
        public void DesignsIdCommentsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignComment data = null;
            //var response = instance.DesignsIdCommentsPost(id, data);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdCustomerGet
        /// </summary>
        [Test]
        public void DesignsIdCustomerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdCustomerGet(id, refresh);
            //Assert.IsInstanceOf<Customer> (response, "response is Customer");
        }
        
        /// <summary>
        /// Test DesignsIdDelete
        /// </summary>
        [Test]
        public void DesignsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignsIdExistsGet
        /// </summary>
        [Test]
        public void DesignsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignsIdExportsCountGet
        /// </summary>
        [Test]
        public void DesignsIdExportsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignsIdExportsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsIdExportsDelete
        /// </summary>
        [Test]
        public void DesignsIdExportsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignsIdExportsDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignsIdExportsFkDelete
        /// </summary>
        [Test]
        public void DesignsIdExportsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdExportsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdExportsFkGet
        /// </summary>
        [Test]
        public void DesignsIdExportsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdExportsFkGet(id, fk);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignsIdExportsFkPut
        /// </summary>
        [Test]
        public void DesignsIdExportsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignExport data = null;
            //var response = instance.DesignsIdExportsFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignsIdExportsGet
        /// </summary>
        [Test]
        public void DesignsIdExportsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignsIdExportsGet(id, filter);
            //Assert.IsInstanceOf<List<DesignExport>> (response, "response is List<DesignExport>");
        }
        
        /// <summary>
        /// Test DesignsIdExportsPost
        /// </summary>
        [Test]
        public void DesignsIdExportsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignExport data = null;
            //var response = instance.DesignsIdExportsPost(id, data);
            //Assert.IsInstanceOf<DesignExport> (response, "response is DesignExport");
        }
        
        /// <summary>
        /// Test DesignsIdFolderGet
        /// </summary>
        [Test]
        public void DesignsIdFolderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdFolderGet(id, refresh);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignsIdGet
        /// </summary>
        [Test]
        public void DesignsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignsIdGet(id, filter);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdHead
        /// </summary>
        [Test]
        public void DesignsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignsIdPatch
        /// </summary>
        [Test]
        public void DesignsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Design data = null;
            //var response = instance.DesignsIdPatch(id, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdPermissionDelete
        /// </summary>
        [Test]
        public void DesignsIdPermissionDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignsIdPermissionDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignsIdPermissionGet
        /// </summary>
        [Test]
        public void DesignsIdPermissionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdPermissionGet(id, refresh);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignsIdPermissionPost
        /// </summary>
        [Test]
        public void DesignsIdPermissionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignsIdPermissionPost(id, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignsIdPermissionPut
        /// </summary>
        [Test]
        public void DesignsIdPermissionPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignPermissionSet data = null;
            //var response = instance.DesignsIdPermissionPut(id, data);
            //Assert.IsInstanceOf<DesignPermissionSet> (response, "response is DesignPermissionSet");
        }
        
        /// <summary>
        /// Test DesignsIdPortalGet
        /// </summary>
        [Test]
        public void DesignsIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test DesignsIdPut
        /// </summary>
        [Test]
        public void DesignsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Design data = null;
            //var response = instance.DesignsIdPut(id, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdRejectPost
        /// </summary>
        [Test]
        public void DesignsIdRejectPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //Design data = null;
            //var response = instance.DesignsIdRejectPost(id, id2, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdRejectionCommentGet
        /// </summary>
        [Test]
        public void DesignsIdRejectionCommentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdRejectionCommentGet(id, refresh);
            //Assert.IsInstanceOf<DesignComment> (response, "response is DesignComment");
        }
        
        /// <summary>
        /// Test DesignsIdReplacePost
        /// </summary>
        [Test]
        public void DesignsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Design data = null;
            //var response = instance.DesignsIdReplacePost(id, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdRequesterGet
        /// </summary>
        [Test]
        public void DesignsIdRequesterGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdRequesterGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdReviewerGet
        /// </summary>
        [Test]
        public void DesignsIdReviewerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdReviewerGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignsIdSubmitPost
        /// </summary>
        [Test]
        public void DesignsIdSubmitPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string id2 = null;
            //var response = instance.DesignsIdSubmitPost(id, id2);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsIdTagsCountGet
        /// </summary>
        [Test]
        public void DesignsIdTagsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignsIdTagsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignsIdTagsDelete
        /// </summary>
        [Test]
        public void DesignsIdTagsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignsIdTagsDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignsIdTagsFkDelete
        /// </summary>
        [Test]
        public void DesignsIdTagsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdTagsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdTagsFkGet
        /// </summary>
        [Test]
        public void DesignsIdTagsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdTagsFkGet(id, fk);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test DesignsIdTagsFkPut
        /// </summary>
        [Test]
        public void DesignsIdTagsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Tag data = null;
            //var response = instance.DesignsIdTagsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test DesignsIdTagsGet
        /// </summary>
        [Test]
        public void DesignsIdTagsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignsIdTagsGet(id, filter);
            //Assert.IsInstanceOf<List<Tag>> (response, "response is List<Tag>");
        }
        
        /// <summary>
        /// Test DesignsIdTagsPost
        /// </summary>
        [Test]
        public void DesignsIdTagsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Tag data = null;
            //var response = instance.DesignsIdTagsPost(id, data);
            //Assert.IsInstanceOf<Tag> (response, "response is Tag");
        }
        
        /// <summary>
        /// Test DesignsIdTagsRelFkDelete
        /// </summary>
        [Test]
        public void DesignsIdTagsRelFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignsIdTagsRelFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignsIdTagsRelFkHead
        /// </summary>
        [Test]
        public void DesignsIdTagsRelFkHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignsIdTagsRelFkHead(id, fk);
            //Assert.IsInstanceOf<bool?> (response, "response is bool?");
        }
        
        /// <summary>
        /// Test DesignsIdTagsRelFkPut
        /// </summary>
        [Test]
        public void DesignsIdTagsRelFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignTag data = null;
            //var response = instance.DesignsIdTagsRelFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignTag> (response, "response is DesignTag");
        }
        
        /// <summary>
        /// Test DesignsIdTemplateGet
        /// </summary>
        [Test]
        public void DesignsIdTemplateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignsIdTemplateGet(id, refresh);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test DesignsPatch
        /// </summary>
        [Test]
        public void DesignsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Design data = null;
            //var response = instance.DesignsPatch(data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsPost
        /// </summary>
        [Test]
        public void DesignsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Design data = null;
            //var response = instance.DesignsPost(data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsPut
        /// </summary>
        [Test]
        public void DesignsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Design data = null;
            //var response = instance.DesignsPut(data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Design data = null;
            //var response = instance.DesignsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignsUpdatePost
        /// </summary>
        [Test]
        public void DesignsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Design data = null;
            //var response = instance.DesignsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignsUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Design data = null;
            //var response = instance.DesignsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
    }

}

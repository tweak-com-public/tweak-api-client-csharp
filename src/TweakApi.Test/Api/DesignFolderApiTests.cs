/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.1-beta.1
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
    ///  Class for testing DesignFolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DesignFolderApiTests
    {
        private DesignFolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DesignFolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DesignFolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DesignFolderApi
            //Assert.IsInstanceOfType(typeof(DesignFolderApi), instance, "instance is a DesignFolderApi");
        }

        
        /// <summary>
        /// Test DesignFoldersChangeStreamGet
        /// </summary>
        [Test]
        public void DesignFoldersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignFoldersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignFoldersChangeStreamPost
        /// </summary>
        [Test]
        public void DesignFoldersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.DesignFoldersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test DesignFoldersCountGet
        /// </summary>
        [Test]
        public void DesignFoldersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.DesignFoldersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignFoldersFindOneGet
        /// </summary>
        [Test]
        public void DesignFoldersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignFoldersFindOneGet(filter);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersGet
        /// </summary>
        [Test]
        public void DesignFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.DesignFoldersGet(filter);
            //Assert.IsInstanceOf<List<DesignFolder>> (response, "response is List<DesignFolder>");
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenCountGet
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignFoldersIdChildrenCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenDelete
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignFoldersIdChildrenDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenFkDelete
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignFoldersIdChildrenFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenFkGet
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignFoldersIdChildrenFkGet(id, fk);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenFkPut
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersIdChildrenFkPut(id, fk, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenGet
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignFoldersIdChildrenGet(id, filter);
            //Assert.IsInstanceOf<List<DesignFolder>> (response, "response is List<DesignFolder>");
        }
        
        /// <summary>
        /// Test DesignFoldersIdChildrenPost
        /// </summary>
        [Test]
        public void DesignFoldersIdChildrenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersIdChildrenPost(id, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDelete
        /// </summary>
        [Test]
        public void DesignFoldersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignFoldersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsCountGet
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.DesignFoldersIdDesignsCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsDelete
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DesignFoldersIdDesignsDelete(id);
            
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsFkDelete
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.DesignFoldersIdDesignsFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsFkGet
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.DesignFoldersIdDesignsFkGet(id, fk);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsFkPut
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Design data = null;
            //var response = instance.DesignFoldersIdDesignsFkPut(id, fk, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsGet
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignFoldersIdDesignsGet(id, filter);
            //Assert.IsInstanceOf<List<Design>> (response, "response is List<Design>");
        }
        
        /// <summary>
        /// Test DesignFoldersIdDesignsPost
        /// </summary>
        [Test]
        public void DesignFoldersIdDesignsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Design data = null;
            //var response = instance.DesignFoldersIdDesignsPost(id, data);
            //Assert.IsInstanceOf<Design> (response, "response is Design");
        }
        
        /// <summary>
        /// Test DesignFoldersIdExistsGet
        /// </summary>
        [Test]
        public void DesignFoldersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignFoldersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignFoldersIdGet
        /// </summary>
        [Test]
        public void DesignFoldersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.DesignFoldersIdGet(id, filter);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdHead
        /// </summary>
        [Test]
        public void DesignFoldersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.DesignFoldersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test DesignFoldersIdMemberGet
        /// </summary>
        [Test]
        public void DesignFoldersIdMemberGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignFoldersIdMemberGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test DesignFoldersIdParentGet
        /// </summary>
        [Test]
        public void DesignFoldersIdParentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignFoldersIdParentGet(id, refresh);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdPatch
        /// </summary>
        [Test]
        public void DesignFoldersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersIdPatch(id, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdPortalGet
        /// </summary>
        [Test]
        public void DesignFoldersIdPortalGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.DesignFoldersIdPortalGet(id, refresh);
            //Assert.IsInstanceOf<Portal> (response, "response is Portal");
        }
        
        /// <summary>
        /// Test DesignFoldersIdPut
        /// </summary>
        [Test]
        public void DesignFoldersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersIdPut(id, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersIdReplacePost
        /// </summary>
        [Test]
        public void DesignFoldersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersIdReplacePost(id, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersPatch
        /// </summary>
        [Test]
        public void DesignFoldersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignFolder data = null;
            //var response = instance.DesignFoldersPatch(data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersPost
        /// </summary>
        [Test]
        public void DesignFoldersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignFolder data = null;
            //var response = instance.DesignFoldersPost(data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersPut
        /// </summary>
        [Test]
        public void DesignFoldersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignFolder data = null;
            //var response = instance.DesignFoldersPut(data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void DesignFoldersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DesignFolder data = null;
            //var response = instance.DesignFoldersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
        /// <summary>
        /// Test DesignFoldersUpdatePost
        /// </summary>
        [Test]
        public void DesignFoldersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test DesignFoldersUpsertWithWherePost
        /// </summary>
        [Test]
        public void DesignFoldersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //DesignFolder data = null;
            //var response = instance.DesignFoldersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<DesignFolder> (response, "response is DesignFolder");
        }
        
    }

}

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
    ///  Class for testing TeamTemplateFolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeamTemplateFolderApiTests
    {
        private TeamTemplateFolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamTemplateFolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamTemplateFolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamTemplateFolderApi
            //Assert.IsInstanceOfType(typeof(TeamTemplateFolderApi), instance, "instance is a TeamTemplateFolderApi");
        }

        
        /// <summary>
        /// Test TeamTemplateFoldersChangeStreamGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamTemplateFoldersChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersChangeStreamPost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.TeamTemplateFoldersChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersCountGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.TeamTemplateFoldersCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersFindOneGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamTemplateFoldersFindOneGet(filter);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.TeamTemplateFoldersGet(filter);
            //Assert.IsInstanceOf<List<TeamTemplateFolder>> (response, "response is List<TeamTemplateFolder>");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenCountGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.TeamTemplateFoldersIdChildrenCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenDelete
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.TeamTemplateFoldersIdChildrenDelete(id);
            
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenFkDelete
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TeamTemplateFoldersIdChildrenFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenFkGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TeamTemplateFoldersIdChildrenFkGet(id, fk);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenFkPut
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersIdChildrenFkPut(id, fk, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamTemplateFoldersIdChildrenGet(id, filter);
            //Assert.IsInstanceOf<List<TeamTemplateFolder>> (response, "response is List<TeamTemplateFolder>");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdChildrenPost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdChildrenPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersIdChildrenPost(id, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdDelete
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamTemplateFoldersIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdExistsGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamTemplateFoldersIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamTemplateFoldersIdGet(id, filter);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdHead
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.TeamTemplateFoldersIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdParentGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdParentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamTemplateFoldersIdParentGet(id, refresh);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdPatch
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersIdPatch(id, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdPut
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersIdPut(id, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdReplacePost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersIdReplacePost(id, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTeamGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.TeamTemplateFoldersIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesCountGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.TeamTemplateFoldersIdTemplatesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesDelete
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.TeamTemplateFoldersIdTemplatesDelete(id);
            
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesFkDelete
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.TeamTemplateFoldersIdTemplatesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesFkGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.TeamTemplateFoldersIdTemplatesFkGet(id, fk);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesFkPut
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Template data = null;
            //var response = instance.TeamTemplateFoldersIdTemplatesFkPut(id, fk, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesGet
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.TeamTemplateFoldersIdTemplatesGet(id, filter);
            //Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersIdTemplatesPost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersIdTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Template data = null;
            //var response = instance.TeamTemplateFoldersIdTemplatesPost(id, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersPatch
        /// </summary>
        [Test]
        public void TeamTemplateFoldersPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersPatch(data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersPost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersPost(data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersPut
        /// </summary>
        [Test]
        public void TeamTemplateFoldersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersPut(data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersReplaceOrCreatePost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersUpdatePost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test TeamTemplateFoldersUpsertWithWherePost
        /// </summary>
        [Test]
        public void TeamTemplateFoldersUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //TeamTemplateFolder data = null;
            //var response = instance.TeamTemplateFoldersUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<TeamTemplateFolder> (response, "response is TeamTemplateFolder");
        }
        
    }

}

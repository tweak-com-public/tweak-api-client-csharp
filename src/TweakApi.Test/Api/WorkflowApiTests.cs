/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.2-alpha.10
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
    ///  Class for testing WorkflowApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkflowApiTests
    {
        private WorkflowApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkflowApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkflowApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkflowApi
            //Assert.IsInstanceOfType(typeof(WorkflowApi), instance, "instance is a WorkflowApi");
        }

        
        /// <summary>
        /// Test WorkflowsChangeStreamGet
        /// </summary>
        [Test]
        public void WorkflowsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.WorkflowsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test WorkflowsChangeStreamPost
        /// </summary>
        [Test]
        public void WorkflowsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.WorkflowsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test WorkflowsCountGet
        /// </summary>
        [Test]
        public void WorkflowsCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //var response = instance.WorkflowsCountGet(where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test WorkflowsFindOneGet
        /// </summary>
        [Test]
        public void WorkflowsFindOneGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.WorkflowsFindOneGet(filter);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsGet
        /// </summary>
        [Test]
        public void WorkflowsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //var response = instance.WorkflowsGet(filter);
            //Assert.IsInstanceOf<List<Workflow>> (response, "response is List<Workflow>");
        }
        
        /// <summary>
        /// Test WorkflowsIdCreatorGet
        /// </summary>
        [Test]
        public void WorkflowsIdCreatorGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.WorkflowsIdCreatorGet(id, refresh);
            //Assert.IsInstanceOf<TeamMember> (response, "response is TeamMember");
        }
        
        /// <summary>
        /// Test WorkflowsIdDelete
        /// </summary>
        [Test]
        public void WorkflowsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WorkflowsIdDelete(id);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test WorkflowsIdExistsGet
        /// </summary>
        [Test]
        public void WorkflowsIdExistsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WorkflowsIdExistsGet(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test WorkflowsIdGet
        /// </summary>
        [Test]
        public void WorkflowsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.WorkflowsIdGet(id, filter);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsIdHead
        /// </summary>
        [Test]
        public void WorkflowsIdHeadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.WorkflowsIdHead(id);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test WorkflowsIdPatch
        /// </summary>
        [Test]
        public void WorkflowsIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Workflow data = null;
            //var response = instance.WorkflowsIdPatch(id, data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsIdPut
        /// </summary>
        [Test]
        public void WorkflowsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Workflow data = null;
            //var response = instance.WorkflowsIdPut(id, data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsIdReplacePost
        /// </summary>
        [Test]
        public void WorkflowsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Workflow data = null;
            //var response = instance.WorkflowsIdReplacePost(id, data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsIdTeamGet
        /// </summary>
        [Test]
        public void WorkflowsIdTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? refresh = null;
            //var response = instance.WorkflowsIdTeamGet(id, refresh);
            //Assert.IsInstanceOf<Team> (response, "response is Team");
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesCountGet
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesCountGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string where = null;
            //var response = instance.WorkflowsIdTemplatesCountGet(id, where);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesDelete
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.WorkflowsIdTemplatesDelete(id);
            
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesFkDelete
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesFkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //instance.WorkflowsIdTemplatesFkDelete(id, fk);
            
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesFkGet
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesFkGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //var response = instance.WorkflowsIdTemplatesFkGet(id, fk);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesFkPut
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesFkPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fk = null;
            //Template data = null;
            //var response = instance.WorkflowsIdTemplatesFkPut(id, fk, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesGet
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string filter = null;
            //var response = instance.WorkflowsIdTemplatesGet(id, filter);
            //Assert.IsInstanceOf<List<Template>> (response, "response is List<Template>");
        }
        
        /// <summary>
        /// Test WorkflowsIdTemplatesPost
        /// </summary>
        [Test]
        public void WorkflowsIdTemplatesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Template data = null;
            //var response = instance.WorkflowsIdTemplatesPost(id, data);
            //Assert.IsInstanceOf<Template> (response, "response is Template");
        }
        
        /// <summary>
        /// Test WorkflowsPatch
        /// </summary>
        [Test]
        public void WorkflowsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Workflow data = null;
            //var response = instance.WorkflowsPatch(data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsPost
        /// </summary>
        [Test]
        public void WorkflowsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Workflow data = null;
            //var response = instance.WorkflowsPost(data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsPut
        /// </summary>
        [Test]
        public void WorkflowsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Workflow data = null;
            //var response = instance.WorkflowsPut(data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void WorkflowsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Workflow data = null;
            //var response = instance.WorkflowsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
        /// <summary>
        /// Test WorkflowsUpdatePost
        /// </summary>
        [Test]
        public void WorkflowsUpdatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Workflow data = null;
            //var response = instance.WorkflowsUpdatePost(where, data);
            //Assert.IsInstanceOf<InlineResponse2002> (response, "response is InlineResponse2002");
        }
        
        /// <summary>
        /// Test WorkflowsUpsertWithWherePost
        /// </summary>
        [Test]
        public void WorkflowsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Workflow data = null;
            //var response = instance.WorkflowsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Workflow> (response, "response is Workflow");
        }
        
    }

}

/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.8-alpha.13
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
    ///  Class for testing PublicVTeamMemberApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicVTeamMemberApiTests
    {
        private PublicVTeamMemberApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicVTeamMemberApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicVTeamMemberApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicVTeamMemberApi
            //Assert.IsInstanceOfType(typeof(PublicVTeamMemberApi), instance, "instance is a PublicVTeamMemberApi");
        }

        
        /// <summary>
        /// Test V1TeamMembersLoginPost
        /// </summary>
        [Test]
        public void V1TeamMembersLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string portalId = null;
            //var response = instance.V1TeamMembersLoginPost(id, portalId);
            //Assert.IsInstanceOf<TeamMemberAccessToken> (response, "response is TeamMemberAccessToken");
        }
        
        /// <summary>
        /// Test V1TeamMembersLogoutPost
        /// </summary>
        [Test]
        public void V1TeamMembersLogoutPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.V1TeamMembersLogoutPost();
            
        }
        
        /// <summary>
        /// Test V1TeamMembersPost
        /// </summary>
        [Test]
        public void V1TeamMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PublicV1TeamMember data = null;
            //var response = instance.V1TeamMembersPost(data);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}

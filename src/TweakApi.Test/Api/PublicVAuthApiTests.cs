/* 
 * tweak-api
 *
 * Tweak API to integrate with all the Tweak services.  You can find out more about Tweak      at <a href='https://www.tweak.com'>https://www.tweak.com</a>, #tweak.
 *
 * OpenAPI spec version: 1.0.3-beta.2
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
    ///  Class for testing PublicVAuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PublicVAuthApiTests
    {
        private PublicVAuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicVAuthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicVAuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PublicVAuthApi
            //Assert.IsInstanceOfType(typeof(PublicVAuthApi), instance, "instance is a PublicVAuthApi");
        }

        
        /// <summary>
        /// Test V1AuthValidateGet
        /// </summary>
        [Test]
        public void V1AuthValidateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.V1AuthValidateGet();
            //Assert.IsInstanceOf<TeamMemberAccessToken> (response, "response is TeamMemberAccessToken");
        }
        
    }

}

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
    ///  Class for testing BillingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingApiTests
    {
        private BillingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingApi
            //Assert.IsInstanceOfType(typeof(BillingApi), instance, "instance is a BillingApi");
        }

        
        /// <summary>
        /// Test BillingsChangeStreamGet
        /// </summary>
        [Test]
        public void BillingsChangeStreamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.BillingsChangeStreamGet(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test BillingsChangeStreamPost
        /// </summary>
        [Test]
        public void BillingsChangeStreamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string options = null;
            //var response = instance.BillingsChangeStreamPost(options);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test BillingsCountriesGet
        /// </summary>
        [Test]
        public void BillingsCountriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BillingsCountriesGet();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test BillingsIdPut
        /// </summary>
        [Test]
        public void BillingsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Billing data = null;
            //var response = instance.BillingsIdPut(id, data);
            //Assert.IsInstanceOf<Billing> (response, "response is Billing");
        }
        
        /// <summary>
        /// Test BillingsIdReplacePost
        /// </summary>
        [Test]
        public void BillingsIdReplacePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Billing data = null;
            //var response = instance.BillingsIdReplacePost(id, data);
            //Assert.IsInstanceOf<Billing> (response, "response is Billing");
        }
        
        /// <summary>
        /// Test BillingsPut
        /// </summary>
        [Test]
        public void BillingsPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Billing data = null;
            //var response = instance.BillingsPut(data);
            //Assert.IsInstanceOf<Billing> (response, "response is Billing");
        }
        
        /// <summary>
        /// Test BillingsReplaceOrCreatePost
        /// </summary>
        [Test]
        public void BillingsReplaceOrCreatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Billing data = null;
            //var response = instance.BillingsReplaceOrCreatePost(data);
            //Assert.IsInstanceOf<Billing> (response, "response is Billing");
        }
        
        /// <summary>
        /// Test BillingsUpsertWithWherePost
        /// </summary>
        [Test]
        public void BillingsUpsertWithWherePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //Billing data = null;
            //var response = instance.BillingsUpsertWithWherePost(where, data);
            //Assert.IsInstanceOf<Billing> (response, "response is Billing");
        }
        
    }

}

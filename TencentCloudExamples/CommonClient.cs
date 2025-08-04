/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloudExamples
{
    public class CommonClient
    {
        public static void Run(string[] args)
        {
            var client = BuildClient();

            // Demonstrate how to build a CommonRequest from a JSON string
            JsonStrRequest(client).Wait();

            // Demonstrate how to build a CommonRequest from a Dictionary
            DictionaryRequest(client).Wait();

            // Demonstrate how to customize the Request type
            CustomRequest(client).Wait();

            // Demonstrate how to customize the Response type
            CustomResponse(client).Wait();
        }

        static async Task JsonStrRequest(TencentCloud.Common.CommonClient client)
        {
            var limit = 1;
            var filterName = "zone";
            var filterValue = "ap-guangzhou-1";
            var reqJson = $@"
    {{
        ""Limit"": {limit},
        ""Filters"": [
            {{
                ""Name"": ""{filterName}"",
                ""Values"":[""{filterValue}""]
            }}
        ]
    }}
";
            var rep = await client.CallAsync(new CommonRequest(reqJson), "DescribeInstances");
            Console.WriteLine(rep);
        }

        static async Task DictionaryRequest(TencentCloud.Common.CommonClient client)
        {
            var reqDict = new Dictionary<string, object>
            {
                { "Limit", 1 },
                {
                    "Filters", new List<object>
                    {
                        new Dictionary<string, object>
                        {
                            { "Name", "zone" },
                            { "Values", new List<string> { "ap-guangzhou-1" } }
                        }
                    }
                }
            };
            var rep = await client.CallAsync(new CommonRequest(reqDict), "DescribeInstances");
            Console.WriteLine(rep);
        }


        class DescribeInstancesReq
        {
            internal class Filter
            {
                public string Name;
                public string[] Values;
            }

            public string[] InstanceIds;
            public Filter[] Filters;
            public int Offset;
            public int Limit;
        }

        static async Task CustomRequest(TencentCloud.Common.CommonClient client)
        {
            var req = new CommonRequest(
                new DescribeInstancesReq
                {
                    Filters = new[]
                    {
                        new DescribeInstancesReq.Filter
                        {
                            Name = "zone",
                            Values = new[] { "ap-guangzhou-1" }
                        }
                    },
                    Limit = 5,
                    Offset = 0,
                }
            );

            var rep = await client.CallAsync(req, "DescribeInstances");
            Console.WriteLine(rep);
        }

        class DescribeInstancesRep
        {
            public string RequestId;
            public int TotalCount;
            public JArray ZoneSet;
        }

        static async Task CustomResponse(TencentCloud.Common.CommonClient client)
        {
            var req = new CommonRequest("{}");
            var rep = await client.CallAsync<DescribeInstancesRep>(req, "DescribeZones");
            Console.WriteLine(JsonConvert.SerializeObject(rep));
        }

        static TencentCloud.Common.CommonClient BuildClient()
        {
            // Mandatory steps:
            // Instantiate an authentication object. You need to pass your Tencent Cloud account's secretId and secretKey as parameters.
            // This example reads them from environment variables. You need to set these two values in your environment first.
            // You can also hardcode the key pair directly in your code, but be careful not to copy, upload, or share the code with others
            // to avoid leaking the key pair and jeopardizing your assets.
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            // Instantiate a client profile object (optional; can be skipped if there are no special requirements).
            ClientProfile clientProfile = new ClientProfile();
            // Specify the signing algorithm (default is HmacSHA256).
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            // Optional step:
            // Instantiate a client configuration object, which allows you to set the timeout period and other configurations.
            HttpProfile httpProfile = new HttpProfile();
            // The SDK defaults to using the POST method.
            // If you must use the GET method, you can set it here. The GET method cannot handle some larger requests.
            httpProfile.ReqMethod = "GET";
            // The SDK has a default timeout period. Do not adjust it unless necessary.
            // If you need to, please check the code for the latest default value.
            httpProfile.Timeout = 10; // Request connection timeout, in seconds (default is 60 seconds).
            // The SDK automatically specifies the domain name. It is usually not necessary to specify a domain name, but if you are accessing a service in a financial zone,
            // you must manually specify the domain name, for example, for a CVM in the Shanghai financial zone: cvm.ap-shanghai-fsi.tencentcloudapi.com
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            // Proxy server; set this if you are in an environment with a proxy server.
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            // Instantiate the client object for the product you want to request (using CVM as an example).
            // The second parameter is the region information, which can be a string like "ap-guangzhou" or a predefined constant. clientProfile is optional.
            return new TencentCloud.Common.CommonClient(
                "cvm", "2017-03-12", cred, "ap-guangzhou", clientProfile);
        }
    }
}
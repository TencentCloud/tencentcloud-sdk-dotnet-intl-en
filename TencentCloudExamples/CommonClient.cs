
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

            // Demonstrate how to build a CommonRequest via JsonString
            JsonStrRequest(client).Wait();

            // Demonstrate how to build a CommonRequest via Dictionary
            DictionaryRequest(client).Wait();

            // Demonstrate how to customize the Request type
            CustomRequest(client).Wait();

            // Demonstrate how to customize the Response type
            CustomResponse(client).Wait();
        }

        static async Task JsonStrRequest(TencentCloud.Common.CommonClient client)
        {
            var limit       = 1;
            var filterName  = "zone";
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
                public string   Name;
                public string[] Values;
            }

            public string[] InstanceIds;
            public Filter[] Filters;
            public int      Offset;
            public int      Limit;
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
                            Name   = "zone",
                            Values = new[] { "ap-guangzhou-1" }
                        }
                    },
                    Limit  = 5,
                    Offset = 0,
                }
            );

            var rep = await client.CallAsync(req, "DescribeInstances");
            Console.WriteLine(rep);
        }

        class DescribeInstancesRep
        {
            public string RequestId;
            public int    TotalCount;
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
            // Essential step:
            // Instantiate an authentication object, which requires the Tencent Cloud account key pair
            // secretId and secretKey as input parameters.
            // Here, we read them from environment variables, so these two values need to be set
            // in the environment variables first.
            // You can also hardcode the key pair directly in the code, but be careful not to copy,
            // upload, or share the code with others,
            // to avoid exposing the key pair and jeopardizing your property security.
            var cred = new Credential
            {
                SecretId  = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            // Instantiate a client option, which is optional. You can skip it if there are no special requirements.
            ClientProfile clientProfile = new ClientProfile();
            // Specify the signature algorithm (default is HmacSHA256)
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            // Non-essential step
            // Instantiate a client configuration object, which allows specifying configurations like timeout.
            HttpProfile httpProfile = new HttpProfile();
            // The SDK uses the POST method by default.
            // If you must use the GET method, you can set it here. The GET method cannot handle some larger requests.
            httpProfile.ReqMethod = "GET";
            // The SDK has a default timeout. Please do not adjust it unless necessary.
            // If needed, check the code for the latest default value.
            httpProfile.Timeout = 10; // Request connection timeout, in seconds (default is 60 seconds)
            // The SDK will automatically specify the domain name. It is usually not necessary to specify the domain name,
            // but if you are accessing a service in the financial region,
            // you must manually specify the domain name, for example, the domain name for CVM in the Shanghai Financial Region: cvm.ap-shanghai-fsi.tencentcloudapi.com
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            // Proxy server, set this if you have a proxy server in your environment
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            // Instantiate the client object for the product to be requested (taking cvm as an example)
            // The second parameter is region information, which can be a string like ap-guangzhou or a predefined constant. clientProfile is optional.
            return new TencentCloud.Common.CommonClient(
                "cvm", "2017-03-12", cred, "ap-guangzhou", clientProfile);
        }
    }
}

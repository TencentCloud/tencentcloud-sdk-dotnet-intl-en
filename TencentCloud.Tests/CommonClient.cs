/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloud.Tests
{
    [TestClass]
    public sealed class CommonClient
    {
        [TestMethod]
        public async Task TestJsonStrRequest()
        {
            var client = CreateClient();

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

        static async Task TestDictionaryRequest(TencentCloud.Common.CommonClient client)
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

        [TestMethod]
        public async Task TestCustomRequest()
        {
            var client = CreateClient();
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

        [TestMethod]
        public async Task TestCustomResponse()
        {
            var client = CreateClient();
            var req = new CommonRequest("{}");
            var rep = await client.CallAsync<DescribeInstancesRep>(req, "DescribeZones");
            Console.WriteLine(JsonConvert.SerializeObject(rep));
        }

        private TencentCloud.Common.CommonClient CreateClient()
        {
            // Necessary steps:
            // Instantiate an authentication object.
            // The input parameters need to be the Tencent Cloud account key pair secretId and secretKey.
            // The method used here is to read from environment variables,
            // and these two values need to be set in the environment variables first.
            // You can also write the key pair directly in the code, but be careful not to copy, upload or share the code with others.
            // To avoid disclosing the key pair and endangering the security of your property.
            var cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            // Instantiate a ClientProfile, optional, can be skipped if there are no special requirements
            ClientProfile clientProfile = new ClientProfile();
            // Specify the signature algorithm (default is HmacSHA256)
            clientProfile.SignMethod = ClientProfile.SIGN_TC3SHA256;
            // Optional
            // Instantiate a client configuration object, which can specify configurations such as timeout and so on.
            HttpProfile httpProfile = new HttpProfile();
            // The SDK uses the POST method by default.
            // If you must use the GET method, you can set it here. The GET method cannot handle some larger requests.
            httpProfile.ReqMethod = "GET";
            // The SDK has a default timeout, please do not adjust it unless necessary.
            // Check in the code for the latest default values if necessary.
            httpProfile.Timeout = 10; // 请求连接超时时间，单位为秒(默认60秒)
            // The SDK will automatically specify the domain name.
            // Usually there is no need to specify a domain name,
            // but if you are accessing services in the financial district,
            // You must manually specify the domain name, for example,
            // the Shanghai financial region name of the cloud server: cvm.ap-shanghai-fsi.tencentcloudapi.com
            httpProfile.Endpoint = "cvm.tencentcloudapi.com";
            // Proxy server, set when there is a proxy server in your environment
            httpProfile.WebProxy = Environment.GetEnvironmentVariable("HTTPS_PROXY");

            clientProfile.HttpProfile = httpProfile;

            // Instantiate the client object to request the product (take cvm as an example)
            // The second parameter is regional information. You can directly fill in the string ap-guangzhou,
            // or refer to the preset constants. clientProfile is optional.
            return new TencentCloud.Common.CommonClient(
                "cvm", "2017-03-12", cred, "ap-guangzhou", clientProfile);
        }
    }
}
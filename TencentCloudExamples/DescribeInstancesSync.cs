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
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Cvm.V20170312;
using TencentCloud.Cvm.V20170312.Models;

namespace TencentCloudExamples
{
    public class DescribeInstancesSync
    {
        public static void Run(string[] args)
        {
            try
            {
                // Essential step:
                // Instantiate an authentication object, which requires the Tencent Cloud account key pair
                // secretId and secretKey as input parameters.
                // Here, we read them from environment variables, so these two values need to be set
                // in the environment variables first.
                // You can also hardcode the key pair directly in the code, but be careful not to copy,
                // upload, or share the code with others,
                // to avoid exposing the key pair and jeopardizing your property security.
                Credential cred = new Credential
                {
                    SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
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
                CvmClient client = new CvmClient(cred, "ap-guangzhou", clientProfile);

                // Instantiate a request object. Request parameters can be further set according to the called interface and actual situation.
                // You can directly check the SDK source code to determine which properties of DescribeInstancesRequest can be set.
                // Properties may be basic types or refer to another data structure.
                // It is recommended to use an IDE for development, as it allows for easy jumping to and viewing of the documentation for various interfaces and data structures.
                DescribeInstancesRequest req = new DescribeInstancesRequest();

                // Setting basic types.
                // This interface allows setting the number of instances to return. Here, it is specified to return only one.
                // The SDK uses a pointer-style to specify parameters, even for basic types you need to use a pointer to assign a value to the parameter.
                // The SDK provides wrapper functions for pointer references of basic types.
                req.Limit = 1;
                // Setting array types.
                // This interface allows specifying instance IDs for filtering, but it is commented out for now because it conflicts with the Filter parameter demonstration below.
                // req.InstanceIds = new string[] { "ins-r8hr2upy" };

                // Setting complex objects.
                // In this interface, Filters is an array, the elements of the array are the complex object Filter, and the member Values of Filter is a string array.
                // Populate the request parameters. The member variables of the request object correspond to the input parameters of the interface.
                // You can view the definition of request parameters through the official interface documentation or by navigating to the definition of the request object.
                Filter zoneFilter = new Filter(); // Create a Filter object to query cvm instances by zone dimension
                zoneFilter.Name = "zone";
                zoneFilter.Values = new string[] { "ap-guangzhou-1", "ap-guangzhou-2" };
                Filter nameFilter = new Filter();
                nameFilter.Name = "instance-name";
                nameFilter.Values = new string[] { "中文测试" };
                req.Filters = new Filter[] { zoneFilter, nameFilter }; // Filters is a list whose members are Filter objects

                //// It also supports assigning request parameters using a standard JSON format string. The code below is equivalent to the parameter assignment above.
                //string strParams = "{\"Filters\":[{\"Name\":\"zone\",\"Values\":[\"ap-guangzhou-1\",\"ap-guangzhou-2\"]}]}";
                //req = DescribeInstancesRequest.FromJsonString<DescribeInstancesRequest>(strParams);

                // Call the DescribeInstancesSync method via the client object to initiate the request. Note that the request method name corresponds to the request object.
                // The returned resp is an instance of the DescribeInstancesResponse class, corresponding to the request object.
                DescribeInstancesResponse resp = client.DescribeInstancesSync(req);

                // Output the JSON format response string
                Console.WriteLine(AbstractModel.ToJsonString(resp));

                // You can also retrieve individual values.
                // You can view the definition of the returned fields through the official interface documentation or by navigating to the definition of the response object.
                Console.WriteLine(resp.TotalCount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.Read();
        }
    }
}

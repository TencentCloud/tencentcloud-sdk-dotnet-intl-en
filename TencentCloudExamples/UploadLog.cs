/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

using System;
using Cls;
using Google.Protobuf;
using TencentCloud.Cls.V20201016;
using TencentCloud.Cls.V20201016.Models;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloudExamples
{
    class UploadLog
    {
        static void UploadLogMain(string[] args)
        {
            // The customer's actual topicId needs to be used here, and topicname cannot be entered.
            // For details, please refer to: https://www.tencentcloud.com/document/product/614/42787?lang=en
            string topicId = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            // It needs to be filled in according to the actual region of the customer.
            string region = "xx";

            Credential cred = new Credential
            {
                SecretId = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_ID"),
                SecretKey = Environment.GetEnvironmentVariable("TENCENTCLOUD_SECRET_KEY")
            };

            ClientProfile clientProfile = new ClientProfile();
            HttpProfile httpProfile = new HttpProfile();
            // UploadLog must use the POST request method
            httpProfile.ReqMethod = "POST";
            clientProfile.HttpProfile = httpProfile;

            ClsClient client = new ClsClient(cred, region, clientProfile);

            UploadLogRequest req = new UploadLogRequest();

            req.TopicId = topicId;
            // Set binary data through OctetBody
            req.OctetBody = BuildLogBody();

            UploadLogResponse resp = client.UploadLog(req).Result;

            // Output string return packet in json format
            Console.WriteLine(AbstractModel.ToJsonString(resp));
        }


        static byte[] BuildLogBody()
        {
            Log log = new Log();
            log.Time = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();

            Log.Types.Content content = new Log.Types.Content();
            content.Key = "log-key";
            content.Value = "log-value";
            log.Contents.Add(content);

            LogGroup group = new LogGroup();

            LogGroupList list = new LogGroupList();
            list.LogGroupList_.Add(group);
            
            return list.ToByteArray();
        }
    }
}
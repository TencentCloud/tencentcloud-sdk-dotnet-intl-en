﻿/*
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
using System.Threading.Tasks;
using TencentCloud.Common.Profile;

namespace TencentCloud.Common
{
    public class CommonClient : AbstractClient
    {
        public CommonClient(
            string module, string version, Credential credential, string region, ClientProfile profile)
            : base(module + ".tencentcloudapi.com", version, credential, region, profile)
        {
        }

        public Task<string> CallAsync(CommonRequest req, string action)
        {
            return InternalRequest(req, action);
        }

        public Task<TRep> CallAsync<TRep>(CommonRequest req, string action)
        {
            return InternalRequest(req, action)
                .ContinueWith(
                    task => JsonConvert.DeserializeObject<JsonResponseModel<TRep>>(task.Result).Response
                );
        }

        public string Call(CommonRequest req, string action)
        {
            return CallAsync(req, action).Result;
        }

        public TRep Call<TRep>(CommonRequest req, string action)
        {
            return CallAsync<TRep>(req, action).Result;
        }
    }
}
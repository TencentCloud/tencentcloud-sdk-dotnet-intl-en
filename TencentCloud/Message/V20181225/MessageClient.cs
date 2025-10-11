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

namespace TencentCloud.Message.V20181225
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Message.V20181225.Models;

   public class MessageClient : AbstractClient{

       private const string endpoint = "message.intl.tencentcloudapi.com";
       private const string version = "2018-12-25";
       private const string sdkVersion = "SDK_NET_3.0.1221";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MessageClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MessageClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to batch modify delivery methods.
        /// </summary>
        /// <param name="req"><see cref="ModifySendChannelOnMsgTypesRequest"/></param>
        /// <returns><see cref="ModifySendChannelOnMsgTypesResponse"/></returns>
        public Task<ModifySendChannelOnMsgTypesResponse> ModifySendChannelOnMsgTypes(ModifySendChannelOnMsgTypesRequest req)
        {
            return InternalRequestAsync<ModifySendChannelOnMsgTypesResponse>(req, "ModifySendChannelOnMsgTypes");
        }

        /// <summary>
        /// This API is used to batch modify delivery methods.
        /// </summary>
        /// <param name="req"><see cref="ModifySendChannelOnMsgTypesRequest"/></param>
        /// <returns><see cref="ModifySendChannelOnMsgTypesResponse"/></returns>
        public ModifySendChannelOnMsgTypesResponse ModifySendChannelOnMsgTypesSync(ModifySendChannelOnMsgTypesRequest req)
        {
            return InternalRequestAsync<ModifySendChannelOnMsgTypesResponse>(req, "ModifySendChannelOnMsgTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

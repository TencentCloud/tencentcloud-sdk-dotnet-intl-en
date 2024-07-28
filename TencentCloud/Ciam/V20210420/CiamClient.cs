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

namespace TencentCloud.Ciam.V20210420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ciam.V20210420.Models;

   public class CiamClient : AbstractClient{

       private const string endpoint = "ciam.tencentcloudapi.com";
       private const string version = "2021-04-20";
       private const string sdkVersion = "SDK_NET_3.0.949";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CiamClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CiamClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to list user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public Task<ListUserGroupsResponse> ListUserGroups(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups");
        }

        /// <summary>
        /// This API is used to list user groups.
        /// </summary>
        /// <param name="req"><see cref="ListUserGroupsRequest"/></param>
        /// <returns><see cref="ListUserGroupsResponse"/></returns>
        public ListUserGroupsResponse ListUserGroupsSync(ListUserGroupsRequest req)
        {
            return InternalRequestAsync<ListUserGroupsResponse>(req, "ListUserGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

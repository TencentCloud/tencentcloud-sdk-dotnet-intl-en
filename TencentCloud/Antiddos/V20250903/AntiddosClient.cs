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

namespace TencentCloud.Antiddos.V20250903
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Antiddos.V20250903.Models;

   public class AntiddosClient : AbstractClient{

       private const string endpoint = "antiddos.intl.tencentcloudapi.com";
       private const string version = "2025-09-03";
       private const string sdkVersion = "SDK_NET_3.0.1352";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AntiddosClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AntiddosClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Query block unblock records and unblocking quota info.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public Task<DescribeDDoSBlockRecordsResponse> DescribeDDoSBlockRecords(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords");
        }

        /// <summary>
        /// Query block unblock records and unblocking quota info.
        /// </summary>
        /// <param name="req"><see cref="DescribeDDoSBlockRecordsRequest"/></param>
        /// <returns><see cref="DescribeDDoSBlockRecordsResponse"/></returns>
        public DescribeDDoSBlockRecordsResponse DescribeDDoSBlockRecordsSync(DescribeDDoSBlockRecordsRequest req)
        {
            return InternalRequestAsync<DescribeDDoSBlockRecordsResponse>(req, "DescribeDDoSBlockRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Apply for unblocking resources. You can obtain the unblocking status of resources through the DescribeDDoSBlockRecords API.
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public Task<UnblockResourcesResponse> UnblockResources(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources");
        }

        /// <summary>
        /// Apply for unblocking resources. You can obtain the unblocking status of resources through the DescribeDDoSBlockRecords API.
        /// </summary>
        /// <param name="req"><see cref="UnblockResourcesRequest"/></param>
        /// <returns><see cref="UnblockResourcesResponse"/></returns>
        public UnblockResourcesResponse UnblockResourcesSync(UnblockResourcesRequest req)
        {
            return InternalRequestAsync<UnblockResourcesResponse>(req, "UnblockResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

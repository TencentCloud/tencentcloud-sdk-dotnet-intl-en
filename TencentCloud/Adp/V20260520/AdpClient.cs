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

namespace TencentCloud.Adp.V20260520
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Adp.V20260520.Models;

   public class AdpClient : AbstractClient{

       private const string endpoint = "adp.intl.tencentcloudapi.com";
       private const string version = "2026-05-20";
       private const string sdkVersion = "SDK_NET_3.0.1417";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Knowledge retrieval
        /// </summary>
        /// <param name="req"><see cref="SearchKnowledgeRequest"/></param>
        /// <returns><see cref="SearchKnowledgeResponse"/></returns>
        public Task<SearchKnowledgeResponse> SearchKnowledge(SearchKnowledgeRequest req)
        {
            return InternalRequestAsync<SearchKnowledgeResponse>(req, "SearchKnowledge");
        }

        /// <summary>
        /// Knowledge retrieval
        /// </summary>
        /// <param name="req"><see cref="SearchKnowledgeRequest"/></param>
        /// <returns><see cref="SearchKnowledgeResponse"/></returns>
        public SearchKnowledgeResponse SearchKnowledgeSync(SearchKnowledgeRequest req)
        {
            return InternalRequestAsync<SearchKnowledgeResponse>(req, "SearchKnowledge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

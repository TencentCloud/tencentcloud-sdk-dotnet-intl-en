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

namespace TencentCloud.Advisor.V20200721
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Advisor.V20200721.Models;

   public class AdvisorClient : AbstractClient{

       private const string endpoint = "advisor.intl.tencentcloudapi.com";
       private const string version = "2020-07-21";
       private const string sdkVersion = "SDK_NET_3.0.1164";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AdvisorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AdvisorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to query information about assessment items.
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public Task<DescribeStrategiesResponse> DescribeStrategies(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies");
        }

        /// <summary>
        /// This API is used to query information about assessment items.
        /// </summary>
        /// <param name="req"><see cref="DescribeStrategiesRequest"/></param>
        /// <returns><see cref="DescribeStrategiesResponse"/></returns>
        public DescribeStrategiesResponse DescribeStrategiesSync(DescribeStrategiesRequest req)
        {
            return InternalRequestAsync<DescribeStrategiesResponse>(req, "DescribeStrategies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the risky instance list of the assessment item.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public Task<DescribeTaskStrategyRisksResponse> DescribeTaskStrategyRisks(DescribeTaskStrategyRisksRequest req)
        {
            return InternalRequestAsync<DescribeTaskStrategyRisksResponse>(req, "DescribeTaskStrategyRisks");
        }

        /// <summary>
        /// This API is used to query the risky instance list of the assessment item.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskStrategyRisksRequest"/></param>
        /// <returns><see cref="DescribeTaskStrategyRisksResponse"/></returns>
        public DescribeTaskStrategyRisksResponse DescribeTaskStrategyRisksSync(DescribeTaskStrategyRisksRequest req)
        {
            return InternalRequestAsync<DescribeTaskStrategyRisksResponse>(req, "DescribeTaskStrategyRisks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

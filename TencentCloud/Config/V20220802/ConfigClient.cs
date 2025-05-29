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

namespace TencentCloud.Config.V20220802
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Config.V20220802.Models;

   public class ConfigClient : AbstractClient{

       private const string endpoint = "config.intl.tencentcloudapi.com";
       private const string version = "2022-08-02";
       private const string sdkVersion = "SDK_NET_3.0.1141";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ConfigClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ConfigClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResource(DescribeDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeDiscoveredResourceResponse>(req, "DescribeDiscoveredResource");
        }

        /// <summary>
        /// Resource details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiscoveredResourceRequest"/></param>
        /// <returns><see cref="DescribeDiscoveredResourceResponse"/></returns>
        public DescribeDiscoveredResourceResponse DescribeDiscoveredResourceSync(DescribeDiscoveredResourceRequest req)
        {
            return InternalRequestAsync<DescribeDiscoveredResourceResponse>(req, "DescribeDiscoveredResource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the account group rule list.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRulesRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRulesResponse"/></returns>
        public Task<ListAggregateConfigRulesResponse> ListAggregateConfigRules(ListAggregateConfigRulesRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRulesResponse>(req, "ListAggregateConfigRules");
        }

        /// <summary>
        /// This API is used to get the account group rule list.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateConfigRulesRequest"/></param>
        /// <returns><see cref="ListAggregateConfigRulesResponse"/></returns>
        public ListAggregateConfigRulesResponse ListAggregateConfigRulesSync(ListAggregateConfigRulesRequest req)
        {
            return InternalRequestAsync<ListAggregateConfigRulesResponse>(req, "ListAggregateConfigRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Account Group access the list of resources.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListAggregateDiscoveredResourcesResponse"/></returns>
        public Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListAggregateDiscoveredResourcesResponse>(req, "ListAggregateDiscoveredResources");
        }

        /// <summary>
        /// Account Group access the list of resources.
        /// </summary>
        /// <param name="req"><see cref="ListAggregateDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListAggregateDiscoveredResourcesResponse"/></returns>
        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResourcesSync(ListAggregateDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListAggregateDiscoveredResourcesResponse>(req, "ListAggregateDiscoveredResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the rule list.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRulesRequest"/></param>
        /// <returns><see cref="ListConfigRulesResponse"/></returns>
        public Task<ListConfigRulesResponse> ListConfigRules(ListConfigRulesRequest req)
        {
            return InternalRequestAsync<ListConfigRulesResponse>(req, "ListConfigRules");
        }

        /// <summary>
        /// This API is used to get the rule list.
        /// </summary>
        /// <param name="req"><see cref="ListConfigRulesRequest"/></param>
        /// <returns><see cref="ListConfigRulesResponse"/></returns>
        public ListConfigRulesResponse ListConfigRulesSync(ListConfigRulesRequest req)
        {
            return InternalRequestAsync<ListConfigRulesResponse>(req, "ListConfigRules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public Task<ListDiscoveredResourcesResponse> ListDiscoveredResources(ListDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListDiscoveredResourcesResponse>(req, "ListDiscoveredResources");
        }

        /// <summary>
        /// This API is used to get the resource list.
        /// </summary>
        /// <param name="req"><see cref="ListDiscoveredResourcesRequest"/></param>
        /// <returns><see cref="ListDiscoveredResourcesResponse"/></returns>
        public ListDiscoveredResourcesResponse ListDiscoveredResourcesSync(ListDiscoveredResourcesRequest req)
        {
            return InternalRequestAsync<ListDiscoveredResourcesResponse>(req, "ListDiscoveredResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to report custom rule evaluation results.
        /// </summary>
        /// <param name="req"><see cref="PutEvaluationsRequest"/></param>
        /// <returns><see cref="PutEvaluationsResponse"/></returns>
        public Task<PutEvaluationsResponse> PutEvaluations(PutEvaluationsRequest req)
        {
            return InternalRequestAsync<PutEvaluationsResponse>(req, "PutEvaluations");
        }

        /// <summary>
        /// This API is used to report custom rule evaluation results.
        /// </summary>
        /// <param name="req"><see cref="PutEvaluationsRequest"/></param>
        /// <returns><see cref="PutEvaluationsResponse"/></returns>
        public PutEvaluationsResponse PutEvaluationsSync(PutEvaluationsRequest req)
        {
            return InternalRequestAsync<PutEvaluationsResponse>(req, "PutEvaluations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

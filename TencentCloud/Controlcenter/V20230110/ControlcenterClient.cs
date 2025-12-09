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

namespace TencentCloud.Controlcenter.V20230110
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Controlcenter.V20230110.Models;

   public class ControlcenterClient : AbstractClient{

       private const string endpoint = "controlcenter.intl.tencentcloudapi.com";
       private const string version = "2023-01-10";
       private const string sdkVersion = "SDK_NET_3.0.1244";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ControlcenterClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ControlcenterClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply baselines to existing accounts in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public Task<BatchApplyAccountBaselinesResponse> BatchApplyAccountBaselines(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines");
        }

        /// <summary>
        /// This API is used to apply baselines to existing accounts in batches.
        /// </summary>
        /// <param name="req"><see cref="BatchApplyAccountBaselinesRequest"/></param>
        /// <returns><see cref="BatchApplyAccountBaselinesResponse"/></returns>
        public BatchApplyAccountBaselinesResponse BatchApplyAccountBaselinesSync(BatchApplyAccountBaselinesRequest req)
        {
            return InternalRequestAsync<BatchApplyAccountBaselinesResponse>(req, "BatchApplyAccountBaselines")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve user baseline configuration data.
        /// </summary>
        /// <param name="req"><see cref="GetAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="GetAccountFactoryBaselineResponse"/></returns>
        public Task<GetAccountFactoryBaselineResponse> GetAccountFactoryBaseline(GetAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<GetAccountFactoryBaselineResponse>(req, "GetAccountFactoryBaseline");
        }

        /// <summary>
        /// This API is used to retrieve user baseline configuration data.
        /// </summary>
        /// <param name="req"><see cref="GetAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="GetAccountFactoryBaselineResponse"/></returns>
        public GetAccountFactoryBaselineResponse GetAccountFactoryBaselineSync(GetAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<GetAccountFactoryBaselineResponse>(req, "GetAccountFactoryBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain account factory system baseline items.
        /// </summary>
        /// <param name="req"><see cref="ListAccountFactoryBaselineItemsRequest"/></param>
        /// <returns><see cref="ListAccountFactoryBaselineItemsResponse"/></returns>
        public Task<ListAccountFactoryBaselineItemsResponse> ListAccountFactoryBaselineItems(ListAccountFactoryBaselineItemsRequest req)
        {
            return InternalRequestAsync<ListAccountFactoryBaselineItemsResponse>(req, "ListAccountFactoryBaselineItems");
        }

        /// <summary>
        /// This API is used to obtain account factory system baseline items.
        /// </summary>
        /// <param name="req"><see cref="ListAccountFactoryBaselineItemsRequest"/></param>
        /// <returns><see cref="ListAccountFactoryBaselineItemsResponse"/></returns>
        public ListAccountFactoryBaselineItemsResponse ListAccountFactoryBaselineItemsSync(ListAccountFactoryBaselineItemsRequest req)
        {
            return InternalRequestAsync<ListAccountFactoryBaselineItemsResponse>(req, "ListAccountFactoryBaselineItems")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retrieve the application history of a certain baseline item.
        /// </summary>
        /// <param name="req"><see cref="ListDeployStepTasksRequest"/></param>
        /// <returns><see cref="ListDeployStepTasksResponse"/></returns>
        public Task<ListDeployStepTasksResponse> ListDeployStepTasks(ListDeployStepTasksRequest req)
        {
            return InternalRequestAsync<ListDeployStepTasksResponse>(req, "ListDeployStepTasks");
        }

        /// <summary>
        /// This API is used to retrieve the application history of a certain baseline item.
        /// </summary>
        /// <param name="req"><see cref="ListDeployStepTasksRequest"/></param>
        /// <returns><see cref="ListDeployStepTasksResponse"/></returns>
        public ListDeployStepTasksResponse ListDeployStepTasksSync(ListDeployStepTasksRequest req)
        {
            return InternalRequestAsync<ListDeployStepTasksResponse>(req, "ListDeployStepTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the current baseline item configuration of a user. The baseline configuration will be overwritten with the current configuration. When adding new baseline items, the newly-added baseline configuration needs to be added to the existing configuration. When deleting baseline items, the deleted baseline configuration needs to be removed from the existing configuration, then save the latest baseline configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="UpdateAccountFactoryBaselineResponse"/></returns>
        public Task<UpdateAccountFactoryBaselineResponse> UpdateAccountFactoryBaseline(UpdateAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<UpdateAccountFactoryBaselineResponse>(req, "UpdateAccountFactoryBaseline");
        }

        /// <summary>
        /// This API is used to update the current baseline item configuration of a user. The baseline configuration will be overwritten with the current configuration. When adding new baseline items, the newly-added baseline configuration needs to be added to the existing configuration. When deleting baseline items, the deleted baseline configuration needs to be removed from the existing configuration, then save the latest baseline configuration.
        /// </summary>
        /// <param name="req"><see cref="UpdateAccountFactoryBaselineRequest"/></param>
        /// <returns><see cref="UpdateAccountFactoryBaselineResponse"/></returns>
        public UpdateAccountFactoryBaselineResponse UpdateAccountFactoryBaselineSync(UpdateAccountFactoryBaselineRequest req)
        {
            return InternalRequestAsync<UpdateAccountFactoryBaselineResponse>(req, "UpdateAccountFactoryBaseline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

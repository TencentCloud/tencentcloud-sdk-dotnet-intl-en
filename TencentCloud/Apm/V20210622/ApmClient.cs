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

namespace TencentCloud.Apm.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apm.V20210622.Models;

   public class ApmClient : AbstractClient{

       private const string endpoint = "apm.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1079";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ApmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ApmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a business purchase in the APM business system.
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public Task<CreateApmInstanceResponse> CreateApmInstance(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance");
        }

        /// <summary>
        /// This API is used to create a business purchase in the APM business system.
        /// </summary>
        /// <param name="req"><see cref="CreateApmInstanceRequest"/></param>
        /// <returns><see cref="CreateApmInstanceResponse"/></returns>
        public CreateApmInstanceResponse CreateApmInstanceSync(CreateApmInstanceRequest req)
        {
            return InternalRequestAsync<CreateApmInstanceResponse>(req, "CreateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Obtaining APM Access Point.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public Task<DescribeApmAgentResponse> DescribeApmAgent(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent");
        }

        /// <summary>
        /// Obtaining APM Access Point.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAgentRequest"/></param>
        /// <returns><see cref="DescribeApmAgentResponse"/></returns>
        public DescribeApmAgentResponse DescribeApmAgentSync(DescribeApmAgentRequest req)
        {
            return InternalRequestAsync<DescribeApmAgentResponse>(req, "DescribeApmAgent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of APM business systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public Task<DescribeApmInstancesResponse> DescribeApmInstances(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances");
        }

        /// <summary>
        /// This API is used to obtain the list of APM business systems.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmInstancesRequest"/></param>
        /// <returns><see cref="DescribeApmInstancesResponse"/></returns>
        public DescribeApmInstancesResponse DescribeApmInstancesSync(DescribeApmInstancesRequest req)
        {
            return InternalRequestAsync<DescribeApmInstancesResponse>(req, "DescribeApmInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the application configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public Task<DescribeGeneralApmApplicationConfigResponse> DescribeGeneralApmApplicationConfig(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig");
        }

        /// <summary>
        /// This API is used to query the application configuration information.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeGeneralApmApplicationConfigResponse"/></returns>
        public DescribeGeneralApmApplicationConfigResponse DescribeGeneralApmApplicationConfigSync(DescribeGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeGeneralApmApplicationConfigResponse>(req, "DescribeGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is a general API used to obtain metric data. Users submit request parameters as needed and receive the corresponding metric data.
        /// The API call frequency is limited to 20 requests per second and 1200 requests per minute. The number of data points per request is limited to 1440.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public Task<DescribeGeneralMetricDataResponse> DescribeGeneralMetricData(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData");
        }

        /// <summary>
        /// This API is a general API used to obtain metric data. Users submit request parameters as needed and receive the corresponding metric data.
        /// The API call frequency is limited to 20 requests per second and 1200 requests per minute. The number of data points per request is limited to 1440.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public DescribeGeneralMetricDataResponse DescribeGeneralMetricDataSync(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// General Query OpenTelemetry Call Chain List.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralOTSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralOTSpanListResponse"/></returns>
        public Task<DescribeGeneralOTSpanListResponse> DescribeGeneralOTSpanList(DescribeGeneralOTSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralOTSpanListResponse>(req, "DescribeGeneralOTSpanList");
        }

        /// <summary>
        /// General Query OpenTelemetry Call Chain List.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralOTSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralOTSpanListResponse"/></returns>
        public DescribeGeneralOTSpanListResponse DescribeGeneralOTSpanListSync(DescribeGeneralOTSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralOTSpanListResponse>(req, "DescribeGeneralOTSpanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// General Query Call Chain List.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public Task<DescribeGeneralSpanListResponse> DescribeGeneralSpanList(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList");
        }

        /// <summary>
        /// General Query Call Chain List.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralSpanListRequest"/></param>
        /// <returns><see cref="DescribeGeneralSpanListResponse"/></returns>
        public DescribeGeneralSpanListResponse DescribeGeneralSpanListSync(DescribeGeneralSpanListRequest req)
        {
            return InternalRequestAsync<DescribeGeneralSpanListResponse>(req, "DescribeGeneralSpanList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query metric list. To query metrics, it is recommended to use the DescribeGeneralMetricData API.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public Task<DescribeMetricRecordsResponse> DescribeMetricRecords(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords");
        }

        /// <summary>
        /// This API is used to query metric list. To query metrics, it is recommended to use the DescribeGeneralMetricData API.
        /// </summary>
        /// <param name="req"><see cref="DescribeMetricRecordsRequest"/></param>
        /// <returns><see cref="DescribeMetricRecordsResponse"/></returns>
        public DescribeMetricRecordsResponse DescribeMetricRecordsSync(DescribeMetricRecordsRequest req)
        {
            return InternalRequestAsync<DescribeMetricRecordsResponse>(req, "DescribeMetricRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pull application overview data.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public Task<DescribeServiceOverviewResponse> DescribeServiceOverview(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview");
        }

        /// <summary>
        /// This API is used to pull application overview data.
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceOverviewRequest"/></param>
        /// <returns><see cref="DescribeServiceOverviewResponse"/></returns>
        public DescribeServiceOverviewResponse DescribeServiceOverviewSync(DescribeServiceOverviewRequest req)
        {
            return InternalRequestAsync<DescribeServiceOverviewResponse>(req, "DescribeServiceOverview")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query dimensional data by dimension name and filter condition.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues");
        }

        /// <summary>
        /// This API is used to query dimensional data by dimension name and filter condition.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the APM business system.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public Task<ModifyApmInstanceResponse> ModifyApmInstance(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance");
        }

        /// <summary>
        /// This API is used to modify the APM business system.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmInstanceRequest"/></param>
        /// <returns><see cref="ModifyApmInstanceResponse"/></returns>
        public ModifyApmInstanceResponse ModifyApmInstanceSync(ModifyApmInstanceRequest req)
        {
            return InternalRequestAsync<ModifyApmInstanceResponse>(req, "ModifyApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// OpenAPI available for external use. Customers can flexibly specify the fields to be modified, and then add the list of services to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public Task<ModifyGeneralApmApplicationConfigResponse> ModifyGeneralApmApplicationConfig(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig");
        }

        /// <summary>
        /// OpenAPI available for external use. Customers can flexibly specify the fields to be modified, and then add the list of services to be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyGeneralApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyGeneralApmApplicationConfigResponse"/></returns>
        public ModifyGeneralApmApplicationConfigResponse ModifyGeneralApmApplicationConfigSync(ModifyGeneralApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyGeneralApmApplicationConfigResponse>(req, "ModifyGeneralApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Termination of APM business system.
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public Task<TerminateApmInstanceResponse> TerminateApmInstance(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance");
        }

        /// <summary>
        /// Termination of APM business system.
        /// </summary>
        /// <param name="req"><see cref="TerminateApmInstanceRequest"/></param>
        /// <returns><see cref="TerminateApmInstanceResponse"/></returns>
        public TerminateApmInstanceResponse TerminateApmInstanceSync(TerminateApmInstanceRequest req)
        {
            return InternalRequestAsync<TerminateApmInstanceResponse>(req, "TerminateApmInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

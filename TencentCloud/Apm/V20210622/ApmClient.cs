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

namespace TencentCloud.Apm.V20210622
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Apm.V20210622.Models;

   public class ApmClient : AbstractClient{

       private const string endpoint = "apm.intl.tencentcloudapi.com";
       private const string version = "2021-06-22";
       private const string sdkVersion = "SDK_NET_3.0.1314";

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
        /// This API is used to create metric match rules between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="CreateApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="CreateApmPrometheusRuleResponse"/></returns>
        public Task<CreateApmPrometheusRuleResponse> CreateApmPrometheusRule(CreateApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<CreateApmPrometheusRuleResponse>(req, "CreateApmPrometheusRule");
        }

        /// <summary>
        /// This API is used to create metric match rules between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="CreateApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="CreateApmPrometheusRuleResponse"/></returns>
        public CreateApmPrometheusRuleResponse CreateApmPrometheusRuleSync(CreateApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<CreateApmPrometheusRuleResponse>(req, "CreateApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create sampling configurations
        /// </summary>
        /// <param name="req"><see cref="CreateApmSampleConfigRequest"/></param>
        /// <returns><see cref="CreateApmSampleConfigResponse"/></returns>
        public Task<CreateApmSampleConfigResponse> CreateApmSampleConfig(CreateApmSampleConfigRequest req)
        {
            return InternalRequestAsync<CreateApmSampleConfigResponse>(req, "CreateApmSampleConfig");
        }

        /// <summary>
        /// Create sampling configurations
        /// </summary>
        /// <param name="req"><see cref="CreateApmSampleConfigRequest"/></param>
        /// <returns><see cref="CreateApmSampleConfigResponse"/></returns>
        public CreateApmSampleConfigResponse CreateApmSampleConfigSync(CreateApmSampleConfigRequest req)
        {
            return InternalRequestAsync<CreateApmSampleConfigResponse>(req, "CreateApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an event task.
        /// </summary>
        /// <param name="req"><see cref="CreateProfileTaskRequest"/></param>
        /// <returns><see cref="CreateProfileTaskResponse"/></returns>
        public Task<CreateProfileTaskResponse> CreateProfileTask(CreateProfileTaskRequest req)
        {
            return InternalRequestAsync<CreateProfileTaskResponse>(req, "CreateProfileTask");
        }

        /// <summary>
        /// This API is used to create an event task.
        /// </summary>
        /// <param name="req"><see cref="CreateProfileTaskRequest"/></param>
        /// <returns><see cref="CreateProfileTaskResponse"/></returns>
        public CreateProfileTaskResponse CreateProfileTaskSync(CreateProfileTaskRequest req)
        {
            return InternalRequestAsync<CreateProfileTaskResponse>(req, "CreateProfileTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete sampling configurations
        /// </summary>
        /// <param name="req"><see cref="DeleteApmSampleConfigRequest"/></param>
        /// <returns><see cref="DeleteApmSampleConfigResponse"/></returns>
        public Task<DeleteApmSampleConfigResponse> DeleteApmSampleConfig(DeleteApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DeleteApmSampleConfigResponse>(req, "DeleteApmSampleConfig");
        }

        /// <summary>
        /// Delete sampling configurations
        /// </summary>
        /// <param name="req"><see cref="DeleteApmSampleConfigRequest"/></param>
        /// <returns><see cref="DeleteApmSampleConfigResponse"/></returns>
        public DeleteApmSampleConfigResponse DeleteApmSampleConfigSync(DeleteApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DeleteApmSampleConfigResponse>(req, "DeleteApmSampleConfig")
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
        /// Query all vulnerability information of the user
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeApmAllVulCountResponse"/></returns>
        public Task<DescribeApmAllVulCountResponse> DescribeApmAllVulCount(DescribeApmAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeApmAllVulCountResponse>(req, "DescribeApmAllVulCount");
        }

        /// <summary>
        /// Query all vulnerability information of the user
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeApmAllVulCountResponse"/></returns>
        public DescribeApmAllVulCountResponse DescribeApmAllVulCountSync(DescribeApmAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeApmAllVulCountResponse>(req, "DescribeApmAllVulCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query application configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApmApplicationConfigResponse"/></returns>
        public Task<DescribeApmApplicationConfigResponse> DescribeApmApplicationConfig(DescribeApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmApplicationConfigResponse>(req, "DescribeApmApplicationConfig");
        }

        /// <summary>
        /// This API is used to query application configuration.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmApplicationConfigRequest"/></param>
        /// <returns><see cref="DescribeApmApplicationConfigResponse"/></returns>
        public DescribeApmApplicationConfigResponse DescribeApmApplicationConfigSync(DescribeApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmApplicationConfigResponse>(req, "DescribeApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the relationship between apm Business System and other product.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAssociationRequest"/></param>
        /// <returns><see cref="DescribeApmAssociationResponse"/></returns>
        public Task<DescribeApmAssociationResponse> DescribeApmAssociation(DescribeApmAssociationRequest req)
        {
            return InternalRequestAsync<DescribeApmAssociationResponse>(req, "DescribeApmAssociation");
        }

        /// <summary>
        /// This API is used to query the relationship between apm Business System and other product.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmAssociationRequest"/></param>
        /// <returns><see cref="DescribeApmAssociationResponse"/></returns>
        public DescribeApmAssociationResponse DescribeApmAssociationSync(DescribeApmAssociationRequest req)
        {
            return InternalRequestAsync<DescribeApmAssociationResponse>(req, "DescribeApmAssociation")
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
        /// This API is used to query the match rule for metrics between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="DescribeApmPrometheusRuleResponse"/></returns>
        public Task<DescribeApmPrometheusRuleResponse> DescribeApmPrometheusRule(DescribeApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<DescribeApmPrometheusRuleResponse>(req, "DescribeApmPrometheusRule");
        }

        /// <summary>
        /// This API is used to query the match rule for metrics between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="DescribeApmPrometheusRuleResponse"/></returns>
        public DescribeApmPrometheusRuleResponse DescribeApmPrometheusRuleSync(DescribeApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<DescribeApmPrometheusRuleResponse>(req, "DescribeApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query SQL injection details
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSQLInjectionDetailRequest"/></param>
        /// <returns><see cref="DescribeApmSQLInjectionDetailResponse"/></returns>
        public Task<DescribeApmSQLInjectionDetailResponse> DescribeApmSQLInjectionDetail(DescribeApmSQLInjectionDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmSQLInjectionDetailResponse>(req, "DescribeApmSQLInjectionDetail");
        }

        /// <summary>
        /// Query SQL injection details
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSQLInjectionDetailRequest"/></param>
        /// <returns><see cref="DescribeApmSQLInjectionDetailResponse"/></returns>
        public DescribeApmSQLInjectionDetailResponse DescribeApmSQLInjectionDetailSync(DescribeApmSQLInjectionDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmSQLInjectionDetailResponse>(req, "DescribeApmSQLInjectionDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query sampling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeApmSampleConfigResponse"/></returns>
        public Task<DescribeApmSampleConfigResponse> DescribeApmSampleConfig(DescribeApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmSampleConfigResponse>(req, "DescribeApmSampleConfig");
        }

        /// <summary>
        /// Query sampling configuration
        /// </summary>
        /// <param name="req"><see cref="DescribeApmSampleConfigRequest"/></param>
        /// <returns><see cref="DescribeApmSampleConfigResponse"/></returns>
        public DescribeApmSampleConfigResponse DescribeApmSampleConfigSync(DescribeApmSampleConfigRequest req)
        {
            return InternalRequestAsync<DescribeApmSampleConfigResponse>(req, "DescribeApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the list of APM application metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmServiceMetricRequest"/></param>
        /// <returns><see cref="DescribeApmServiceMetricResponse"/></returns>
        public Task<DescribeApmServiceMetricResponse> DescribeApmServiceMetric(DescribeApmServiceMetricRequest req)
        {
            return InternalRequestAsync<DescribeApmServiceMetricResponse>(req, "DescribeApmServiceMetric");
        }

        /// <summary>
        /// This API is used to obtain the list of APM application metrics.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmServiceMetricRequest"/></param>
        /// <returns><see cref="DescribeApmServiceMetricResponse"/></returns>
        public DescribeApmServiceMetricResponse DescribeApmServiceMetricSync(DescribeApmServiceMetricRequest req)
        {
            return InternalRequestAsync<DescribeApmServiceMetricResponse>(req, "DescribeApmServiceMetric")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query vulnerability metrics
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityCountRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityCountResponse"/></returns>
        public Task<DescribeApmVulnerabilityCountResponse> DescribeApmVulnerabilityCount(DescribeApmVulnerabilityCountRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityCountResponse>(req, "DescribeApmVulnerabilityCount");
        }

        /// <summary>
        /// Query vulnerability metrics
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityCountRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityCountResponse"/></returns>
        public DescribeApmVulnerabilityCountResponse DescribeApmVulnerabilityCountSync(DescribeApmVulnerabilityCountRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityCountResponse>(req, "DescribeApmVulnerabilityCount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityDetailRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityDetailResponse"/></returns>
        public Task<DescribeApmVulnerabilityDetailResponse> DescribeApmVulnerabilityDetail(DescribeApmVulnerabilityDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityDetailResponse>(req, "DescribeApmVulnerabilityDetail");
        }

        /// <summary>
        /// Query vulnerability details.
        /// </summary>
        /// <param name="req"><see cref="DescribeApmVulnerabilityDetailRequest"/></param>
        /// <returns><see cref="DescribeApmVulnerabilityDetailResponse"/></returns>
        public DescribeApmVulnerabilityDetailResponse DescribeApmVulnerabilityDetailSync(DescribeApmVulnerabilityDetailRequest req)
        {
            return InternalRequestAsync<DescribeApmVulnerabilityDetailResponse>(req, "DescribeApmVulnerabilityDetail")
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
        /// General interface to obtain metric data. Submit request parameters as needed and receive the corresponding metric data.
        /// API call frequency limit: 20 requests/second, 1,200 requests/minute. Data point limit per single request: up to 1,440 data points.
        /// 
        /// General interface to obtain metric data usage: This API is used to query metric data flexibly. The query method of this API is similar to using the following SQL statement: SELECT {Metrics} FROM {ViewName} WHERE {Filters} GROUP BY {GroupBy}. Before initiating request, please confirm the following key parameters:
        /// 1. View (ViewName)
        /// Determine the domain of the queried data.
        /// For example: service_metric (service monitoring view), db_metric (database view). For views supported by APM, see metrics view (https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1#069b06a9-2593-49db-b694-dea4200f3b19).
        /// 
        /// 2. Metrics
        /// Used to specify one or more metric items in the returned result.
        /// For example: request_count (request count), duration_avg (avg duration), error_rate (error rate). For supported metrics about APM, see [APM Protocol Standards](https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1). Each view (ViewName) supports an exclusive metric set.
        /// 3. Filters
        /// Support filter criteria in the form of one or multiple Key-Value pairs.
        /// For example: Only query a certain specific service with service.name = "order-service". Common dimensional and each view (ViewName) support exclusive dimensions, which can be used as keys in filter conditions. For details, refer to the APM metrics protocol standard (https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1).
        /// 
        /// 4. GroupBy (aggregation)
        /// Support one or more aggregate dimensions, equivalent to SQL GROUP BY.
        /// For example: Group by API name operation to view the performance of each API. Common dimensional and each view (ViewName) support exclusive dimensional, which can be used as aggregation dimension. For details, see [APM protocol standards](https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1).
        /// 5. Granularity (Period) 
        /// This parameter determines whether time slice aggregation is required.
        /// -Period = 1: Time series mode: In the returned result, aggregation is performed by time slice. The time series (TimeSerial) and data sequence (DataSerial) have a one-to-one correspondence, representing aggregation results for specific time slices. Time series mode is mainly used to show time trend charts.
        /// -Period = 0: Summarize mode. In the returned result, the data sequence (DataSerial) only contains a unique value, representing the aggregated data for the entire time interval.
        /// </summary>
        /// <param name="req"><see cref="DescribeGeneralMetricDataRequest"/></param>
        /// <returns><see cref="DescribeGeneralMetricDataResponse"/></returns>
        public Task<DescribeGeneralMetricDataResponse> DescribeGeneralMetricData(DescribeGeneralMetricDataRequest req)
        {
            return InternalRequestAsync<DescribeGeneralMetricDataResponse>(req, "DescribeGeneralMetricData");
        }

        /// <summary>
        /// General interface to obtain metric data. Submit request parameters as needed and receive the corresponding metric data.
        /// API call frequency limit: 20 requests/second, 1,200 requests/minute. Data point limit per single request: up to 1,440 data points.
        /// 
        /// General interface to obtain metric data usage: This API is used to query metric data flexibly. The query method of this API is similar to using the following SQL statement: SELECT {Metrics} FROM {ViewName} WHERE {Filters} GROUP BY {GroupBy}. Before initiating request, please confirm the following key parameters:
        /// 1. View (ViewName)
        /// Determine the domain of the queried data.
        /// For example: service_metric (service monitoring view), db_metric (database view). For views supported by APM, see metrics view (https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1#069b06a9-2593-49db-b694-dea4200f3b19).
        /// 
        /// 2. Metrics
        /// Used to specify one or more metric items in the returned result.
        /// For example: request_count (request count), duration_avg (avg duration), error_rate (error rate). For supported metrics about APM, see [APM Protocol Standards](https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1). Each view (ViewName) supports an exclusive metric set.
        /// 3. Filters
        /// Support filter criteria in the form of one or multiple Key-Value pairs.
        /// For example: Only query a certain specific service with service.name = "order-service". Common dimensional and each view (ViewName) support exclusive dimensions, which can be used as keys in filter conditions. For details, refer to the APM metrics protocol standard (https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1).
        /// 
        /// 4. GroupBy (aggregation)
        /// Support one or more aggregate dimensions, equivalent to SQL GROUP BY.
        /// For example: Group by API name operation to view the performance of each API. Common dimensional and each view (ViewName) support exclusive dimensional, which can be used as aggregation dimension. For details, see [APM protocol standards](https://www.tencentcloud.com/document/product/248/101681?from_cn_redirect=1).
        /// 5. Granularity (Period) 
        /// This parameter determines whether time slice aggregation is required.
        /// -Period = 1: Time series mode: In the returned result, aggregation is performed by time slice. The time series (TimeSerial) and data sequence (DataSerial) have a one-to-one correspondence, representing aggregation results for specific time slices. Time series mode is mainly used to show time trend charts.
        /// -Period = 0: Summarize mode. In the returned result, the data sequence (DataSerial) only contains a unique value, representing the aggregated data for the entire time interval.
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
        /// Query all vulnerability information of the user
        /// </summary>
        /// <param name="req"><see cref="DescribeOPRAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeOPRAllVulCountResponse"/></returns>
        public Task<DescribeOPRAllVulCountResponse> DescribeOPRAllVulCount(DescribeOPRAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeOPRAllVulCountResponse>(req, "DescribeOPRAllVulCount");
        }

        /// <summary>
        /// Query all vulnerability information of the user
        /// </summary>
        /// <param name="req"><see cref="DescribeOPRAllVulCountRequest"/></param>
        /// <returns><see cref="DescribeOPRAllVulCountResponse"/></returns>
        public DescribeOPRAllVulCountResponse DescribeOPRAllVulCountSync(DescribeOPRAllVulCountRequest req)
        {
            return InternalRequestAsync<DescribeOPRAllVulCountResponse>(req, "DescribeOPRAllVulCount")
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
        /// This API is used to query the service topology diagram according to the application name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopologyNewRequest"/></param>
        /// <returns><see cref="DescribeTopologyNewResponse"/></returns>
        public Task<DescribeTopologyNewResponse> DescribeTopologyNew(DescribeTopologyNewRequest req)
        {
            return InternalRequestAsync<DescribeTopologyNewResponse>(req, "DescribeTopologyNew");
        }

        /// <summary>
        /// This API is used to query the service topology diagram according to the application name.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopologyNewRequest"/></param>
        /// <returns><see cref="DescribeTopologyNewResponse"/></returns>
        public DescribeTopologyNewResponse DescribeTopologyNewSync(DescribeTopologyNewRequest req)
        {
            return InternalRequestAsync<DescribeTopologyNewResponse>(req, "DescribeTopologyNew")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify application configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyApmApplicationConfigResponse"/></returns>
        public Task<ModifyApmApplicationConfigResponse> ModifyApmApplicationConfig(ModifyApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmApplicationConfigResponse>(req, "ModifyApmApplicationConfig");
        }

        /// <summary>
        /// Modify application configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyApmApplicationConfigRequest"/></param>
        /// <returns><see cref="ModifyApmApplicationConfigResponse"/></returns>
        public ModifyApmApplicationConfigResponse ModifyApmApplicationConfigSync(ModifyApmApplicationConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmApplicationConfigResponse>(req, "ModifyApmApplicationConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the relationship between the apm Business System and other products, including deletion.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmAssociationRequest"/></param>
        /// <returns><see cref="ModifyApmAssociationResponse"/></returns>
        public Task<ModifyApmAssociationResponse> ModifyApmAssociation(ModifyApmAssociationRequest req)
        {
            return InternalRequestAsync<ModifyApmAssociationResponse>(req, "ModifyApmAssociation");
        }

        /// <summary>
        /// This API is used to modify the relationship between the apm Business System and other products, including deletion.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmAssociationRequest"/></param>
        /// <returns><see cref="ModifyApmAssociationResponse"/></returns>
        public ModifyApmAssociationResponse ModifyApmAssociationSync(ModifyApmAssociationRequest req)
        {
            return InternalRequestAsync<ModifyApmAssociationResponse>(req, "ModifyApmAssociation")
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
        /// This API is used to modify metric match rules between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="ModifyApmPrometheusRuleResponse"/></returns>
        public Task<ModifyApmPrometheusRuleResponse> ModifyApmPrometheusRule(ModifyApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<ModifyApmPrometheusRuleResponse>(req, "ModifyApmPrometheusRule");
        }

        /// <summary>
        /// This API is used to modify metric match rules between apm Business System and Prometheus Instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmPrometheusRuleRequest"/></param>
        /// <returns><see cref="ModifyApmPrometheusRuleResponse"/></returns>
        public ModifyApmPrometheusRuleResponse ModifyApmPrometheusRuleSync(ModifyApmPrometheusRuleRequest req)
        {
            return InternalRequestAsync<ModifyApmPrometheusRuleResponse>(req, "ModifyApmPrometheusRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify sampling configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyApmSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyApmSampleConfigResponse"/></returns>
        public Task<ModifyApmSampleConfigResponse> ModifyApmSampleConfig(ModifyApmSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmSampleConfigResponse>(req, "ModifyApmSampleConfig");
        }

        /// <summary>
        /// Modify sampling configurations
        /// </summary>
        /// <param name="req"><see cref="ModifyApmSampleConfigRequest"/></param>
        /// <returns><see cref="ModifyApmSampleConfigResponse"/></returns>
        public ModifyApmSampleConfigResponse ModifyApmSampleConfigSync(ModifyApmSampleConfigRequest req)
        {
            return InternalRequestAsync<ModifyApmSampleConfigResponse>(req, "ModifyApmSampleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to edit information about applications of APM.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmServiceRequest"/></param>
        /// <returns><see cref="ModifyApmServiceResponse"/></returns>
        public Task<ModifyApmServiceResponse> ModifyApmService(ModifyApmServiceRequest req)
        {
            return InternalRequestAsync<ModifyApmServiceResponse>(req, "ModifyApmService");
        }

        /// <summary>
        /// This API is used to edit information about applications of APM.
        /// </summary>
        /// <param name="req"><see cref="ModifyApmServiceRequest"/></param>
        /// <returns><see cref="ModifyApmServiceResponse"/></returns>
        public ModifyApmServiceResponse ModifyApmServiceSync(ModifyApmServiceRequest req)
        {
            return InternalRequestAsync<ModifyApmServiceResponse>(req, "ModifyApmService")
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

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

namespace TencentCloud.Dbbrain.V20210527
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20210527.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2021-05-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DbbrainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create an async task of killing all proxy node connection sessions and is currently supported only for Redis. The async task ID is the returned value, which can be passed to the API `DescribeProxySessionKillTasks` as a parameter to query the execution status of the session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public async Task<CreateProxySessionKillTaskResponse> CreateProxySessionKillTask(CreateProxySessionKillTaskRequest req)
        {
             JsonResponseModel<CreateProxySessionKillTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateProxySessionKillTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxySessionKillTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an async task of killing all proxy node connection sessions and is currently supported only for Redis. The async task ID is the returned value, which can be passed to the API `DescribeProxySessionKillTasks` as a parameter to query the execution status of the session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public CreateProxySessionKillTaskResponse CreateProxySessionKillTaskSync(CreateProxySessionKillTaskRequest req)
        {
             JsonResponseModel<CreateProxySessionKillTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateProxySessionKillTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateProxySessionKillTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the diagnosis event list in a specified time period by risk level, instance ID, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public async Task<DescribeDBDiagEventsResponse> DescribeDBDiagEvents(DescribeDBDiagEventsRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the diagnosis event list in a specified time period by risk level, instance ID, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public DescribeDBDiagEventsResponse DescribeDBDiagEventsSync(DescribeDBDiagEventsRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance information list. Please always select Guangzhou for `Region`.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public async Task<DescribeDiagDBInstancesResponse> DescribeDiagDBInstances(DescribeDiagDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDiagDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDiagDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance information list. Please always select Guangzhou for `Region`.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public DescribeDiagDBInstancesResponse DescribeDiagDBInstancesSync(DescribeDiagDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDiagDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDiagDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDiagDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time thread list of a relational database.
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public async Task<DescribeMySqlProcessListResponse> DescribeMySqlProcessList(DescribeMySqlProcessListRequest req)
        {
             JsonResponseModel<DescribeMySqlProcessListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMySqlProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMySqlProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the real-time thread list of a relational database.
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public DescribeMySqlProcessListResponse DescribeMySqlProcessListSync(DescribeMySqlProcessListRequest req)
        {
             JsonResponseModel<DescribeMySqlProcessListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMySqlProcessList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMySqlProcessListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the session killing task executed by the Redis proxy node. The async task ID (an input parameter) is obtained after the API `CreateProxySessionKillTask` is successfully called. Currently, the only valid value of `product` is `redis`.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public async Task<DescribeProxySessionKillTasksResponse> DescribeProxySessionKillTasks(DescribeProxySessionKillTasksRequest req)
        {
             JsonResponseModel<DescribeProxySessionKillTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxySessionKillTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySessionKillTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the result of the session killing task executed by the Redis proxy node. The async task ID (an input parameter) is obtained after the API `CreateProxySessionKillTask` is successfully called. Currently, the only valid value of `product` is `redis`.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public DescribeProxySessionKillTasksResponse DescribeProxySessionKillTasksSync(DescribeProxySessionKillTasksRequest req)
        {
             JsonResponseModel<DescribeProxySessionKillTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxySessionKillTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxySessionKillTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of top key prefixes for Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public async Task<DescribeRedisTopKeyPrefixListResponse> DescribeRedisTopKeyPrefixList(DescribeRedisTopKeyPrefixListRequest req)
        {
             JsonResponseModel<DescribeRedisTopKeyPrefixListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRedisTopKeyPrefixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRedisTopKeyPrefixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of top key prefixes for Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public DescribeRedisTopKeyPrefixListResponse DescribeRedisTopKeyPrefixListSync(DescribeRedisTopKeyPrefixListRequest req)
        {
             JsonResponseModel<DescribeRedisTopKeyPrefixListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRedisTopKeyPrefixList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRedisTopKeyPrefixListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public async Task<DescribeSlowLogUserHostStatsResponse> DescribeSlowLogUserHostStats(DescribeSlowLogUserHostStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogUserHostStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogUserHostStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogUserHostStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public DescribeSlowLogUserHostStatsResponse DescribeSlowLogUserHostStatsSync(DescribeSlowLogUserHostStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogUserHostStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogUserHostStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogUserHostStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top databases of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public async Task<DescribeTopSpaceSchemasResponse> DescribeTopSpaceSchemas(DescribeTopSpaceSchemasRequest req)
        {
             JsonResponseModel<DescribeTopSpaceSchemasResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceSchemas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceSchemasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top databases of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public DescribeTopSpaceSchemasResponse DescribeTopSpaceSchemasSync(DescribeTopSpaceSchemasRequest req)
        {
             JsonResponseModel<DescribeTopSpaceSchemasResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceSchemas");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceSchemasResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get SQL statement optimization suggestions. It is free of charge for a limited time and will be charged after DBbrain is commercialized.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public async Task<DescribeUserSqlAdviceResponse> DescribeUserSqlAdvice(DescribeUserSqlAdviceRequest req)
        {
             JsonResponseModel<DescribeUserSqlAdviceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserSqlAdvice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSqlAdviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get SQL statement optimization suggestions. It is free of charge for a limited time and will be charged after DBbrain is commercialized.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public DescribeUserSqlAdviceResponse DescribeUserSqlAdviceSync(DescribeUserSqlAdviceRequest req)
        {
             JsonResponseModel<DescribeUserSqlAdviceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserSqlAdvice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserSqlAdviceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

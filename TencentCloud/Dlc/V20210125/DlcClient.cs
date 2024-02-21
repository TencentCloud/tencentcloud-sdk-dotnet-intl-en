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

namespace TencentCloud.Dlc.V20210125
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dlc.V20210125.Models;

   public class DlcClient : AbstractClient{

       private const string endpoint = "dlc.tencentcloudapi.com";
       private const string version = "2021-01-25";
       private const string sdkVersion = "SDK_NET_3.0.845";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DlcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DlcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public Task<CancelSparkSessionBatchSQLResponse> CancelSparkSessionBatchSQL(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL");
        }

        /// <summary>
        /// This API is used to cancel a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="CancelSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CancelSparkSessionBatchSQLResponse"/></returns>
        public CancelSparkSessionBatchSQLResponse CancelSparkSessionBatchSQLSync(CancelSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CancelSparkSessionBatchSQLResponse>(req, "CancelSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask");
        }

        /// <summary>
        /// This API is used to cancel a task.
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
            return InternalRequestAsync<CancelTaskResponse>(req, "CancelTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public Task<CreateDataEngineResponse> CreateDataEngine(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine");
        }

        /// <summary>
        /// This API is used to create a data engine.
        /// </summary>
        /// <param name="req"><see cref="CreateDataEngineRequest"/></param>
        /// <returns><see cref="CreateDataEngineResponse"/></returns>
        public CreateDataEngineResponse CreateDataEngineSync(CreateDataEngineRequest req)
        {
            return InternalRequestAsync<CreateDataEngineResponse>(req, "CreateDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public Task<CreateInternalTableResponse> CreateInternalTable(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable");
        }

        /// <summary>
        /// This API is used to create a managed internal table. It has been disused.
        /// </summary>
        /// <param name="req"><see cref="CreateInternalTableRequest"/></param>
        /// <returns><see cref="CreateInternalTableResponse"/></returns>
        public CreateInternalTableResponse CreateInternalTableSync(CreateInternalTableRequest req)
        {
            return InternalRequestAsync<CreateInternalTableResponse>(req, "CreateInternalTable")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public Task<CreateResultDownloadResponse> CreateResultDownload(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload");
        }

        /// <summary>
        /// This API is used to create a query result download task.
        /// </summary>
        /// <param name="req"><see cref="CreateResultDownloadRequest"/></param>
        /// <returns><see cref="CreateResultDownloadResponse"/></returns>
        public CreateResultDownloadResponse CreateResultDownloadSync(CreateResultDownloadRequest req)
        {
            return InternalRequestAsync<CreateResultDownloadResponse>(req, "CreateResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public Task<CreateSparkAppResponse> CreateSparkApp(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp");
        }

        /// <summary>
        /// This API is used to create a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppRequest"/></param>
        /// <returns><see cref="CreateSparkAppResponse"/></returns>
        public CreateSparkAppResponse CreateSparkAppSync(CreateSparkAppRequest req)
        {
            return InternalRequestAsync<CreateSparkAppResponse>(req, "CreateSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public Task<CreateSparkAppTaskResponse> CreateSparkAppTask(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask");
        }

        /// <summary>
        /// This API is used to start a Spark job.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkAppTaskRequest"/></param>
        /// <returns><see cref="CreateSparkAppTaskResponse"/></returns>
        public CreateSparkAppTaskResponse CreateSparkAppTaskSync(CreateSparkAppTaskRequest req)
        {
            return InternalRequestAsync<CreateSparkAppTaskResponse>(req, "CreateSparkAppTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public Task<CreateSparkSessionBatchSQLResponse> CreateSparkSessionBatchSQL(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL");
        }

        /// <summary>
        /// This API is used to submit a Spark SQL batch task to the job engine.
        /// </summary>
        /// <param name="req"><see cref="CreateSparkSessionBatchSQLRequest"/></param>
        /// <returns><see cref="CreateSparkSessionBatchSQLResponse"/></returns>
        public CreateSparkSessionBatchSQLResponse CreateSparkSessionBatchSQLSync(CreateSparkSessionBatchSQLRequest req)
        {
            return InternalRequestAsync<CreateSparkSessionBatchSQLResponse>(req, "CreateSparkSessionBatchSQL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public Task<CreateTaskResponse> CreateTask(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask");
        }

        /// <summary>
        /// This API is used to create and execute a SQL task. (`CreateTasks` is recommended.)
        /// </summary>
        /// <param name="req"><see cref="CreateTaskRequest"/></param>
        /// <returns><see cref="CreateTaskResponse"/></returns>
        public CreateTaskResponse CreateTaskSync(CreateTaskRequest req)
        {
            return InternalRequestAsync<CreateTaskResponse>(req, "CreateTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public Task<CreateTasksResponse> CreateTasks(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks");
        }

        /// <summary>
        /// This API is used to create and execute SQL tasks in batches.
        /// </summary>
        /// <param name="req"><see cref="CreateTasksRequest"/></param>
        /// <returns><see cref="CreateTasksResponse"/></returns>
        public CreateTasksResponse CreateTasksSync(CreateTasksRequest req)
        {
            return InternalRequestAsync<CreateTasksResponse>(req, "CreateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public Task<DeleteSparkAppResponse> DeleteSparkApp(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp");
        }

        /// <summary>
        /// This API is used to delete a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DeleteSparkAppRequest"/></param>
        /// <returns><see cref="DeleteSparkAppResponse"/></returns>
        public DeleteSparkAppResponse DeleteSparkAppSync(DeleteSparkAppRequest req)
        {
            return InternalRequestAsync<DeleteSparkAppResponse>(req, "DeleteSparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public Task<DescribeEngineUsageInfoResponse> DescribeEngineUsageInfo(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo");
        }

        /// <summary>
        /// This API is used to query the resource usage of a data engine based on its ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeEngineUsageInfoRequest"/></param>
        /// <returns><see cref="DescribeEngineUsageInfoResponse"/></returns>
        public DescribeEngineUsageInfoResponse DescribeEngineUsageInfoSync(DescribeEngineUsageInfoRequest req)
        {
            return InternalRequestAsync<DescribeEngineUsageInfoResponse>(req, "DescribeEngineUsageInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public Task<DescribeForbiddenTableProResponse> DescribeForbiddenTablePro(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro");
        }

        /// <summary>
        /// This API is used to get the list of disabled table attributes (new).
        /// </summary>
        /// <param name="req"><see cref="DescribeForbiddenTableProRequest"/></param>
        /// <returns><see cref="DescribeForbiddenTableProResponse"/></returns>
        public DescribeForbiddenTableProResponse DescribeForbiddenTableProSync(DescribeForbiddenTableProRequest req)
        {
            return InternalRequestAsync<DescribeForbiddenTableProResponse>(req, "DescribeForbiddenTablePro")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public Task<DescribeLakeFsDirSummaryResponse> DescribeLakeFsDirSummary(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary");
        }

        /// <summary>
        /// This API is used to query the summary of a specified directory in a managed storage.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsDirSummaryRequest"/></param>
        /// <returns><see cref="DescribeLakeFsDirSummaryResponse"/></returns>
        public DescribeLakeFsDirSummaryResponse DescribeLakeFsDirSummarySync(DescribeLakeFsDirSummaryRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsDirSummaryResponse>(req, "DescribeLakeFsDirSummary")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public Task<DescribeLakeFsInfoResponse> DescribeLakeFsInfo(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo");
        }

        /// <summary>
        /// This API is used to query managed storage information.
        /// </summary>
        /// <param name="req"><see cref="DescribeLakeFsInfoRequest"/></param>
        /// <returns><see cref="DescribeLakeFsInfoResponse"/></returns>
        public DescribeLakeFsInfoResponse DescribeLakeFsInfoSync(DescribeLakeFsInfoRequest req)
        {
            return InternalRequestAsync<DescribeLakeFsInfoResponse>(req, "DescribeLakeFsInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public Task<DescribeResultDownloadResponse> DescribeResultDownload(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload");
        }

        /// <summary>
        /// This API is used to get a query result download task.
        /// </summary>
        /// <param name="req"><see cref="DescribeResultDownloadRequest"/></param>
        /// <returns><see cref="DescribeResultDownloadResponse"/></returns>
        public DescribeResultDownloadResponse DescribeResultDownloadSync(DescribeResultDownloadRequest req)
        {
            return InternalRequestAsync<DescribeResultDownloadResponse>(req, "DescribeResultDownload")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public Task<DescribeSparkAppJobResponse> DescribeSparkAppJob(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob");
        }

        /// <summary>
        /// u200cThis API is used to query the information of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobResponse"/></returns>
        public DescribeSparkAppJobResponse DescribeSparkAppJobSync(DescribeSparkAppJobRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobResponse>(req, "DescribeSparkAppJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public Task<DescribeSparkAppJobsResponse> DescribeSparkAppJobs(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs");
        }

        /// <summary>
        /// This API is used to query the list of Spark jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppJobsRequest"/></param>
        /// <returns><see cref="DescribeSparkAppJobsResponse"/></returns>
        public DescribeSparkAppJobsResponse DescribeSparkAppJobsSync(DescribeSparkAppJobsRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppJobsResponse>(req, "DescribeSparkAppJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public Task<DescribeSparkAppTasksResponse> DescribeSparkAppTasks(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks");
        }

        /// <summary>
        /// This API is used to query the list of running task instances of a Spark job.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkAppTasksRequest"/></param>
        /// <returns><see cref="DescribeSparkAppTasksResponse"/></returns>
        public DescribeSparkAppTasksResponse DescribeSparkAppTasksSync(DescribeSparkAppTasksRequest req)
        {
            return InternalRequestAsync<DescribeSparkAppTasksResponse>(req, "DescribeSparkAppTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the logs of a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public Task<DescribeSparkSessionBatchSqlLogResponse> DescribeSparkSessionBatchSqlLog(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog");
        }

        /// <summary>
        /// This API is used to obtain the logs of a Spark SQL batch task.
        /// </summary>
        /// <param name="req"><see cref="DescribeSparkSessionBatchSqlLogRequest"/></param>
        /// <returns><see cref="DescribeSparkSessionBatchSqlLogResponse"/></returns>
        public DescribeSparkSessionBatchSqlLogResponse DescribeSparkSessionBatchSqlLogSync(DescribeSparkSessionBatchSqlLogRequest req)
        {
            return InternalRequestAsync<DescribeSparkSessionBatchSqlLogResponse>(req, "DescribeSparkSessionBatchSqlLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public Task<DescribeTaskResultResponse> DescribeTaskResult(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult");
        }

        /// <summary>
        /// This API is used to query the result of a task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskResultRequest"/></param>
        /// <returns><see cref="DescribeTaskResultResponse"/></returns>
        public DescribeTaskResultResponse DescribeTaskResultSync(DescribeTaskResultRequest req)
        {
            return InternalRequestAsync<DescribeTaskResultResponse>(req, "DescribeTaskResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks");
        }

        /// <summary>
        /// This API is used to query the list of tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
            return InternalRequestAsync<DescribeTasksResponse>(req, "DescribeTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public Task<DescribeUserRolesResponse> DescribeUserRoles(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles");
        }

        /// <summary>
        /// This API is used to enumerate user roles.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRolesRequest"/></param>
        /// <returns><see cref="DescribeUserRolesResponse"/></returns>
        public DescribeUserRolesResponse DescribeUserRolesSync(DescribeUserRolesRequest req)
        {
            return InternalRequestAsync<DescribeUserRolesResponse>(req, "DescribeUserRoles")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public Task<GenerateCreateMangedTableSqlResponse> GenerateCreateMangedTableSql(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql");
        }

        /// <summary>
        /// This API is used to generate SQL statements for creating a managed table.
        /// </summary>
        /// <param name="req"><see cref="GenerateCreateMangedTableSqlRequest"/></param>
        /// <returns><see cref="GenerateCreateMangedTableSqlResponse"/></returns>
        public GenerateCreateMangedTableSqlResponse GenerateCreateMangedTableSqlSync(GenerateCreateMangedTableSqlRequest req)
        {
            return InternalRequestAsync<GenerateCreateMangedTableSqlResponse>(req, "GenerateCreateMangedTableSql")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public Task<ModifyGovernEventRuleResponse> ModifyGovernEventRule(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule");
        }

        /// <summary>
        /// This API is used to change data governance event thresholds.
        /// </summary>
        /// <param name="req"><see cref="ModifyGovernEventRuleRequest"/></param>
        /// <returns><see cref="ModifyGovernEventRuleResponse"/></returns>
        public ModifyGovernEventRuleResponse ModifyGovernEventRuleSync(ModifyGovernEventRuleRequest req)
        {
            return InternalRequestAsync<ModifyGovernEventRuleResponse>(req, "ModifyGovernEventRule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public Task<ModifySparkAppResponse> ModifySparkApp(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp");
        }

        /// <summary>
        /// This API is used to update a Spark job.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppRequest"/></param>
        /// <returns><see cref="ModifySparkAppResponse"/></returns>
        public ModifySparkAppResponse ModifySparkAppSync(ModifySparkAppRequest req)
        {
            return InternalRequestAsync<ModifySparkAppResponse>(req, "ModifySparkApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public Task<ModifySparkAppBatchResponse> ModifySparkAppBatch(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch");
        }

        /// <summary>
        /// This API is used to modify Spark job parameters in batches.
        /// </summary>
        /// <param name="req"><see cref="ModifySparkAppBatchRequest"/></param>
        /// <returns><see cref="ModifySparkAppBatchResponse"/></returns>
        public ModifySparkAppBatchResponse ModifySparkAppBatchSync(ModifySparkAppBatchRequest req)
        {
            return InternalRequestAsync<ModifySparkAppBatchResponse>(req, "ModifySparkAppBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public Task<SuspendResumeDataEngineResponse> SuspendResumeDataEngine(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine");
        }

        /// <summary>
        /// This API is used to suspend or start a data engine.
        /// </summary>
        /// <param name="req"><see cref="SuspendResumeDataEngineRequest"/></param>
        /// <returns><see cref="SuspendResumeDataEngineResponse"/></returns>
        public SuspendResumeDataEngineResponse SuspendResumeDataEngineSync(SuspendResumeDataEngineRequest req)
        {
            return InternalRequestAsync<SuspendResumeDataEngineResponse>(req, "SuspendResumeDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public Task<SwitchDataEngineResponse> SwitchDataEngine(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine");
        }

        /// <summary>
        /// This API is used to switch between the primary and standby clusters.
        /// </summary>
        /// <param name="req"><see cref="SwitchDataEngineRequest"/></param>
        /// <returns><see cref="SwitchDataEngineResponse"/></returns>
        public SwitchDataEngineResponse SwitchDataEngineSync(SwitchDataEngineRequest req)
        {
            return InternalRequestAsync<SwitchDataEngineResponse>(req, "SwitchDataEngine")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public Task<UpdateRowFilterResponse> UpdateRowFilter(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter");
        }

        /// <summary>
        /// This API is used to update row filters. Please note that it updates filters only but not catalogs, databases, or tables.
        /// </summary>
        /// <param name="req"><see cref="UpdateRowFilterRequest"/></param>
        /// <returns><see cref="UpdateRowFilterResponse"/></returns>
        public UpdateRowFilterResponse UpdateRowFilterSync(UpdateRowFilterRequest req)
        {
            return InternalRequestAsync<UpdateRowFilterResponse>(req, "UpdateRowFilter")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

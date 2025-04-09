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

namespace TencentCloud.Batch.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Batch.V20170312.Models;

   public class BatchClient : AbstractClient{

       private const string endpoint = "batch.intl.tencentcloudapi.com";
       private const string version = "2017-03-12";
       private const string sdkVersion = "SDK_NET_3.0.1108";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BatchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BatchClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add existing instances to the compute environment.
        /// Requirements: <br/>
        /// 1. The instance is not in the batch compute system.<br/>
        /// 2. The instance is in “Running” status.<br/>
        /// 3. Spot instances are not supported.<b/>
        /// 
        /// For instances added to the compute environment, their UserData will be reset, and the operating systems will be reinstalled.
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances");
        }

        /// <summary>
        /// This API is used to add existing instances to the compute environment.
        /// Requirements: <br/>
        /// 1. The instance is not in the batch compute system.<br/>
        /// 2. The instance is in “Running” status.<br/>
        /// 3. Spot instances are not supported.<b/>
        /// 
        /// For instances added to the compute environment, their UserData will be reset, and the operating systems will be reinstalled.
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public AttachInstancesResponse AttachInstancesSync(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a compute environment.
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public Task<CreateComputeEnvResponse> CreateComputeEnv(CreateComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateComputeEnvResponse>(req, "CreateComputeEnv");
        }

        /// <summary>
        /// This API is used to create a compute environment.
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public CreateComputeEnvResponse CreateComputeEnvSync(CreateComputeEnvRequest req)
        {
            return InternalRequestAsync<CreateComputeEnvResponse>(req, "CreateComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a task template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public Task<CreateTaskTemplateResponse> CreateTaskTemplate(CreateTaskTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskTemplateResponse>(req, "CreateTaskTemplate");
        }

        /// <summary>
        /// This API is used to create a task template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public CreateTaskTemplateResponse CreateTaskTemplateSync(CreateTaskTemplateRequest req)
        {
            return InternalRequestAsync<CreateTaskTemplateResponse>(req, "CreateTaskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a compute environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public Task<DeleteComputeEnvResponse> DeleteComputeEnv(DeleteComputeEnvRequest req)
        {
            return InternalRequestAsync<DeleteComputeEnvResponse>(req, "DeleteComputeEnv");
        }

        /// <summary>
        /// This API is used to delete a compute environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public DeleteComputeEnvResponse DeleteComputeEnvSync(DeleteComputeEnvRequest req)
        {
            return InternalRequestAsync<DeleteComputeEnvResponse>(req, "DeleteComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a job.
        /// When a job is deleted, all related information is deleted and the job cannot be queried.
        /// To delete a job, the job and all its task instances must be in SUCCEED or FAILED status.
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob");
        }

        /// <summary>
        /// This API is used to delete a job.
        /// When a job is deleted, all related information is deleted and the job cannot be queried.
        /// To delete a job, the job and all its task instances must be in SUCCEED or FAILED status.
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public DeleteJobResponse DeleteJobSync(DeleteJobRequest req)
        {
            return InternalRequestAsync<DeleteJobResponse>(req, "DeleteJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete task template information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public Task<DeleteTaskTemplatesResponse> DeleteTaskTemplates(DeleteTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteTaskTemplatesResponse>(req, "DeleteTaskTemplates");
        }

        /// <summary>
        /// This API is used to delete task template information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public DeleteTaskTemplatesResponse DeleteTaskTemplatesSync(DeleteTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DeleteTaskTemplatesResponse>(req, "DeleteTaskTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public Task<DescribeAvailableCvmInstanceTypesResponse> DescribeAvailableCvmInstanceTypes(DescribeAvailableCvmInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCvmInstanceTypesResponse>(req, "DescribeAvailableCvmInstanceTypes");
        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public DescribeAvailableCvmInstanceTypesResponse DescribeAvailableCvmInstanceTypesSync(DescribeAvailableCvmInstanceTypesRequest req)
        {
            return InternalRequestAsync<DescribeAvailableCvmInstanceTypesResponse>(req, "DescribeAvailableCvmInstanceTypes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query compute environment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public Task<DescribeComputeEnvResponse> DescribeComputeEnv(DescribeComputeEnvRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvResponse>(req, "DescribeComputeEnv");
        }

        /// <summary>
        /// This API is used to query compute environment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public DescribeComputeEnvResponse DescribeComputeEnvSync(DescribeComputeEnvRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvResponse>(req, "DescribeComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of activities in the compute environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public Task<DescribeComputeEnvActivitiesResponse> DescribeComputeEnvActivities(DescribeComputeEnvActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvActivitiesResponse>(req, "DescribeComputeEnvActivities");
        }

        /// <summary>
        /// This API is used to query the information of activities in the compute environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public DescribeComputeEnvActivitiesResponse DescribeComputeEnvActivitiesSync(DescribeComputeEnvActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvActivitiesResponse>(req, "DescribeComputeEnvActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the compute environment creation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public Task<DescribeComputeEnvCreateInfoResponse> DescribeComputeEnvCreateInfo(DescribeComputeEnvCreateInfoRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfoResponse>(req, "DescribeComputeEnvCreateInfo");
        }

        /// <summary>
        /// This API is used to query the compute environment creation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public DescribeComputeEnvCreateInfoResponse DescribeComputeEnvCreateInfoSync(DescribeComputeEnvCreateInfoRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfoResponse>(req, "DescribeComputeEnvCreateInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the list of information of compute environment creation, including name, description, type, environment parameters, notifications, and number of desired nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public Task<DescribeComputeEnvCreateInfosResponse> DescribeComputeEnvCreateInfos(DescribeComputeEnvCreateInfosRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfosResponse>(req, "DescribeComputeEnvCreateInfos");
        }

        /// <summary>
        /// This API is used to view the list of information of compute environment creation, including name, description, type, environment parameters, notifications, and number of desired nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public DescribeComputeEnvCreateInfosResponse DescribeComputeEnvCreateInfosSync(DescribeComputeEnvCreateInfosRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvCreateInfosResponse>(req, "DescribeComputeEnvCreateInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of compute environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public Task<DescribeComputeEnvsResponse> DescribeComputeEnvs(DescribeComputeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvsResponse>(req, "DescribeComputeEnvs");
        }

        /// <summary>
        /// This API is used to get the list of compute environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public DescribeComputeEnvsResponse DescribeComputeEnvsSync(DescribeComputeEnvsRequest req)
        {
            return InternalRequestAsync<DescribeComputeEnvsResponse>(req, "DescribeComputeEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public Task<DescribeCvmZoneInstanceConfigInfosResponse> DescribeCvmZoneInstanceConfigInfos(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeCvmZoneInstanceConfigInfosResponse>(req, "DescribeCvmZoneInstanceConfigInfos");
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public DescribeCvmZoneInstanceConfigInfosResponse DescribeCvmZoneInstanceConfigInfosSync(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
            return InternalRequestAsync<DescribeCvmZoneInstanceConfigInfosResponse>(req, "DescribeCvmZoneInstanceConfigInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public Task<DescribeInstanceCategoriesResponse> DescribeInstanceCategories(DescribeInstanceCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCategoriesResponse>(req, "DescribeInstanceCategories");
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public DescribeInstanceCategoriesResponse DescribeInstanceCategoriesSync(DescribeInstanceCategoriesRequest req)
        {
            return InternalRequestAsync<DescribeInstanceCategoriesResponse>(req, "DescribeInstanceCategories")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a job, including internal task (`Task`) and dependency (`Dependence`) information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob");
        }

        /// <summary>
        /// This API is used to query the details of a job, including internal task (`Task`) and dependency (`Dependence`) information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
            return InternalRequestAsync<DescribeJobResponse>(req, "DescribeJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the submission information of the specified job, with the return including the job submission information used as input parameters in the JobId and SubmitJob APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public Task<DescribeJobSubmitInfoResponse> DescribeJobSubmitInfo(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo");
        }

        /// <summary>
        /// This API is used to query the submission information of the specified job, with the return including the job submission information used as input parameters in the JobId and SubmitJob APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public DescribeJobSubmitInfoResponse DescribeJobSubmitInfoSync(DescribeJobSubmitInfoRequest req)
        {
            return InternalRequestAsync<DescribeJobSubmitInfoResponse>(req, "DescribeJobSubmitInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview information of several jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs");
        }

        /// <summary>
        /// This API is used to query the overview information of several jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
            return InternalRequestAsync<DescribeJobsResponse>(req, "DescribeJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a specified task, including information of the task instances inside the task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask");
        }

        /// <summary>
        /// This API is used to query the details of a specified task, including information of the task instances inside the task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
            return InternalRequestAsync<DescribeTaskResponse>(req, "DescribeTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the standard outputs and standard error logs of multiple task instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public Task<DescribeTaskLogsResponse> DescribeTaskLogs(DescribeTaskLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogsResponse>(req, "DescribeTaskLogs");
        }

        /// <summary>
        /// This API is used to get the standard outputs and standard error logs of multiple task instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public DescribeTaskLogsResponse DescribeTaskLogsSync(DescribeTaskLogsRequest req)
        {
            return InternalRequestAsync<DescribeTaskLogsResponse>(req, "DescribeTaskLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of task templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public Task<DescribeTaskTemplatesResponse> DescribeTaskTemplates(DescribeTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTaskTemplatesResponse>(req, "DescribeTaskTemplates");
        }

        /// <summary>
        /// This API is used to query the information of task templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public DescribeTaskTemplatesResponse DescribeTaskTemplatesSync(DescribeTaskTemplatesRequest req)
        {
            return InternalRequestAsync<DescribeTaskTemplatesResponse>(req, "DescribeTaskTemplates")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove instances that from compute environment. 
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances");
        }

        /// <summary>
        /// This API is used to remove instances that from compute environment. 
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public DetachInstancesResponse DetachInstancesSync(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the attributes of a compute environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public Task<ModifyComputeEnvResponse> ModifyComputeEnv(ModifyComputeEnvRequest req)
        {
            return InternalRequestAsync<ModifyComputeEnvResponse>(req, "ModifyComputeEnv");
        }

        /// <summary>
        /// This API is used to modify the attributes of a compute environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public ModifyComputeEnvResponse ModifyComputeEnvSync(ModifyComputeEnvRequest req)
        {
            return InternalRequestAsync<ModifyComputeEnvResponse>(req, "ModifyComputeEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a task template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public Task<ModifyTaskTemplateResponse> ModifyTaskTemplate(ModifyTaskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTaskTemplateResponse>(req, "ModifyTaskTemplate");
        }

        /// <summary>
        /// This API is used to modify a task template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public ModifyTaskTemplateResponse ModifyTaskTemplateSync(ModifyTaskTemplateRequest req)
        {
            return InternalRequestAsync<ModifyTaskTemplateResponse>(req, "ModifyTaskTemplate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to retry the failed task instances in a job.
        /// Job retry is supported only if a job is in the "FAILED" state. After the retry operation succeeds, the job will retry the failing task instances in each task in turn according to the task dependencies specified in the "DAG". The history information of the task instances will be reset, the instances will participate in subsequent scheduling and execution as if they are run for the first time.
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public Task<RetryJobsResponse> RetryJobs(RetryJobsRequest req)
        {
            return InternalRequestAsync<RetryJobsResponse>(req, "RetryJobs");
        }

        /// <summary>
        /// This API is used to retry the failed task instances in a job.
        /// Job retry is supported only if a job is in the "FAILED" state. After the retry operation succeeds, the job will retry the failing task instances in each task in turn according to the task dependencies specified in the "DAG". The history information of the task instances will be reset, the instances will participate in subsequent scheduling and execution as if they are run for the first time.
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public RetryJobsResponse RetryJobsSync(RetryJobsRequest req)
        {
            return InternalRequestAsync<RetryJobsResponse>(req, "RetryJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a compute node.
        /// Termination is allowed for nodes in the CREATED, CREATION_FAILED, RUNNING or ABNORMAL state.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public Task<TerminateComputeNodeResponse> TerminateComputeNode(TerminateComputeNodeRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodeResponse>(req, "TerminateComputeNode");
        }

        /// <summary>
        /// This API is used to terminate a compute node.
        /// Termination is allowed for nodes in the CREATED, CREATION_FAILED, RUNNING or ABNORMAL state.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public TerminateComputeNodeResponse TerminateComputeNodeSync(TerminateComputeNodeRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodeResponse>(req, "TerminateComputeNode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate compute nodes in batches. It is not allowed to repeatedly terminate the same node.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public Task<TerminateComputeNodesResponse> TerminateComputeNodes(TerminateComputeNodesRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodesResponse>(req, "TerminateComputeNodes");
        }

        /// <summary>
        /// This API is used to terminate compute nodes in batches. It is not allowed to repeatedly terminate the same node.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public TerminateComputeNodesResponse TerminateComputeNodesSync(TerminateComputeNodesRequest req)
        {
            return InternalRequestAsync<TerminateComputeNodesResponse>(req, "TerminateComputeNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a job.
        /// Termination is prohibited if a job is in the `SUBMITTED` state and does not take effect if it is in the `SUCCEED` state.
        /// Job termination is an asynchronous process, and the time it takes to complete the entire process is directly proportional to the total number of tasks. The effect of terminating a job is equivalent to performing the TerminateTaskInstance operation on all the task instances contained in the job. For more information on the specific effect and usage, see TerminateTaskInstance.
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public Task<TerminateJobResponse> TerminateJob(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob");
        }

        /// <summary>
        /// This API is used to terminate a job.
        /// Termination is prohibited if a job is in the `SUBMITTED` state and does not take effect if it is in the `SUCCEED` state.
        /// Job termination is an asynchronous process, and the time it takes to complete the entire process is directly proportional to the total number of tasks. The effect of terminating a job is equivalent to performing the TerminateTaskInstance operation on all the task instances contained in the job. For more information on the specific effect and usage, see TerminateTaskInstance.
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public TerminateJobResponse TerminateJobSync(TerminateJobRequest req)
        {
            return InternalRequestAsync<TerminateJobResponse>(req, "TerminateJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a task instance.
        /// `SUCCEED` and `FAILED` task instances: No action
        /// `SUBMITTED`, `PENDING`, and `RUNNABLE` task instances: Change status to `FAILED`.
        /// `STARTING`, `RUNNING` and `FAILED_INTERRUPTED` task instances: If `EnvId` is not specified, the CVM instance is terminated, and then the task status goes to `FAILED`. If `EnvId` is specified, the task instance changes to `FAILED`, then the related CVM instance is restarted. 
        /// `FAILED_INTERRUPTED` task instances: The related resources and quotas will be released only after the termination actually succeeds.
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskInstanceRequest"/></param>
        /// <returns><see cref="TerminateTaskInstanceResponse"/></returns>
        public Task<TerminateTaskInstanceResponse> TerminateTaskInstance(TerminateTaskInstanceRequest req)
        {
            return InternalRequestAsync<TerminateTaskInstanceResponse>(req, "TerminateTaskInstance");
        }

        /// <summary>
        /// This API is used to terminate a task instance.
        /// `SUCCEED` and `FAILED` task instances: No action
        /// `SUBMITTED`, `PENDING`, and `RUNNABLE` task instances: Change status to `FAILED`.
        /// `STARTING`, `RUNNING` and `FAILED_INTERRUPTED` task instances: If `EnvId` is not specified, the CVM instance is terminated, and then the task status goes to `FAILED`. If `EnvId` is specified, the task instance changes to `FAILED`, then the related CVM instance is restarted. 
        /// `FAILED_INTERRUPTED` task instances: The related resources and quotas will be released only after the termination actually succeeds.
        /// </summary>
        /// <param name="req"><see cref="TerminateTaskInstanceRequest"/></param>
        /// <returns><see cref="TerminateTaskInstanceResponse"/></returns>
        public TerminateTaskInstanceResponse TerminateTaskInstanceSync(TerminateTaskInstanceRequest req)
        {
            return InternalRequestAsync<TerminateTaskInstanceResponse>(req, "TerminateTaskInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

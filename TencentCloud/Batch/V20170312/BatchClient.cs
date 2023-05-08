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

       private const string endpoint = "batch.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BatchClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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
        public async Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
             JsonResponseModel<AttachInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AttachInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a compute environment.
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public async Task<CreateComputeEnvResponse> CreateComputeEnv(CreateComputeEnvRequest req)
        {
             JsonResponseModel<CreateComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a compute environment.
        /// </summary>
        /// <param name="req"><see cref="CreateComputeEnvRequest"/></param>
        /// <returns><see cref="CreateComputeEnvResponse"/></returns>
        public CreateComputeEnvResponse CreateComputeEnvSync(CreateComputeEnvRequest req)
        {
             JsonResponseModel<CreateComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a task template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public async Task<CreateTaskTemplateResponse> CreateTaskTemplate(CreateTaskTemplateRequest req)
        {
             JsonResponseModel<CreateTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a task template.
        /// </summary>
        /// <param name="req"><see cref="CreateTaskTemplateRequest"/></param>
        /// <returns><see cref="CreateTaskTemplateResponse"/></returns>
        public CreateTaskTemplateResponse CreateTaskTemplateSync(CreateTaskTemplateRequest req)
        {
             JsonResponseModel<CreateTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a compute environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public async Task<DeleteComputeEnvResponse> DeleteComputeEnv(DeleteComputeEnvRequest req)
        {
             JsonResponseModel<DeleteComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a compute environment.
        /// </summary>
        /// <param name="req"><see cref="DeleteComputeEnvRequest"/></param>
        /// <returns><see cref="DeleteComputeEnvResponse"/></returns>
        public DeleteComputeEnvResponse DeleteComputeEnvSync(DeleteComputeEnvRequest req)
        {
             JsonResponseModel<DeleteComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a job.
        /// When a job is deleted, all related information is deleted and the job cannot be queried.
        /// To delete a job, the job and all its task instances must be in SUCCEED or FAILED status.
        /// </summary>
        /// <param name="req"><see cref="DeleteJobRequest"/></param>
        /// <returns><see cref="DeleteJobResponse"/></returns>
        public async Task<DeleteJobResponse> DeleteJob(DeleteJobRequest req)
        {
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete task template information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public async Task<DeleteTaskTemplatesResponse> DeleteTaskTemplates(DeleteTaskTemplatesRequest req)
        {
             JsonResponseModel<DeleteTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete task template information.
        /// </summary>
        /// <param name="req"><see cref="DeleteTaskTemplatesRequest"/></param>
        /// <returns><see cref="DeleteTaskTemplatesResponse"/></returns>
        public DeleteTaskTemplatesResponse DeleteTaskTemplatesSync(DeleteTaskTemplatesRequest req)
        {
             JsonResponseModel<DeleteTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public async Task<DescribeAvailableCvmInstanceTypesResponse> DescribeAvailableCvmInstanceTypes(DescribeAvailableCvmInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableCvmInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the information of available CVM model configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableCvmInstanceTypesRequest"/></param>
        /// <returns><see cref="DescribeAvailableCvmInstanceTypesResponse"/></returns>
        public DescribeAvailableCvmInstanceTypesResponse DescribeAvailableCvmInstanceTypesSync(DescribeAvailableCvmInstanceTypesRequest req)
        {
             JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableCvmInstanceTypes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableCvmInstanceTypesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query compute environment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public async Task<DescribeComputeEnvResponse> DescribeComputeEnv(DescribeComputeEnvRequest req)
        {
             JsonResponseModel<DescribeComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query compute environment details.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvResponse"/></returns>
        public DescribeComputeEnvResponse DescribeComputeEnvSync(DescribeComputeEnvRequest req)
        {
             JsonResponseModel<DescribeComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of activities in the compute environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public async Task<DescribeComputeEnvActivitiesResponse> DescribeComputeEnvActivities(DescribeComputeEnvActivitiesRequest req)
        {
             JsonResponseModel<DescribeComputeEnvActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of activities in the compute environment.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvActivitiesRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvActivitiesResponse"/></returns>
        public DescribeComputeEnvActivitiesResponse DescribeComputeEnvActivitiesSync(DescribeComputeEnvActivitiesRequest req)
        {
             JsonResponseModel<DescribeComputeEnvActivitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComputeEnvActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the compute environment creation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public async Task<DescribeComputeEnvCreateInfoResponse> DescribeComputeEnvCreateInfo(DescribeComputeEnvCreateInfoRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvCreateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the compute environment creation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfoRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfoResponse"/></returns>
        public DescribeComputeEnvCreateInfoResponse DescribeComputeEnvCreateInfoSync(DescribeComputeEnvCreateInfoRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComputeEnvCreateInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of information of compute environment creation, including name, description, type, environment parameters, notifications, and number of desired nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public async Task<DescribeComputeEnvCreateInfosResponse> DescribeComputeEnvCreateInfos(DescribeComputeEnvCreateInfosRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvCreateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to view the list of information of compute environment creation, including name, description, type, environment parameters, notifications, and number of desired nodes.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvCreateInfosRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvCreateInfosResponse"/></returns>
        public DescribeComputeEnvCreateInfosResponse DescribeComputeEnvCreateInfosSync(DescribeComputeEnvCreateInfosRequest req)
        {
             JsonResponseModel<DescribeComputeEnvCreateInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComputeEnvCreateInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvCreateInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of compute environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public async Task<DescribeComputeEnvsResponse> DescribeComputeEnvs(DescribeComputeEnvsRequest req)
        {
             JsonResponseModel<DescribeComputeEnvsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeComputeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of compute environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeComputeEnvsRequest"/></param>
        /// <returns><see cref="DescribeComputeEnvsResponse"/></returns>
        public DescribeComputeEnvsResponse DescribeComputeEnvsSync(DescribeComputeEnvsRequest req)
        {
             JsonResponseModel<DescribeComputeEnvsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeComputeEnvs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeComputeEnvsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public async Task<DescribeCvmZoneInstanceConfigInfosResponse> DescribeCvmZoneInstanceConfigInfos(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCvmZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the model configuration information of the availability zone of BatchCompute.
        /// </summary>
        /// <param name="req"><see cref="DescribeCvmZoneInstanceConfigInfosRequest"/></param>
        /// <returns><see cref="DescribeCvmZoneInstanceConfigInfosResponse"/></returns>
        public DescribeCvmZoneInstanceConfigInfosResponse DescribeCvmZoneInstanceConfigInfosSync(DescribeCvmZoneInstanceConfigInfosRequest req)
        {
             JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCvmZoneInstanceConfigInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCvmZoneInstanceConfigInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public async Task<DescribeInstanceCategoriesResponse> DescribeInstanceCategories(DescribeInstanceCategoriesRequest req)
        {
             JsonResponseModel<DescribeInstanceCategoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeInstanceCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Currently, CVM instance families are classified into different category, and each category contains several instance families. This API is used to query the instance category information.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceCategoriesRequest"/></param>
        /// <returns><see cref="DescribeInstanceCategoriesResponse"/></returns>
        public DescribeInstanceCategoriesResponse DescribeInstanceCategoriesSync(DescribeInstanceCategoriesRequest req)
        {
             JsonResponseModel<DescribeInstanceCategoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeInstanceCategories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeInstanceCategoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a job, including internal task (`Task`) and dependency (`Dependence`) information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public async Task<DescribeJobResponse> DescribeJob(DescribeJobRequest req)
        {
             JsonResponseModel<DescribeJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a job, including internal task (`Task`) and dependency (`Dependence`) information.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobRequest"/></param>
        /// <returns><see cref="DescribeJobResponse"/></returns>
        public DescribeJobResponse DescribeJobSync(DescribeJobRequest req)
        {
             JsonResponseModel<DescribeJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the submission information of the specified job, with the return including the job submission information used as input parameters in the JobId and SubmitJob APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public async Task<DescribeJobSubmitInfoResponse> DescribeJobSubmitInfo(DescribeJobSubmitInfoRequest req)
        {
             JsonResponseModel<DescribeJobSubmitInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobSubmitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobSubmitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the submission information of the specified job, with the return including the job submission information used as input parameters in the JobId and SubmitJob APIs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobSubmitInfoRequest"/></param>
        /// <returns><see cref="DescribeJobSubmitInfoResponse"/></returns>
        public DescribeJobSubmitInfoResponse DescribeJobSubmitInfoSync(DescribeJobSubmitInfoRequest req)
        {
             JsonResponseModel<DescribeJobSubmitInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobSubmitInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobSubmitInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the overview information of several jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public async Task<DescribeJobsResponse> DescribeJobs(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the overview information of several jobs.
        /// </summary>
        /// <param name="req"><see cref="DescribeJobsRequest"/></param>
        /// <returns><see cref="DescribeJobsResponse"/></returns>
        public DescribeJobsResponse DescribeJobsSync(DescribeJobsRequest req)
        {
             JsonResponseModel<DescribeJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a specified task, including information of the task instances inside the task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public async Task<DescribeTaskResponse> DescribeTask(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a specified task, including information of the task instances inside the task.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskRequest"/></param>
        /// <returns><see cref="DescribeTaskResponse"/></returns>
        public DescribeTaskResponse DescribeTaskSync(DescribeTaskRequest req)
        {
             JsonResponseModel<DescribeTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the standard outputs and standard error logs of multiple task instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public async Task<DescribeTaskLogsResponse> DescribeTaskLogs(DescribeTaskLogsRequest req)
        {
             JsonResponseModel<DescribeTaskLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the standard outputs and standard error logs of multiple task instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskLogsRequest"/></param>
        /// <returns><see cref="DescribeTaskLogsResponse"/></returns>
        public DescribeTaskLogsResponse DescribeTaskLogsSync(DescribeTaskLogsRequest req)
        {
             JsonResponseModel<DescribeTaskLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of task templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public async Task<DescribeTaskTemplatesResponse> DescribeTaskTemplates(DescribeTaskTemplatesRequest req)
        {
             JsonResponseModel<DescribeTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of task templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTaskTemplatesResponse"/></returns>
        public DescribeTaskTemplatesResponse DescribeTaskTemplatesSync(DescribeTaskTemplatesRequest req)
        {
             JsonResponseModel<DescribeTaskTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove instances that from compute environment. 
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public async Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
             JsonResponseModel<DetachInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove instances that from compute environment. 
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public DetachInstancesResponse DetachInstancesSync(DetachInstancesRequest req)
        {
             JsonResponseModel<DetachInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a compute environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public async Task<ModifyComputeEnvResponse> ModifyComputeEnv(ModifyComputeEnvRequest req)
        {
             JsonResponseModel<ModifyComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the attributes of a compute environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyComputeEnvRequest"/></param>
        /// <returns><see cref="ModifyComputeEnvResponse"/></returns>
        public ModifyComputeEnvResponse ModifyComputeEnvSync(ModifyComputeEnvRequest req)
        {
             JsonResponseModel<ModifyComputeEnvResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyComputeEnv");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyComputeEnvResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a task template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public async Task<ModifyTaskTemplateResponse> ModifyTaskTemplate(ModifyTaskTemplateRequest req)
        {
             JsonResponseModel<ModifyTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a task template.
        /// </summary>
        /// <param name="req"><see cref="ModifyTaskTemplateRequest"/></param>
        /// <returns><see cref="ModifyTaskTemplateResponse"/></returns>
        public ModifyTaskTemplateResponse ModifyTaskTemplateSync(ModifyTaskTemplateRequest req)
        {
             JsonResponseModel<ModifyTaskTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTaskTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTaskTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry the failed task instances in a job.
        /// Job retry is supported only if a job is in the "FAILED" state. After the retry operation succeeds, the job will retry the failing task instances in each task in turn according to the task dependencies specified in the "DAG". The history information of the task instances will be reset, the instances will participate in subsequent scheduling and execution as if they are run for the first time.
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public async Task<RetryJobsResponse> RetryJobs(RetryJobsRequest req)
        {
             JsonResponseModel<RetryJobsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RetryJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to retry the failed task instances in a job.
        /// Job retry is supported only if a job is in the "FAILED" state. After the retry operation succeeds, the job will retry the failing task instances in each task in turn according to the task dependencies specified in the "DAG". The history information of the task instances will be reset, the instances will participate in subsequent scheduling and execution as if they are run for the first time.
        /// </summary>
        /// <param name="req"><see cref="RetryJobsRequest"/></param>
        /// <returns><see cref="RetryJobsResponse"/></returns>
        public RetryJobsResponse RetryJobsSync(RetryJobsRequest req)
        {
             JsonResponseModel<RetryJobsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RetryJobs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RetryJobsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a compute node.
        /// Termination is allowed for nodes in the CREATED, CREATION_FAILED, RUNNING or ABNORMAL state.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public async Task<TerminateComputeNodeResponse> TerminateComputeNode(TerminateComputeNodeRequest req)
        {
             JsonResponseModel<TerminateComputeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateComputeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a compute node.
        /// Termination is allowed for nodes in the CREATED, CREATION_FAILED, RUNNING or ABNORMAL state.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodeRequest"/></param>
        /// <returns><see cref="TerminateComputeNodeResponse"/></returns>
        public TerminateComputeNodeResponse TerminateComputeNodeSync(TerminateComputeNodeRequest req)
        {
             JsonResponseModel<TerminateComputeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateComputeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate compute nodes in batches. It is not allowed to repeatedly terminate the same node.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public async Task<TerminateComputeNodesResponse> TerminateComputeNodes(TerminateComputeNodesRequest req)
        {
             JsonResponseModel<TerminateComputeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateComputeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate compute nodes in batches. It is not allowed to repeatedly terminate the same node.
        /// </summary>
        /// <param name="req"><see cref="TerminateComputeNodesRequest"/></param>
        /// <returns><see cref="TerminateComputeNodesResponse"/></returns>
        public TerminateComputeNodesResponse TerminateComputeNodesSync(TerminateComputeNodesRequest req)
        {
             JsonResponseModel<TerminateComputeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateComputeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateComputeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate a job.
        /// Termination is prohibited if a job is in the `SUBMITTED` state and does not take effect if it is in the `SUCCEED` state.
        /// Job termination is an asynchronous process, and the time it takes to complete the entire process is directly proportional to the total number of tasks. The effect of terminating a job is equivalent to performing the TerminateTaskInstance operation on all the task instances contained in the job. For more information on the specific effect and usage, see TerminateTaskInstance.
        /// </summary>
        /// <param name="req"><see cref="TerminateJobRequest"/></param>
        /// <returns><see cref="TerminateJobResponse"/></returns>
        public async Task<TerminateJobResponse> TerminateJob(TerminateJobRequest req)
        {
             JsonResponseModel<TerminateJobResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<TerminateJobResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateJob");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateJobResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<TerminateTaskInstanceResponse> TerminateTaskInstance(TerminateTaskInstanceRequest req)
        {
             JsonResponseModel<TerminateTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<TerminateTaskInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateTaskInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateTaskInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

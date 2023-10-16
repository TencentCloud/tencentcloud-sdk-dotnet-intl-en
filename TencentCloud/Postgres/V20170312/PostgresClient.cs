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

namespace TencentCloud.Postgres.V20170312
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Postgres.V20170312.Models;

   public class PostgresClient : AbstractClient{

       private const string endpoint = "postgres.tencentcloudapi.com";
       private const string version = "2017-03-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PostgresClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PostgresClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add a read-only replica to an RO group.
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public async Task<AddDBInstanceToReadOnlyGroupResponse> AddDBInstanceToReadOnlyGroup(AddDBInstanceToReadOnlyGroupRequest req)
        {
             JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDBInstanceToReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a read-only replica to an RO group.
        /// </summary>
        /// <param name="req"><see cref="AddDBInstanceToReadOnlyGroupRequest"/></param>
        /// <returns><see cref="AddDBInstanceToReadOnlyGroupResponse"/></returns>
        public AddDBInstanceToReadOnlyGroupResponse AddDBInstanceToReadOnlyGroupSync(AddDBInstanceToReadOnlyGroupRequest req)
        {
             JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDBInstanceToReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDBInstanceToReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clone an instance by specifying a backup set or a point in time.
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public async Task<CloneDBInstanceResponse> CloneDBInstance(CloneDBInstanceRequest req)
        {
             JsonResponseModel<CloneDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloneDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clone an instance by specifying a backup set or a point in time.
        /// </summary>
        /// <param name="req"><see cref="CloneDBInstanceRequest"/></param>
        /// <returns><see cref="CloneDBInstanceResponse"/></returns>
        public CloneDBInstanceResponse CloneDBInstanceSync(CloneDBInstanceRequest req)
        {
             JsonResponseModel<CloneDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloneDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloneDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the public network address of an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public async Task<CloseDBExtranetAccessResponse> CloseDBExtranetAccess(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the public network address of an instance.
        /// </summary>
        /// <param name="req"><see cref="CloseDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseDBExtranetAccessResponse"/></returns>
        public CloseDBExtranetAccessResponse CloseDBExtranetAccessSync(CloseDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public async Task<CloseServerlessDBExtranetAccessResponse> CloseServerlessDBExtranetAccess(CloseServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to disable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="CloseServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="CloseServerlessDBExtranetAccessResponse"/></returns>
        public CloseServerlessDBExtranetAccessResponse CloseServerlessDBExtranetAccessSync(CloseServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<CloseServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a full backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public async Task<CreateBaseBackupResponse> CreateBaseBackup(CreateBaseBackupRequest req)
        {
             JsonResponseModel<CreateBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a full backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateBaseBackupRequest"/></param>
        /// <returns><see cref="CreateBaseBackupResponse"/></returns>
        public CreateBaseBackupResponse CreateBaseBackupSync(CreateBaseBackupRequest req)
        {
             JsonResponseModel<CreateBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public async Task<CreateDBInstanceNetworkAccessResponse> CreateDBInstanceNetworkAccess(CreateDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<CreateDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network for an instance.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateDBInstanceNetworkAccessResponse"/></returns>
        public CreateDBInstanceNetworkAccessResponse CreateDBInstanceNetworkAccessSync(CreateDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<CreateDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create (but not initialize) one or more TencentDB for PostgreSQL instances. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public async Task<CreateDBInstancesResponse> CreateDBInstances(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create (but not initialize) one or more TencentDB for PostgreSQL instances. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="CreateDBInstancesRequest"/></param>
        /// <returns><see cref="CreateDBInstancesResponse"/></returns>
        public CreateDBInstancesResponse CreateDBInstancesSync(CreateDBInstancesRequest req)
        {
             JsonResponseModel<CreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and initialize one or more TencentDB for PostgreSQL instances.
        /// <li>After an instance is created successfully, it will start up automatically and enter the "Running" status.
        /// <li>If you create a monthly subscribed instance, you will be billed for the instance before the creation; if you create a pay-as-you-go instance billed on an hourly basis, the amount equivalent to the hourly rate will be frozen before the creation. Make sure your account balance is sufficient before calling this API.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create and initialize one or more TencentDB for PostgreSQL instances.
        /// <li>After an instance is created successfully, it will start up automatically and enter the "Running" status.
        /// <li>If you create a monthly subscribed instance, you will be billed for the instance before the creation; if you create a pay-as-you-go instance billed on an hourly basis, the amount equivalent to the hourly rate will be frozen before the creation. Make sure your account balance is sufficient before calling this API.
        /// </summary>
        /// <param name="req"><see cref="CreateInstancesRequest"/></param>
        /// <returns><see cref="CreateInstancesResponse"/></returns>
        public CreateInstancesResponse CreateInstancesSync(CreateInstancesRequest req)
        {
             JsonResponseModel<CreateInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public async Task<CreateParameterTemplateResponse> CreateParameterTemplate(CreateParameterTemplateRequest req)
        {
             JsonResponseModel<CreateParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a parameter template.
        /// </summary>
        /// <param name="req"><see cref="CreateParameterTemplateRequest"/></param>
        /// <returns><see cref="CreateParameterTemplateResponse"/></returns>
        public CreateParameterTemplateResponse CreateParameterTemplateSync(CreateParameterTemplateRequest req)
        {
             JsonResponseModel<CreateParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create read-only replicas.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public async Task<CreateReadOnlyDBInstanceResponse> CreateReadOnlyDBInstance(CreateReadOnlyDBInstanceRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create read-only replicas.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyDBInstanceRequest"/></param>
        /// <returns><see cref="CreateReadOnlyDBInstanceResponse"/></returns>
        public CreateReadOnlyDBInstanceResponse CreateReadOnlyDBInstanceSync(CreateReadOnlyDBInstanceRequest req)
        {
             JsonResponseModel<CreateReadOnlyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public async Task<CreateReadOnlyGroupResponse> CreateReadOnlyGroup(CreateReadOnlyGroupRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupResponse"/></returns>
        public CreateReadOnlyGroupResponse CreateReadOnlyGroupSync(CreateReadOnlyGroupRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network for an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public async Task<CreateReadOnlyGroupNetworkAccessResponse> CreateReadOnlyGroupNetworkAccess(CreateReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a network for an RO group.
        /// </summary>
        /// <param name="req"><see cref="CreateReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="CreateReadOnlyGroupNetworkAccessResponse"/></returns>
        public CreateReadOnlyGroupNetworkAccessResponse CreateReadOnlyGroupNetworkAccessSync(CreateReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a PostgreSQL for Serverless instance. If the creation succeeds, the instance ID will be returned.
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public async Task<CreateServerlessDBInstanceResponse> CreateServerlessDBInstance(CreateServerlessDBInstanceRequest req)
        {
             JsonResponseModel<CreateServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a PostgreSQL for Serverless instance. If the creation succeeds, the instance ID will be returned.
        /// </summary>
        /// <param name="req"><see cref="CreateServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="CreateServerlessDBInstanceResponse"/></returns>
        public CreateServerlessDBInstanceResponse CreateServerlessDBInstanceSync(CreateServerlessDBInstanceRequest req)
        {
             JsonResponseModel<CreateServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified full backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public async Task<DeleteBaseBackupResponse> DeleteBaseBackup(DeleteBaseBackupRequest req)
        {
             JsonResponseModel<DeleteBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified full backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteBaseBackupRequest"/></param>
        /// <returns><see cref="DeleteBaseBackupResponse"/></returns>
        public DeleteBaseBackupResponse DeleteBaseBackupSync(DeleteBaseBackupRequest req)
        {
             JsonResponseModel<DeleteBaseBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteBaseBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteBaseBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public async Task<DeleteDBInstanceNetworkAccessResponse> DeleteDBInstanceNetworkAccess(DeleteDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBInstanceNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteDBInstanceNetworkAccessResponse"/></returns>
        public DeleteDBInstanceNetworkAccessResponse DeleteDBInstanceNetworkAccessSync(DeleteDBInstanceNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteDBInstanceNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDBInstanceNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBInstanceNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified log backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public async Task<DeleteLogBackupResponse> DeleteLogBackup(DeleteLogBackupRequest req)
        {
             JsonResponseModel<DeleteLogBackupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLogBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the specified log backup of an instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteLogBackupRequest"/></param>
        /// <returns><see cref="DeleteLogBackupResponse"/></returns>
        public DeleteLogBackupResponse DeleteLogBackupSync(DeleteLogBackupRequest req)
        {
             JsonResponseModel<DeleteLogBackupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLogBackup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLogBackupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public async Task<DeleteParameterTemplateResponse> DeleteParameterTemplate(DeleteParameterTemplateRequest req)
        {
             JsonResponseModel<DeleteParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a parameter template.
        /// </summary>
        /// <param name="req"><see cref="DeleteParameterTemplateRequest"/></param>
        /// <returns><see cref="DeleteParameterTemplateResponse"/></returns>
        public DeleteParameterTemplateResponse DeleteParameterTemplateSync(DeleteParameterTemplateRequest req)
        {
             JsonResponseModel<DeleteParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public async Task<DeleteReadOnlyGroupResponse> DeleteReadOnlyGroup(DeleteReadOnlyGroupRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupResponse"/></returns>
        public DeleteReadOnlyGroupResponse DeleteReadOnlyGroupSync(DeleteReadOnlyGroupRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network of an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public async Task<DeleteReadOnlyGroupNetworkAccessResponse> DeleteReadOnlyGroupNetworkAccess(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a network of an RO group.
        /// </summary>
        /// <param name="req"><see cref="DeleteReadOnlyGroupNetworkAccessRequest"/></param>
        /// <returns><see cref="DeleteReadOnlyGroupNetworkAccessResponse"/></returns>
        public DeleteReadOnlyGroupNetworkAccessResponse DeleteReadOnlyGroupNetworkAccessSync(DeleteReadOnlyGroupNetworkAccessRequest req)
        {
             JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteReadOnlyGroupNetworkAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteReadOnlyGroupNetworkAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public async Task<DeleteServerlessDBInstanceResponse> DeleteServerlessDBInstance(DeleteServerlessDBInstanceRequest req)
        {
             JsonResponseModel<DeleteServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="DeleteServerlessDBInstanceRequest"/></param>
        /// <returns><see cref="DeleteServerlessDBInstanceResponse"/></returns>
        public DeleteServerlessDBInstanceResponse DeleteServerlessDBInstanceSync(DeleteServerlessDBInstanceRequest req)
        {
             JsonResponseModel<DeleteServerlessDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteServerlessDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServerlessDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the database accounts for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public async Task<DescribeAccountsResponse> DescribeAccounts(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of the database accounts for an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountsRequest"/></param>
        /// <returns><see cref="DescribeAccountsResponse"/></returns>
        public DescribeAccountsResponse DescribeAccountsSync(DescribeAccountsRequest req)
        {
             JsonResponseModel<DescribeAccountsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccounts");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the available restoration time of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public async Task<DescribeAvailableRecoveryTimeResponse> DescribeAvailableRecoveryTime(DescribeAvailableRecoveryTimeRequest req)
        {
             JsonResponseModel<DescribeAvailableRecoveryTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAvailableRecoveryTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableRecoveryTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the available restoration time of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeAvailableRecoveryTimeRequest"/></param>
        /// <returns><see cref="DescribeAvailableRecoveryTimeResponse"/></returns>
        public DescribeAvailableRecoveryTimeResponse DescribeAvailableRecoveryTimeSync(DescribeAvailableRecoveryTimeRequest req)
        {
             JsonResponseModel<DescribeAvailableRecoveryTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAvailableRecoveryTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAvailableRecoveryTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public async Task<DescribeBackupDownloadRestrictionResponse> DescribeBackupDownloadRestriction(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadRestrictionResponse"/></returns>
        public DescribeBackupDownloadRestrictionResponse DescribeBackupDownloadRestrictionSync(DescribeBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to query the download address of a specified backup set, including full backup sets and incremental log backup sets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public async Task<DescribeBackupDownloadURLResponse> DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// u200cThis API is used to query the download address of a specified backup set, including full backup sets and incremental log backup sets.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupDownloadURLRequest"/></param>
        /// <returns><see cref="DescribeBackupDownloadURLResponse"/></returns>
        public DescribeBackupDownloadURLResponse DescribeBackupDownloadURLSync(DescribeBackupDownloadURLRequest req)
        {
             JsonResponseModel<DescribeBackupDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup overview. It will return the current number and size of backups, free backup space size, and paid backup space size (all size values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public async Task<DescribeBackupOverviewResponse> DescribeBackupOverview(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup overview. It will return the current number and size of backups, free backup space size, and paid backup space size (all size values are in bytes).
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupOverviewRequest"/></param>
        /// <returns><see cref="DescribeBackupOverviewResponse"/></returns>
        public DescribeBackupOverviewResponse DescribeBackupOverviewSync(DescribeBackupOverviewRequest req)
        {
             JsonResponseModel<DescribeBackupOverviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupOverview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupOverviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all backup plans of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public async Task<DescribeBackupPlansResponse> DescribeBackupPlans(DescribeBackupPlansRequest req)
        {
             JsonResponseModel<DescribeBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all backup plans of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupPlansRequest"/></param>
        /// <returns><see cref="DescribeBackupPlansResponse"/></returns>
        public DescribeBackupPlansResponse DescribeBackupPlansSync(DescribeBackupPlansRequest req)
        {
             JsonResponseModel<DescribeBackupPlansResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupPlans");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupPlansResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup statistics of an instance. It will return the number and size (bytes) of backups of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public async Task<DescribeBackupSummariesResponse> DescribeBackupSummaries(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup statistics of an instance. It will return the number and size (bytes) of backups of the instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeBackupSummariesRequest"/></param>
        /// <returns><see cref="DescribeBackupSummariesResponse"/></returns>
        public DescribeBackupSummariesResponse DescribeBackupSummariesSync(DescribeBackupSummariesRequest req)
        {
             JsonResponseModel<DescribeBackupSummariesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBackupSummaries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBackupSummariesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of full backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public async Task<DescribeBaseBackupsResponse> DescribeBaseBackups(DescribeBaseBackupsRequest req)
        {
             JsonResponseModel<DescribeBaseBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of full backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseBackupsRequest"/></param>
        /// <returns><see cref="DescribeBaseBackupsResponse"/></returns>
        public DescribeBaseBackupsResponse DescribeBaseBackupsSync(DescribeBaseBackupsRequest req)
        {
             JsonResponseModel<DescribeBaseBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public async Task<DescribeClassesResponse> DescribeClasses(DescribeClassesRequest req)
        {
             JsonResponseModel<DescribeClassesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeClasses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query purchasable instance specifications.
        /// </summary>
        /// <param name="req"><see cref="DescribeClassesRequest"/></param>
        /// <returns><see cref="DescribeClassesResponse"/></returns>
        public DescribeClassesResponse DescribeClassesSync(DescribeClassesRequest req)
        {
             JsonResponseModel<DescribeClassesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeClasses");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeClassesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the minimum specification required by a cloned instance, including `SpecCode` and disk specification.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public async Task<DescribeCloneDBInstanceSpecResponse> DescribeCloneDBInstanceSpec(DescribeCloneDBInstanceSpecRequest req)
        {
             JsonResponseModel<DescribeCloneDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCloneDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the minimum specification required by a cloned instance, including `SpecCode` and disk specification.
        /// </summary>
        /// <param name="req"><see cref="DescribeCloneDBInstanceSpecRequest"/></param>
        /// <returns><see cref="DescribeCloneDBInstanceSpecResponse"/></returns>
        public DescribeCloneDBInstanceSpecResponse DescribeCloneDBInstanceSpecSync(DescribeCloneDBInstanceSpecRequest req)
        {
             JsonResponseModel<DescribeCloneDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCloneDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCloneDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup list of an instance. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public async Task<DescribeDBBackupsResponse> DescribeDBBackups(DescribeDBBackupsRequest req)
        {
             JsonResponseModel<DescribeDBBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the backup list of an instance. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBBackupsRequest"/></param>
        /// <returns><see cref="DescribeDBBackupsResponse"/></returns>
        public DescribeDBBackupsResponse DescribeDBBackupsSync(DescribeDBBackupsRequest req)
        {
             JsonResponseModel<DescribeDBBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an error log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public async Task<DescribeDBErrlogsResponse> DescribeDBErrlogs(DescribeDBErrlogsRequest req)
        {
             JsonResponseModel<DescribeDBErrlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBErrlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBErrlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query an error log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBErrlogsRequest"/></param>
        /// <returns><see cref="DescribeDBErrlogsResponse"/></returns>
        public DescribeDBErrlogsResponse DescribeDBErrlogsSync(DescribeDBErrlogsRequest req)
        {
             JsonResponseModel<DescribeDBErrlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBErrlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBErrlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public async Task<DescribeDBInstanceAttributeResponse> DescribeDBInstanceAttribute(DescribeDBInstanceAttributeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceAttributeRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceAttributeResponse"/></returns>
        public DescribeDBInstanceAttributeResponse DescribeDBInstanceAttributeSync(DescribeDBInstanceAttributeRequest req)
        {
             JsonResponseModel<DescribeDBInstanceAttributeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceAttribute");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceAttributeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the HA configuration of an instance, u200cwhich includes:
        /// <li>Allow a standby node to promote to a primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public async Task<DescribeDBInstanceHAConfigResponse> DescribeDBInstanceHAConfig(DescribeDBInstanceHAConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceHAConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceHAConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceHAConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the HA configuration of an instance, u200cwhich includes:
        /// <li>Allow a standby node to promote to a primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceHAConfigResponse"/></returns>
        public DescribeDBInstanceHAConfigResponse DescribeDBInstanceHAConfigSync(DescribeDBInstanceHAConfigRequest req)
        {
             JsonResponseModel<DescribeDBInstanceHAConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceHAConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceHAConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameters of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public async Task<DescribeDBInstanceParametersResponse> DescribeDBInstanceParameters(DescribeDBInstanceParametersRequest req)
        {
             JsonResponseModel<DescribeDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameters of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceParametersRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceParametersResponse"/></returns>
        public DescribeDBInstanceParametersResponse DescribeDBInstanceParametersSync(DescribeDBInstanceParametersRequest req)
        {
             JsonResponseModel<DescribeDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<DescribeDBInstanceSecurityGroupsResponse> DescribeDBInstanceSecurityGroups(DescribeDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="DescribeDBInstanceSecurityGroupsResponse"/></returns>
        public DescribeDBInstanceSecurityGroupsResponse DescribeDBInstanceSecurityGroupsSync(DescribeDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public async Task<DescribeDBInstancesResponse> DescribeDBInstances(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one or more instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDBInstancesResponse"/></returns>
        public DescribeDBInstancesResponse DescribeDBInstancesSync(DescribeDBInstancesRequest req)
        {
             JsonResponseModel<DescribeDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a slow query log. Since it was deprecated on September 1, 2021, it has no longer returned data. You need to use the [DescribeSlowQueryList](https://intl.cloud.tencent.com/document/product/409/60540?from_cn_redirect=1) API instead to get slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public async Task<DescribeDBSlowlogsResponse> DescribeDBSlowlogs(DescribeDBSlowlogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get a slow query log. Since it was deprecated on September 1, 2021, it has no longer returned data. You need to use the [DescribeSlowQueryList](https://intl.cloud.tencent.com/document/product/409/60540?from_cn_redirect=1) API instead to get slow query logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSlowlogsRequest"/></param>
        /// <returns><see cref="DescribeDBSlowlogsResponse"/></returns>
        public DescribeDBSlowlogsResponse DescribeDBSlowlogsSync(DescribeDBSlowlogsRequest req)
        {
             JsonResponseModel<DescribeDBSlowlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSlowlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSlowlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of supported database versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public async Task<DescribeDBVersionsResponse> DescribeDBVersions(DescribeDBVersionsRequest req)
        {
             JsonResponseModel<DescribeDBVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of supported database versions.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBVersionsRequest"/></param>
        /// <returns><see cref="DescribeDBVersionsResponse"/></returns>
        public DescribeDBVersionsResponse DescribeDBVersionsSync(DescribeDBVersionsRequest req)
        {
             JsonResponseModel<DescribeDBVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance Xlog list. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public async Task<DescribeDBXlogsResponse> DescribeDBXlogs(DescribeDBXlogsRequest req)
        {
             JsonResponseModel<DescribeDBXlogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBXlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBXlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the instance Xlog list. This API is disused and replaced by the [DescribeBaseBackups](https://intl.cloud.tencent.com/document/api/409/89022?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBXlogsRequest"/></param>
        /// <returns><see cref="DescribeDBXlogsResponse"/></returns>
        public DescribeDBXlogsResponse DescribeDBXlogsSync(DescribeDBXlogsRequest req)
        {
             JsonResponseModel<DescribeDBXlogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBXlogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBXlogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the database list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public async Task<DescribeDatabasesResponse> DescribeDatabases(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the database list of an instance.
        /// </summary>
        /// <param name="req"><see cref="DescribeDatabasesRequest"/></param>
        /// <returns><see cref="DescribeDatabasesResponse"/></returns>
        public DescribeDatabasesResponse DescribeDatabasesSync(DescribeDatabasesRequest req)
        {
             JsonResponseModel<DescribeDatabasesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDatabases");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDatabasesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all parameters supported by a database version and engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public async Task<DescribeDefaultParametersResponse> DescribeDefaultParameters(DescribeDefaultParametersRequest req)
        {
             JsonResponseModel<DescribeDefaultParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDefaultParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query all parameters supported by a database version and engine.
        /// </summary>
        /// <param name="req"><see cref="DescribeDefaultParametersRequest"/></param>
        /// <returns><see cref="DescribeDefaultParametersResponse"/></returns>
        public DescribeDefaultParametersResponse DescribeDefaultParametersSync(DescribeDefaultParametersRequest req)
        {
             JsonResponseModel<DescribeDefaultParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDefaultParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDefaultParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public async Task<DescribeEncryptionKeysResponse> DescribeEncryptionKeys(DescribeEncryptionKeysRequest req)
        {
             JsonResponseModel<DescribeEncryptionKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEncryptionKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the instance key list.
        /// </summary>
        /// <param name="req"><see cref="DescribeEncryptionKeysRequest"/></param>
        /// <returns><see cref="DescribeEncryptionKeysResponse"/></returns>
        public DescribeEncryptionKeysResponse DescribeEncryptionKeysSync(DescribeEncryptionKeysRequest req)
        {
             JsonResponseModel<DescribeEncryptionKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEncryptionKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEncryptionKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of log backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public async Task<DescribeLogBackupsResponse> DescribeLogBackups(DescribeLogBackupsRequest req)
        {
             JsonResponseModel<DescribeLogBackupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLogBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of log backups.
        /// </summary>
        /// <param name="req"><see cref="DescribeLogBackupsRequest"/></param>
        /// <returns><see cref="DescribeLogBackupsResponse"/></returns>
        public DescribeLogBackupsResponse DescribeLogBackupsSync(DescribeLogBackupsRequest req)
        {
             JsonResponseModel<DescribeLogBackupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLogBackups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLogBackupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public async Task<DescribeOrdersResponse> DescribeOrders(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the order information.
        /// </summary>
        /// <param name="req"><see cref="DescribeOrdersRequest"/></param>
        /// <returns><see cref="DescribeOrdersResponse"/></returns>
        public DescribeOrdersResponse DescribeOrdersSync(DescribeOrdersRequest req)
        {
             JsonResponseModel<DescribeOrdersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrders");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrdersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a parameter template, including basic information and parameter information.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public async Task<DescribeParameterTemplateAttributesResponse> DescribeParameterTemplateAttributes(DescribeParameterTemplateAttributesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplateAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParameterTemplateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of a parameter template, including basic information and parameter information.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplateAttributesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplateAttributesResponse"/></returns>
        public DescribeParameterTemplateAttributesResponse DescribeParameterTemplateAttributesSync(DescribeParameterTemplateAttributesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplateAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParameterTemplateAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplateAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public async Task<DescribeParameterTemplatesResponse> DescribeParameterTemplates(DescribeParameterTemplatesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParameterTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of parameter templates.
        /// </summary>
        /// <param name="req"><see cref="DescribeParameterTemplatesRequest"/></param>
        /// <returns><see cref="DescribeParameterTemplatesResponse"/></returns>
        public DescribeParameterTemplatesResponse DescribeParameterTemplatesSync(DescribeParameterTemplatesRequest req)
        {
             JsonResponseModel<DescribeParameterTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParameterTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParameterTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter modification event.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public async Task<DescribeParamsEventResponse> DescribeParamsEvent(DescribeParamsEventRequest req)
        {
             JsonResponseModel<DescribeParamsEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeParamsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the parameter modification event.
        /// </summary>
        /// <param name="req"><see cref="DescribeParamsEventRequest"/></param>
        /// <returns><see cref="DescribeParamsEventResponse"/></returns>
        public DescribeParamsEventResponse DescribeParamsEventSync(DescribeParamsEventRequest req)
        {
             JsonResponseModel<DescribeParamsEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeParamsEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeParamsEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable specification configuration. u200cThis API is disused and replaced by the [DescribeClasses](https://intl.cloud.tencent.com/document/api/409/89019?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public async Task<DescribeProductConfigResponse> DescribeProductConfig(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable specification configuration. u200cThis API is disused and replaced by the [DescribeClasses](https://intl.cloud.tencent.com/document/api/409/89019?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductConfigRequest"/></param>
        /// <returns><see cref="DescribeProductConfigResponse"/></returns>
        public DescribeProductConfigResponse DescribeProductConfigSync(DescribeProductConfigRequest req)
        {
             JsonResponseModel<DescribeProductConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of RO groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public async Task<DescribeReadOnlyGroupsResponse> DescribeReadOnlyGroups(DescribeReadOnlyGroupsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeReadOnlyGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of RO groups.
        /// </summary>
        /// <param name="req"><see cref="DescribeReadOnlyGroupsRequest"/></param>
        /// <returns><see cref="DescribeReadOnlyGroupsResponse"/></returns>
        public DescribeReadOnlyGroupsResponse DescribeReadOnlyGroupsSync(DescribeReadOnlyGroupsRequest req)
        {
             JsonResponseModel<DescribeReadOnlyGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeReadOnlyGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeReadOnlyGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public async Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchasable regions.
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
             JsonResponseModel<DescribeRegionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one or more PostgreSQL for Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public async Task<DescribeServerlessDBInstancesResponse> DescribeServerlessDBInstances(DescribeServerlessDBInstancesRequest req)
        {
             JsonResponseModel<DescribeServerlessDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServerlessDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the details of one or more PostgreSQL for Serverless instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeServerlessDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeServerlessDBInstancesResponse"/></returns>
        public DescribeServerlessDBInstancesResponse DescribeServerlessDBInstancesSync(DescribeServerlessDBInstancesRequest req)
        {
             JsonResponseModel<DescribeServerlessDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeServerlessDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServerlessDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to count and analyze slow query statements during the specified period of time and return aggregated statistical analysis results which are classified by statement with abstract parameter values.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public async Task<DescribeSlowQueryAnalysisResponse> DescribeSlowQueryAnalysis(DescribeSlowQueryAnalysisRequest req)
        {
             JsonResponseModel<DescribeSlowQueryAnalysisResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowQueryAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to count and analyze slow query statements during the specified period of time and return aggregated statistical analysis results which are classified by statement with abstract parameter values.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryAnalysisRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryAnalysisResponse"/></returns>
        public DescribeSlowQueryAnalysisResponse DescribeSlowQueryAnalysisSync(DescribeSlowQueryAnalysisRequest req)
        {
             JsonResponseModel<DescribeSlowQueryAnalysisResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowQueryAnalysis");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryAnalysisResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow queries during the specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public async Task<DescribeSlowQueryListResponse> DescribeSlowQueryList(DescribeSlowQueryListRequest req)
        {
             JsonResponseModel<DescribeSlowQueryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowQueryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow queries during the specified period of time.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowQueryListRequest"/></param>
        /// <returns><see cref="DescribeSlowQueryListResponse"/></returns>
        public DescribeSlowQueryListResponse DescribeSlowQueryListSync(DescribeSlowQueryListRequest req)
        {
             JsonResponseModel<DescribeSlowQueryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowQueryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowQueryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the supported AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public async Task<DescribeZonesResponse> DescribeZones(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the supported AZs.
        /// </summary>
        /// <param name="req"><see cref="DescribeZonesRequest"/></param>
        /// <returns><see cref="DescribeZonesResponse"/></returns>
        public DescribeZonesResponse DescribeZonesSync(DescribeZonesRequest req)
        {
             JsonResponseModel<DescribeZonesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeZones");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeZonesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an isolated instance by specifying the `DBInstanceId` parameter. The data of a terminated instance will be deleted and cannot be recovered. Be cautious with this API calling. Only the instance in isolation can be terminated.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public async Task<DestroyDBInstanceResponse> DestroyDBInstance(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to terminate an isolated instance by specifying the `DBInstanceId` parameter. The data of a terminated instance will be deleted and cannot be recovered. Be cautious with this API calling. Only the instance in isolation can be terminated.
        /// </summary>
        /// <param name="req"><see cref="DestroyDBInstanceRequest"/></param>
        /// <returns><see cref="DestroyDBInstanceResponse"/></returns>
        public DestroyDBInstanceResponse DestroyDBInstanceSync(DestroyDBInstanceRequest req)
        {
             JsonResponseModel<DestroyDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove one or more instances from isolation.
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public async Task<DisIsolateDBInstancesResponse> DisIsolateDBInstances(DisIsolateDBInstancesRequest req)
        {
             JsonResponseModel<DisIsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisIsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisIsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove one or more instances from isolation.
        /// </summary>
        /// <param name="req"><see cref="DisIsolateDBInstancesRequest"/></param>
        /// <returns><see cref="DisIsolateDBInstancesResponse"/></returns>
        public DisIsolateDBInstancesResponse DisIsolateDBInstancesSync(DisIsolateDBInstancesRequest req)
        {
             JsonResponseModel<DisIsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisIsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisIsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to initialize a TencentDB for PostgreSQL instance. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public async Task<InitDBInstancesResponse> InitDBInstances(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to initialize a TencentDB for PostgreSQL instance. This API is disused and replaced by the [CreateInstances](https://intl.cloud.tencent.com/document/api/409/56107?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="InitDBInstancesRequest"/></param>
        /// <returns><see cref="InitDBInstancesResponse"/></returns>
        public InitDBInstancesResponse InitDBInstancesSync(InitDBInstancesRequest req)
        {
             JsonResponseModel<InitDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InitDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InitDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchase price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public async Task<InquiryPriceCreateDBInstancesResponse> InquiryPriceCreateDBInstances(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the purchase price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateDBInstancesRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateDBInstancesResponse"/></returns>
        public InquiryPriceCreateDBInstancesResponse InquiryPriceCreateDBInstancesSync(InquiryPriceCreateDBInstancesRequest req)
        {
             JsonResponseModel<InquiryPriceCreateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceCreateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceCreateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the renewal price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public async Task<InquiryPriceRenewDBInstanceResponse> InquiryPriceRenewDBInstance(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the renewal price of an instance.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewDBInstanceResponse"/></returns>
        public InquiryPriceRenewDBInstanceResponse InquiryPriceRenewDBInstanceSync(InquiryPriceRenewDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceRenewDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceRenewDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceRenewDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the fees of upgrading a specified database instance. Only pay-as-you-go instance is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public async Task<InquiryPriceUpgradeDBInstanceResponse> InquiryPriceUpgradeDBInstance(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the fees of upgrading a specified database instance. Only pay-as-you-go instance is supported.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpgradeDBInstanceResponse"/></returns>
        public InquiryPriceUpgradeDBInstanceResponse InquiryPriceUpgradeDBInstanceSync(InquiryPriceUpgradeDBInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "InquiryPriceUpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceUpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public async Task<IsolateDBInstancesResponse> IsolateDBInstances(IsolateDBInstancesRequest req)
        {
             JsonResponseModel<IsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "IsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to isolate an instance.
        /// </summary>
        /// <param name="req"><see cref="IsolateDBInstancesRequest"/></param>
        /// <returns><see cref="IsolateDBInstancesResponse"/></returns>
        public IsolateDBInstancesResponse IsolateDBInstancesSync(IsolateDBInstancesRequest req)
        {
             JsonResponseModel<IsolateDBInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "IsolateDBInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<IsolateDBInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public async Task<ModifyAccountRemarkResponse> ModifyAccountRemark(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify account remarks.
        /// </summary>
        /// <param name="req"><see cref="ModifyAccountRemarkRequest"/></param>
        /// <returns><see cref="ModifyAccountRemarkResponse"/></returns>
        public ModifyAccountRemarkResponse ModifyAccountRemarkSync(ModifyAccountRemarkRequest req)
        {
             JsonResponseModel<ModifyAccountRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAccountRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAccountRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public async Task<ModifyBackupDownloadRestrictionResponse> ModifyBackupDownloadRestriction(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup download restrictions.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupDownloadRestrictionRequest"/></param>
        /// <returns><see cref="ModifyBackupDownloadRestrictionResponse"/></returns>
        public ModifyBackupDownloadRestrictionResponse ModifyBackupDownloadRestrictionSync(ModifyBackupDownloadRestrictionRequest req)
        {
             JsonResponseModel<ModifyBackupDownloadRestrictionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupDownloadRestriction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupDownloadRestrictionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup plan of an instance, such as modifying the backup start time. By default, a full backup starts at midnight every day and the generated backup files will be retained for seven days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public async Task<ModifyBackupPlanResponse> ModifyBackupPlan(ModifyBackupPlanRequest req)
        {
             JsonResponseModel<ModifyBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the backup plan of an instance, such as modifying the backup start time. By default, a full backup starts at midnight every day and the generated backup files will be retained for seven days.
        /// </summary>
        /// <param name="req"><see cref="ModifyBackupPlanRequest"/></param>
        /// <returns><see cref="ModifyBackupPlanResponse"/></returns>
        public ModifyBackupPlanResponse ModifyBackupPlanSync(ModifyBackupPlanRequest req)
        {
             JsonResponseModel<ModifyBackupPlanResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBackupPlan");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBackupPlanResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the specified expiration time of a full backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public async Task<ModifyBaseBackupExpireTimeResponse> ModifyBaseBackupExpireTime(ModifyBaseBackupExpireTimeRequest req)
        {
             JsonResponseModel<ModifyBaseBackupExpireTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBaseBackupExpireTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaseBackupExpireTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the specified expiration time of a full backup for an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyBaseBackupExpireTimeRequest"/></param>
        /// <returns><see cref="ModifyBaseBackupExpireTimeResponse"/></returns>
        public ModifyBaseBackupExpireTimeResponse ModifyBaseBackupExpireTimeSync(ModifyBaseBackupExpireTimeRequest req)
        {
             JsonResponseModel<ModifyBaseBackupExpireTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBaseBackupExpireTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBaseBackupExpireTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch the instance billing mode from pay-as-you-go to monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public async Task<ModifyDBInstanceChargeTypeResponse> ModifyDBInstanceChargeType(ModifyDBInstanceChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDBInstanceChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to switch the instance billing mode from pay-as-you-go to monthly subscription.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceChargeTypeRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceChargeTypeResponse"/></returns>
        public ModifyDBInstanceChargeTypeResponse ModifyDBInstanceChargeTypeSync(ModifyDBInstanceChargeTypeRequest req)
        {
             JsonResponseModel<ModifyDBInstanceChargeTypeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceChargeType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceChargeTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the AZs where the nodes of a source instance reside.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public async Task<ModifyDBInstanceDeploymentResponse> ModifyDBInstanceDeployment(ModifyDBInstanceDeploymentRequest req)
        {
             JsonResponseModel<ModifyDBInstanceDeploymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceDeployment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceDeploymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the AZs where the nodes of a source instance reside.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceDeploymentRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceDeploymentResponse"/></returns>
        public ModifyDBInstanceDeploymentResponse ModifyDBInstanceDeploymentSync(ModifyDBInstanceDeploymentRequest req)
        {
             JsonResponseModel<ModifyDBInstanceDeploymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceDeployment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceDeploymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the HA configuration of an instance. u200cwhich includes:
        /// <li>Allow the standby node to promote to the primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public async Task<ModifyDBInstanceHAConfigResponse> ModifyDBInstanceHAConfig(ModifyDBInstanceHAConfigRequest req)
        {
             JsonResponseModel<ModifyDBInstanceHAConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceHAConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceHAConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the HA configuration of an instance. u200cwhich includes:
        /// <li>Allow the standby node to promote to the primary node.
        /// <li>Allow a semi-sync instance to adopt sync or async replication.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceHAConfigRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceHAConfigResponse"/></returns>
        public ModifyDBInstanceHAConfigResponse ModifyDBInstanceHAConfigSync(ModifyDBInstanceHAConfigRequest req)
        {
             JsonResponseModel<ModifyDBInstanceHAConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceHAConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceHAConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a TencentDB for PostgreSQL instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public async Task<ModifyDBInstanceNameResponse> ModifyDBInstanceName(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rename a TencentDB for PostgreSQL instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceNameRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceNameResponse"/></returns>
        public ModifyDBInstanceNameResponse ModifyDBInstanceNameSync(ModifyDBInstanceNameRequest req)
        {
             JsonResponseModel<ModifyDBInstanceNameResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceName");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceNameResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public async Task<ModifyDBInstanceParametersResponse> ModifyDBInstanceParameters(ModifyDBInstanceParametersRequest req)
        {
             JsonResponseModel<ModifyDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance parameters.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceParametersRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceParametersResponse"/></returns>
        public ModifyDBInstanceParametersResponse ModifyDBInstanceParametersSync(ModifyDBInstanceParametersRequest req)
        {
             JsonResponseModel<ModifyDBInstanceParametersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceParameters");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceParametersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the RO group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public async Task<ModifyDBInstanceReadOnlyGroupResponse> ModifyDBInstanceReadOnlyGroup(ModifyDBInstanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the RO group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceReadOnlyGroupResponse"/></returns>
        public ModifyDBInstanceReadOnlyGroupResponse ModifyDBInstanceReadOnlyGroupSync(ModifyDBInstanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public async Task<ModifyDBInstanceSecurityGroupsResponse> ModifyDBInstanceSecurityGroups(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the security group of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSecurityGroupsRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSecurityGroupsResponse"/></returns>
        public ModifyDBInstanceSecurityGroupsResponse ModifyDBInstanceSecurityGroupsSync(ModifyDBInstanceSecurityGroupsRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSecurityGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSecurityGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance specifications, including memory and disk size.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public async Task<ModifyDBInstanceSpecResponse> ModifyDBInstanceSpec(ModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify instance specifications, including memory and disk size.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstanceSpecRequest"/></param>
        /// <returns><see cref="ModifyDBInstanceSpecResponse"/></returns>
        public ModifyDBInstanceSpecResponse ModifyDBInstanceSpecSync(ModifyDBInstanceSpecRequest req)
        {
             JsonResponseModel<ModifyDBInstanceSpecResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstanceSpec");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstanceSpecResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the project of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public async Task<ModifyDBInstancesProjectResponse> ModifyDBInstancesProject(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the project of an instance.
        /// </summary>
        /// <param name="req"><see cref="ModifyDBInstancesProjectRequest"/></param>
        /// <returns><see cref="ModifyDBInstancesProjectResponse"/></returns>
        public ModifyDBInstancesProjectResponse ModifyDBInstancesProjectSync(ModifyDBInstancesProjectRequest req)
        {
             JsonResponseModel<ModifyDBInstancesProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDBInstancesProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDBInstancesProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configurations, such as parameter template name and description. It can also be used to manage the parameter list in the parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public async Task<ModifyParameterTemplateResponse> ModifyParameterTemplate(ModifyParameterTemplateRequest req)
        {
             JsonResponseModel<ModifyParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configurations, such as parameter template name and description. It can also be used to manage the parameter list in the parameter template.
        /// </summary>
        /// <param name="req"><see cref="ModifyParameterTemplateRequest"/></param>
        /// <returns><see cref="ModifyParameterTemplateResponse"/></returns>
        public ModifyParameterTemplateResponse ModifyParameterTemplateSync(ModifyParameterTemplateRequest req)
        {
             JsonResponseModel<ModifyParameterTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyParameterTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyParameterTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify RO group configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public async Task<ModifyReadOnlyGroupConfigResponse> ModifyReadOnlyGroupConfig(ModifyReadOnlyGroupConfigRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyReadOnlyGroupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify RO group configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyReadOnlyGroupConfigRequest"/></param>
        /// <returns><see cref="ModifyReadOnlyGroupConfigResponse"/></returns>
        public ModifyReadOnlyGroupConfigResponse ModifyReadOnlyGroupConfigSync(ModifyReadOnlyGroupConfigRequest req)
        {
             JsonResponseModel<ModifyReadOnlyGroupConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyReadOnlyGroupConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyReadOnlyGroupConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform a primary-standby switch for an instance waiting for the switch after it is upgraded.
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public async Task<ModifySwitchTimePeriodResponse> ModifySwitchTimePeriod(ModifySwitchTimePeriodRequest req)
        {
             JsonResponseModel<ModifySwitchTimePeriodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySwitchTimePeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySwitchTimePeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to perform a primary-standby switch for an instance waiting for the switch after it is upgraded.
        /// </summary>
        /// <param name="req"><see cref="ModifySwitchTimePeriodRequest"/></param>
        /// <returns><see cref="ModifySwitchTimePeriodResponse"/></returns>
        public ModifySwitchTimePeriodResponse ModifySwitchTimePeriodSync(ModifySwitchTimePeriodRequest req)
        {
             JsonResponseModel<ModifySwitchTimePeriodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySwitchTimePeriod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySwitchTimePeriodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public async Task<OpenDBExtranetAccessResponse> OpenDBExtranetAccess(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the public network access of an instance.
        /// </summary>
        /// <param name="req"><see cref="OpenDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenDBExtranetAccessResponse"/></returns>
        public OpenDBExtranetAccessResponse OpenDBExtranetAccessSync(OpenDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public async Task<OpenServerlessDBExtranetAccessResponse> OpenServerlessDBExtranetAccess(OpenServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OpenServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the public network address of a PostgreSQL for Serverless instance.
        /// </summary>
        /// <param name="req"><see cref="OpenServerlessDBExtranetAccessRequest"/></param>
        /// <returns><see cref="OpenServerlessDBExtranetAccessResponse"/></returns>
        public OpenServerlessDBExtranetAccessResponse OpenServerlessDBExtranetAccessSync(OpenServerlessDBExtranetAccessRequest req)
        {
             JsonResponseModel<OpenServerlessDBExtranetAccessResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OpenServerlessDBExtranetAccess");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OpenServerlessDBExtranetAccessResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the loads of read-only replicas in an RO group. Please note that connections to those read-only replicas will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public async Task<RebalanceReadOnlyGroupResponse> RebalanceReadOnlyGroup(RebalanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<RebalanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RebalanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebalanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to rebalance the loads of read-only replicas in an RO group. Please note that connections to those read-only replicas will be interrupted transiently; therefore, you should ensure that your application can reconnect to the databases. This operation should be performed with caution.
        /// </summary>
        /// <param name="req"><see cref="RebalanceReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RebalanceReadOnlyGroupResponse"/></returns>
        public RebalanceReadOnlyGroupResponse RebalanceReadOnlyGroupSync(RebalanceReadOnlyGroupRequest req)
        {
             JsonResponseModel<RebalanceReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RebalanceReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RebalanceReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a read-only replica from an RO group.
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public async Task<RemoveDBInstanceFromReadOnlyGroupResponse> RemoveDBInstanceFromReadOnlyGroup(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
             JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveDBInstanceFromReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a read-only replica from an RO group.
        /// </summary>
        /// <param name="req"><see cref="RemoveDBInstanceFromReadOnlyGroupRequest"/></param>
        /// <returns><see cref="RemoveDBInstanceFromReadOnlyGroupResponse"/></returns>
        public RemoveDBInstanceFromReadOnlyGroupResponse RemoveDBInstanceFromReadOnlyGroupSync(RemoveDBInstanceFromReadOnlyGroupRequest req)
        {
             JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveDBInstanceFromReadOnlyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveDBInstanceFromReadOnlyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public async Task<RenewInstanceResponse> RenewInstance(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to renew an instance.
        /// </summary>
        /// <param name="req"><see cref="RenewInstanceRequest"/></param>
        /// <returns><see cref="RenewInstanceResponse"/></returns>
        public RenewInstanceResponse RenewInstanceSync(RenewInstanceRequest req)
        {
             JsonResponseModel<RenewInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public async Task<ResetAccountPasswordResponse> ResetAccountPassword(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reset the account password of an instance.
        /// </summary>
        /// <param name="req"><see cref="ResetAccountPasswordRequest"/></param>
        /// <returns><see cref="ResetAccountPasswordResponse"/></returns>
        public ResetAccountPasswordResponse ResetAccountPasswordSync(ResetAccountPasswordRequest req)
        {
             JsonResponseModel<ResetAccountPasswordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetAccountPassword");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetAccountPasswordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public async Task<RestartDBInstanceResponse> RestartDBInstance(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to restart an instance.
        /// </summary>
        /// <param name="req"><see cref="RestartDBInstanceRequest"/></param>
        /// <returns><see cref="RestartDBInstanceResponse"/></returns>
        public RestartDBInstanceResponse RestartDBInstanceSync(RestartDBInstanceRequest req)
        {
             JsonResponseModel<RestartDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RestartDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RestartDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public async Task<SetAutoRenewFlagResponse> SetAutoRenewFlag(SetAutoRenewFlagRequest req)
        {
             JsonResponseModel<SetAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set auto-renewal.
        /// </summary>
        /// <param name="req"><see cref="SetAutoRenewFlagRequest"/></param>
        /// <returns><see cref="SetAutoRenewFlagResponse"/></returns>
        public SetAutoRenewFlagResponse SetAutoRenewFlagSync(SetAutoRenewFlagRequest req)
        {
             JsonResponseModel<SetAutoRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAutoRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAutoRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the primary-standby switch of an instance.
        /// <li>By initiating a switch, you can verify whether the primary-standby switch is performed correctly.
        /// <li>By using forced switch, you can forcibly initiate the primary-standby switch when the delay of replica node failed to meet the switch requirement.
        /// <li>This operation can only be performed for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public async Task<SwitchDBInstancePrimaryResponse> SwitchDBInstancePrimary(SwitchDBInstancePrimaryRequest req)
        {
             JsonResponseModel<SwitchDBInstancePrimaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SwitchDBInstancePrimary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstancePrimaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable the primary-standby switch of an instance.
        /// <li>By initiating a switch, you can verify whether the primary-standby switch is performed correctly.
        /// <li>By using forced switch, you can forcibly initiate the primary-standby switch when the delay of replica node failed to meet the switch requirement.
        /// <li>This operation can only be performed for the primary instance.
        /// </summary>
        /// <param name="req"><see cref="SwitchDBInstancePrimaryRequest"/></param>
        /// <returns><see cref="SwitchDBInstancePrimaryResponse"/></returns>
        public SwitchDBInstancePrimaryResponse SwitchDBInstancePrimarySync(SwitchDBInstancePrimaryRequest req)
        {
             JsonResponseModel<SwitchDBInstancePrimaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SwitchDBInstancePrimary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SwitchDBInstancePrimaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance configurations. u200cThis API is disused and replaced by the [ModifyDBInstanceSpec](https://intl.cloud.tencent.com/document/api/409/63689?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public async Task<UpgradeDBInstanceResponse> UpgradeDBInstance(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade instance configurations. u200cThis API is disused and replaced by the [ModifyDBInstanceSpec](https://intl.cloud.tencent.com/document/api/409/63689?from_cn_redirect=1) API.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceResponse"/></returns>
        public UpgradeDBInstanceResponse UpgradeDBInstanceSync(UpgradeDBInstanceRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public async Task<UpgradeDBInstanceKernelVersionResponse> UpgradeDBInstanceKernelVersion(UpgradeDBInstanceKernelVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceKernelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeDBInstanceKernelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceKernelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade the kernel version of an instance.
        /// </summary>
        /// <param name="req"><see cref="UpgradeDBInstanceKernelVersionRequest"/></param>
        /// <returns><see cref="UpgradeDBInstanceKernelVersionResponse"/></returns>
        public UpgradeDBInstanceKernelVersionResponse UpgradeDBInstanceKernelVersionSync(UpgradeDBInstanceKernelVersionRequest req)
        {
             JsonResponseModel<UpgradeDBInstanceKernelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeDBInstanceKernelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeDBInstanceKernelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

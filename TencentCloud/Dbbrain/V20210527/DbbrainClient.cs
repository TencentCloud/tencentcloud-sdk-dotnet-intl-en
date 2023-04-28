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
        /// This API is used to add the recipient name and email. The returned value is the ID of the successfully added recipient.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public async Task<AddUserContactResponse> AddUserContact(AddUserContactRequest req)
        {
             JsonResponseModel<AddUserContactResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add the recipient name and email. The returned value is the ID of the successfully added recipient.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public AddUserContactResponse AddUserContactSync(AddUserContactRequest req)
        {
             JsonResponseModel<AddUserContactResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a health report and send it via email as configured.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public async Task<CreateDBDiagReportTaskResponse> CreateDBDiagReportTask(CreateDBDiagReportTaskRequest req)
        {
             JsonResponseModel<CreateDBDiagReportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBDiagReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a health report and send it via email as configured.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public CreateDBDiagReportTaskResponse CreateDBDiagReportTaskSync(CreateDBDiagReportTaskRequest req)
        {
             JsonResponseModel<CreateDBDiagReportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBDiagReportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a URL for a health report.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public async Task<CreateDBDiagReportUrlResponse> CreateDBDiagReportUrl(CreateDBDiagReportUrlRequest req)
        {
             JsonResponseModel<CreateDBDiagReportUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDBDiagReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a URL for a health report.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public CreateDBDiagReportUrlResponse CreateDBDiagReportUrlSync(CreateDBDiagReportUrlRequest req)
        {
             JsonResponseModel<CreateDBDiagReportUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDBDiagReportUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDBDiagReportUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public async Task<CreateKillTaskResponse> CreateKillTask(CreateKillTaskRequest req)
        {
             JsonResponseModel<CreateKillTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateKillTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKillTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public CreateKillTaskResponse CreateKillTaskSync(CreateKillTaskRequest req)
        {
             JsonResponseModel<CreateKillTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateKillTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateKillTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of scheduled task health report). Always select Guangzhou for `Region`, regardless of the region where the instance resides.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public async Task<CreateMailProfileResponse> CreateMailProfile(CreateMailProfileRequest req)
        {
             JsonResponseModel<CreateMailProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of scheduled task health report). Always select Guangzhou for `Region`, regardless of the region where the instance resides.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public CreateMailProfileResponse CreateMailProfileSync(CreateMailProfileRequest req)
        {
             JsonResponseModel<CreateMailProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMailProfileResponse>>(strResp);
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
        /// This API is used to create the regular generation time of health reports and the regular email sending configuration. Pass in the regular generation time of health reports as a parameter (Monday to Sunday) to set the regular generation time, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public async Task<CreateSchedulerMailProfileResponse> CreateSchedulerMailProfile(CreateSchedulerMailProfileRequest req)
        {
             JsonResponseModel<CreateSchedulerMailProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchedulerMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulerMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the regular generation time of health reports and the regular email sending configuration. Pass in the regular generation time of health reports as a parameter (Monday to Sunday) to set the regular generation time, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public CreateSchedulerMailProfileResponse CreateSchedulerMailProfileSync(CreateSchedulerMailProfileRequest req)
        {
             JsonResponseModel<CreateSchedulerMailProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchedulerMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchedulerMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public async Task<CreateSecurityAuditLogExportTaskResponse> CreateSecurityAuditLogExportTask(CreateSecurityAuditLogExportTaskRequest req)
        {
             JsonResponseModel<CreateSecurityAuditLogExportTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecurityAuditLogExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityAuditLogExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public CreateSecurityAuditLogExportTaskResponse CreateSecurityAuditLogExportTaskSync(CreateSecurityAuditLogExportTaskRequest req)
        {
             JsonResponseModel<CreateSecurityAuditLogExportTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecurityAuditLogExportTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecurityAuditLogExportTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete health report generation tasks by task ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public async Task<DeleteDBDiagReportTasksResponse> DeleteDBDiagReportTasks(DeleteDBDiagReportTasksRequest req)
        {
             JsonResponseModel<DeleteDBDiagReportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDBDiagReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBDiagReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete health report generation tasks by task ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public DeleteDBDiagReportTasksResponse DeleteDBDiagReportTasksSync(DeleteDBDiagReportTasksRequest req)
        {
             JsonResponseModel<DeleteDBDiagReportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDBDiagReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDBDiagReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public async Task<DeleteSecurityAuditLogExportTasksResponse> DeleteSecurityAuditLogExportTasks(DeleteSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public DeleteSecurityAuditLogExportTasksResponse DeleteSecurityAuditLogExportTasksSync(DeleteSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the recipient in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public async Task<DescribeAllUserContactResponse> DescribeAllUserContact(DescribeAllUserContactRequest req)
        {
             JsonResponseModel<DescribeAllUserContactResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the recipient in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public DescribeAllUserContactResponse DescribeAllUserContactSync(DescribeAllUserContactRequest req)
        {
             JsonResponseModel<DescribeAllUserContactResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllUserContact");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserContactResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the recipient group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public async Task<DescribeAllUserGroupResponse> DescribeAllUserGroup(DescribeAllUserGroupRequest req)
        {
             JsonResponseModel<DescribeAllUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of the recipient group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public DescribeAllUserGroupResponse DescribeAllUserGroupSync(DescribeAllUserGroupRequest req)
        {
             JsonResponseModel<DescribeAllUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public async Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
             JsonResponseModel<DescribeDBDiagEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagEventResponse>>(strResp);
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
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public async Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
             JsonResponseModel<DescribeDBDiagHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of health report generation tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public async Task<DescribeDBDiagReportTasksResponse> DescribeDBDiagReportTasks(DescribeDBDiagReportTasksRequest req)
        {
             JsonResponseModel<DescribeDBDiagReportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBDiagReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of health report generation tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public DescribeDBDiagReportTasksResponse DescribeDBDiagReportTasksSync(DescribeDBDiagReportTasksRequest req)
        {
             JsonResponseModel<DescribeDBDiagReportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBDiagReportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBDiagReportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the overview of instance space usage during a specified time period, including disk usage growth (MB), available disk space (MB), total disk space (MB), and estimated number of available days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public async Task<DescribeDBSpaceStatusResponse> DescribeDBSpaceStatus(DescribeDBSpaceStatusRequest req)
        {
             JsonResponseModel<DescribeDBSpaceStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDBSpaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSpaceStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the overview of instance space usage during a specified time period, including disk usage growth (MB), available disk space (MB), total disk space (MB), and estimated number of available days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public DescribeDBSpaceStatusResponse DescribeDBSpaceStatusSync(DescribeDBSpaceStatusRequest req)
        {
             JsonResponseModel<DescribeDBSpaceStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDBSpaceStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDBSpaceStatusResponse>>(strResp);
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
        /// This API is used to get the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public async Task<DescribeHealthScoreResponse> DescribeHealthScore(DescribeHealthScoreRequest req)
        {
             JsonResponseModel<DescribeHealthScoreResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeHealthScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHealthScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public DescribeHealthScoreResponse DescribeHealthScoreSync(DescribeHealthScoreRequest req)
        {
             JsonResponseModel<DescribeHealthScoreResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeHealthScore");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeHealthScoreResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the email sending configuration, including the email configuration for database inspection and the email sending configuration for scheduled task health reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public async Task<DescribeMailProfileResponse> DescribeMailProfile(DescribeMailProfileRequest req)
        {
             JsonResponseModel<DescribeMailProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMailProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the email sending configuration, including the email configuration for database inspection and the email sending configuration for scheduled task health reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public DescribeMailProfileResponse DescribeMailProfileSync(DescribeMailProfileRequest req)
        {
             JsonResponseModel<DescribeMailProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMailProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMailProfileResponse>>(strResp);
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
        /// This API is used to get the session statistics of a single proxy under the current instance, and can only be called in particular environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public async Task<DescribeProxyProcessStatisticsResponse> DescribeProxyProcessStatistics(DescribeProxyProcessStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyProcessStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProxyProcessStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyProcessStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the session statistics of a single proxy under the current instance, and can only be called in particular environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public DescribeProxyProcessStatisticsResponse DescribeProxyProcessStatisticsSync(DescribeProxyProcessStatisticsRequest req)
        {
             JsonResponseModel<DescribeProxyProcessStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProxyProcessStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProxyProcessStatisticsResponse>>(strResp);
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
        /// This API is used to query the download link of a security audit log export file. Currently, log file download only provides a Tencent Cloud private network address. Download it by using a CVM instance in the Guangzhou region.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public async Task<DescribeSecurityAuditLogDownloadUrlsResponse> DescribeSecurityAuditLogDownloadUrls(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityAuditLogDownloadUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the download link of a security audit log export file. Currently, log file download only provides a Tencent Cloud private network address. Download it by using a CVM instance in the Guangzhou region.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public DescribeSecurityAuditLogDownloadUrlsResponse DescribeSecurityAuditLogDownloadUrlsSync(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityAuditLogDownloadUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogDownloadUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of security audit log export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public async Task<DescribeSecurityAuditLogExportTasksResponse> DescribeSecurityAuditLogExportTasks(DescribeSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the list of security audit log export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public DescribeSecurityAuditLogExportTasksResponse DescribeSecurityAuditLogExportTasksSync(DescribeSecurityAuditLogExportTasksRequest req)
        {
             JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecurityAuditLogExportTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecurityAuditLogExportTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public async Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTimeSeriesStats");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTimeSeriesStatsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public async Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
             JsonResponseModel<DescribeSlowLogTopSqlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogTopSqls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogTopSqlsResponse>>(strResp);
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
        /// This API is used to obtain the slow query log details of a SQL template in a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public async Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the slow query log details of a SQL template in a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
             JsonResponseModel<DescribeSlowLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSlowLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSlowLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public async Task<DescribeTopSpaceSchemaTimeSeriesResponse> DescribeTopSpaceSchemaTimeSeries(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceSchemaTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceSchemaTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceSchemaTimeSeriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public DescribeTopSpaceSchemaTimeSeriesResponse DescribeTopSpaceSchemaTimeSeriesSync(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceSchemaTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceSchemaTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceSchemaTimeSeriesResponse>>(strResp);
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
        /// This API is used to get the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public async Task<DescribeTopSpaceTableTimeSeriesResponse> DescribeTopSpaceTableTimeSeries(DescribeTopSpaceTableTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceTableTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public DescribeTopSpaceTableTimeSeriesResponse DescribeTopSpaceTableTimeSeriesSync(DescribeTopSpaceTableTimeSeriesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceTableTimeSeries");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTableTimeSeriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top tables of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public async Task<DescribeTopSpaceTablesResponse> DescribeTopSpaceTables(DescribeTopSpaceTablesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTablesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTopSpaceTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTablesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top tables of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public DescribeTopSpaceTablesResponse DescribeTopSpaceTablesSync(DescribeTopSpaceTablesRequest req)
        {
             JsonResponseModel<DescribeTopSpaceTablesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTopSpaceTables");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTopSpaceTablesResponse>>(strResp);
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

        /// <summary>
        /// This API is used to interrupt the current session by session ID. It needs to be called twice to commit the session interruption task in two stages. In the pre-commit stage, the stage value is `Prepare`, and the returned value is `SqlExecId`. In the commit stage, the stage value is `Commit`, and `SqlExecId` will be passed in as a parameter. Then, the session process will be terminated.
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public async Task<KillMySqlThreadsResponse> KillMySqlThreads(KillMySqlThreadsRequest req)
        {
             JsonResponseModel<KillMySqlThreadsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "KillMySqlThreads");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMySqlThreadsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to interrupt the current session by session ID. It needs to be called twice to commit the session interruption task in two stages. In the pre-commit stage, the stage value is `Prepare`, and the returned value is `SqlExecId`. In the commit stage, the stage value is `Commit`, and `SqlExecId` will be passed in as a parameter. Then, the session process will be terminated.
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public KillMySqlThreadsResponse KillMySqlThreadsSync(KillMySqlThreadsRequest req)
        {
             JsonResponseModel<KillMySqlThreadsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "KillMySqlThreads");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<KillMySqlThreadsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable instance inspection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public async Task<ModifyDiagDBInstanceConfResponse> ModifyDiagDBInstanceConf(ModifyDiagDBInstanceConfRequest req)
        {
             JsonResponseModel<ModifyDiagDBInstanceConfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDiagDBInstanceConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiagDBInstanceConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable/disable instance inspection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public ModifyDiagDBInstanceConfResponse ModifyDiagDBInstanceConfSync(ModifyDiagDBInstanceConfRequest req)
        {
             JsonResponseModel<ModifyDiagDBInstanceConfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDiagDBInstanceConf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDiagDBInstanceConfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

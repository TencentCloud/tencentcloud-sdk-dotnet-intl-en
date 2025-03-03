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
       private const string sdkVersion = "SDK_NET_3.0.1081";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DbbrainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add the recipient name and email. The returned value is the ID of the successfully added recipient.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public Task<AddUserContactResponse> AddUserContact(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact");
        }

        /// <summary>
        /// This API is used to add the recipient name and email. The returned value is the ID of the successfully added recipient.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public AddUserContactResponse AddUserContactSync(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable database audit as needed.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public Task<CloseAuditServiceResponse> CloseAuditService(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService");
        }

        /// <summary>
        /// This API is used to disable database audit as needed.
        /// </summary>
        /// <param name="req"><see cref="CloseAuditServiceRequest"/></param>
        /// <returns><see cref="CloseAuditServiceResponse"/></returns>
        public CloseAuditServiceResponse CloseAuditServiceSync(CloseAuditServiceRequest req)
        {
            return InternalRequestAsync<CloseAuditServiceResponse>(req, "CloseAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a health report and send it via email as configured.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public Task<CreateDBDiagReportTaskResponse> CreateDBDiagReportTask(CreateDBDiagReportTaskRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportTaskResponse>(req, "CreateDBDiagReportTask");
        }

        /// <summary>
        /// This API is used to create a health report and send it via email as configured.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportTaskRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportTaskResponse"/></returns>
        public CreateDBDiagReportTaskResponse CreateDBDiagReportTaskSync(CreateDBDiagReportTaskRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportTaskResponse>(req, "CreateDBDiagReportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a URL for a health report.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public Task<CreateDBDiagReportUrlResponse> CreateDBDiagReportUrl(CreateDBDiagReportUrlRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportUrlResponse>(req, "CreateDBDiagReportUrl");
        }

        /// <summary>
        /// This API is used to create a URL for a health report.
        /// </summary>
        /// <param name="req"><see cref="CreateDBDiagReportUrlRequest"/></param>
        /// <returns><see cref="CreateDBDiagReportUrlResponse"/></returns>
        public CreateDBDiagReportUrlResponse CreateDBDiagReportUrlSync(CreateDBDiagReportUrlRequest req)
        {
            return InternalRequestAsync<CreateDBDiagReportUrlResponse>(req, "CreateDBDiagReportUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public Task<CreateKillTaskResponse> CreateKillTask(CreateKillTaskRequest req)
        {
            return InternalRequestAsync<CreateKillTaskResponse>(req, "CreateKillTask");
        }

        /// <summary>
        /// This API is used to create a session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateKillTaskRequest"/></param>
        /// <returns><see cref="CreateKillTaskResponse"/></returns>
        public CreateKillTaskResponse CreateKillTaskSync(CreateKillTaskRequest req)
        {
            return InternalRequestAsync<CreateKillTaskResponse>(req, "CreateKillTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of scheduled task health report). Always select Guangzhou for `Region`, regardless of the region where the instance resides.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public Task<CreateMailProfileResponse> CreateMailProfile(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile");
        }

        /// <summary>
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of scheduled task health report). Always select Guangzhou for `Region`, regardless of the region where the instance resides.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public CreateMailProfileResponse CreateMailProfileSync(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an async task of killing all proxy node connection sessions and is currently supported only for Redis. The async task ID is the returned value, which can be passed to the API `DescribeProxySessionKillTasks` as a parameter to query the execution status of the session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public Task<CreateProxySessionKillTaskResponse> CreateProxySessionKillTask(CreateProxySessionKillTaskRequest req)
        {
            return InternalRequestAsync<CreateProxySessionKillTaskResponse>(req, "CreateProxySessionKillTask");
        }

        /// <summary>
        /// This API is used to create an async task of killing all proxy node connection sessions and is currently supported only for Redis. The async task ID is the returned value, which can be passed to the API `DescribeProxySessionKillTasks` as a parameter to query the execution status of the session killing task.
        /// </summary>
        /// <param name="req"><see cref="CreateProxySessionKillTaskRequest"/></param>
        /// <returns><see cref="CreateProxySessionKillTaskResponse"/></returns>
        public CreateProxySessionKillTaskResponse CreateProxySessionKillTaskSync(CreateProxySessionKillTaskRequest req)
        {
            return InternalRequestAsync<CreateProxySessionKillTaskResponse>(req, "CreateProxySessionKillTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an ad hoc big key analysis task for Redis instances. By default, there can only be up to five running ad hoc analysis tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateRedisBigKeyAnalysisTaskRequest"/></param>
        /// <returns><see cref="CreateRedisBigKeyAnalysisTaskResponse"/></returns>
        public Task<CreateRedisBigKeyAnalysisTaskResponse> CreateRedisBigKeyAnalysisTask(CreateRedisBigKeyAnalysisTaskRequest req)
        {
            return InternalRequestAsync<CreateRedisBigKeyAnalysisTaskResponse>(req, "CreateRedisBigKeyAnalysisTask");
        }

        /// <summary>
        /// This API is used to create an ad hoc big key analysis task for Redis instances. By default, there can only be up to five running ad hoc analysis tasks.
        /// </summary>
        /// <param name="req"><see cref="CreateRedisBigKeyAnalysisTaskRequest"/></param>
        /// <returns><see cref="CreateRedisBigKeyAnalysisTaskResponse"/></returns>
        public CreateRedisBigKeyAnalysisTaskResponse CreateRedisBigKeyAnalysisTaskSync(CreateRedisBigKeyAnalysisTaskRequest req)
        {
            return InternalRequestAsync<CreateRedisBigKeyAnalysisTaskResponse>(req, "CreateRedisBigKeyAnalysisTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the regular generation time of health reports and the regular email sending configuration. Pass in the regular generation time of health reports as a parameter (Monday to Sunday) to set the regular generation time, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public Task<CreateSchedulerMailProfileResponse> CreateSchedulerMailProfile(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile");
        }

        /// <summary>
        /// This API is used to create the regular generation time of health reports and the regular email sending configuration. Pass in the regular generation time of health reports as a parameter (Monday to Sunday) to set the regular generation time, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public CreateSchedulerMailProfileResponse CreateSchedulerMailProfileSync(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public Task<CreateSecurityAuditLogExportTaskResponse> CreateSecurityAuditLogExportTask(CreateSecurityAuditLogExportTaskRequest req)
        {
            return InternalRequestAsync<CreateSecurityAuditLogExportTaskResponse>(req, "CreateSecurityAuditLogExportTask");
        }

        /// <summary>
        /// This API is used to create a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="CreateSecurityAuditLogExportTaskRequest"/></param>
        /// <returns><see cref="CreateSecurityAuditLogExportTaskResponse"/></returns>
        public CreateSecurityAuditLogExportTaskResponse CreateSecurityAuditLogExportTaskSync(CreateSecurityAuditLogExportTaskRequest req)
        {
            return InternalRequestAsync<CreateSecurityAuditLogExportTaskResponse>(req, "CreateSecurityAuditLogExportTask")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete health report generation tasks by task ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public Task<DeleteDBDiagReportTasksResponse> DeleteDBDiagReportTasks(DeleteDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DeleteDBDiagReportTasksResponse>(req, "DeleteDBDiagReportTasks");
        }

        /// <summary>
        /// This API is used to delete health report generation tasks by task ID.
        /// </summary>
        /// <param name="req"><see cref="DeleteDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DeleteDBDiagReportTasksResponse"/></returns>
        public DeleteDBDiagReportTasksResponse DeleteDBDiagReportTasksSync(DeleteDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DeleteDBDiagReportTasksResponse>(req, "DeleteDBDiagReportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public Task<DeleteSecurityAuditLogExportTasksResponse> DeleteSecurityAuditLogExportTasks(DeleteSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAuditLogExportTasksResponse>(req, "DeleteSecurityAuditLogExportTasks");
        }

        /// <summary>
        /// This API is used to delete a security audit log export task.
        /// </summary>
        /// <param name="req"><see cref="DeleteSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DeleteSecurityAuditLogExportTasksResponse"/></returns>
        public DeleteSecurityAuditLogExportTasksResponse DeleteSecurityAuditLogExportTasksSync(DeleteSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DeleteSecurityAuditLogExportTasksResponse>(req, "DeleteSecurityAuditLogExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of the recipient in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public Task<DescribeAllUserContactResponse> DescribeAllUserContact(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact");
        }

        /// <summary>
        /// This API is used to get the information of the recipient in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public DescribeAllUserContactResponse DescribeAllUserContactSync(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of the recipient group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public Task<DescribeAllUserGroupResponse> DescribeAllUserGroup(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup");
        }

        /// <summary>
        /// This API is used to get the information of the recipient group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public DescribeAllUserGroupResponse DescribeAllUserGroupSync(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public Task<DescribeAuditInstanceListResponse> DescribeAuditInstanceList(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList");
        }

        /// <summary>
        /// This API is used to query the instance list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditInstanceListRequest"/></param>
        /// <returns><see cref="DescribeAuditInstanceListResponse"/></returns>
        public DescribeAuditInstanceListResponse DescribeAuditInstanceListSync(DescribeAuditInstanceListRequest req)
        {
            return InternalRequestAsync<DescribeAuditInstanceListResponse>(req, "DescribeAuditInstanceList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public Task<DescribeDBDiagEventResponse> DescribeDBDiagEvent(DescribeDBDiagEventRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventResponse>(req, "DescribeDBDiagEvent");
        }

        /// <summary>
        /// This API is used to get the details of an instance exception diagnosis event.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventResponse"/></returns>
        public DescribeDBDiagEventResponse DescribeDBDiagEventSync(DescribeDBDiagEventRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventResponse>(req, "DescribeDBDiagEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the diagnosis event list in a specified time period by risk level, instance ID, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public Task<DescribeDBDiagEventsResponse> DescribeDBDiagEvents(DescribeDBDiagEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventsResponse>(req, "DescribeDBDiagEvents");
        }

        /// <summary>
        /// This API is used to obtain the diagnosis event list in a specified time period by risk level, instance ID, etc.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagEventsRequest"/></param>
        /// <returns><see cref="DescribeDBDiagEventsResponse"/></returns>
        public DescribeDBDiagEventsResponse DescribeDBDiagEventsSync(DescribeDBDiagEventsRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagEventsResponse>(req, "DescribeDBDiagEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public Task<DescribeDBDiagHistoryResponse> DescribeDBDiagHistory(DescribeDBDiagHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagHistoryResponse>(req, "DescribeDBDiagHistory");
        }

        /// <summary>
        /// This API is used to get the list of instance diagnosis events.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagHistoryRequest"/></param>
        /// <returns><see cref="DescribeDBDiagHistoryResponse"/></returns>
        public DescribeDBDiagHistoryResponse DescribeDBDiagHistorySync(DescribeDBDiagHistoryRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagHistoryResponse>(req, "DescribeDBDiagHistory")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of health report generation tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public Task<DescribeDBDiagReportTasksResponse> DescribeDBDiagReportTasks(DescribeDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportTasksResponse>(req, "DescribeDBDiagReportTasks");
        }

        /// <summary>
        /// This API is used to query the list of health report generation tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBDiagReportTasksRequest"/></param>
        /// <returns><see cref="DescribeDBDiagReportTasksResponse"/></returns>
        public DescribeDBDiagReportTasksResponse DescribeDBDiagReportTasksSync(DescribeDBDiagReportTasksRequest req)
        {
            return InternalRequestAsync<DescribeDBDiagReportTasksResponse>(req, "DescribeDBDiagReportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the overview of instance space usage during a specified time period, including disk usage growth (MB), available disk space (MB), total disk space (MB), and estimated number of available days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public Task<DescribeDBSpaceStatusResponse> DescribeDBSpaceStatus(DescribeDBSpaceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBSpaceStatusResponse>(req, "DescribeDBSpaceStatus");
        }

        /// <summary>
        /// This API is used to query the overview of instance space usage during a specified time period, including disk usage growth (MB), available disk space (MB), total disk space (MB), and estimated number of available days.
        /// </summary>
        /// <param name="req"><see cref="DescribeDBSpaceStatusRequest"/></param>
        /// <returns><see cref="DescribeDBSpaceStatusResponse"/></returns>
        public DescribeDBSpaceStatusResponse DescribeDBSpaceStatusSync(DescribeDBSpaceStatusRequest req)
        {
            return InternalRequestAsync<DescribeDBSpaceStatusResponse>(req, "DescribeDBSpaceStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the instance information list. Please always select Guangzhou for `Region`.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public Task<DescribeDiagDBInstancesResponse> DescribeDiagDBInstances(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances");
        }

        /// <summary>
        /// This API is used to get the instance information list. Please always select Guangzhou for `Region`.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public DescribeDiagDBInstancesResponse DescribeDiagDBInstancesSync(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public Task<DescribeHealthScoreResponse> DescribeHealthScore(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore");
        }

        /// <summary>
        /// This API is used to get the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public DescribeHealthScoreResponse DescribeHealthScoreSync(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the email sending configuration, including the email configuration for database inspection and the email sending configuration for scheduled task health reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public Task<DescribeMailProfileResponse> DescribeMailProfile(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile");
        }

        /// <summary>
        /// This API is used to get the email sending configuration, including the email configuration for database inspection and the email sending configuration for scheduled task health reports.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public DescribeMailProfileResponse DescribeMailProfileSync(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the real-time thread list of a relational database.
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public Task<DescribeMySqlProcessListResponse> DescribeMySqlProcessList(DescribeMySqlProcessListRequest req)
        {
            return InternalRequestAsync<DescribeMySqlProcessListResponse>(req, "DescribeMySqlProcessList");
        }

        /// <summary>
        /// This API is used to query the real-time thread list of a relational database.
        /// </summary>
        /// <param name="req"><see cref="DescribeMySqlProcessListRequest"/></param>
        /// <returns><see cref="DescribeMySqlProcessListResponse"/></returns>
        public DescribeMySqlProcessListResponse DescribeMySqlProcessListSync(DescribeMySqlProcessListRequest req)
        {
            return InternalRequestAsync<DescribeMySqlProcessListResponse>(req, "DescribeMySqlProcessList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the session statistics of a single proxy under the current instance, and can only be called in particular environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public Task<DescribeProxyProcessStatisticsResponse> DescribeProxyProcessStatistics(DescribeProxyProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyProcessStatisticsResponse>(req, "DescribeProxyProcessStatistics");
        }

        /// <summary>
        /// This API is used to get the session statistics of a single proxy under the current instance, and can only be called in particular environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxyProcessStatisticsRequest"/></param>
        /// <returns><see cref="DescribeProxyProcessStatisticsResponse"/></returns>
        public DescribeProxyProcessStatisticsResponse DescribeProxyProcessStatisticsSync(DescribeProxyProcessStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeProxyProcessStatisticsResponse>(req, "DescribeProxyProcessStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the result of the session killing task executed by the Redis proxy node. The async task ID (an input parameter) is obtained after the API `CreateProxySessionKillTask` is successfully called. Currently, the only valid value of `product` is `redis`.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public Task<DescribeProxySessionKillTasksResponse> DescribeProxySessionKillTasks(DescribeProxySessionKillTasksRequest req)
        {
            return InternalRequestAsync<DescribeProxySessionKillTasksResponse>(req, "DescribeProxySessionKillTasks");
        }

        /// <summary>
        /// This API is used to query the result of the session killing task executed by the Redis proxy node. The async task ID (an input parameter) is obtained after the API `CreateProxySessionKillTask` is successfully called. Currently, the only valid value of `product` is `redis`.
        /// </summary>
        /// <param name="req"><see cref="DescribeProxySessionKillTasksRequest"/></param>
        /// <returns><see cref="DescribeProxySessionKillTasksResponse"/></returns>
        public DescribeProxySessionKillTasksResponse DescribeProxySessionKillTasksSync(DescribeProxySessionKillTasksRequest req)
        {
            return InternalRequestAsync<DescribeProxySessionKillTasksResponse>(req, "DescribeProxySessionKillTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of top key prefixes for Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public Task<DescribeRedisTopKeyPrefixListResponse> DescribeRedisTopKeyPrefixList(DescribeRedisTopKeyPrefixListRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopKeyPrefixListResponse>(req, "DescribeRedisTopKeyPrefixList");
        }

        /// <summary>
        /// This API is used to query the list of top key prefixes for Redis instances.
        /// </summary>
        /// <param name="req"><see cref="DescribeRedisTopKeyPrefixListRequest"/></param>
        /// <returns><see cref="DescribeRedisTopKeyPrefixListResponse"/></returns>
        public DescribeRedisTopKeyPrefixListResponse DescribeRedisTopKeyPrefixListSync(DescribeRedisTopKeyPrefixListRequest req)
        {
            return InternalRequestAsync<DescribeRedisTopKeyPrefixListResponse>(req, "DescribeRedisTopKeyPrefixList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the download link of a security audit log export file. Currently, log file download only provides a Tencent Cloud private network address. Download it by using a CVM instance in the Guangzhou region.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public Task<DescribeSecurityAuditLogDownloadUrlsResponse> DescribeSecurityAuditLogDownloadUrls(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogDownloadUrlsResponse>(req, "DescribeSecurityAuditLogDownloadUrls");
        }

        /// <summary>
        /// This API is used to query the download link of a security audit log export file. Currently, log file download only provides a Tencent Cloud private network address. Download it by using a CVM instance in the Guangzhou region.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogDownloadUrlsRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogDownloadUrlsResponse"/></returns>
        public DescribeSecurityAuditLogDownloadUrlsResponse DescribeSecurityAuditLogDownloadUrlsSync(DescribeSecurityAuditLogDownloadUrlsRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogDownloadUrlsResponse>(req, "DescribeSecurityAuditLogDownloadUrls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of security audit log export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public Task<DescribeSecurityAuditLogExportTasksResponse> DescribeSecurityAuditLogExportTasks(DescribeSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogExportTasksResponse>(req, "DescribeSecurityAuditLogExportTasks");
        }

        /// <summary>
        /// This API is used to query the list of security audit log export tasks.
        /// </summary>
        /// <param name="req"><see cref="DescribeSecurityAuditLogExportTasksRequest"/></param>
        /// <returns><see cref="DescribeSecurityAuditLogExportTasksResponse"/></returns>
        public DescribeSecurityAuditLogExportTasksResponse DescribeSecurityAuditLogExportTasksSync(DescribeSecurityAuditLogExportTasksRequest req)
        {
            return InternalRequestAsync<DescribeSecurityAuditLogExportTasksResponse>(req, "DescribeSecurityAuditLogExportTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public Task<DescribeSlowLogTimeSeriesStatsResponse> DescribeSlowLogTimeSeriesStats(DescribeSlowLogTimeSeriesStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTimeSeriesStatsResponse>(req, "DescribeSlowLogTimeSeriesStats");
        }

        /// <summary>
        /// This API is used to get the slow log statistics histogram.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTimeSeriesStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTimeSeriesStatsResponse"/></returns>
        public DescribeSlowLogTimeSeriesStatsResponse DescribeSlowLogTimeSeriesStatsSync(DescribeSlowLogTimeSeriesStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTimeSeriesStatsResponse>(req, "DescribeSlowLogTimeSeriesStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public Task<DescribeSlowLogTopSqlsResponse> DescribeSlowLogTopSqls(DescribeSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTopSqlsResponse>(req, "DescribeSlowLogTopSqls");
        }

        /// <summary>
        /// This API is used to get and sort the top slow SQL statements in a specified time period by the aggregation mode of SQL template plus schema.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogTopSqlsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogTopSqlsResponse"/></returns>
        public DescribeSlowLogTopSqlsResponse DescribeSlowLogTopSqlsSync(DescribeSlowLogTopSqlsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogTopSqlsResponse>(req, "DescribeSlowLogTopSqls")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public Task<DescribeSlowLogUserHostStatsResponse> DescribeSlowLogUserHostStats(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats");
        }

        /// <summary>
        /// This API is used to get the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public DescribeSlowLogUserHostStatsResponse DescribeSlowLogUserHostStatsSync(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the slow log details of a SQL template in a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public Task<DescribeSlowLogsResponse> DescribeSlowLogs(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs");
        }

        /// <summary>
        /// This API is used to obtain the slow log details of a SQL template in a specified time period.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogsResponse"/></returns>
        public DescribeSlowLogsResponse DescribeSlowLogsSync(DescribeSlowLogsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogsResponse>(req, "DescribeSlowLogs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceSchemaTimeSeriesResponse> DescribeTopSpaceSchemaTimeSeries(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries");
        }

        /// <summary>
        /// This API is used to get the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public DescribeTopSpaceSchemaTimeSeriesResponse DescribeTopSpaceSchemaTimeSeriesSync(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top databases of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public Task<DescribeTopSpaceSchemasResponse> DescribeTopSpaceSchemas(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas");
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top databases of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public DescribeTopSpaceSchemasResponse DescribeTopSpaceSchemasSync(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceTableTimeSeriesResponse> DescribeTopSpaceTableTimeSeries(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries");
        }

        /// <summary>
        /// This API is used to get the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public DescribeTopSpaceTableTimeSeriesResponse DescribeTopSpaceTableTimeSeriesSync(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top tables of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public Task<DescribeTopSpaceTablesResponse> DescribeTopSpaceTables(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables");
        }

        /// <summary>
        /// This API is used to get the real-time space statistics of top tables of an instance. The returned results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public DescribeTopSpaceTablesResponse DescribeTopSpaceTablesSync(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get SQL statement optimization suggestions. It is free of charge for a limited time and will be charged after DBbrain is commercialized.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public Task<DescribeUserSqlAdviceResponse> DescribeUserSqlAdvice(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice");
        }

        /// <summary>
        /// This API is used to get SQL statement optimization suggestions. It is free of charge for a limited time and will be charged after DBbrain is commercialized.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public DescribeUserSqlAdviceResponse DescribeUserSqlAdviceSync(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to interrupt the current session by session ID. It needs to be called twice to commit the session interruption task in two stages. In the pre-commit stage, the stage value is `Prepare`, and the returned value is `SqlExecId`. In the commit stage, the stage value is `Commit`, and `SqlExecId` will be passed in as a parameter. Then, the session process will be terminated.
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public Task<KillMySqlThreadsResponse> KillMySqlThreads(KillMySqlThreadsRequest req)
        {
            return InternalRequestAsync<KillMySqlThreadsResponse>(req, "KillMySqlThreads");
        }

        /// <summary>
        /// This API is used to interrupt the current session by session ID. It needs to be called twice to commit the session interruption task in two stages. In the pre-commit stage, the stage value is `Prepare`, and the returned value is `SqlExecId`. In the commit stage, the stage value is `Commit`, and `SqlExecId` will be passed in as a parameter. Then, the session process will be terminated.
        /// </summary>
        /// <param name="req"><see cref="KillMySqlThreadsRequest"/></param>
        /// <returns><see cref="KillMySqlThreadsResponse"/></returns>
        public KillMySqlThreadsResponse KillMySqlThreadsSync(KillMySqlThreadsRequest req)
        {
            return InternalRequestAsync<KillMySqlThreadsResponse>(req, "KillMySqlThreads")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// u200cThis API is used to modify audit configurations such as the frequent access storage period.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public Task<ModifyAuditServiceResponse> ModifyAuditService(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService");
        }

        /// <summary>
        /// u200cThis API is used to modify audit configurations such as the frequent access storage period.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditServiceRequest"/></param>
        /// <returns><see cref="ModifyAuditServiceResponse"/></returns>
        public ModifyAuditServiceResponse ModifyAuditServiceSync(ModifyAuditServiceRequest req)
        {
            return InternalRequestAsync<ModifyAuditServiceResponse>(req, "ModifyAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable/disable instance inspection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public Task<ModifyDiagDBInstanceConfResponse> ModifyDiagDBInstanceConf(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf");
        }

        /// <summary>
        /// This API is used to enable/disable instance inspection.
        /// </summary>
        /// <param name="req"><see cref="ModifyDiagDBInstanceConfRequest"/></param>
        /// <returns><see cref="ModifyDiagDBInstanceConfResponse"/></returns>
        public ModifyDiagDBInstanceConfResponse ModifyDiagDBInstanceConfSync(ModifyDiagDBInstanceConfRequest req)
        {
            return InternalRequestAsync<ModifyDiagDBInstanceConfResponse>(req, "ModifyDiagDBInstanceConf")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable database audit.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public Task<OpenAuditServiceResponse> OpenAuditService(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService");
        }

        /// <summary>
        /// This API is used to enable database audit.
        /// </summary>
        /// <param name="req"><see cref="OpenAuditServiceRequest"/></param>
        /// <returns><see cref="OpenAuditServiceResponse"/></returns>
        public OpenAuditServiceResponse OpenAuditServiceSync(OpenAuditServiceRequest req)
        {
            return InternalRequestAsync<OpenAuditServiceResponse>(req, "OpenAuditService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

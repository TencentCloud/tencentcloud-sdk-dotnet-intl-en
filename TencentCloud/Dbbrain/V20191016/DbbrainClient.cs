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

namespace TencentCloud.Dbbrain.V20191016
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dbbrain.V20191016.Models;

   public class DbbrainClient : AbstractClient{

       private const string endpoint = "dbbrain.tencentcloudapi.com";
       private const string version = "2019-10-16";
       private const string sdkVersion = "SDK_NET_3.0.1048";

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
        /// This API is used to add the contact name and email.. The return value is the successfully added contact ID. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public Task<AddUserContactResponse> AddUserContact(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact");
        }

        /// <summary>
        /// This API is used to add the contact name and email.. The return value is the successfully added contact ID. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="AddUserContactRequest"/></param>
        /// <returns><see cref="AddUserContactResponse"/></returns>
        public AddUserContactResponse AddUserContactSync(AddUserContactRequest req)
        {
            return InternalRequestAsync<AddUserContactResponse>(req, "AddUserContact")
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
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of regularly generated health report). Select Guangzhou for Region, regardless of the region where the instance belongs.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public Task<CreateMailProfileResponse> CreateMailProfile(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile");
        }

        /// <summary>
        /// This API is used to create the email configuration. The input parameter `ProfileType` represents the type of the email configuration. Valid values: `dbScan_mail_configuration` (email configuration of database inspection report) and `scheduler_mail_configuration` (email sending configuration of regularly generated health report). Select Guangzhou for Region, regardless of the region where the instance belongs.
        /// </summary>
        /// <param name="req"><see cref="CreateMailProfileRequest"/></param>
        /// <returns><see cref="CreateMailProfileResponse"/></returns>
        public CreateMailProfileResponse CreateMailProfileSync(CreateMailProfileRequest req)
        {
            return InternalRequestAsync<CreateMailProfileResponse>(req, "CreateMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create the regular generation time of the health reports and the regular email sending configuration. Pass in the regular generation time of the health reports as a parameter (Monday to Sunday) to set the regular generation time of the health reports, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public Task<CreateSchedulerMailProfileResponse> CreateSchedulerMailProfile(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile");
        }

        /// <summary>
        /// This API is used to create the regular generation time of the health reports and the regular email sending configuration. Pass in the regular generation time of the health reports as a parameter (Monday to Sunday) to set the regular generation time of the health reports, and save the corresponding regular email sending configuration.
        /// </summary>
        /// <param name="req"><see cref="CreateSchedulerMailProfileRequest"/></param>
        /// <returns><see cref="CreateSchedulerMailProfileResponse"/></returns>
        public CreateSchedulerMailProfileResponse CreateSchedulerMailProfileSync(CreateSchedulerMailProfileRequest req)
        {
            return InternalRequestAsync<CreateSchedulerMailProfileResponse>(req, "CreateSchedulerMailProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of the contact in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public Task<DescribeAllUserContactResponse> DescribeAllUserContact(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact");
        }

        /// <summary>
        /// This API is used to obtain the information of the contact in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserContactRequest"/></param>
        /// <returns><see cref="DescribeAllUserContactResponse"/></returns>
        public DescribeAllUserContactResponse DescribeAllUserContactSync(DescribeAllUserContactRequest req)
        {
            return InternalRequestAsync<DescribeAllUserContactResponse>(req, "DescribeAllUserContact")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the information of the contact group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public Task<DescribeAllUserGroupResponse> DescribeAllUserGroup(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup");
        }

        /// <summary>
        /// This API is used to obtain the information of the contact group in the email.
        /// </summary>
        /// <param name="req"><see cref="DescribeAllUserGroupRequest"/></param>
        /// <returns><see cref="DescribeAllUserGroupResponse"/></returns>
        public DescribeAllUserGroupResponse DescribeAllUserGroupSync(DescribeAllUserGroupRequest req)
        {
            return InternalRequestAsync<DescribeAllUserGroupResponse>(req, "DescribeAllUserGroup")
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
        /// This API is used to obtain the instance information list. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public Task<DescribeDiagDBInstancesResponse> DescribeDiagDBInstances(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances");
        }

        /// <summary>
        /// This API is used to obtain the instance information list. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="DescribeDiagDBInstancesRequest"/></param>
        /// <returns><see cref="DescribeDiagDBInstancesResponse"/></returns>
        public DescribeDiagDBInstancesResponse DescribeDiagDBInstancesSync(DescribeDiagDBInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDiagDBInstancesResponse>(req, "DescribeDiagDBInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public Task<DescribeHealthScoreResponse> DescribeHealthScore(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore");
        }

        /// <summary>
        /// This API is used to obtain the health score and deduction for exceptions in the specified time period (30 minutes) based on the instance ID.
        /// </summary>
        /// <param name="req"><see cref="DescribeHealthScoreRequest"/></param>
        /// <returns><see cref="DescribeHealthScoreResponse"/></returns>
        public DescribeHealthScoreResponse DescribeHealthScoreSync(DescribeHealthScoreRequest req)
        {
            return InternalRequestAsync<DescribeHealthScoreResponse>(req, "DescribeHealthScore")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the email sending configurations, including the email configuration for database inspection and the email sending configuration for regularly generated health reports. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public Task<DescribeMailProfileResponse> DescribeMailProfile(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile");
        }

        /// <summary>
        /// This API is used to obtain the email sending configurations, including the email configuration for database inspection and the email sending configuration for regularly generated health reports. Select Guangzhou for Region.
        /// </summary>
        /// <param name="req"><see cref="DescribeMailProfileRequest"/></param>
        /// <returns><see cref="DescribeMailProfileResponse"/></returns>
        public DescribeMailProfileResponse DescribeMailProfileSync(DescribeMailProfileRequest req)
        {
            return InternalRequestAsync<DescribeMailProfileResponse>(req, "DescribeMailProfile")
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
        /// This API is used to obtain the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public Task<DescribeSlowLogUserHostStatsResponse> DescribeSlowLogUserHostStats(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats");
        }

        /// <summary>
        /// This API is used to obtain the statistical distribution chart of slow log source addresses.
        /// </summary>
        /// <param name="req"><see cref="DescribeSlowLogUserHostStatsRequest"/></param>
        /// <returns><see cref="DescribeSlowLogUserHostStatsResponse"/></returns>
        public DescribeSlowLogUserHostStatsResponse DescribeSlowLogUserHostStatsSync(DescribeSlowLogUserHostStatsRequest req)
        {
            return InternalRequestAsync<DescribeSlowLogUserHostStatsResponse>(req, "DescribeSlowLogUserHostStats")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceSchemaTimeSeriesResponse> DescribeTopSpaceSchemaTimeSeries(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries");
        }

        /// <summary>
        /// This API is used to query the daily space data of top databases consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemaTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemaTimeSeriesResponse"/></returns>
        public DescribeTopSpaceSchemaTimeSeriesResponse DescribeTopSpaceSchemaTimeSeriesSync(DescribeTopSpaceSchemaTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemaTimeSeriesResponse>(req, "DescribeTopSpaceSchemaTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time space statistics of top databases. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public Task<DescribeTopSpaceSchemasResponse> DescribeTopSpaceSchemas(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas");
        }

        /// <summary>
        /// This API is used to query real-time space statistics of top databases. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceSchemasRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceSchemasResponse"/></returns>
        public DescribeTopSpaceSchemasResponse DescribeTopSpaceSchemasSync(DescribeTopSpaceSchemasRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceSchemasResponse>(req, "DescribeTopSpaceSchemas")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public Task<DescribeTopSpaceTableTimeSeriesResponse> DescribeTopSpaceTableTimeSeries(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries");
        }

        /// <summary>
        /// This API is used to query the daily space data of top tables consuming the most instance space. The data is daily collected by DBbrain during a specified time period. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTableTimeSeriesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTableTimeSeriesResponse"/></returns>
        public DescribeTopSpaceTableTimeSeriesResponse DescribeTopSpaceTableTimeSeriesSync(DescribeTopSpaceTableTimeSeriesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTableTimeSeriesResponse>(req, "DescribeTopSpaceTableTimeSeries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query real-time space statistics of top tables of an instance. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public Task<DescribeTopSpaceTablesResponse> DescribeTopSpaceTables(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables");
        }

        /// <summary>
        /// This API is used to query real-time space statistics of top tables of an instance. The return results are sorted by size by default.
        /// </summary>
        /// <param name="req"><see cref="DescribeTopSpaceTablesRequest"/></param>
        /// <returns><see cref="DescribeTopSpaceTablesResponse"/></returns>
        public DescribeTopSpaceTablesResponse DescribeTopSpaceTablesSync(DescribeTopSpaceTablesRequest req)
        {
            return InternalRequestAsync<DescribeTopSpaceTablesResponse>(req, "DescribeTopSpaceTables")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain SQL statement optimization suggestions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public Task<DescribeUserSqlAdviceResponse> DescribeUserSqlAdvice(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice");
        }

        /// <summary>
        /// This API is used to obtain SQL statement optimization suggestions.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserSqlAdviceRequest"/></param>
        /// <returns><see cref="DescribeUserSqlAdviceResponse"/></returns>
        public DescribeUserSqlAdviceResponse DescribeUserSqlAdviceSync(DescribeUserSqlAdviceRequest req)
        {
            return InternalRequestAsync<DescribeUserSqlAdviceResponse>(req, "DescribeUserSqlAdvice")
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

    }
}

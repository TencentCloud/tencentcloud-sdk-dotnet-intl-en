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

namespace TencentCloud.Emr.V20190103
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Emr.V20190103.Models;

   public class EmrClient : AbstractClient{

       private const string endpoint = "emr.tencentcloudapi.com";
       private const string version = "2019-01-03";
       private const string sdkVersion = "SDK_NET_3.0.889";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EmrClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EmrClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public Task<AddUsersForUserManagerResponse> AddUsersForUserManager(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager");
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to add user lists (user management).
        /// </summary>
        /// <param name="req"><see cref="AddUsersForUserManagerRequest"/></param>
        /// <returns><see cref="AddUsersForUserManagerResponse"/></returns>
        public AddUsersForUserManagerResponse AddUsersForUserManagerSync(AddUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<AddUsersForUserManagerResponse>(req, "AddUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public Task<CreateInstanceResponse> CreateInstance(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance");
        }

        /// <summary>
        /// This API is used to create an EMR cluster instance.
        /// </summary>
        /// <param name="req"><see cref="CreateInstanceRequest"/></param>
        /// <returns><see cref="CreateInstanceResponse"/></returns>
        public CreateInstanceResponse CreateInstanceSync(CreateInstanceRequest req)
        {
            return InternalRequestAsync<CreateInstanceResponse>(req, "CreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquiry detailed records of cluster autoscaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public Task<DescribeAutoScaleRecordsResponse> DescribeAutoScaleRecords(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords");
        }

        /// <summary>
        /// This API is used to inquiry detailed records of cluster autoscaling.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScaleRecordsRequest"/></param>
        /// <returns><see cref="DescribeAutoScaleRecordsResponse"/></returns>
        public DescribeAutoScaleRecordsResponse DescribeAutoScaleRecordsSync(DescribeAutoScaleRecordsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScaleRecordsResponse>(req, "DescribeAutoScaleRecords")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public Task<DescribeClusterNodesResponse> DescribeClusterNodes(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes");
        }

        /// <summary>
        /// This API is used to query the information of nodes in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterNodesRequest"/></param>
        /// <returns><see cref="DescribeClusterNodesResponse"/></returns>
        public DescribeClusterNodesResponse DescribeClusterNodesSync(DescribeClusterNodesRequest req)
        {
            return InternalRequestAsync<DescribeClusterNodesResponse>(req, "DescribeClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        ///  This API is used to query the Yarn application statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public Task<DescribeEmrApplicationStaticsResponse> DescribeEmrApplicationStatics(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics");
        }

        /// <summary>
        ///  This API is used to query the Yarn application statistics.
        /// </summary>
        /// <param name="req"><see cref="DescribeEmrApplicationStaticsRequest"/></param>
        /// <returns><see cref="DescribeEmrApplicationStaticsResponse"/></returns>
        public DescribeEmrApplicationStaticsResponse DescribeEmrApplicationStaticsSync(DescribeEmrApplicationStaticsRequest req)
        {
            return InternalRequestAsync<DescribeEmrApplicationStaticsResponse>(req, "DescribeEmrApplicationStatics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to inquiry Hive query data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public Task<DescribeHiveQueriesResponse> DescribeHiveQueries(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries");
        }

        /// <summary>
        /// This API is used to inquiry Hive query data.
        /// </summary>
        /// <param name="req"><see cref="DescribeHiveQueriesRequest"/></param>
        /// <returns><see cref="DescribeHiveQueriesResponse"/></returns>
        public DescribeHiveQueriesResponse DescribeHiveQueriesSync(DescribeHiveQueriesRequest req)
        {
            return InternalRequestAsync<DescribeHiveQueriesResponse>(req, "DescribeHiveQueries")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// This API is used to query the information of instances in a cluster.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public Task<DescribeInstancesListResponse> DescribeInstancesList(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList");
        }

        /// <summary>
        /// This API is used to query the cluster list.
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesListRequest"/></param>
        /// <returns><see cref="DescribeInstancesListResponse"/></returns>
        public DescribeInstancesListResponse DescribeInstancesListSync(DescribeInstancesListRequest req)
        {
            return InternalRequestAsync<DescribeInstancesListResponse>(req, "DescribeInstancesList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the data of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public Task<DescribeResourceScheduleResponse> DescribeResourceSchedule(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule");
        }

        /// <summary>
        /// This API is used to query the data of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceScheduleRequest"/></param>
        /// <returns><see cref="DescribeResourceScheduleResponse"/></returns>
        public DescribeResourceScheduleResponse DescribeResourceScheduleSync(DescribeResourceScheduleRequest req)
        {
            return InternalRequestAsync<DescribeResourceScheduleResponse>(req, "DescribeResourceSchedule")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public Task<DescribeUsersForUserManagerResponse> DescribeUsersForUserManager(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager");
        }

        /// <summary>
        /// This API is available for clusters with OpenLDAP components configured.
        /// This API is used to export users in batches. For a Kerberos cluster, set `NeedKeytabInfo` to `true` to obtain the download link of the Keytab file. If `SupportDownLoadKeyTab` is `true`, but `DownLoadKeyTabUrl` is null, the Keytab file is not ready yet (being generated) in the backend.
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersForUserManagerRequest"/></param>
        /// <returns><see cref="DescribeUsersForUserManagerResponse"/></returns>
        public DescribeUsersForUserManagerResponse DescribeUsersForUserManagerSync(DescribeUsersForUserManagerRequest req)
        {
            return InternalRequestAsync<DescribeUsersForUserManagerResponse>(req, "DescribeUsersForUserManager")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public Task<InquiryPriceCreateInstanceResponse> InquiryPriceCreateInstance(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance");
        }

        /// <summary>
        /// This API is used to query price of instance creation.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceCreateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceCreateInstanceResponse"/></returns>
        public InquiryPriceCreateInstanceResponse InquiryPriceCreateInstanceSync(InquiryPriceCreateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceCreateInstanceResponse>(req, "InquiryPriceCreateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public Task<InquiryPriceRenewInstanceResponse> InquiryPriceRenewInstance(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance");
        }

        /// <summary>
        /// This API is used to query the price for renewal.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceRenewInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceRenewInstanceResponse"/></returns>
        public InquiryPriceRenewInstanceResponse InquiryPriceRenewInstanceSync(InquiryPriceRenewInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceRenewInstanceResponse>(req, "InquiryPriceRenewInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public Task<InquiryPriceScaleOutInstanceResponse> InquiryPriceScaleOutInstance(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance");
        }

        /// <summary>
        /// This API is used to query price of scale-out.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceScaleOutInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceScaleOutInstanceResponse"/></returns>
        public InquiryPriceScaleOutInstanceResponse InquiryPriceScaleOutInstanceSync(InquiryPriceScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceScaleOutInstanceResponse>(req, "InquiryPriceScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public Task<InquiryPriceUpdateInstanceResponse> InquiryPriceUpdateInstance(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance");
        }

        /// <summary>
        /// This API is used to query price of scaling.
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceUpdateInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceUpdateInstanceResponse"/></returns>
        public InquiryPriceUpdateInstanceResponse InquiryPriceUpdateInstanceSync(InquiryPriceUpdateInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceUpdateInstanceResponse>(req, "InquiryPriceUpdateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public Task<ModifyResourceScheduleConfigResponse> ModifyResourceScheduleConfig(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig");
        }

        /// <summary>
        /// This API is used to modify the resource configuration of YARN Resource Scheduling.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceScheduleConfigRequest"/></param>
        /// <returns><see cref="ModifyResourceScheduleConfigResponse"/></returns>
        public ModifyResourceScheduleConfigResponse ModifyResourceScheduleConfigSync(ModifyResourceScheduleConfigRequest req)
        {
            return InternalRequestAsync<ModifyResourceScheduleConfigResponse>(req, "ModifyResourceScheduleConfig")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the YARN resource scheduler (the change will take effect after you click Apply).
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public Task<ModifyResourceSchedulerResponse> ModifyResourceScheduler(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler");
        }

        /// <summary>
        /// This API is used to modify the YARN resource scheduler (the change will take effect after you click Apply).
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceSchedulerRequest"/></param>
        /// <returns><see cref="ModifyResourceSchedulerResponse"/></returns>
        public ModifyResourceSchedulerResponse ModifyResourceSchedulerSync(ModifyResourceSchedulerRequest req)
        {
            return InternalRequestAsync<ModifyResourceSchedulerResponse>(req, "ModifyResourceScheduler")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to forcibly modify tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public Task<ModifyResourcesTagsResponse> ModifyResourcesTags(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags");
        }

        /// <summary>
        /// This API is used to forcibly modify tags.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagsRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagsResponse"/></returns>
        public ModifyResourcesTagsResponse ModifyResourcesTagsSync(ModifyResourcesTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagsResponse>(req, "ModifyResourcesTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to change user password (user management).
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public Task<ModifyUserManagerPwdResponse> ModifyUserManagerPwd(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd");
        }

        /// <summary>
        /// This API is used to change user password (user management).
        /// </summary>
        /// <param name="req"><see cref="ModifyUserManagerPwdRequest"/></param>
        /// <returns><see cref="ModifyUserManagerPwdResponse"/></returns>
        public ModifyUserManagerPwdResponse ModifyUserManagerPwdSync(ModifyUserManagerPwdRequest req)
        {
            return InternalRequestAsync<ModifyUserManagerPwdResponse>(req, "ModifyUserManagerPwd")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out a cluster.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public Task<ScaleOutClusterResponse> ScaleOutCluster(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster");
        }

        /// <summary>
        /// This API is used to scale out a cluster.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutClusterRequest"/></param>
        /// <returns><see cref="ScaleOutClusterResponse"/></returns>
        public ScaleOutClusterResponse ScaleOutClusterSync(ScaleOutClusterRequest req)
        {
            return InternalRequestAsync<ScaleOutClusterResponse>(req, "ScaleOutCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public Task<ScaleOutInstanceResponse> ScaleOutInstance(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance");
        }

        /// <summary>
        /// This API is used to scale out instances.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstanceRequest"/></param>
        /// <returns><see cref="ScaleOutInstanceResponse"/></returns>
        public ScaleOutInstanceResponse ScaleOutInstanceSync(ScaleOutInstanceRequest req)
        {
            return InternalRequestAsync<ScaleOutInstanceResponse>(req, "ScaleOutInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start, stop, or restart services.
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public Task<StartStopServiceOrMonitorResponse> StartStopServiceOrMonitor(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor");
        }

        /// <summary>
        /// This API is used to start, stop, or restart services.
        /// </summary>
        /// <param name="req"><see cref="StartStopServiceOrMonitorRequest"/></param>
        /// <returns><see cref="StartStopServiceOrMonitorResponse"/></returns>
        public StartStopServiceOrMonitorResponse StartStopServiceOrMonitorSync(StartStopServiceOrMonitorRequest req)
        {
            return InternalRequestAsync<StartStopServiceOrMonitorResponse>(req, "StartStopServiceOrMonitor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public Task<TerminateClusterNodesResponse> TerminateClusterNodes(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes");
        }

        /// <summary>
        /// This API is used to terminate cluster nodes.
        /// </summary>
        /// <param name="req"><see cref="TerminateClusterNodesRequest"/></param>
        /// <returns><see cref="TerminateClusterNodesResponse"/></returns>
        public TerminateClusterNodesResponse TerminateClusterNodesSync(TerminateClusterNodesRequest req)
        {
            return InternalRequestAsync<TerminateClusterNodesResponse>(req, "TerminateClusterNodes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public Task<TerminateInstanceResponse> TerminateInstance(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance");
        }

        /// <summary>
        /// This API is used to terminate EMR instances. It is only supported in the official paid edition of EMR.
        /// </summary>
        /// <param name="req"><see cref="TerminateInstanceRequest"/></param>
        /// <returns><see cref="TerminateInstanceResponse"/></returns>
        public TerminateInstanceResponse TerminateInstanceSync(TerminateInstanceRequest req)
        {
            return InternalRequestAsync<TerminateInstanceResponse>(req, "TerminateInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public Task<TerminateTasksResponse> TerminateTasks(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks");
        }

        /// <summary>
        /// This API is used to terminate a task node.
        /// </summary>
        /// <param name="req"><see cref="TerminateTasksRequest"/></param>
        /// <returns><see cref="TerminateTasksResponse"/></returns>
        public TerminateTasksResponse TerminateTasksSync(TerminateTasksRequest req)
        {
            return InternalRequestAsync<TerminateTasksResponse>(req, "TerminateTasks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

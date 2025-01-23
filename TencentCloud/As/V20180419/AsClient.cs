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

namespace TencentCloud.As.V20180419
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.As.V20180419.Models;

   public class AsClient : AbstractClient{

       private const string endpoint = "as.tencentcloudapi.com";
       private const string version = "2018-04-19";
       private const string sdkVersion = "SDK_NET_3.0.1061";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add CVM instances to an auto scaling group.
        /// * Only CVM instances in `RUNNING` or `STOPPED` status can be added.
        /// * The added CVM instances must in the same VPC as the scaling group.
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public Task<AttachInstancesResponse> AttachInstances(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances");
        }

        /// <summary>
        /// This API is used to add CVM instances to an auto scaling group.
        /// * Only CVM instances in `RUNNING` or `STOPPED` status can be added.
        /// * The added CVM instances must in the same VPC as the scaling group.
        /// </summary>
        /// <param name="req"><see cref="AttachInstancesRequest"/></param>
        /// <returns><see cref="AttachInstancesResponse"/></returns>
        public AttachInstancesResponse AttachInstancesSync(AttachInstancesRequest req)
        {
            return InternalRequestAsync<AttachInstancesResponse>(req, "AttachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add CLBs to a security group.
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public Task<AttachLoadBalancersResponse> AttachLoadBalancers(AttachLoadBalancersRequest req)
        {
            return InternalRequestAsync<AttachLoadBalancersResponse>(req, "AttachLoadBalancers");
        }

        /// <summary>
        /// This API is used to add CLBs to a security group.
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public AttachLoadBalancersResponse AttachLoadBalancersSync(AttachLoadBalancersRequest req)
        {
            return InternalRequestAsync<AttachLoadBalancersResponse>(req, "AttachLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to cancel the instance refresh activity of the scaling group.
        /// * The batches that have already been refreshed or are currently being refreshed remain unaffected, but the batches pending refresh will be canceled.
        /// * If a refresh fails, the affected instances will remain in the secondary status, and require manual intervention to exit the secondary status or terminate the instances.
        /// * Rollback operations are not allowed after cancellation, and recovery is also unsupported.
        /// * The instances temporarily scaled out due to the MaxSurge parameter are automatically terminated after cancellation.
        /// * During scale-in, all instances have already been updated and cannot be canceled.
        /// </summary>
        /// <param name="req"><see cref="CancelInstanceRefreshRequest"/></param>
        /// <returns><see cref="CancelInstanceRefreshResponse"/></returns>
        public Task<CancelInstanceRefreshResponse> CancelInstanceRefresh(CancelInstanceRefreshRequest req)
        {
            return InternalRequestAsync<CancelInstanceRefreshResponse>(req, "CancelInstanceRefresh");
        }

        /// <summary>
        /// This API is used to cancel the instance refresh activity of the scaling group.
        /// * The batches that have already been refreshed or are currently being refreshed remain unaffected, but the batches pending refresh will be canceled.
        /// * If a refresh fails, the affected instances will remain in the secondary status, and require manual intervention to exit the secondary status or terminate the instances.
        /// * Rollback operations are not allowed after cancellation, and recovery is also unsupported.
        /// * The instances temporarily scaled out due to the MaxSurge parameter are automatically terminated after cancellation.
        /// * During scale-in, all instances have already been updated and cannot be canceled.
        /// </summary>
        /// <param name="req"><see cref="CancelInstanceRefreshRequest"/></param>
        /// <returns><see cref="CancelInstanceRefreshResponse"/></returns>
        public CancelInstanceRefreshResponse CancelInstanceRefreshSync(CancelInstanceRefreshRequest req)
        {
            return InternalRequestAsync<CancelInstanceRefreshResponse>(req, "CancelInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to clear specific attributes of the launch configuration.
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public Task<ClearLaunchConfigurationAttributesResponse> ClearLaunchConfigurationAttributes(ClearLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ClearLaunchConfigurationAttributesResponse>(req, "ClearLaunchConfigurationAttributes");
        }

        /// <summary>
        /// This API is used to clear specific attributes of the launch configuration.
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public ClearLaunchConfigurationAttributesResponse ClearLaunchConfigurationAttributesSync(ClearLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ClearLaunchConfigurationAttributesResponse>(req, "ClearLaunchConfigurationAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to complete a lifecycle action by setting the status of lifecycle hook to `CONTINUE` or `ABANDON`.
        /// 
        /// * If this API is not called, the lifecycle hook goes to the status specified in `DefaultResult` after the timeout period.
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public Task<CompleteLifecycleActionResponse> CompleteLifecycleAction(CompleteLifecycleActionRequest req)
        {
            return InternalRequestAsync<CompleteLifecycleActionResponse>(req, "CompleteLifecycleAction");
        }

        /// <summary>
        /// This API is used to complete a lifecycle action by setting the status of lifecycle hook to `CONTINUE` or `ABANDON`.
        /// 
        /// * If this API is not called, the lifecycle hook goes to the status specified in `DefaultResult` after the timeout period.
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public CompleteLifecycleActionResponse CompleteLifecycleActionSync(CompleteLifecycleActionRequest req)
        {
            return InternalRequestAsync<CompleteLifecycleActionResponse>(req, "CompleteLifecycleAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateAutoScalingGroup) is used to create an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroup(CreateAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupResponse>(req, "CreateAutoScalingGroup");
        }

        /// <summary>
        /// This API (CreateAutoScalingGroup) is used to create an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroupSync(CreateAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupResponse>(req, "CreateAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create launch configurations and scaling groups based on an instance.
        /// 
        /// Note: for a scaling group that is created based on a monthly-subscribed instance, the instances added for scale-out are pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupFromInstanceRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupFromInstanceResponse"/></returns>
        public Task<CreateAutoScalingGroupFromInstanceResponse> CreateAutoScalingGroupFromInstance(CreateAutoScalingGroupFromInstanceRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupFromInstanceResponse>(req, "CreateAutoScalingGroupFromInstance");
        }

        /// <summary>
        /// This API is used to create launch configurations and scaling groups based on an instance.
        /// 
        /// Note: for a scaling group that is created based on a monthly-subscribed instance, the instances added for scale-out are pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupFromInstanceRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupFromInstanceResponse"/></returns>
        public CreateAutoScalingGroupFromInstanceResponse CreateAutoScalingGroupFromInstanceSync(CreateAutoScalingGroupFromInstanceRequest req)
        {
            return InternalRequestAsync<CreateAutoScalingGroupFromInstanceResponse>(req, "CreateAutoScalingGroupFromInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a launch configuration.
        /// 
        /// * To modify a launch configuration, please use `ModifyLaunchConfigurationAttributes`.
        /// 
        /// * Up to 20 launch configurations can be created for each project. For more information, see [Usage Limits](https://intl.cloud.tencent.com/document/product/377/3120?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public Task<CreateLaunchConfigurationResponse> CreateLaunchConfiguration(CreateLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<CreateLaunchConfigurationResponse>(req, "CreateLaunchConfiguration");
        }

        /// <summary>
        /// This API is used to create a launch configuration.
        /// 
        /// * To modify a launch configuration, please use `ModifyLaunchConfigurationAttributes`.
        /// 
        /// * Up to 20 launch configurations can be created for each project. For more information, see [Usage Limits](https://intl.cloud.tencent.com/document/product/377/3120?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public CreateLaunchConfigurationResponse CreateLaunchConfigurationSync(CreateLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<CreateLaunchConfigurationResponse>(req, "CreateLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a lifecycle hook.
        /// 
        /// * You can configure notifications or automation commands (TAT) for the lifecycle hook.
        /// 
        /// If you configured a notification, Auto Scaling will notify the TDMQ queue of the following information:
        /// 
        /// ```
        /// {
        /// 	"Service": "Tencent Cloud Auto Scaling",
        /// 	"Time": "2019-03-14T10:15:11Z",
        /// 	"AppId": "1251783334",
        /// 	"ActivityId": "asa-fznnvrja",
        /// 	"AutoScalingGroupId": "asg-rrrrtttt",
        /// 	"LifecycleHookId": "ash-xxxxyyyy",
        /// 	"LifecycleHookName": "my-hook",
        /// 	"LifecycleActionToken": "3080e1c9-0efe-4dd7-ad3b-90cd6618298f",
        /// 	"InstanceId": "ins-aaaabbbb",
        /// 	"LifecycleTransition": "INSTANCE_LAUNCHING",
        /// 	"NotificationMetadata": ""
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleHookRequest"/></param>
        /// <returns><see cref="CreateLifecycleHookResponse"/></returns>
        public Task<CreateLifecycleHookResponse> CreateLifecycleHook(CreateLifecycleHookRequest req)
        {
            return InternalRequestAsync<CreateLifecycleHookResponse>(req, "CreateLifecycleHook");
        }

        /// <summary>
        /// This API is used to create a lifecycle hook.
        /// 
        /// * You can configure notifications or automation commands (TAT) for the lifecycle hook.
        /// 
        /// If you configured a notification, Auto Scaling will notify the TDMQ queue of the following information:
        /// 
        /// ```
        /// {
        /// 	"Service": "Tencent Cloud Auto Scaling",
        /// 	"Time": "2019-03-14T10:15:11Z",
        /// 	"AppId": "1251783334",
        /// 	"ActivityId": "asa-fznnvrja",
        /// 	"AutoScalingGroupId": "asg-rrrrtttt",
        /// 	"LifecycleHookId": "ash-xxxxyyyy",
        /// 	"LifecycleHookName": "my-hook",
        /// 	"LifecycleActionToken": "3080e1c9-0efe-4dd7-ad3b-90cd6618298f",
        /// 	"InstanceId": "ins-aaaabbbb",
        /// 	"LifecycleTransition": "INSTANCE_LAUNCHING",
        /// 	"NotificationMetadata": ""
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateLifecycleHookRequest"/></param>
        /// <returns><see cref="CreateLifecycleHookResponse"/></returns>
        public CreateLifecycleHookResponse CreateLifecycleHookSync(CreateLifecycleHookRequest req)
        {
            return InternalRequestAsync<CreateLifecycleHookResponse>(req, "CreateLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a notification policy.
        /// When the notification is sent to a CMQ topic or queue, the following contents are included:
        /// ```
        /// {
        ///     "Service": "Tencent Cloud Auto Scaling",
        ///     "CreatedTime": "2021-10-11T10:15:11Z", // Activity creation time
        ///     "AppId": "100000000",
        ///     "ActivityId": "asa-fznnvrja", // Scaling activity ID
        ///     "AutoScalingGroupId": "asg-pc2oqu2z", // Scaling group ID
        ///     "ActivityType": "SCALE_OUT",  // Scaling activity type
        ///     "StatusCode": "SUCCESSFUL",   // Scaling activity result
        ///     "Description": "Activity was launched in response to a difference between desired capacity and actual capacity,
        ///     scale out 1 instance(s).", // Scaling activity description
        ///     "StartTime": "2021-10-11T10:15:11Z",  // Activity starting time
        ///     "EndTime": "2021-10-11T10:15:32Z",    // Activity ending time
        ///     "DetailedStatusMessageSet": [ // A collection of failed attempts during the scaling process (Failed attempts are allowed in a successful scaling activity)
        ///         {
        ///             "Code": "InvalidInstanceType",
        ///             "Zone": "ap-guangzhou-2",
        ///             "InstanceId": "",
        ///             "InstanceChargeType": "POSTPAID_BY_HOUR",
        ///             "SubnetId": "subnet-4t5mgeuu",
        ///             "Message": "The specified instance type `S5.LARGE8` is invalid in `subnet-4t5mgeuu`, `ap-guangzhou-2`.",
        ///             "InstanceType": "S5.LARGE8",
        ///         }
        ///     ]
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateNotificationConfigurationRequest"/></param>
        /// <returns><see cref="CreateNotificationConfigurationResponse"/></returns>
        public Task<CreateNotificationConfigurationResponse> CreateNotificationConfiguration(CreateNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<CreateNotificationConfigurationResponse>(req, "CreateNotificationConfiguration");
        }

        /// <summary>
        /// This API is used to create a notification policy.
        /// When the notification is sent to a CMQ topic or queue, the following contents are included:
        /// ```
        /// {
        ///     "Service": "Tencent Cloud Auto Scaling",
        ///     "CreatedTime": "2021-10-11T10:15:11Z", // Activity creation time
        ///     "AppId": "100000000",
        ///     "ActivityId": "asa-fznnvrja", // Scaling activity ID
        ///     "AutoScalingGroupId": "asg-pc2oqu2z", // Scaling group ID
        ///     "ActivityType": "SCALE_OUT",  // Scaling activity type
        ///     "StatusCode": "SUCCESSFUL",   // Scaling activity result
        ///     "Description": "Activity was launched in response to a difference between desired capacity and actual capacity,
        ///     scale out 1 instance(s).", // Scaling activity description
        ///     "StartTime": "2021-10-11T10:15:11Z",  // Activity starting time
        ///     "EndTime": "2021-10-11T10:15:32Z",    // Activity ending time
        ///     "DetailedStatusMessageSet": [ // A collection of failed attempts during the scaling process (Failed attempts are allowed in a successful scaling activity)
        ///         {
        ///             "Code": "InvalidInstanceType",
        ///             "Zone": "ap-guangzhou-2",
        ///             "InstanceId": "",
        ///             "InstanceChargeType": "POSTPAID_BY_HOUR",
        ///             "SubnetId": "subnet-4t5mgeuu",
        ///             "Message": "The specified instance type `S5.LARGE8` is invalid in `subnet-4t5mgeuu`, `ap-guangzhou-2`.",
        ///             "InstanceType": "S5.LARGE8",
        ///         }
        ///     ]
        /// }
        /// ```
        /// </summary>
        /// <param name="req"><see cref="CreateNotificationConfigurationRequest"/></param>
        /// <returns><see cref="CreateNotificationConfigurationResponse"/></returns>
        public CreateNotificationConfigurationResponse CreateNotificationConfigurationSync(CreateNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<CreateNotificationConfigurationResponse>(req, "CreateNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateScalingPolicy) is used to create an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public Task<CreateScalingPolicyResponse> CreateScalingPolicy(CreateScalingPolicyRequest req)
        {
            return InternalRequestAsync<CreateScalingPolicyResponse>(req, "CreateScalingPolicy");
        }

        /// <summary>
        /// This API (CreateScalingPolicy) is used to create an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public CreateScalingPolicyResponse CreateScalingPolicySync(CreateScalingPolicyRequest req)
        {
            return InternalRequestAsync<CreateScalingPolicyResponse>(req, "CreateScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (CreateScheduledAction) is used to create a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public Task<CreateScheduledActionResponse> CreateScheduledAction(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction");
        }

        /// <summary>
        /// This API (CreateScheduledAction) is used to create a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public CreateScheduledActionResponse CreateScheduledActionSync(CreateScheduledActionRequest req)
        {
            return InternalRequestAsync<CreateScheduledActionResponse>(req, "CreateScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an auto-scaling group. Make sure that there are no `IN_SERVICE` instances in the group, and there are no ongoing scaling activities. When you delete a scaling group, instances in the status of `CREATION_FAILED`, `TERMINATION_FAILED` and `DETACH_FAILED` are not terminated.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalingGroupResponse>(req, "DeleteAutoScalingGroup");
        }

        /// <summary>
        /// This API is used to delete an auto-scaling group. Make sure that there are no `IN_SERVICE` instances in the group, and there are no ongoing scaling activities. When you delete a scaling group, instances in the status of `CREATION_FAILED`, `TERMINATION_FAILED` and `DETACH_FAILED` are not terminated.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroupSync(DeleteAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DeleteAutoScalingGroupResponse>(req, "DeleteAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteLaunchConfiguration) is used to delete a launch configuration.
        /// 
        /// * If the launch configuration is active in an auto scaling group, it cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns><see cref="DeleteLaunchConfigurationResponse"/></returns>
        public Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteLaunchConfigurationResponse>(req, "DeleteLaunchConfiguration");
        }

        /// <summary>
        /// This API (DeleteLaunchConfiguration) is used to delete a launch configuration.
        /// 
        /// * If the launch configuration is active in an auto scaling group, it cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns><see cref="DeleteLaunchConfigurationResponse"/></returns>
        public DeleteLaunchConfigurationResponse DeleteLaunchConfigurationSync(DeleteLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteLaunchConfigurationResponse>(req, "DeleteLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteLifeCycleHook) is used to delete a lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public Task<DeleteLifecycleHookResponse> DeleteLifecycleHook(DeleteLifecycleHookRequest req)
        {
            return InternalRequestAsync<DeleteLifecycleHookResponse>(req, "DeleteLifecycleHook");
        }

        /// <summary>
        /// This API (DeleteLifeCycleHook) is used to delete a lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public DeleteLifecycleHookResponse DeleteLifecycleHookSync(DeleteLifecycleHookRequest req)
        {
            return InternalRequestAsync<DeleteLifecycleHookResponse>(req, "DeleteLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteNotificationConfiguration) is used to delete the specified notification.
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteNotificationConfigurationResponse>(req, "DeleteNotificationConfiguration");
        }

        /// <summary>
        /// This API (DeleteNotificationConfiguration) is used to delete the specified notification.
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public DeleteNotificationConfigurationResponse DeleteNotificationConfigurationSync(DeleteNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<DeleteNotificationConfigurationResponse>(req, "DeleteNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteScalingPolicy) is used to delete an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy");
        }

        /// <summary>
        /// This API (DeleteScalingPolicy) is used to delete an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public DeleteScalingPolicyResponse DeleteScalingPolicySync(DeleteScalingPolicyRequest req)
        {
            return InternalRequestAsync<DeleteScalingPolicyResponse>(req, "DeleteScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DeleteScheduledAction) is used to delete the specified scheduled task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public Task<DeleteScheduledActionResponse> DeleteScheduledAction(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction");
        }

        /// <summary>
        /// This API (DeleteScheduledAction) is used to delete the specified scheduled task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public DeleteScheduledActionResponse DeleteScheduledActionSync(DeleteScheduledActionRequest req)
        {
            return InternalRequestAsync<DeleteScheduledActionResponse>(req, "DeleteScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAccountLimits) is used to query the limits of user's AS resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public Task<DescribeAccountLimitsResponse> DescribeAccountLimits(DescribeAccountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeAccountLimitsResponse>(req, "DescribeAccountLimits");
        }

        /// <summary>
        /// This API (DescribeAccountLimits) is used to query the limits of user's AS resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public DescribeAccountLimitsResponse DescribeAccountLimitsSync(DescribeAccountLimitsRequest req)
        {
            return InternalRequestAsync<DescribeAccountLimitsResponse>(req, "DescribeAccountLimits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAutoScalingActivities) is used to query the activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public Task<DescribeAutoScalingActivitiesResponse> DescribeAutoScalingActivities(DescribeAutoScalingActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingActivitiesResponse>(req, "DescribeAutoScalingActivities");
        }

        /// <summary>
        /// This API (DescribeAutoScalingActivities) is used to query the activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public DescribeAutoScalingActivitiesResponse DescribeAutoScalingActivitiesSync(DescribeAutoScalingActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingActivitiesResponse>(req, "DescribeAutoScalingActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query suggestions for scaling group configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public Task<DescribeAutoScalingAdvicesResponse> DescribeAutoScalingAdvices(DescribeAutoScalingAdvicesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingAdvicesResponse>(req, "DescribeAutoScalingAdvices");
        }

        /// <summary>
        /// This API is used to query suggestions for scaling group configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public DescribeAutoScalingAdvicesResponse DescribeAutoScalingAdvicesSync(DescribeAutoScalingAdvicesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingAdvicesResponse>(req, "DescribeAutoScalingAdvices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the latest activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public Task<DescribeAutoScalingGroupLastActivitiesResponse> DescribeAutoScalingGroupLastActivities(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupLastActivitiesResponse>(req, "DescribeAutoScalingGroupLastActivities");
        }

        /// <summary>
        /// This API is used to query the latest activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public DescribeAutoScalingGroupLastActivitiesResponse DescribeAutoScalingGroupLastActivitiesSync(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupLastActivitiesResponse>(req, "DescribeAutoScalingGroupLastActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAutoScalingGroups) is used to query the information of auto scaling groups.
        /// 
        /// * You can query the details of auto scaling groups based on information such as auto scaling group ID, auto scaling group name, or launch configuration ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of auto scaling groups of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupsResponse"/></returns>
        public Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupsResponse>(req, "DescribeAutoScalingGroups");
        }

        /// <summary>
        /// This API (DescribeAutoScalingGroups) is used to query the information of auto scaling groups.
        /// 
        /// * You can query the details of auto scaling groups based on information such as auto scaling group ID, auto scaling group name, or launch configuration ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of auto scaling groups of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupsResponse"/></returns>
        public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroupsSync(DescribeAutoScalingGroupsRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingGroupsResponse>(req, "DescribeAutoScalingGroups")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeAutoScalingInstances) is used to query the information of instances associated with AS.
        /// 
        /// * You can query the details of instances based on information such as instance ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of instances of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingInstancesResponse"/></returns>
        public Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingInstancesResponse>(req, "DescribeAutoScalingInstances");
        }

        /// <summary>
        /// This API (DescribeAutoScalingInstances) is used to query the information of instances associated with AS.
        /// 
        /// * You can query the details of instances based on information such as instance ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of instances of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingInstancesResponse"/></returns>
        public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstancesSync(DescribeAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<DescribeAutoScalingInstancesResponse>(req, "DescribeAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of launch configurations.
        /// 
        /// * You can query the launch configuration details based on information such as launch configuration ID and name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of launch configurations of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeLaunchConfigurationsResponse"/></returns>
        public Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchConfigurationsResponse>(req, "DescribeLaunchConfigurations");
        }

        /// <summary>
        /// This API is used to query the information of launch configurations.
        /// 
        /// * You can query the launch configuration details based on information such as launch configuration ID and name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of launch configurations of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeLaunchConfigurationsResponse"/></returns>
        public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurationsSync(DescribeLaunchConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeLaunchConfigurationsResponse>(req, "DescribeLaunchConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeLifecycleHooks) is used to query the information of lifecycle hooks.
        /// 
        /// * You can query the details of lifecycle hooks based on information such as auto scaling group ID, lifecycle hook ID, or lifecycle hook name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of lifecycle hooks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns><see cref="DescribeLifecycleHooksResponse"/></returns>
        public Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooks(DescribeLifecycleHooksRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleHooksResponse>(req, "DescribeLifecycleHooks");
        }

        /// <summary>
        /// This API (DescribeLifecycleHooks) is used to query the information of lifecycle hooks.
        /// 
        /// * You can query the details of lifecycle hooks based on information such as auto scaling group ID, lifecycle hook ID, or lifecycle hook name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of lifecycle hooks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns><see cref="DescribeLifecycleHooksResponse"/></returns>
        public DescribeLifecycleHooksResponse DescribeLifecycleHooksSync(DescribeLifecycleHooksRequest req)
        {
            return InternalRequestAsync<DescribeLifecycleHooksResponse>(req, "DescribeLifecycleHooks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeNotificationConfigurations) is used to query the information of one or more notifications.
        /// 
        /// You can query the details of notifications based on information such as notification ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of notifications of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeNotificationConfigurationsResponse"/></returns>
        public Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeNotificationConfigurationsResponse>(req, "DescribeNotificationConfigurations");
        }

        /// <summary>
        /// This API (DescribeNotificationConfigurations) is used to query the information of one or more notifications.
        /// 
        /// You can query the details of notifications based on information such as notification ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of notifications of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeNotificationConfigurationsResponse"/></returns>
        public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurationsSync(DescribeNotificationConfigurationsRequest req)
        {
            return InternalRequestAsync<DescribeNotificationConfigurationsResponse>(req, "DescribeNotificationConfigurations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeRefreshActivities) is used to query the instance refresh activity records of a scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRefreshActivitiesResponse"/></returns>
        public Task<DescribeRefreshActivitiesResponse> DescribeRefreshActivities(DescribeRefreshActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRefreshActivitiesResponse>(req, "DescribeRefreshActivities");
        }

        /// <summary>
        /// This API (DescribeRefreshActivities) is used to query the instance refresh activity records of a scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeRefreshActivitiesRequest"/></param>
        /// <returns><see cref="DescribeRefreshActivitiesResponse"/></returns>
        public DescribeRefreshActivitiesResponse DescribeRefreshActivitiesSync(DescribeRefreshActivitiesRequest req)
        {
            return InternalRequestAsync<DescribeRefreshActivitiesResponse>(req, "DescribeRefreshActivities")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeScalingPolicies) is used to query alarm trigger policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies");
        }

        /// <summary>
        /// This API (DescribeScalingPolicies) is used to query alarm trigger policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public DescribeScalingPoliciesResponse DescribeScalingPoliciesSync(DescribeScalingPoliciesRequest req)
        {
            return InternalRequestAsync<DescribeScalingPoliciesResponse>(req, "DescribeScalingPolicies")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (DescribeScheduledActions) is used to query the details of one or more scheduled tasks.
        /// 
        /// * You can query the details of scheduled tasks based on information such as scheduled task ID, scheduled task name, or auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of scheduled tasks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public Task<DescribeScheduledActionsResponse> DescribeScheduledActions(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions");
        }

        /// <summary>
        /// This API (DescribeScheduledActions) is used to query the details of one or more scheduled tasks.
        /// 
        /// * You can query the details of scheduled tasks based on information such as scheduled task ID, scheduled task name, or auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of scheduled tasks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public DescribeScheduledActionsResponse DescribeScheduledActionsSync(DescribeScheduledActionsRequest req)
        {
            return InternalRequestAsync<DescribeScheduledActionsResponse>(req, "DescribeScheduledActions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove CVM instances from a scaling group. Instances removed via this API will not be terminated.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public Task<DetachInstancesResponse> DetachInstances(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances");
        }

        /// <summary>
        /// This API is used to remove CVM instances from a scaling group. Instances removed via this API will not be terminated.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
        /// </summary>
        /// <param name="req"><see cref="DetachInstancesRequest"/></param>
        /// <returns><see cref="DetachInstancesResponse"/></returns>
        public DetachInstancesResponse DetachInstancesSync(DetachInstancesRequest req)
        {
            return InternalRequestAsync<DetachInstancesResponse>(req, "DetachInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind one or more CLBs from a scaling group. This API will not terminate CLBs.
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public Task<DetachLoadBalancersResponse> DetachLoadBalancers(DetachLoadBalancersRequest req)
        {
            return InternalRequestAsync<DetachLoadBalancersResponse>(req, "DetachLoadBalancers");
        }

        /// <summary>
        /// This API is used to unbind one or more CLBs from a scaling group. This API will not terminate CLBs.
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public DetachLoadBalancersResponse DetachLoadBalancersSync(DetachLoadBalancersRequest req)
        {
            return InternalRequestAsync<DetachLoadBalancersResponse>(req, "DetachLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable the specified auto-scaling group.
        /// * When a scaling group is disabled, the following activities are not triggered automatically:
        ///     - Scaling activities triggered alert policies
        ///     - Scaling activities triggered by desired group capacity
        ///     - Replacement of unhealthy instances
        ///     - Scheduled actions
        /// * When the scaling group is disabled, you can trigger scaling activities manually, including: 
        ///     - Scale out to the specify number of instances (ScaleOutInstances)
        ///     - Scale in to the specify number of instances (ScaleInInstances)
        ///     - Remove instances from the scaling group (DetachInstances)
        ///     - Delete instances from the scaling group (RemoveInstances)
        ///     - Add instances to a scaling group (AttachInstances)
        ///     - Shut down CVM instances in a scaling group (StopAutoScalingInstances)
        ///     - Start up CVM instances in a scaling group (StartAutoScalingInstances)
        /// </summary>
        /// <param name="req"><see cref="DisableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DisableAutoScalingGroupResponse"/></returns>
        public Task<DisableAutoScalingGroupResponse> DisableAutoScalingGroup(DisableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DisableAutoScalingGroupResponse>(req, "DisableAutoScalingGroup");
        }

        /// <summary>
        /// This API is used to disable the specified auto-scaling group.
        /// * When a scaling group is disabled, the following activities are not triggered automatically:
        ///     - Scaling activities triggered alert policies
        ///     - Scaling activities triggered by desired group capacity
        ///     - Replacement of unhealthy instances
        ///     - Scheduled actions
        /// * When the scaling group is disabled, you can trigger scaling activities manually, including: 
        ///     - Scale out to the specify number of instances (ScaleOutInstances)
        ///     - Scale in to the specify number of instances (ScaleInInstances)
        ///     - Remove instances from the scaling group (DetachInstances)
        ///     - Delete instances from the scaling group (RemoveInstances)
        ///     - Add instances to a scaling group (AttachInstances)
        ///     - Shut down CVM instances in a scaling group (StopAutoScalingInstances)
        ///     - Start up CVM instances in a scaling group (StartAutoScalingInstances)
        /// </summary>
        /// <param name="req"><see cref="DisableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DisableAutoScalingGroupResponse"/></returns>
        public DisableAutoScalingGroupResponse DisableAutoScalingGroupSync(DisableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<DisableAutoScalingGroupResponse>(req, "DisableAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (EnableAutoScalingGroup) is used to enable the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public Task<EnableAutoScalingGroupResponse> EnableAutoScalingGroup(EnableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<EnableAutoScalingGroupResponse>(req, "EnableAutoScalingGroup");
        }

        /// <summary>
        /// This API (EnableAutoScalingGroup) is used to enable the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public EnableAutoScalingGroupResponse EnableAutoScalingGroupSync(EnableAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<EnableAutoScalingGroupResponse>(req, "EnableAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to execute a scaling policy.
        /// 
        /// * The scaling policy can be executed based on the scaling policy ID.
        /// * The policy cannot be executed if there are ongoing scaling actions on the scaling group.
        /// * Executing a target tracking policy is not supported.
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public Task<ExecuteScalingPolicyResponse> ExecuteScalingPolicy(ExecuteScalingPolicyRequest req)
        {
            return InternalRequestAsync<ExecuteScalingPolicyResponse>(req, "ExecuteScalingPolicy");
        }

        /// <summary>
        /// This API is used to execute a scaling policy.
        /// 
        /// * The scaling policy can be executed based on the scaling policy ID.
        /// * The policy cannot be executed if there are ongoing scaling actions on the scaling group.
        /// * Executing a target tracking policy is not supported.
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public ExecuteScalingPolicyResponse ExecuteScalingPolicySync(ExecuteScalingPolicyRequest req)
        {
            return InternalRequestAsync<ExecuteScalingPolicyResponse>(req, "ExecuteScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to exit instances from the standby status in the scaling group.
        /// * When an instance is in standby status, its load balancer weight is set to 0. Upon exiting the standby status, the weight value automatically gets restored.
        /// * Initiating power-on/power-off actions on instances that are in standby status also results in them exiting from the standby status.
        /// </summary>
        /// <param name="req"><see cref="ExitStandbyRequest"/></param>
        /// <returns><see cref="ExitStandbyResponse"/></returns>
        public Task<ExitStandbyResponse> ExitStandby(ExitStandbyRequest req)
        {
            return InternalRequestAsync<ExitStandbyResponse>(req, "ExitStandby");
        }

        /// <summary>
        /// This API is used to exit instances from the standby status in the scaling group.
        /// * When an instance is in standby status, its load balancer weight is set to 0. Upon exiting the standby status, the weight value automatically gets restored.
        /// * Initiating power-on/power-off actions on instances that are in standby status also results in them exiting from the standby status.
        /// </summary>
        /// <param name="req"><see cref="ExitStandbyRequest"/></param>
        /// <returns><see cref="ExitStandbyResponse"/></returns>
        public ExitStandbyResponse ExitStandbySync(ExitStandbyRequest req)
        {
            return InternalRequestAsync<ExitStandbyResponse>(req, "ExitStandby")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyAutoScalingGroup) is used to modify an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public Task<ModifyAutoScalingGroupResponse> ModifyAutoScalingGroup(ModifyAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalingGroupResponse>(req, "ModifyAutoScalingGroup");
        }

        /// <summary>
        /// This API (ModifyAutoScalingGroup) is used to modify an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public ModifyAutoScalingGroupResponse ModifyAutoScalingGroupSync(ModifyAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<ModifyAutoScalingGroupResponse>(req, "ModifyAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyDesiredCapacity) is used to modify the desired number of instances in the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public Task<ModifyDesiredCapacityResponse> ModifyDesiredCapacity(ModifyDesiredCapacityRequest req)
        {
            return InternalRequestAsync<ModifyDesiredCapacityResponse>(req, "ModifyDesiredCapacity");
        }

        /// <summary>
        /// This API (ModifyDesiredCapacity) is used to modify the desired number of instances in the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public ModifyDesiredCapacityResponse ModifyDesiredCapacitySync(ModifyDesiredCapacityRequest req)
        {
            return InternalRequestAsync<ModifyDesiredCapacityResponse>(req, "ModifyDesiredCapacity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyLaunchConfigurationAttributes) is used to modify some attributes of a launch configuration.
        /// 
        /// * The changes of launch configuration do not affect the existing instances. New instances will be created based on the modified configuration.
        /// * This API supports modifying certain simple types of attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ModifyLaunchConfigurationAttributesResponse"/></returns>
        public Task<ModifyLaunchConfigurationAttributesResponse> ModifyLaunchConfigurationAttributes(ModifyLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLaunchConfigurationAttributesResponse>(req, "ModifyLaunchConfigurationAttributes");
        }

        /// <summary>
        /// This API (ModifyLaunchConfigurationAttributes) is used to modify some attributes of a launch configuration.
        /// 
        /// * The changes of launch configuration do not affect the existing instances. New instances will be created based on the modified configuration.
        /// * This API supports modifying certain simple types of attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ModifyLaunchConfigurationAttributesResponse"/></returns>
        public ModifyLaunchConfigurationAttributesResponse ModifyLaunchConfigurationAttributesSync(ModifyLaunchConfigurationAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLaunchConfigurationAttributesResponse>(req, "ModifyLaunchConfigurationAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public Task<ModifyLifecycleHookResponse> ModifyLifecycleHook(ModifyLifecycleHookRequest req)
        {
            return InternalRequestAsync<ModifyLifecycleHookResponse>(req, "ModifyLifecycleHook");
        }

        /// <summary>
        /// This API is used to modify the lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public ModifyLifecycleHookResponse ModifyLifecycleHookSync(ModifyLifecycleHookRequest req)
        {
            return InternalRequestAsync<ModifyLifecycleHookResponse>(req, "ModifyLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the target rule attributes of the CLB in the scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public Task<ModifyLoadBalancerTargetAttributesResponse> ModifyLoadBalancerTargetAttributes(ModifyLoadBalancerTargetAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerTargetAttributesResponse>(req, "ModifyLoadBalancerTargetAttributes");
        }

        /// <summary>
        /// This API is used to modify the target rule attributes of the CLB in the scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public ModifyLoadBalancerTargetAttributesResponse ModifyLoadBalancerTargetAttributesSync(ModifyLoadBalancerTargetAttributesRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancerTargetAttributesResponse>(req, "ModifyLoadBalancerTargetAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the cloud load balancers of a scaling group.
        /// 
        /// * This API can specify a new cloud load balancer configuration for the scaling group. The new configuration overwrites the original load balancer configuration.
        /// * To clear the cloud load balancer of the scaling group, specify only the scaling group ID but not the specific cloud load balancer.
        /// * This API modifies the cloud load balancer of the scaling group and generate a scaling activity to asynchronously modify the cloud load balancers of existing instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersResponse"/></returns>
        public Task<ModifyLoadBalancersResponse> ModifyLoadBalancers(ModifyLoadBalancersRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersResponse>(req, "ModifyLoadBalancers");
        }

        /// <summary>
        /// This API is used to modify the cloud load balancers of a scaling group.
        /// 
        /// * This API can specify a new cloud load balancer configuration for the scaling group. The new configuration overwrites the original load balancer configuration.
        /// * To clear the cloud load balancer of the scaling group, specify only the scaling group ID but not the specific cloud load balancer.
        /// * This API modifies the cloud load balancer of the scaling group and generate a scaling activity to asynchronously modify the cloud load balancers of existing instances.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancersRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancersResponse"/></returns>
        public ModifyLoadBalancersResponse ModifyLoadBalancersSync(ModifyLoadBalancersRequest req)
        {
            return InternalRequestAsync<ModifyLoadBalancersResponse>(req, "ModifyLoadBalancers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a notification policy.
        /// * The receiver type of the notification policy cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyNotificationConfigurationResponse>(req, "ModifyNotificationConfiguration");
        }

        /// <summary>
        /// This API is used to modify a notification policy.
        /// * The receiver type of the notification policy cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public ModifyNotificationConfigurationResponse ModifyNotificationConfigurationSync(ModifyNotificationConfigurationRequest req)
        {
            return InternalRequestAsync<ModifyNotificationConfigurationResponse>(req, "ModifyNotificationConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyScalingPolicy) is used to modify an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public Task<ModifyScalingPolicyResponse> ModifyScalingPolicy(ModifyScalingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyScalingPolicyResponse>(req, "ModifyScalingPolicy");
        }

        /// <summary>
        /// This API (ModifyScalingPolicy) is used to modify an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public ModifyScalingPolicyResponse ModifyScalingPolicySync(ModifyScalingPolicyRequest req)
        {
            return InternalRequestAsync<ModifyScalingPolicyResponse>(req, "ModifyScalingPolicy")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API (ModifyScheduledAction) is used to modify a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public Task<ModifyScheduledActionResponse> ModifyScheduledAction(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction");
        }

        /// <summary>
        /// This API (ModifyScheduledAction) is used to modify a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public ModifyScheduledActionResponse ModifyScheduledActionSync(ModifyScheduledActionRequest req)
        {
            return InternalRequestAsync<ModifyScheduledActionResponse>(req, "ModifyScheduledAction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete CVM instances from a scaling group. Instances that are automatically created through AS will be terminated, while those manually added to the scaling group will be removed and retained.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances");
        }

        /// <summary>
        /// This API is used to delete CVM instances from a scaling group. Instances that are automatically created through AS will be terminated, while those manually added to the scaling group will be removed and retained.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public RemoveInstancesResponse RemoveInstancesSync(RemoveInstancesRequest req)
        {
            return InternalRequestAsync<RemoveInstancesResponse>(req, "RemoveInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to resume the paused instance refresh activity, allowing it to retry failed instances in the current batch or proceed with refreshing subsequent batches. Note that calling this API is ineffective when the activity is not in a paused status.
        /// 
        /// - When the MaxSurge parameter is used, the activity may be paused due to scale-out or scale-in failures. This API can also be used to retry scaling operations.
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRefreshRequest"/></param>
        /// <returns><see cref="ResumeInstanceRefreshResponse"/></returns>
        public Task<ResumeInstanceRefreshResponse> ResumeInstanceRefresh(ResumeInstanceRefreshRequest req)
        {
            return InternalRequestAsync<ResumeInstanceRefreshResponse>(req, "ResumeInstanceRefresh");
        }

        /// <summary>
        /// This API is used to resume the paused instance refresh activity, allowing it to retry failed instances in the current batch or proceed with refreshing subsequent batches. Note that calling this API is ineffective when the activity is not in a paused status.
        /// 
        /// - When the MaxSurge parameter is used, the activity may be paused due to scale-out or scale-in failures. This API can also be used to retry scaling operations.
        /// </summary>
        /// <param name="req"><see cref="ResumeInstanceRefreshRequest"/></param>
        /// <returns><see cref="ResumeInstanceRefreshResponse"/></returns>
        public ResumeInstanceRefreshResponse ResumeInstanceRefreshSync(ResumeInstanceRefreshRequest req)
        {
            return InternalRequestAsync<ResumeInstanceRefreshResponse>(req, "ResumeInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a new instance refresh activity, which also supports batch refreshing and operations such as pausing, resuming, and canceling. This API returns RefreshActivityId for the rollback activity.
        /// * The instances pending refresh in the original activity are updated to canceled status. Nonexistent instances are disregarded, while instances in all other statuses proceed to enter the rollback process.
        /// * The instances that are being refreshed in the original activity will not be immediately terminated. Instead, the rollback activity will be executed after their refresh complete.
        /// * Rollback is supported for activities that are in the paused status or those succeeded in refreshing last time. It is not supported for activities in other statuses.
        /// * When the original refresh activity involves reinstalling instances, for the ImageId parameter, it will automatically recover to the image ID before the rollback; for parameters such as UserData, EnhancedService, LoginSettings, and HostName, they will still be read from the launch configuration, requiring users to manually modify the launch configuration before initiating the rollback.
        /// * The rollback activity does not support the MaxSurge parameter currently.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRefreshRequest"/></param>
        /// <returns><see cref="RollbackInstanceRefreshResponse"/></returns>
        public Task<RollbackInstanceRefreshResponse> RollbackInstanceRefresh(RollbackInstanceRefreshRequest req)
        {
            return InternalRequestAsync<RollbackInstanceRefreshResponse>(req, "RollbackInstanceRefresh");
        }

        /// <summary>
        /// This API is used to generate a new instance refresh activity, which also supports batch refreshing and operations such as pausing, resuming, and canceling. This API returns RefreshActivityId for the rollback activity.
        /// * The instances pending refresh in the original activity are updated to canceled status. Nonexistent instances are disregarded, while instances in all other statuses proceed to enter the rollback process.
        /// * The instances that are being refreshed in the original activity will not be immediately terminated. Instead, the rollback activity will be executed after their refresh complete.
        /// * Rollback is supported for activities that are in the paused status or those succeeded in refreshing last time. It is not supported for activities in other statuses.
        /// * When the original refresh activity involves reinstalling instances, for the ImageId parameter, it will automatically recover to the image ID before the rollback; for parameters such as UserData, EnhancedService, LoginSettings, and HostName, they will still be read from the launch configuration, requiring users to manually modify the launch configuration before initiating the rollback.
        /// * The rollback activity does not support the MaxSurge parameter currently.
        /// </summary>
        /// <param name="req"><see cref="RollbackInstanceRefreshRequest"/></param>
        /// <returns><see cref="RollbackInstanceRefreshResponse"/></returns>
        public RollbackInstanceRefreshResponse RollbackInstanceRefreshSync(RollbackInstanceRefreshRequest req)
        {
            return InternalRequestAsync<RollbackInstanceRefreshResponse>(req, "RollbackInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to reduce the specified number of instances from the scaling group.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * You can specify the instances to remove in the scale-in activity by using `TerminationPolicies`. For more information, see [Scaling In Policies](https://intl.cloud.tencent.com/document/product/377/8563?from_cn_redirect=1).
        /// * Only the `IN_SERVICE` instances will be reduced. To reduce instances in other statues, use the [`DetachInstances`](https://intl.cloud.tencent.com/document/api/377/31011?from_cn_redirect=1) or [`RemoveInstances`](https://intl.cloud.tencent.com/document/api/377/31005?from_cn_redirect=1) API.
        /// * The desired capacity will be reduced accordingly. The new desired capacity should be no less than the minimum capacity.
        /// * If the scale-in activity failed or partially succeeded, the final desired capacity only deducts the instances that have been reduced successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public Task<ScaleInInstancesResponse> ScaleInInstances(ScaleInInstancesRequest req)
        {
            return InternalRequestAsync<ScaleInInstancesResponse>(req, "ScaleInInstances");
        }

        /// <summary>
        /// This API is used to reduce the specified number of instances from the scaling group.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * You can specify the instances to remove in the scale-in activity by using `TerminationPolicies`. For more information, see [Scaling In Policies](https://intl.cloud.tencent.com/document/product/377/8563?from_cn_redirect=1).
        /// * Only the `IN_SERVICE` instances will be reduced. To reduce instances in other statues, use the [`DetachInstances`](https://intl.cloud.tencent.com/document/api/377/31011?from_cn_redirect=1) or [`RemoveInstances`](https://intl.cloud.tencent.com/document/api/377/31005?from_cn_redirect=1) API.
        /// * The desired capacity will be reduced accordingly. The new desired capacity should be no less than the minimum capacity.
        /// * If the scale-in activity failed or partially succeeded, the final desired capacity only deducts the instances that have been reduced successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public ScaleInInstancesResponse ScaleInInstancesSync(ScaleInInstancesRequest req)
        {
            return InternalRequestAsync<ScaleInInstancesResponse>(req, "ScaleInInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add the specified number of instances to a scaling group. It returns the scaling activity ID `ActivityId`.
        /// * Make sure that there are no ongoing scaling tasks.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * The total number of instances after this action cannot exceed the maximum capacity.
        /// * If a scale-out action failed or partially succeeded, only the number of successfully created instances is added to the number of desired capacity.
        /// * If the allocation policy is `SPOT_MIXED`, there may be multiple scaling activities triggered for one scaling task. In this case, the first activity ID (`ActivityId`) is returned.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public Task<ScaleOutInstancesResponse> ScaleOutInstances(ScaleOutInstancesRequest req)
        {
            return InternalRequestAsync<ScaleOutInstancesResponse>(req, "ScaleOutInstances");
        }

        /// <summary>
        /// This API is used to add the specified number of instances to a scaling group. It returns the scaling activity ID `ActivityId`.
        /// * Make sure that there are no ongoing scaling tasks.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * The total number of instances after this action cannot exceed the maximum capacity.
        /// * If a scale-out action failed or partially succeeded, only the number of successfully created instances is added to the number of desired capacity.
        /// * If the allocation policy is `SPOT_MIXED`, there may be multiple scaling activities triggered for one scaling task. In this case, the first activity ID (`ActivityId`) is returned.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public ScaleOutInstancesResponse ScaleOutInstancesSync(ScaleOutInstancesRequest req)
        {
            return InternalRequestAsync<ScaleOutInstancesResponse>(req, "ScaleOutInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable scale-in protection for an instance.
        /// When scale-in protection is enabled, the instance will not be removed in scale-in activities triggered by replacement of unhealthy instances, alarm threshold reached, change of desired quantity, etc.
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public Task<SetInstancesProtectionResponse> SetInstancesProtection(SetInstancesProtectionRequest req)
        {
            return InternalRequestAsync<SetInstancesProtectionResponse>(req, "SetInstancesProtection");
        }

        /// <summary>
        /// This API is used to enable scale-in protection for an instance.
        /// When scale-in protection is enabled, the instance will not be removed in scale-in activities triggered by replacement of unhealthy instances, alarm threshold reached, change of desired quantity, etc.
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public SetInstancesProtectionResponse SetInstancesProtectionSync(SetInstancesProtectionRequest req)
        {
            return InternalRequestAsync<SetInstancesProtectionResponse>(req, "SetInstancesProtection")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start up CVM instances in a scaling group.
        /// * After startup, the instance will be in the `IN_SERVICE` status, which will increase the desired capacity. Please note that the desired capacity cannot exceed the maximum value.
        /// * This API supports batch operation. Up to 100 instances can be started up in each request.
        /// </summary>
        /// <param name="req"><see cref="StartAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StartAutoScalingInstancesResponse"/></returns>
        public Task<StartAutoScalingInstancesResponse> StartAutoScalingInstances(StartAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StartAutoScalingInstancesResponse>(req, "StartAutoScalingInstances");
        }

        /// <summary>
        /// This API is used to start up CVM instances in a scaling group.
        /// * After startup, the instance will be in the `IN_SERVICE` status, which will increase the desired capacity. Please note that the desired capacity cannot exceed the maximum value.
        /// * This API supports batch operation. Up to 100 instances can be started up in each request.
        /// </summary>
        /// <param name="req"><see cref="StartAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StartAutoScalingInstancesResponse"/></returns>
        public StartAutoScalingInstancesResponse StartAutoScalingInstancesSync(StartAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StartAutoScalingInstancesResponse>(req, "StartAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to refresh running CVM instances in the scaling group and return the RefreshActivityId for the instance refresh activity based on parameters in the launch configuration.
        /// * For refresh methods involving reinstallation (currently only reinstallation is supported), during reinstallation, only the ImageId, UserData, EnhancedService, HostName, and LoginSettings parameters will be fetched from the launch configuration for refreshing; other parameters of the instance will not be refreshed.
        /// * During the instance refresh process (including paused status), the scaling group will be disabled. It is not recommended to modify the associated launch configuration during a refresh, as this may impact the refresh parameters, leading to inconsistent instance configurations.
        /// * In rolling update mode, instance refreshes are performed in multiple batches. If there are failed refreshes within a batch, the activity will enter a failed paused status.
        /// * Instances pending refresh that are removed or destroyed will be marked as NOT_FOUND status, but they will not block the instance refresh activity.
        /// * Even if a running instance has parameters consistent with the latest launch configuration, it can still undergo another refresh.
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRefreshRequest"/></param>
        /// <returns><see cref="StartInstanceRefreshResponse"/></returns>
        public Task<StartInstanceRefreshResponse> StartInstanceRefresh(StartInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StartInstanceRefreshResponse>(req, "StartInstanceRefresh");
        }

        /// <summary>
        /// This API is used to refresh running CVM instances in the scaling group and return the RefreshActivityId for the instance refresh activity based on parameters in the launch configuration.
        /// * For refresh methods involving reinstallation (currently only reinstallation is supported), during reinstallation, only the ImageId, UserData, EnhancedService, HostName, and LoginSettings parameters will be fetched from the launch configuration for refreshing; other parameters of the instance will not be refreshed.
        /// * During the instance refresh process (including paused status), the scaling group will be disabled. It is not recommended to modify the associated launch configuration during a refresh, as this may impact the refresh parameters, leading to inconsistent instance configurations.
        /// * In rolling update mode, instance refreshes are performed in multiple batches. If there are failed refreshes within a batch, the activity will enter a failed paused status.
        /// * Instances pending refresh that are removed or destroyed will be marked as NOT_FOUND status, but they will not block the instance refresh activity.
        /// * Even if a running instance has parameters consistent with the latest launch configuration, it can still undergo another refresh.
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRefreshRequest"/></param>
        /// <returns><see cref="StartInstanceRefreshResponse"/></returns>
        public StartInstanceRefreshResponse StartInstanceRefreshSync(StartInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StartInstanceRefreshResponse>(req, "StartInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to shut down CVM instances in a scaling group.
        /// * Use the `SOFT_FIRST` shutdown, which means the CVM will be forcibly shut down if the soft shutdown fails.
        /// * Shutting down instances in the `IN_SERVICE` status will reduce the desired capacity, but the desired capacity cannot be less than the minimum value.
        /// * To use the `STOP_CHARGING` shutdown, the instances you want to shut down must satisfy the conditions of [no charges when shut down](https://intl.cloud.tencent.com/document/product/213/19918?from_cn_redirect=1).
        /// * This API supports batch operation. Up to 100 instances can be shut down in each request.
        /// </summary>
        /// <param name="req"><see cref="StopAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StopAutoScalingInstancesResponse"/></returns>
        public Task<StopAutoScalingInstancesResponse> StopAutoScalingInstances(StopAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StopAutoScalingInstancesResponse>(req, "StopAutoScalingInstances");
        }

        /// <summary>
        /// This API is used to shut down CVM instances in a scaling group.
        /// * Use the `SOFT_FIRST` shutdown, which means the CVM will be forcibly shut down if the soft shutdown fails.
        /// * Shutting down instances in the `IN_SERVICE` status will reduce the desired capacity, but the desired capacity cannot be less than the minimum value.
        /// * To use the `STOP_CHARGING` shutdown, the instances you want to shut down must satisfy the conditions of [no charges when shut down](https://intl.cloud.tencent.com/document/product/213/19918?from_cn_redirect=1).
        /// * This API supports batch operation. Up to 100 instances can be shut down in each request.
        /// </summary>
        /// <param name="req"><see cref="StopAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StopAutoScalingInstancesResponse"/></returns>
        public StopAutoScalingInstancesResponse StopAutoScalingInstancesSync(StopAutoScalingInstancesRequest req)
        {
            return InternalRequestAsync<StopAutoScalingInstancesResponse>(req, "StopAutoScalingInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pause the ongoing instance refresh activity.
        /// * In the paused status, the scaling group will also be disabled.
        /// * The instances that are currently being updated or scaled out will not be paused, but instances pending updates will have their updates paused.
        /// * During scale-in, all instances have already been updated and cannot be paused.
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRefreshRequest"/></param>
        /// <returns><see cref="StopInstanceRefreshResponse"/></returns>
        public Task<StopInstanceRefreshResponse> StopInstanceRefresh(StopInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StopInstanceRefreshResponse>(req, "StopInstanceRefresh");
        }

        /// <summary>
        /// This API is used to pause the ongoing instance refresh activity.
        /// * In the paused status, the scaling group will also be disabled.
        /// * The instances that are currently being updated or scaled out will not be paused, but instances pending updates will have their updates paused.
        /// * During scale-in, all instances have already been updated and cannot be paused.
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRefreshRequest"/></param>
        /// <returns><see cref="StopInstanceRefreshResponse"/></returns>
        public StopInstanceRefreshResponse StopInstanceRefreshSync(StopInstanceRefreshRequest req)
        {
            return InternalRequestAsync<StopInstanceRefreshResponse>(req, "StopInstanceRefresh")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 已有替代接口ModifyLaunchConfiguration。该接口存在覆盖参数风险，目前官网已隐藏
        /// 
        /// There is a replacement API: ModifyLaunchConfiguration. This API carries the risk of parameter overwriting, and it has currently been hidden on the official website.
        /// This API (UpgradeLaunchConfiguration) is used to upgrade the launch configuration.
        /// * This API is used to upgrade the launch configuration, adopting an "entirely overwrite" approach. Regardless of previous parameter settings, they will be uniformly replaced with new configurations as specified in the interface parameters. For non-mandatory fields, if not filled in, default values will be assigned.
        /// * After upgrading and modifying the launch configuration, existing instances that have been scaled out using this configuration will not undergo any changes. Subsequently, newly added instances using this upgraded launch configuration will be scaled out according to the new configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public Task<UpgradeLaunchConfigurationResponse> UpgradeLaunchConfiguration(UpgradeLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<UpgradeLaunchConfigurationResponse>(req, "UpgradeLaunchConfiguration");
        }

        /// <summary>
        /// 已有替代接口ModifyLaunchConfiguration。该接口存在覆盖参数风险，目前官网已隐藏
        /// 
        /// There is a replacement API: ModifyLaunchConfiguration. This API carries the risk of parameter overwriting, and it has currently been hidden on the official website.
        /// This API (UpgradeLaunchConfiguration) is used to upgrade the launch configuration.
        /// * This API is used to upgrade the launch configuration, adopting an "entirely overwrite" approach. Regardless of previous parameter settings, they will be uniformly replaced with new configurations as specified in the interface parameters. For non-mandatory fields, if not filled in, default values will be assigned.
        /// * After upgrading and modifying the launch configuration, existing instances that have been scaled out using this configuration will not undergo any changes. Subsequently, newly added instances using this upgraded launch configuration will be scaled out according to the new configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public UpgradeLaunchConfigurationResponse UpgradeLaunchConfigurationSync(UpgradeLaunchConfigurationRequest req)
        {
            return InternalRequestAsync<UpgradeLaunchConfigurationResponse>(req, "UpgradeLaunchConfiguration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to upgrade the lifecycle hook.
        /// 
        /// * This API is used to upgrade the lifecycle hook, adopting a "comprehensive overwrite" style. Regardless of how the previous parameters were set, it uniformly uses the new configurations for API parameters. For optional fields, if they are not filled in, default values will be used.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public Task<UpgradeLifecycleHookResponse> UpgradeLifecycleHook(UpgradeLifecycleHookRequest req)
        {
            return InternalRequestAsync<UpgradeLifecycleHookResponse>(req, "UpgradeLifecycleHook");
        }

        /// <summary>
        /// This API is used to upgrade the lifecycle hook.
        /// 
        /// * This API is used to upgrade the lifecycle hook, adopting a "comprehensive overwrite" style. Regardless of how the previous parameters were set, it uniformly uses the new configurations for API parameters. For optional fields, if they are not filled in, default values will be used.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public UpgradeLifecycleHookResponse UpgradeLifecycleHookSync(UpgradeLifecycleHookRequest req)
        {
            return InternalRequestAsync<UpgradeLifecycleHookResponse>(req, "UpgradeLifecycleHook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}

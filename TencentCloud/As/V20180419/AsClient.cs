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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to add CVM instances to an auto scaling group.
        /// * Only CVM instances in `RUNNING` or `STOPPED` status can be added.
        /// * The added CVM instances must in the same VPC as the scaling group.
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
        /// This API is used to add CVM instances to an auto scaling group.
        /// * Only CVM instances in `RUNNING` or `STOPPED` status can be added.
        /// * The added CVM instances must in the same VPC as the scaling group.
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
        /// This API is used to add CLBs to a security group.
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public async Task<AttachLoadBalancersResponse> AttachLoadBalancers(AttachLoadBalancersRequest req)
        {
             JsonResponseModel<AttachLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AttachLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add CLBs to a security group.
        /// </summary>
        /// <param name="req"><see cref="AttachLoadBalancersRequest"/></param>
        /// <returns><see cref="AttachLoadBalancersResponse"/></returns>
        public AttachLoadBalancersResponse AttachLoadBalancersSync(AttachLoadBalancersRequest req)
        {
             JsonResponseModel<AttachLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AttachLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AttachLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear specific attributes of the launch configuration.
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public async Task<ClearLaunchConfigurationAttributesResponse> ClearLaunchConfigurationAttributes(ClearLaunchConfigurationAttributesRequest req)
        {
             JsonResponseModel<ClearLaunchConfigurationAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ClearLaunchConfigurationAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearLaunchConfigurationAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to clear specific attributes of the launch configuration.
        /// </summary>
        /// <param name="req"><see cref="ClearLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ClearLaunchConfigurationAttributesResponse"/></returns>
        public ClearLaunchConfigurationAttributesResponse ClearLaunchConfigurationAttributesSync(ClearLaunchConfigurationAttributesRequest req)
        {
             JsonResponseModel<ClearLaunchConfigurationAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ClearLaunchConfigurationAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ClearLaunchConfigurationAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CompleteLifecycleAction) is used to complete a lifecycle action.
        /// 
        /// * The result ("CONTINUE" or "ABANDON") of a specific lifecycle hook can be specified by calling this API. If this API is not called at all, the lifecycle hook will be processed based on the "DefaultResult" after timeout.
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public async Task<CompleteLifecycleActionResponse> CompleteLifecycleAction(CompleteLifecycleActionRequest req)
        {
             JsonResponseModel<CompleteLifecycleActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompleteLifecycleAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteLifecycleActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CompleteLifecycleAction) is used to complete a lifecycle action.
        /// 
        /// * The result ("CONTINUE" or "ABANDON") of a specific lifecycle hook can be specified by calling this API. If this API is not called at all, the lifecycle hook will be processed based on the "DefaultResult" after timeout.
        /// </summary>
        /// <param name="req"><see cref="CompleteLifecycleActionRequest"/></param>
        /// <returns><see cref="CompleteLifecycleActionResponse"/></returns>
        public CompleteLifecycleActionResponse CompleteLifecycleActionSync(CompleteLifecycleActionRequest req)
        {
             JsonResponseModel<CompleteLifecycleActionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompleteLifecycleAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompleteLifecycleActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateAutoScalingGroup) is used to create an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public async Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroup(CreateAutoScalingGroupRequest req)
        {
             JsonResponseModel<CreateAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateAutoScalingGroup) is used to create an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupResponse"/></returns>
        public CreateAutoScalingGroupResponse CreateAutoScalingGroupSync(CreateAutoScalingGroupRequest req)
        {
             JsonResponseModel<CreateAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create launch configurations and scaling groups based on an instance.
        /// 
        /// Note: for a scaling group that is created based on a monthly-subscribed instance, the instances added for scale-out are pay-as-you-go instance.
        /// </summary>
        /// <param name="req"><see cref="CreateAutoScalingGroupFromInstanceRequest"/></param>
        /// <returns><see cref="CreateAutoScalingGroupFromInstanceResponse"/></returns>
        public async Task<CreateAutoScalingGroupFromInstanceResponse> CreateAutoScalingGroupFromInstance(CreateAutoScalingGroupFromInstanceRequest req)
        {
             JsonResponseModel<CreateAutoScalingGroupFromInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAutoScalingGroupFromInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoScalingGroupFromInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateAutoScalingGroupFromInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAutoScalingGroupFromInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAutoScalingGroupFromInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a launch configuration.
        /// 
        /// * To modify a launch configuration, you can use `ModifyLaunchConfigurationAttributes`.
        /// 
        /// * You can create up to 20 launch configurations for each project. For more information, see [Usage Limits](https://intl.cloud.tencent.com/document/product/377/3120?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public async Task<CreateLaunchConfigurationResponse> CreateLaunchConfiguration(CreateLaunchConfigurationRequest req)
        {
             JsonResponseModel<CreateLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a launch configuration.
        /// 
        /// * To modify a launch configuration, you can use `ModifyLaunchConfigurationAttributes`.
        /// 
        /// * You can create up to 20 launch configurations for each project. For more information, see [Usage Limits](https://intl.cloud.tencent.com/document/product/377/3120?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="CreateLaunchConfigurationRequest"/></param>
        /// <returns><see cref="CreateLaunchConfigurationResponse"/></returns>
        public CreateLaunchConfigurationResponse CreateLaunchConfigurationSync(CreateLaunchConfigurationRequest req)
        {
             JsonResponseModel<CreateLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateLifecycleHookResponse> CreateLifecycleHook(CreateLifecycleHookRequest req)
        {
             JsonResponseModel<CreateLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateNotificationConfigurationResponse> CreateNotificationConfiguration(CreateNotificationConfigurationRequest req)
        {
             JsonResponseModel<CreateNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateScalingPolicy) is used to create an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public async Task<CreateScalingPolicyResponse> CreateScalingPolicy(CreateScalingPolicyRequest req)
        {
             JsonResponseModel<CreateScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateScalingPolicy) is used to create an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="CreateScalingPolicyRequest"/></param>
        /// <returns><see cref="CreateScalingPolicyResponse"/></returns>
        public CreateScalingPolicyResponse CreateScalingPolicySync(CreateScalingPolicyRequest req)
        {
             JsonResponseModel<CreateScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateScheduledAction) is used to create a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public async Task<CreateScheduledActionResponse> CreateScheduledAction(CreateScheduledActionRequest req)
        {
             JsonResponseModel<CreateScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (CreateScheduledAction) is used to create a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="CreateScheduledActionRequest"/></param>
        /// <returns><see cref="CreateScheduledActionResponse"/></returns>
        public CreateScheduledActionResponse CreateScheduledActionSync(CreateScheduledActionRequest req)
        {
             JsonResponseModel<CreateScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAutoScalingGroup) is used to delete the specified auto scaling group that has no instances and remains inactive.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public async Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest req)
        {
             JsonResponseModel<DeleteAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteAutoScalingGroup) is used to delete the specified auto scaling group that has no instances and remains inactive.
        /// </summary>
        /// <param name="req"><see cref="DeleteAutoScalingGroupRequest"/></param>
        /// <returns><see cref="DeleteAutoScalingGroupResponse"/></returns>
        public DeleteAutoScalingGroupResponse DeleteAutoScalingGroupSync(DeleteAutoScalingGroupRequest req)
        {
             JsonResponseModel<DeleteAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteLaunchConfiguration) is used to delete a launch configuration.
        /// 
        /// * If the launch configuration is active in an auto scaling group, it cannot be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteLaunchConfigurationRequest"/></param>
        /// <returns><see cref="DeleteLaunchConfigurationResponse"/></returns>
        public async Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest req)
        {
             JsonResponseModel<DeleteLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DeleteLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteLifeCycleHook) is used to delete a lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public async Task<DeleteLifecycleHookResponse> DeleteLifecycleHook(DeleteLifecycleHookRequest req)
        {
             JsonResponseModel<DeleteLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteLifeCycleHook) is used to delete a lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="DeleteLifecycleHookRequest"/></param>
        /// <returns><see cref="DeleteLifecycleHookResponse"/></returns>
        public DeleteLifecycleHookResponse DeleteLifecycleHookSync(DeleteLifecycleHookRequest req)
        {
             JsonResponseModel<DeleteLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteNotificationConfiguration) is used to delete the specified notification.
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public async Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest req)
        {
             JsonResponseModel<DeleteNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteNotificationConfiguration) is used to delete the specified notification.
        /// </summary>
        /// <param name="req"><see cref="DeleteNotificationConfigurationRequest"/></param>
        /// <returns><see cref="DeleteNotificationConfigurationResponse"/></returns>
        public DeleteNotificationConfigurationResponse DeleteNotificationConfigurationSync(DeleteNotificationConfigurationRequest req)
        {
             JsonResponseModel<DeleteNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteScalingPolicy) is used to delete an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public async Task<DeleteScalingPolicyResponse> DeleteScalingPolicy(DeleteScalingPolicyRequest req)
        {
             JsonResponseModel<DeleteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteScalingPolicy) is used to delete an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="DeleteScalingPolicyRequest"/></param>
        /// <returns><see cref="DeleteScalingPolicyResponse"/></returns>
        public DeleteScalingPolicyResponse DeleteScalingPolicySync(DeleteScalingPolicyRequest req)
        {
             JsonResponseModel<DeleteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteScheduledAction) is used to delete the specified scheduled task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public async Task<DeleteScheduledActionResponse> DeleteScheduledAction(DeleteScheduledActionRequest req)
        {
             JsonResponseModel<DeleteScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DeleteScheduledAction) is used to delete the specified scheduled task.
        /// </summary>
        /// <param name="req"><see cref="DeleteScheduledActionRequest"/></param>
        /// <returns><see cref="DeleteScheduledActionResponse"/></returns>
        public DeleteScheduledActionResponse DeleteScheduledActionSync(DeleteScheduledActionRequest req)
        {
             JsonResponseModel<DeleteScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountLimits) is used to query the limits of user's AS resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public async Task<DescribeAccountLimitsResponse> DescribeAccountLimits(DescribeAccountLimitsRequest req)
        {
             JsonResponseModel<DescribeAccountLimitsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAccountLimits) is used to query the limits of user's AS resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountLimitsRequest"/></param>
        /// <returns><see cref="DescribeAccountLimitsResponse"/></returns>
        public DescribeAccountLimitsResponse DescribeAccountLimitsSync(DescribeAccountLimitsRequest req)
        {
             JsonResponseModel<DescribeAccountLimitsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountLimits");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountLimitsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoScalingActivities) is used to query the activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public async Task<DescribeAutoScalingActivitiesResponse> DescribeAutoScalingActivities(DescribeAutoScalingActivitiesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoScalingActivities) is used to query the activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingActivitiesResponse"/></returns>
        public DescribeAutoScalingActivitiesResponse DescribeAutoScalingActivitiesSync(DescribeAutoScalingActivitiesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingActivitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query suggestions for scaling group configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public async Task<DescribeAutoScalingAdvicesResponse> DescribeAutoScalingAdvices(DescribeAutoScalingAdvicesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingAdvicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingAdvices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingAdvicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query suggestions for scaling group configurations.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingAdvicesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingAdvicesResponse"/></returns>
        public DescribeAutoScalingAdvicesResponse DescribeAutoScalingAdvicesSync(DescribeAutoScalingAdvicesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingAdvicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingAdvices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingAdvicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the latest activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public async Task<DescribeAutoScalingGroupLastActivitiesResponse> DescribeAutoScalingGroupLastActivities(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingGroupLastActivitiesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingGroupLastActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingGroupLastActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the latest activity history of an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupLastActivitiesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupLastActivitiesResponse"/></returns>
        public DescribeAutoScalingGroupLastActivitiesResponse DescribeAutoScalingGroupLastActivitiesSync(DescribeAutoScalingGroupLastActivitiesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingGroupLastActivitiesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingGroupLastActivities");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingGroupLastActivitiesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoScalingGroups) is used to query the information of auto scaling groups.
        /// 
        /// * You can query the details of auto scaling groups based on information such as auto scaling group ID, auto scaling group name, or launch configuration ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of auto scaling groups of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingGroupsRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingGroupsResponse"/></returns>
        public async Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest req)
        {
             JsonResponseModel<DescribeAutoScalingGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeAutoScalingGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeAutoScalingInstances) is used to query the information of instances associated with AS.
        /// 
        /// * You can query the details of instances based on information such as instance ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of instances of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="DescribeAutoScalingInstancesResponse"/></returns>
        public async Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest req)
        {
             JsonResponseModel<DescribeAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of launch configurations.
        /// 
        /// * You can query the launch configuration details based on information such as launch configuration ID and name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of launch configurations of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLaunchConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeLaunchConfigurationsResponse"/></returns>
        public async Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest req)
        {
             JsonResponseModel<DescribeLaunchConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLaunchConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLaunchConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeLaunchConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLaunchConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLaunchConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeLifecycleHooks) is used to query the information of lifecycle hooks.
        /// 
        /// * You can query the details of lifecycle hooks based on information such as auto scaling group ID, lifecycle hook ID, or lifecycle hook name. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of lifecycle hooks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeLifecycleHooksRequest"/></param>
        /// <returns><see cref="DescribeLifecycleHooksResponse"/></returns>
        public async Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooks(DescribeLifecycleHooksRequest req)
        {
             JsonResponseModel<DescribeLifecycleHooksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeLifecycleHooks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLifecycleHooksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeLifecycleHooksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeLifecycleHooks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeLifecycleHooksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeNotificationConfigurations) is used to query the information of one or more notifications.
        /// 
        /// You can query the details of notifications based on information such as notification ID and auto scaling group ID. For more information on filters, see `Filter`.
        /// If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of notifications of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeNotificationConfigurationsRequest"/></param>
        /// <returns><see cref="DescribeNotificationConfigurationsResponse"/></returns>
        public async Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest req)
        {
             JsonResponseModel<DescribeNotificationConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNotificationConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotificationConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeNotificationConfigurationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNotificationConfigurations");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNotificationConfigurationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeScalingPolicies) is used to query alarm trigger policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public async Task<DescribeScalingPoliciesResponse> DescribeScalingPolicies(DescribeScalingPoliciesRequest req)
        {
             JsonResponseModel<DescribeScalingPoliciesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScalingPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScalingPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeScalingPolicies) is used to query alarm trigger policies.
        /// </summary>
        /// <param name="req"><see cref="DescribeScalingPoliciesRequest"/></param>
        /// <returns><see cref="DescribeScalingPoliciesResponse"/></returns>
        public DescribeScalingPoliciesResponse DescribeScalingPoliciesSync(DescribeScalingPoliciesRequest req)
        {
             JsonResponseModel<DescribeScalingPoliciesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScalingPolicies");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScalingPoliciesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (DescribeScheduledActions) is used to query the details of one or more scheduled tasks.
        /// 
        /// * You can query the details of scheduled tasks based on information such as scheduled task ID, scheduled task name, or auto scaling group ID. For more information on filters, see `Filter`.
        /// * If the parameter is empty, a certain number (specified by `Limit` and 20 by default) of scheduled tasks of the current user will be returned.
        /// </summary>
        /// <param name="req"><see cref="DescribeScheduledActionsRequest"/></param>
        /// <returns><see cref="DescribeScheduledActionsResponse"/></returns>
        public async Task<DescribeScheduledActionsResponse> DescribeScheduledActions(DescribeScheduledActionsRequest req)
        {
             JsonResponseModel<DescribeScheduledActionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScheduledActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScheduledActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DescribeScheduledActionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScheduledActions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScheduledActionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove CVM instances from a scaling group. Instances removed via this API will not be terminated.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
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
        /// This API is used to remove CVM instances from a scaling group. Instances removed via this API will not be terminated.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
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
        /// This API is used to unbind one or more CLBs from a scaling group. This API will not terminate CLBs.
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public async Task<DetachLoadBalancersResponse> DetachLoadBalancers(DetachLoadBalancersRequest req)
        {
             JsonResponseModel<DetachLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetachLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind one or more CLBs from a scaling group. This API will not terminate CLBs.
        /// </summary>
        /// <param name="req"><see cref="DetachLoadBalancersRequest"/></param>
        /// <returns><see cref="DetachLoadBalancersResponse"/></returns>
        public DetachLoadBalancersResponse DetachLoadBalancersSync(DetachLoadBalancersRequest req)
        {
             JsonResponseModel<DetachLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetachLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetachLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<DisableAutoScalingGroupResponse> DisableAutoScalingGroup(DisableAutoScalingGroupRequest req)
        {
             JsonResponseModel<DisableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<DisableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableAutoScalingGroup) is used to enable the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public async Task<EnableAutoScalingGroupResponse> EnableAutoScalingGroup(EnableAutoScalingGroupRequest req)
        {
             JsonResponseModel<EnableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (EnableAutoScalingGroup) is used to enable the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="EnableAutoScalingGroupRequest"/></param>
        /// <returns><see cref="EnableAutoScalingGroupResponse"/></returns>
        public EnableAutoScalingGroupResponse EnableAutoScalingGroupSync(EnableAutoScalingGroupRequest req)
        {
             JsonResponseModel<EnableAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ExecuteScalingPolicy) is used to execute a scaling policy.
        /// 
        /// * The scaling policy can be executed based on the scaling policy ID.
        /// * When the auto scaling group to which the scaling policy belongs is performing a scaling activity, the scaling policy will be rejected.
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public async Task<ExecuteScalingPolicyResponse> ExecuteScalingPolicy(ExecuteScalingPolicyRequest req)
        {
             JsonResponseModel<ExecuteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ExecuteScalingPolicy) is used to execute a scaling policy.
        /// 
        /// * The scaling policy can be executed based on the scaling policy ID.
        /// * When the auto scaling group to which the scaling policy belongs is performing a scaling activity, the scaling policy will be rejected.
        /// </summary>
        /// <param name="req"><see cref="ExecuteScalingPolicyRequest"/></param>
        /// <returns><see cref="ExecuteScalingPolicyResponse"/></returns>
        public ExecuteScalingPolicyResponse ExecuteScalingPolicySync(ExecuteScalingPolicyRequest req)
        {
             JsonResponseModel<ExecuteScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAutoScalingGroup) is used to modify an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public async Task<ModifyAutoScalingGroupResponse> ModifyAutoScalingGroup(ModifyAutoScalingGroupRequest req)
        {
             JsonResponseModel<ModifyAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyAutoScalingGroup) is used to modify an auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyAutoScalingGroupRequest"/></param>
        /// <returns><see cref="ModifyAutoScalingGroupResponse"/></returns>
        public ModifyAutoScalingGroupResponse ModifyAutoScalingGroupSync(ModifyAutoScalingGroupRequest req)
        {
             JsonResponseModel<ModifyAutoScalingGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAutoScalingGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAutoScalingGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDesiredCapacity) is used to modify the desired number of instances in the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public async Task<ModifyDesiredCapacityResponse> ModifyDesiredCapacity(ModifyDesiredCapacityRequest req)
        {
             JsonResponseModel<ModifyDesiredCapacityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDesiredCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDesiredCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyDesiredCapacity) is used to modify the desired number of instances in the specified auto scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyDesiredCapacityRequest"/></param>
        /// <returns><see cref="ModifyDesiredCapacityResponse"/></returns>
        public ModifyDesiredCapacityResponse ModifyDesiredCapacitySync(ModifyDesiredCapacityRequest req)
        {
             JsonResponseModel<ModifyDesiredCapacityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDesiredCapacity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDesiredCapacityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyLaunchConfigurationAttributes) is used to modify some attributes of a launch configuration.
        /// 
        /// * The changes of launch configuration do not affect the existing instances. New instances will be created based on the modified configuration.
        /// * This API supports modifying certain simple types of attributes.
        /// </summary>
        /// <param name="req"><see cref="ModifyLaunchConfigurationAttributesRequest"/></param>
        /// <returns><see cref="ModifyLaunchConfigurationAttributesResponse"/></returns>
        public async Task<ModifyLaunchConfigurationAttributesResponse> ModifyLaunchConfigurationAttributes(ModifyLaunchConfigurationAttributesRequest req)
        {
             JsonResponseModel<ModifyLaunchConfigurationAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLaunchConfigurationAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaunchConfigurationAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyLaunchConfigurationAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLaunchConfigurationAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLaunchConfigurationAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public async Task<ModifyLifecycleHookResponse> ModifyLifecycleHook(ModifyLifecycleHookRequest req)
        {
             JsonResponseModel<ModifyLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the lifecycle hook.
        /// </summary>
        /// <param name="req"><see cref="ModifyLifecycleHookRequest"/></param>
        /// <returns><see cref="ModifyLifecycleHookResponse"/></returns>
        public ModifyLifecycleHookResponse ModifyLifecycleHookSync(ModifyLifecycleHookRequest req)
        {
             JsonResponseModel<ModifyLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the target rule attributes of the CLB in the scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public async Task<ModifyLoadBalancerTargetAttributesResponse> ModifyLoadBalancerTargetAttributes(ModifyLoadBalancerTargetAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerTargetAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancerTargetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerTargetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the target rule attributes of the CLB in the scaling group.
        /// </summary>
        /// <param name="req"><see cref="ModifyLoadBalancerTargetAttributesRequest"/></param>
        /// <returns><see cref="ModifyLoadBalancerTargetAttributesResponse"/></returns>
        public ModifyLoadBalancerTargetAttributesResponse ModifyLoadBalancerTargetAttributesSync(ModifyLoadBalancerTargetAttributesRequest req)
        {
             JsonResponseModel<ModifyLoadBalancerTargetAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancerTargetAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancerTargetAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<ModifyLoadBalancersResponse> ModifyLoadBalancers(ModifyLoadBalancersRequest req)
        {
             JsonResponseModel<ModifyLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<ModifyLoadBalancersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyLoadBalancers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyLoadBalancersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a notification policy.
        /// * The receiver type of the notification policy cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public async Task<ModifyNotificationConfigurationResponse> ModifyNotificationConfiguration(ModifyNotificationConfigurationRequest req)
        {
             JsonResponseModel<ModifyNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a notification policy.
        /// * The receiver type of the notification policy cannot be modified.
        /// </summary>
        /// <param name="req"><see cref="ModifyNotificationConfigurationRequest"/></param>
        /// <returns><see cref="ModifyNotificationConfigurationResponse"/></returns>
        public ModifyNotificationConfigurationResponse ModifyNotificationConfigurationSync(ModifyNotificationConfigurationRequest req)
        {
             JsonResponseModel<ModifyNotificationConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNotificationConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNotificationConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyScalingPolicy) is used to modify an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public async Task<ModifyScalingPolicyResponse> ModifyScalingPolicy(ModifyScalingPolicyRequest req)
        {
             JsonResponseModel<ModifyScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyScalingPolicy) is used to modify an alarm trigger policy.
        /// </summary>
        /// <param name="req"><see cref="ModifyScalingPolicyRequest"/></param>
        /// <returns><see cref="ModifyScalingPolicyResponse"/></returns>
        public ModifyScalingPolicyResponse ModifyScalingPolicySync(ModifyScalingPolicyRequest req)
        {
             JsonResponseModel<ModifyScalingPolicyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyScalingPolicy");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScalingPolicyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyScheduledAction) is used to modify a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public async Task<ModifyScheduledActionResponse> ModifyScheduledAction(ModifyScheduledActionRequest req)
        {
             JsonResponseModel<ModifyScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (ModifyScheduledAction) is used to modify a scheduled task.
        /// </summary>
        /// <param name="req"><see cref="ModifyScheduledActionRequest"/></param>
        /// <returns><see cref="ModifyScheduledActionResponse"/></returns>
        public ModifyScheduledActionResponse ModifyScheduledActionSync(ModifyScheduledActionRequest req)
        {
             JsonResponseModel<ModifyScheduledActionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyScheduledAction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyScheduledActionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete CVM instances from a scaling group. Instances that are automatically created through AS will be terminated, while those manually added to the scaling group will be removed and retained.
        /// * If the number of remaining `IN_SERVICE` instances in the scaling group is less than the minimum capacity, this API will return an error.
        /// * However, if the scaling group is in `DISABLED` status, the removal will not verify the relationship between the number of `IN_SERVICE` instances and the minimum capacity.
        /// * This removal will unassociate the CVM from the CLB instance that has been configured for the scaling group.
        /// </summary>
        /// <param name="req"><see cref="RemoveInstancesRequest"/></param>
        /// <returns><see cref="RemoveInstancesResponse"/></returns>
        public async Task<RemoveInstancesResponse> RemoveInstances(RemoveInstancesRequest req)
        {
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<RemoveInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RemoveInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RemoveInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reduce the specified number of instances from the scaling group.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * You can specify the instances to remove in the scale-in activity by using `TerminationPolicies`. For more information, see [Scaling In Policies](https://intl.cloud.tencent.com/document/product/377/8563?from_cn_redirect=1).
        /// * Only the `IN_SERVICE` instances will be reduced. To reduce instances in other statues, use the [`DetachInstances`](https://intl.cloud.tencent.com/document/api/377/20436?from_cn_redirect=1) or [`RemoveInstances`](https://intl.cloud.tencent.com/document/api/377/20431?from_cn_redirect=1) API.
        /// * The desired capacity will be reduced accordingly. The new desired capacity should be no less than the minimum capacity.
        /// * If the scale-in activity failed or partially succeeded, the final desired capacity only deducts the instances that have been reduced successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public async Task<ScaleInInstancesResponse> ScaleInInstances(ScaleInInstancesRequest req)
        {
             JsonResponseModel<ScaleInInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleInInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleInInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to reduce the specified number of instances from the scaling group.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * You can specify the instances to remove in the scale-in activity by using `TerminationPolicies`. For more information, see [Scaling In Policies](https://intl.cloud.tencent.com/document/product/377/8563?from_cn_redirect=1).
        /// * Only the `IN_SERVICE` instances will be reduced. To reduce instances in other statues, use the [`DetachInstances`](https://intl.cloud.tencent.com/document/api/377/20436?from_cn_redirect=1) or [`RemoveInstances`](https://intl.cloud.tencent.com/document/api/377/20431?from_cn_redirect=1) API.
        /// * The desired capacity will be reduced accordingly. The new desired capacity should be no less than the minimum capacity.
        /// * If the scale-in activity failed or partially succeeded, the final desired capacity only deducts the instances that have been reduced successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleInInstancesRequest"/></param>
        /// <returns><see cref="ScaleInInstancesResponse"/></returns>
        public ScaleInInstancesResponse ScaleInInstancesSync(ScaleInInstancesRequest req)
        {
             JsonResponseModel<ScaleInInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleInInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleInInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add the specified number of instances to the scaling group, which returns the scaling activity ID `ActivityId`.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * The desired capacity will be increased accordingly. The new desired capacity should be no more than the maximum capacity.
        /// * If the scale-out activity failed or partially succeeded, the final desired capacity only includes the instances that have been added successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public async Task<ScaleOutInstancesResponse> ScaleOutInstances(ScaleOutInstancesRequest req)
        {
             JsonResponseModel<ScaleOutInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ScaleOutInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add the specified number of instances to the scaling group, which returns the scaling activity ID `ActivityId`.
        /// * There is no on going scaling task.
        /// * This API is valid even when the scaling group is disabled. For more details, see [DisableAutoScalingGroup](https://intl.cloud.tencent.com/document/api/377/20435?from_cn_redirect=1).
        /// * The desired capacity will be increased accordingly. The new desired capacity should be no more than the maximum capacity.
        /// * If the scale-out activity failed or partially succeeded, the final desired capacity only includes the instances that have been added successfully.
        /// </summary>
        /// <param name="req"><see cref="ScaleOutInstancesRequest"/></param>
        /// <returns><see cref="ScaleOutInstancesResponse"/></returns>
        public ScaleOutInstancesResponse ScaleOutInstancesSync(ScaleOutInstancesRequest req)
        {
             JsonResponseModel<ScaleOutInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ScaleOutInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ScaleOutInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable scale-in protection for an instance.
        /// When scale-in protection is enabled, the instance will not be removed in scale-in activities triggered by replacement of unhealthy instances, alarm threshold reached, change of desired quantity, etc.
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public async Task<SetInstancesProtectionResponse> SetInstancesProtection(SetInstancesProtectionRequest req)
        {
             JsonResponseModel<SetInstancesProtectionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetInstancesProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetInstancesProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to enable scale-in protection for an instance.
        /// When scale-in protection is enabled, the instance will not be removed in scale-in activities triggered by replacement of unhealthy instances, alarm threshold reached, change of desired quantity, etc.
        /// </summary>
        /// <param name="req"><see cref="SetInstancesProtectionRequest"/></param>
        /// <returns><see cref="SetInstancesProtectionResponse"/></returns>
        public SetInstancesProtectionResponse SetInstancesProtectionSync(SetInstancesProtectionRequest req)
        {
             JsonResponseModel<SetInstancesProtectionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetInstancesProtection");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetInstancesProtectionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start up CVM instances in a scaling group.
        /// * After startup, the instance will be in the `IN_SERVICE` status, which will increase the desired capacity. Please note that the desired capacity cannot exceed the maximum value.
        /// * This API supports batch operation. Up to 100 instances can be started up in each request.
        /// </summary>
        /// <param name="req"><see cref="StartAutoScalingInstancesRequest"/></param>
        /// <returns><see cref="StartAutoScalingInstancesResponse"/></returns>
        public async Task<StartAutoScalingInstancesResponse> StartAutoScalingInstances(StartAutoScalingInstancesRequest req)
        {
             JsonResponseModel<StartAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<StartAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<StopAutoScalingInstancesResponse> StopAutoScalingInstances(StopAutoScalingInstancesRequest req)
        {
             JsonResponseModel<StopAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<StopAutoScalingInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopAutoScalingInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopAutoScalingInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a launch configuration.
        /// 
        /// * This API is used to upgrade a launch configuration in a "completely overriding" manner, i.e., it uniformly sets a new configuration according to the API parameters regardless of the original parameters. If optional fields are left empty, their default values will be used.
        /// * After the launch configuration is upgraded, the existing instances that have been created by it will not be changed, but new instances will be created according to the new configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public async Task<UpgradeLaunchConfigurationResponse> UpgradeLaunchConfiguration(UpgradeLaunchConfigurationRequest req)
        {
             JsonResponseModel<UpgradeLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to upgrade a launch configuration.
        /// 
        /// * This API is used to upgrade a launch configuration in a "completely overriding" manner, i.e., it uniformly sets a new configuration according to the API parameters regardless of the original parameters. If optional fields are left empty, their default values will be used.
        /// * After the launch configuration is upgraded, the existing instances that have been created by it will not be changed, but new instances will be created according to the new configuration.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLaunchConfigurationRequest"/></param>
        /// <returns><see cref="UpgradeLaunchConfigurationResponse"/></returns>
        public UpgradeLaunchConfigurationResponse UpgradeLaunchConfigurationSync(UpgradeLaunchConfigurationRequest req)
        {
             JsonResponseModel<UpgradeLaunchConfigurationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeLaunchConfiguration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLaunchConfigurationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UpgradeLifecycleHook) is used to upgrade a lifecycle hook.
        /// 
        /// * This API is used to upgrade a lifecycle hook in a "completely overriding" manner, i.e., it uniformly sets a new configuration according to the API parameters regardless of the original parameters. If optional fields are left empty, their default values will be used.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public async Task<UpgradeLifecycleHookResponse> UpgradeLifecycleHook(UpgradeLifecycleHookRequest req)
        {
             JsonResponseModel<UpgradeLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API (UpgradeLifecycleHook) is used to upgrade a lifecycle hook.
        /// 
        /// * This API is used to upgrade a lifecycle hook in a "completely overriding" manner, i.e., it uniformly sets a new configuration according to the API parameters regardless of the original parameters. If optional fields are left empty, their default values will be used.
        /// </summary>
        /// <param name="req"><see cref="UpgradeLifecycleHookRequest"/></param>
        /// <returns><see cref="UpgradeLifecycleHookResponse"/></returns>
        public UpgradeLifecycleHookResponse UpgradeLifecycleHookSync(UpgradeLifecycleHookRequest req)
        {
             JsonResponseModel<UpgradeLifecycleHookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeLifecycleHook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeLifecycleHookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

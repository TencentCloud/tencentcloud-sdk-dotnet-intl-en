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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAlarmPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// Value fixed at "monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// Page number starting from 1. Default value: 1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Number of entries per page. Value range: 1–100. Default value: 20
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Fuzzy search by policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Filter by monitor type. Valid values: MT_QCE (Tencent Cloud service monitoring). If this parameter is left empty, all will be queried by default
        /// </summary>
        [JsonProperty("MonitorTypes")]
        public string[] MonitorTypes{ get; set; }

        /// <summary>
        /// Filter by namespace. For the values of different policy types, please see:
        /// [Policy Type List](https://intl.cloud.tencent.com/document/product/248/50397?from_cn_redirect=1)
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// The alarm object list, which is a JSON string. The outer array corresponds to multiple instances, and the inner array is the dimension of an object. For example, “CVM - Basic Monitor” can be written as:
        /// `[ {"Dimensions": {"unInstanceId": "ins-qr8d555g"}}, {"Dimensions": {"unInstanceId": "ins-qr8d555h"}} ]`
        /// You can also refer to the “Example 2” below.
        /// 
        /// For more information on the parameter samples of different Tencent Cloud services, see [Product Policy Type and Dimension Information](https://intl.cloud.tencent.com/document/product/248/50397?from_cn_redirect=1).
        /// 
        /// Note: If `1` is passed in for `NeedCorrespondence`, the relationship between a policy and an instance needs to be returned. You can pass in up to 20 alarm object dimensions to avoid request timeout.
        /// </summary>
        [JsonProperty("Dimensions")]
        public string Dimensions{ get; set; }

        /// <summary>
        /// Search by recipient. You can get the user list with the API [ListUsers](https://intl.cloud.tencent.com/document/product/598/34587?from_cn_redirect=1) in “Cloud Access Management” or query the sub-user information with the API [GetUser](https://intl.cloud.tencent.com/document/product/598/34590?from_cn_redirect=1). The `Uid` field in the returned result should be entered here.
        /// </summary>
        [JsonProperty("ReceiverUids")]
        public long?[] ReceiverUids{ get; set; }

        /// <summary>
        /// Search by recipient group. You can get the user group list with the API [ListGroups](https://intl.cloud.tencent.com/document/product/598/34589?from_cn_redirect=1) in “Cloud Access Management” or query the user group list where a sub-user is in with the API [ListGroupsForUser](https://intl.cloud.tencent.com/document/product/598/34588?from_cn_redirect=1). The `GroupId` field in the returned result should be entered here.
        /// </summary>
        [JsonProperty("ReceiverGroups")]
        public long?[] ReceiverGroups{ get; set; }

        /// <summary>
        /// Filter by default policy. Valid values: DEFAULT (display default policy), NOT_DEFAULT (display non-default policies). If this parameter is left empty, all policies will be displayed
        /// </summary>
        [JsonProperty("PolicyType")]
        public string[] PolicyType{ get; set; }

        /// <summary>
        /// Sort by field. For example, to sort by the last modification time, use Field: "UpdateTime".
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// Sort order. Valid values: ASC (ascending), DESC (descending)
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// ID array of the policy project, which can be viewed on the following page:
        /// [Project Management](https://console.cloud.tencent.com/project)
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// ID list of the notification template, which can be obtained by querying the notification template list.
        /// It can be queried with the API [DescribeAlarmNotices](https://intl.cloud.tencent.com/document/product/248/51280?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("NoticeIds")]
        public string[] NoticeIds{ get; set; }

        /// <summary>
        /// Filter by trigger condition. Valid values: STATIC (display policies with static threshold), DYNAMIC (display policies with dynamic threshold). If this parameter is left empty, all policies will be displayed
        /// </summary>
        [JsonProperty("RuleTypes")]
        public string[] RuleTypes{ get; set; }

        /// <summary>
        /// Filter by alarm status. Valid values: [1]: enabled; [0]: disabled; [0, 1]: all
        /// </summary>
        [JsonProperty("Enable")]
        public long?[] Enable{ get; set; }

        /// <summary>
        /// If `1` is passed in, alarm policies with no notification rules configured are queried. If it is left empty or other values are passed in, all alarm policies are queried.
        /// </summary>
        [JsonProperty("NotBindingNoticeRule")]
        public long? NotBindingNoticeRule{ get; set; }

        /// <summary>
        /// Instance group ID.
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// Whether the relationship between a policy and the input parameter filter dimension is required. `1`: Yes. `0`: No. Default value: `0`.
        /// </summary>
        [JsonProperty("NeedCorrespondence")]
        public long? NeedCorrespondence{ get; set; }

        /// <summary>
        /// Filter alarm policy by triggered task (such as auto scaling task). Up to 10 tasks can be specified.
        /// </summary>
        [JsonProperty("TriggerTasks")]
        public AlarmPolicyTriggerTask[] TriggerTasks{ get; set; }

        /// <summary>
        /// Filter by quick alarm policy. If this parameter is left empty, all policies are displayed. `ONECLICK`: Display quick alarm policies; `NOT_ONECLICK`: Display non-quick alarm policies.
        /// </summary>
        [JsonProperty("OneClickPolicyType")]
        public string[] OneClickPolicyType{ get; set; }

        /// <summary>
        /// Whether the returned result filters policies associated with all objects. Valid values: `1` (Yes), `0` (No).
        /// </summary>
        [JsonProperty("NotBindAll")]
        public long? NotBindAll{ get; set; }

        /// <summary>
        /// Whether the returned result filters policies associated with instance groups. Valid values: `1` (Yes), `0` (No).
        /// </summary>
        [JsonProperty("NotInstanceGroup")]
        public long? NotInstanceGroup{ get; set; }

        /// <summary>
        /// Filter policies by tag
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamArraySimple(map, prefix + "MonitorTypes.", this.MonitorTypes);
            this.SetParamArraySimple(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamSimple(map, prefix + "Dimensions", this.Dimensions);
            this.SetParamArraySimple(map, prefix + "ReceiverUids.", this.ReceiverUids);
            this.SetParamArraySimple(map, prefix + "ReceiverGroups.", this.ReceiverGroups);
            this.SetParamArraySimple(map, prefix + "PolicyType.", this.PolicyType);
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "NoticeIds.", this.NoticeIds);
            this.SetParamArraySimple(map, prefix + "RuleTypes.", this.RuleTypes);
            this.SetParamArraySimple(map, prefix + "Enable.", this.Enable);
            this.SetParamSimple(map, prefix + "NotBindingNoticeRule", this.NotBindingNoticeRule);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "NeedCorrespondence", this.NeedCorrespondence);
            this.SetParamArrayObj(map, prefix + "TriggerTasks.", this.TriggerTasks);
            this.SetParamArraySimple(map, prefix + "OneClickPolicyType.", this.OneClickPolicyType);
            this.SetParamSimple(map, prefix + "NotBindAll", this.NotBindAll);
            this.SetParamSimple(map, prefix + "NotInstanceGroup", this.NotInstanceGroup);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}


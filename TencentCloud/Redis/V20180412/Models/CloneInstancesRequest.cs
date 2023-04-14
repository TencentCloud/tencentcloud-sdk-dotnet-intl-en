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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the current instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Number of instance to be cloned each time. You can purchase up to 100 monthly subscribed instances or up to 30 pay-as-you-go instances at a time. You can purchase up to 100 instances in each region.
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// ID of the AZ where the clone instance resides. For more information, see [Regions and AZs](https://intl.cloud.tencent.com/document/product/239/4106?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Billing mode. Valid values: <ul><li>`0` (Pay-as-you-go) </li><li>`1` (Monthly subscription) </li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// Purchase duration of an instance. <ul><li>Unit: Month</li><li>Valid values: `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`, `10`, `11`, `12`, `24`, `36`, `48`, `60` (for monthly subscription mode).</li><li> Valid value: `1` (for pay-as-you-go mode).</li></ul>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Security group ID, which can be obtained on the <b>Security Group</b> page in the console.
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// Backup ID of the clone instance, which can be obtained through the [DescribeInstanceBackups](https://intl.cloud.tencent.com/document/product/239/20011?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// Whether the clone instance supports password-free access. Valid values: <ul><li>`true` (Yes)</li><li>`false` (No. When SSL or public network is enabled). Default value: `false`.</li></ul>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// VPC ID. If this parameter is not passed in, the classic network will be selected by default.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID, which is not required for the classic network.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Name of the clone instance. <br>Enter up to 60 letters, digits, hyphens, and underscores.</br>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// The access password of the clone instance. <ul><li>When the input parameter <b>NoAuth</b> is <b>true</b>, this parameter is not required. </li><li>When the instance is Redis 2.8, 4.0, or 5.0, the password must contain 8–30 characters in at least two of the following types: lowercase letters, uppercase letters, digits, and special characters `()`~!@#$%^&*-+=_|{}[]:;<>,.?/` and cannot start with `/`.</li><li>When the instance is CKV 3.2, the password must and can only contain 8–30 letters and digits.</li></ul>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// The auto-renewal flag. Valid values <ul><li>`0`: Manual renewal (default) </li><li>`1`: Auto-renewal. </li><li>`2`: Not auto-renewal (set by user)</ul>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Customized port. Valid range: 1024-65535. Default value: `6379`.
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// Node information of an instance. <ul><li>Currently supported type and AZ information of a node to be configured (master node or replica node) For more information, see [RedisNodeInfo](https://intl.cloud.tencent.com/document/product/239/20022?from_cn_redirect=1#RedisNodeInfo).</li><li>This parameter is not required for single-AZ deployment.</li></ul>
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// Project ID, which can be obtained in <b>Account Center</b> > <b>Project Management</b> in the upper-right corner in the console.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Tag to be bound for the clone instance
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// The ID of a parameter template to be applied to the clone instance, which can be obtained on <b>Parameter Template</b> page in the console. If this parameter is not configured, the default parameter template will be applied.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Alarm policy ID of the specified clone instance, which can be obtained on <b>Cloud Monitor</b> > <b>Alarm Configuration</b> > <b>Alarm Policy</b> in the console.
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public string[] AlarmPolicyList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyList.", this.AlarmPolicyList);
        }
    }
}


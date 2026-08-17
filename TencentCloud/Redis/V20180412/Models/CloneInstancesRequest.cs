/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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
        /// <p>Specify the source instance ID to be cloned. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>The number of clone instances per operation.</p><ul><li>The maximum allowed number for each Monthly Subscription purchase is 100.</li><li>The maximum allowed number for each Pay-As-You-Go purchase is 30.</li></ul>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Availability zone ID of the cloned instance. For supported AZ IDs, see <a href="https://www.tencentcloud.com/document/product/239/4106?from_cn_redirect=1">Regions and Availability Zones</a>.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>Payment method.<ul><li>0: Pay-As-You-Go.</li><li>1: Monthly Subscription.</li></ul></p>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>Instance Purchase Duration.<ul><li>Unit: month.</li><li>When the payment method is set to Monthly Subscription, the value range is [1,2,3,4,5,6,7,8,9,10,11,12,24,36,48,60].</li><li>When the payment method is set to Pay-As-You-Go, it is set to 1.</li></ul></p>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>Security group ID. Call the <a href="https://www.tencentcloud.com/document/product/239/34447?from_cn_redirect=1">DescribeInstanceSecurityGroup</a> API to obtain the security group ID for the instance.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// <p>Backup ID used to clone an instance. Use the interface <a href="https://www.tencentcloud.com/document/product/239/20011?from_cn_redirect=1">DescribeInstanceBackups</a> to obtain the backup ID.</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// <p>Configure whether the cloned instance supports password-free access. Enabling SSL or public network does not support password-free access.<ul><li>true: Password-free instance,</li><li>false: Non-password-free instance. Default for non-passwordless instance.</li></ul></p>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// <p>Configure the VPC ID for the clone instance. If not configured, the basic network is selected by default.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Configure the subnet of the private network for the cloned instance. This parameter requires no configuration for the basic network.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Name of the cloned instance.<br>Only Chinese characters, English letters, numbers, dashes ("-"), or underscores ("_") are allowed, with a length of less than 60.<br></p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>The access password of the clone instance.<ul><li>When the input parameter <b>NoAuth</b> is <b>true</b>, setting this parameter is optional.</li><li>For Redis 2.8, 4.0, and 5.0 instances, the password format is: 8-30 characters, containing at least lowercase letters, uppercase letters, digits, and 2 types of characters from ()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/, and cannot start with "/".</li><li>For CKV 3.2 instances, the password format is: 8-30 characters, must include letters and digits, and exclude other characters.</li></ul></p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>Automatic renewal flag.<ul><li>0: default status, manual renewal.</li><li>1: automatic renewal.</li><li>2: no automatic renewal, auto-isolation upon expiration.</li></ul></p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>User-defined port, defaults to 6379, in the range of [1024,65535].</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>Node information of instance.<ul><li>Currently supports configuring node type (primary node or replica node) and its availability zone info. For details, please refer to <a href="https://www.tencentcloud.com/document/product/239/20022?from_cn_redirect=1#RedisNodeInfo">RedisNodeInfo</a>.</li><li>This parameter can be left blank for single-AZ deployment.</li></ul></p>
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// <p>Project ID. Log in to the <a href="https://console.cloud.tencent.com/redis#/">Redis console</a>. You can find the project ID in the <b>Account Center</b> &gt; <b>Project Management</b> at the top-right corner.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Tag bound to the clone instance.</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Specify the parameter template ID related to the cloned instance.</p><ul><li>If this parameter is not configured, the system will automatically adapt the corresponding default template based on the selected compatible version and architecture.</li><li>Query the parameter template list of the instance through the <a href="https://www.tencentcloud.com/document/product/239/58750?from_cn_redirect=1">DescribeParamTemplates</a> API to obtain the template ID number.</li></ul>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Specify the alarm policy ID of the clone instance. Log in to the <a href="https://console.cloud.tencent.com/monitor/alarm2/policy">Tencent Cloud observability platform console</a>, and get policy ID information on the <b>alarm management</b> &gt; <b>policy management</b> page.</p>
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public string[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// <p>Clone the time when data is recovered.<br>Only instances with second-level backup enabled are supported.</p>
        /// </summary>
        [JsonProperty("CloneTime")]
        public string CloneTime{ get; set; }

        /// <summary>
        /// <p>Whether to encrypt the password</p>
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }

        /// <summary>
        /// <p>Instance password complexity policy</p><p>Input parameter limit: If not passed or Enabled=false, deem as not enabled and verify by default rule.</p>
        /// </summary>
        [JsonProperty("PasswordPolicy")]
        public PasswordPolicy PasswordPolicy{ get; set; }

        /// <summary>
        /// <p>Whether to enable SSL encryption.</p><p>Enumeration value:</p><ul><li>true: Enable.</li><li>false: Disable (default value).</li></ul><p>Default value: false</p>
        /// </summary>
        [JsonProperty("EnableSSL")]
        public bool? EnableSSL{ get; set; }

        /// <summary>
        /// <p>Whether to write the private IPv4 address of the instance to the domain alias (SAN) of the certificate when SSL is enabled. This parameter is valid only when EnableSSL is true.</p><p>Enumeration value:</p><ul><li>true: The private IP is allowed for SSL certificate verification.</li><li>false: The SAN extended information of the certificate is not added.</li></ul><p>Default value: false</p>
        /// </summary>
        [JsonProperty("SSLBindPrivateIPv4")]
        public bool? SSLBindPrivateIPv4{ get; set; }

        /// <summary>
        /// <p>Indicates the instance type.</p><p>Enumeration value:</p><ul><li>local: Common I</li><li>localv2: Common II</li></ul><p>If not passed, it remains the same as the original instance type by default.</p>
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }


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
            this.SetParamSimple(map, prefix + "CloneTime", this.CloneTime);
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
            this.SetParamObj(map, prefix + "PasswordPolicy.", this.PasswordPolicy);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "SSLBindPrivateIPv4", this.SSLBindPrivateIPv4);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
        }
    }
}


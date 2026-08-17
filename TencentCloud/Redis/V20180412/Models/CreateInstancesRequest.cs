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

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance type.</p><ul><li>2: Redis 2.8 memory edition (standard architecture).</li><li>3: CKV 3.2 memory edition (standard architecture).</li><li>4: CKV 3.2 memory edition (cluster architecture).</li><li>6: Redis 4.0 memory edition (standard architecture).</li><li>7: Redis 4.0 memory edition (cluster architecture).</li><li>8: Redis 5.0 memory edition (standard architecture).</li><li>9: Redis 5.0 memory edition (cluster architecture).</li><li>15: Redis 6.2 memory edition (standard architecture).</li><li>16: Redis 6.2 memory edition (cluster architecture).</li><li>17: Redis 7.0 memory edition (standard architecture).</li><li>18: Redis 7.0 memory edition (cluster architecture).</li><li>19: Valkey 8.0 memory edition (standard architecture).</li><li>20: Valkey 8.0 memory edition (cluster architecture).</li><li>21: Valkey 9.0 memory edition (standard architecture).</li><li>22: Valkey 9.0 memory edition (cluster architecture).</li><li>200: Memcached 1.6 memory edition (cluster architecture).<br><strong>Note</strong>: CKV editions are currently used by some users and are temporarily retained.</li></ul>
        /// </summary>
        [JsonProperty("TypeId")]
        public ulong? TypeId{ get; set; }

        /// <summary>
        /// <p>Memory capacity, measured in MB, must be a multiple of 1024. For specific specifications, query the sales specifications for all regions via the <a href="https://www.tencentcloud.com/document/api/239/30600?from_cn_redirect=1">DescribeProductInfo</a> API.</p><ul><li>When <strong>TypeId</strong> is standard architecture, <strong>MemSize</strong> is the total memory capacity of the instance.</li><li>When <strong>TypeId</strong> is cluster architecture, <strong>MemSize</strong> is the sharded memory capacity.</li></ul>
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// <p>Instance count. Number of instances to purchase at a time. For details, query sales specifications in all regions via the <a href="https://www.tencentcloud.com/document/api/239/30600?from_cn_redirect=1">DescribeProductInfo</a> API.</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>Duration of instance purchase.</p><ul><li>If <strong>BillingMode</strong> is <strong>1</strong>, that is, the billing mode is monthly subscription, you need to set this parameter to specify the duration of instance purchase. Measurement unit: month, permissible range [1,2,3,4,5,6,7,8,9,10,11,12,24,36].</li><li>If <strong>BillingMode</strong> is <strong>0</strong>, that is, the billing mode is pay-as-you-go, set this parameter to 1.</li></ul>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// <p>Billing mode.</p><ul><li>0: Pay-As-You-Go.</li><li>1: Monthly Subscription.</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// <p>ID of the AZ to which the instance belongs. See <a href="https://www.tencentcloud.com/document/product/239/4106?from_cn_redirect=1">Regions and AZs</a>.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>Password for accessing instances.</p><ul><li>When the input parameter <strong>NoAuth</strong> is <strong>true</strong>, it means setting instances to Password-free access, and Password does not need to be configured. Otherwise, Password is required.</li><li>When the instance type <strong>TypeId</strong> is Redis 2.8 memory edition standard architecture, Redis 4.0, 5.0, 6.2, or 7.0 memory edition standard architecture or cluster architecture, the Password complexity requirements are: 8-64 characters, containing at least lowercase letters, uppercase letters, digits, and 2 of the following characters: ()`~!@#$%^&amp;*-+=_|{}[]:;&lt;&gt;,.?/, and cannot start with "/".</li><li>When the instance type <strong>TypeId</strong> is CKV 3.2 memory edition standard architecture or cluster architecture, the Password complexity is: 8-30 characters, must include letters and digits, and exclude other characters.</li></ul>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>VPC ID. If you do not configure this parameter, the basic network is selected by default. Log in to the <a href="https://console.cloud.tencent.com/vpc">private network</a> console to query the specific ID.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet of the private network VPC. In the basic network, this parameter requires no configuration. Log in to the <a href="https://console.cloud.tencent.com/vpc">Private Network</a> console to query the subnet list and obtain the specific ID.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Project ID. Log in to the <a href="https://console.cloud.tencent.com/redis#/">Redis console</a>, select <strong>Project Management</strong> from the account information menu in the top-right corner, and query the project ID.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Automatic renewal flag.</p><ul><li>0: default status (manual renewal).</li><li>1: automatic renewal.</li><li>2: non-renewal upon expiration.</li></ul>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>Security group ID array.</p><ul><li>A security group is a virtual firewall that controls network access to a cloud database instance. When creating an instance, it is recommended to bind the corresponding security group.</li><li>Get the security group ID of an instance through the <a href="https://www.tencentcloud.com/document/product/239/34447?from_cn_redirect=1">DescribeInstanceSecurityGroup</a> API.</li></ul>
        /// </summary>
        [JsonProperty("SecurityGroupIdList")]
        public string[] SecurityGroupIdList{ get; set; }

        /// <summary>
        /// <p>User-defined network port. Defaults to 6379, range [1024,65535].</p>
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// <p>Number of instance shards.</p><ul><li>No need to configure this parameter for standard edition instances.</li><li>For cluster edition instances, the shard quantity range is: [1, 3, 5, 8, 12, 16, 24, 32, 40, 48, 64, 80, 96, 128].</li></ul>
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// <p>Instance replica number.</p><ul><li>Redis Memory Edition 4.0, 5.0, 6.2, and 7.0 cluster architecture supports a replica quantity range of [1,5].</li><li>Redis 2.8 Standard Edition and CKV Standard Edition support only 1 replica.</li></ul>
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// <p>Flag whether the instance needs to support read-only replica.</p><ul><li>Redis 2.8 Standard Edition and CKV Standard Edition do not support read-only replica.</li><li>If read-only replica is enabled, the instance will automatically separate read and write operations, with write requests routed to the primary node and read requests routed to replica nodes.</li><li>If needed to enable read-only replica, it is recommended to have at least 2 replicas.</li></ul>
        /// </summary>
        [JsonProperty("ReplicasReadonly")]
        public bool? ReplicasReadonly{ get; set; }

        /// <summary>
        /// <p>Instance name. Naming requirement: It only supports Chinese characters, letters, numbers, hyphens ("-"), or underscores ("_"), with a length of less than 60.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Configure whether the instance supports password-free access.</p><ul><li>true: Access the instance without a password.</li><li>false: Access the instance with a password. By default, password access is enabled. Only instances in a VPC network support password-free access.</li></ul>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// <p>Node information of instance, including node ID, node type, node availability zone ID. For details, please see <a href="https://www.tencentcloud.com/document/product/239/20022?from_cn_redirect=1">RedisNodeInfo</a>.<br>Currently support inputting node type (primary node or replica node) and availability zone. When this parameter is not specified, in regions that support multi-availability zone deployment, the system defaults to creating instances with multi-availability zone architecture.</p>
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// <p>Set a tag for the instance.</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Specify the name of the AZ to which the instance belongs. For details, see <a href="https://www.tencentcloud.com/document/product/239/4106?from_cn_redirect=1">Regions and AZs</a>.</p>
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// <p>Parameter template ID of the specified instance.</p><ul><li>If this parameter is not configured, the system will automatically adapt to the corresponding default template based on the selected compatible version and architecture.</li><li>Query the parameter template list of the instance through the <a href="https://www.tencentcloud.com/document/product/239/58750?from_cn_redirect=1">DescribeParamTemplates</a> API to obtain the template ID number.</li></ul>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Internal parameter to identify whether creating an instance needs to check.</p><ul><li>false: Default value. Send a normal request and create the instance directly after passing the check.</li><li>true: Send a check request without creating an instance.</li></ul>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>Indicates the instance deployment mode.</p><ul><li>local: traditional architecture, defaults to local.</li><li>cdc: dedicated cluster.</li><li>cloud: cloud native, currently not available for sale.</li></ul>
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// <p>Dedicated cluster ID.</p><ul><li>When <strong>ProductVersion</strong> is set to <strong>cdc</strong>, this parameter must be set.</li><li>Get cluster ID through the API <a href="https://www.tencentcloud.com/document/product/239/109628?from_cn_redirect=1">DescribeRedisClusters</a>.</li></ul>
        /// </summary>
        [JsonProperty("RedisClusterId")]
        public string RedisClusterId{ get; set; }

        /// <summary>
        /// <p>Alarm policy ID array.</p><ul><li>Log in to <a href="https://console.cloud.tencent.com/monitor/alarm/policy">Tencent Cloud Observability Platform - Alarm Management - Policy Management</a> to get alarm policy ID.</li><li>If this parameter is not configured, the default alarm policy will be bound. For the default alarm policy details, log in to <a href="https://console.cloud.tencent.com/monitor/alarm/policy">Tencent Cloud Observability Platform - Alarm Management - Policy Management</a> to view.</li></ul>
        /// </summary>
        [JsonProperty("AlarmPolicyList")]
        public string[] AlarmPolicyList{ get; set; }

        /// <summary>
        /// <p>Whether to enable password encryption for transmission.</p><ul><li>true: Encrypted.</li><li>false: Not encrypted (default value).</li></ul>
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }

        /// <summary>
        /// <p>Instance-level password complexity policy. When not passed in or Enabled=false, deem as not enabling policy, validate by system default rule.</p>
        /// </summary>
        [JsonProperty("PasswordPolicy")]
        public PasswordPolicy PasswordPolicy{ get; set; }

        /// <summary>
        /// <p>Whether to enable SSL encryption.</p><ul><li>true: Enable.</li><li>false: Disable (default value).</li></ul>
        /// </summary>
        [JsonProperty("EnableSSL")]
        public bool? EnableSSL{ get; set; }

        /// <summary>
        /// <p>Whether to write the private IPv4 address of an instance to the domain alias (SAN) of the certificate when SSL is enabled. This parameter is valid only when EnableSSL is true.</p><ul><li>true: Allows using private IP to perform SSL certificate verification.</li><li>false: Does not add the SAN extended information to the certificate.</li></ul>
        /// </summary>
        [JsonProperty("SSLBindPrivateIPv4")]
        public bool? SSLBindPrivateIPv4{ get; set; }

        /// <summary>
        /// <p>Instance connectivity access Mode.</p><ul><li>0: Proxy Mode (default value).</li><li>1: Direct access Mode.</li></ul>
        /// </summary>
        [JsonProperty("ConnectionMode")]
        public long? ConnectionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIdList.", this.SecurityGroupIdList);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "ReplicasReadonly", this.ReplicasReadonly);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "RedisClusterId", this.RedisClusterId);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyList.", this.AlarmPolicyList);
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
            this.SetParamObj(map, prefix + "PasswordPolicy.", this.PasswordPolicy);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "SSLBindPrivateIPv4", this.SSLBindPrivateIPv4);
            this.SetParamSimple(map, prefix + "ConnectionMode", this.ConnectionMode);
        }
    }
}


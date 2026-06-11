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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>VPC network ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Database type</p><p>Enumeration value:</p><ul><li>MYSQL: MYSQL</li></ul>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>Database version</p><p>Enumeration value:</p><ul><li>5.7: MySQL 5.7 edition</li><li>8.0: MySQL 8.0 edition</li></ul>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>project-ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is NORMAL or left blank<br>Cpu cores of the regular instance</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is NORMAL or left blank<br>Ordinary instance memory in GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance count</p><p>Value ranges from [1, 16]</p><p>Default value: 2</p><ul><li>A value of 2 means one rw instance + one ro instance.</li><li>The transmitted n refers to one rw instance + n-1 ro instances (identical specifications).</li><li>For a more precise cluster composition collocation, please use InstanceInitInfos.</li><li>The value set by this parameter is suitable for provisioned resource cluster. If needed to set the specifications and quantity of Serverless cluster, please use the InstanceInitInfo structure in InstanceInitInfos.n.</li></ul>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>This parameter is meaningless and abandoned.<br>Storage size, in GB.</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>Cluster name, length less than 64 characters, each character value ranges from uppercase/lowercase letters, digits, special symbols ('-', '_', '.')</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Account (8-64 characters, a combination of uppercase and lowercase letters, digits and symbols ~!@#$%^&amp;*_-+=|(){}[]:;&#39;&lt;&gt;,.?/ with any three types required)</p>
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// <p>Port, default 3306, in the range of [0, 65535)</p>
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration value:</p><ul><li>0: Pay-as-you-go billing</li><li>1: Monthly Subscription</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>Number of clusters to purchase. Optional value range: [1,50]. Default is 1.</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>Rollback type</p><p>Enumeration value:</p><ul><li>noneRollback: No rollback</li><li>snapRollback: Snapshot rollback</li><li>timeRollback: Point-in-time rollback</li></ul>
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// <p>Snapshot rollback means snapshotId; point-in-time rollback means queryId. A value of 0 indicates requirement to judge whether the time point is valid.</p>
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// <p>During rollback, input the source cluster ID to search for the source poolId</p>
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// <p>Point-in-time rollback, specified time; snapshot rollback, snapshot time</p>
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// <p>This parameter is meaningless and abandoned.<br>Point-in-time rollback, allowed range of specified time.</p>
        /// </summary>
        [JsonProperty("ExpectTimeThresh")]
        public ulong? ExpectTimeThresh{ get; set; }

        /// <summary>
        /// <p>Ordinary instance storage cap, in GB<br>When DbType is MYSQL and the storage billing mode is prepaid, this parameter should not exceed the maximum storage specification corresponding to cpu and memory.</p>
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// <p>Annual and monthly subscription duration</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Annual and monthly subscription duration unit, ['s', 'd', 'm', 'y']</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Whether Annual/Monthly Subscription is auto-renewed</p><p>Enumeration value:</p><ul><li>0: Default renewal method</li><li>1: Auto-renewal</li><li>2: No auto-renewal</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>Whether to automatically select voucher 1 Yes 0 No Default value: 0</p><p>Enumeration value:</p><ul><li>1: Yes</li><li>0: No</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>Instance count (this parameter is deprecated and only for existing accommodative)</p>
        /// </summary>
        [JsonProperty("HaCount")]
        public long? HaCount{ get; set; }

        /// <summary>
        /// <p>Order source</p>
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// <p>tag Array info that should be bound for cluster creation</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Db type</p><p>Enumeration value:</p><ul><li>NORMAL: NORMAL instance</li><li>SERVERLESS: SERVERLESS instance</li></ul><p>Default value: NORMAL</p><p>Selectable when DbType is MYSQL (default NORMAL)</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is SERVERLESS<br>Minimum value of cpu. For optional range, see API response of DescribeServerlessInstanceSpecs</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is SERVERLESS:<br>Maximum value of cpu. For optional range, see API response of DescribeServerlessInstanceSpecs.</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>No auto pause</p><p>Enumeration value:</p><ul><li>yes: Yes</li><li>no: No</li></ul><p>Default value: yes</p><p>Take effect when DbMode is SERVERLESS</p>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// <p>When DbMode is SERVERLESS, specify the delay for Cluster Auto-Pause in seconds. Optional range: [600,691200]<br>Default value: 600</p>
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// <p>The storage billing mode of the cluster. Pay-As-You-Go: 0, Monthly Subscription: 1. Default is Pay-As-You-Go.<br>When DbType is MYSQL and the compute billing mode of the cluster is postpaid (including DbMode as SERVERLESS), the storage billing mode can only be Pay-As-You-Go.<br>Rollback and clone do not support Monthly Subscription storage.</p>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// <p>Security group id array</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Alarm policy Id array</p>
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }

        /// <summary>
        /// <p>Parameter array, temporarily supports character_set_server (utf8|latin1|gbk|utf8mb4), lower_case_table_names, 1-case-insensitive, 0-case-sensitive</p>
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// <p>Transaction mode</p><p>Enumeration value:</p><ul><li>0: Place order and pay</li><li>1: Place order</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// <p>Parameter template ID. The parameter template ID can be obtained through querying parameter template information DescribeParamTemplates.</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Multi-AZ address</p>
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// <p>Instance initialization configuration information is mainly used to select different specification instances during cluster purchase.</p>
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public InstanceInitInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// <p>Global database unique ID</p>
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// <p>Database proxy configuration</p>
        /// </summary>
        [JsonProperty("ProxyConfig")]
        public ProxyConfig ProxyConfig{ get; set; }

        /// <summary>
        /// <p>Auto archive or not</p><p>Enumeration value:</p><ul><li>yes: Yes</li><li>no: No</li></ul><p>Default value: no</p><p>This parameter takes effect only when the primary instance of the current cluster is SERVERLESS</p>
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// <p>Archiving processing time after pausing</p><p>Measurement unit: hour</p><p>Default value: 12</p><p>This parameter takes effect only when the primary instance of the current cluster is SERVERLESS.</p>
        /// </summary>
        [JsonProperty("AutoArchiveDelayHours")]
        public long? AutoArchiveDelayHours{ get; set; }

        /// <summary>
        /// <p>Cluster level, optional. Example: P0, P1. (This field can be ignored)</p>
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// <p>Kernel minor version</p>
        /// </summary>
        [JsonProperty("CynosVersion")]
        public string CynosVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "RollbackId", this.RollbackId);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "ExpectTimeThresh", this.ExpectTimeThresh);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "HaCount", this.HaCount);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyIds.", this.AlarmPolicyIds);
            this.SetParamArrayObj(map, prefix + "ClusterParams.", this.ClusterParams);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "SlaveZone", this.SlaveZone);
            this.SetParamArrayObj(map, prefix + "InstanceInitInfos.", this.InstanceInitInfos);
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
            this.SetParamObj(map, prefix + "ProxyConfig.", this.ProxyConfig);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
            this.SetParamSimple(map, prefix + "AutoArchiveDelayHours", this.AutoArchiveDelayHours);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamSimple(map, prefix + "CynosVersion", this.CynosVersion);
        }
    }
}


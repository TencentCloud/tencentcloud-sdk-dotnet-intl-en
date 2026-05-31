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

    public class RollbackToNewClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>AZ.</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>During rollback, input the source cluster ID to search for the source poolId</p>
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// <p>VPC network ID</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>Cluster name, length less than 64 characters. Each character value ranges from uppercase/lowercase letters, digits, to special symbols ('-', '_', '.').</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Snapshot rollback means snapshotId; point-in-time rollback means queryId. A value of 0 indicates requirement to judge whether the time point is valid.</p>
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// <p>Point-in-time rollback, specified time; snapshot rollback, snapshot time</p>
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// <p>Whether to automatically select a voucher. 1: Yes; 0: No. Default is 0.</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>tag Array information that should be bound for cluster creation</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>DB type<br>Selectable when DbType is MYSQL (default NORMAL):</p><li>NORMAL</li><li>SERVERLESS</li>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is SEVERLESS<br>Minimum value of cpu. For optional range, see API response of DescribeServerlessInstanceSpecs</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>Required when DbMode is SEVERLESS:<br>Maximum value of cpu. For the optional range, see the API response of DescribeServerlessInstanceSpecs.</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>When DbMode is SEVERLESS, whether to automatically pause within specified clusters. Optional range</p><li>yes</li><li>no</li>Default value: yes
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// <p>When DbMode is SEVERLESS, specify the delay for Cluster Auto-Pause in seconds, optional range [600,691200]<br>Default value: 600</p>
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

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
        /// <p>Parameter array, temporarily supports character_set_server (utf8|latin1|gbk|utf8mb4), lower_case_table_names, 1-case-insensitive, 0-case-sensitive.</p>
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// <p>Parameter template ID. The parameter template ID can be obtained through querying parameter template information DescribeParamTemplates.</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Instance initialization configuration information is mainly used to select different specification instances during cluster purchase.</p>
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public InstanceInitInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// <p>0-Place order and pay 1-Placing order</p>
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// <p>Pay-per-compute-node model: 0-Pay-As-You-Go, 1-Prepayment</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>Time</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>Unit</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>Rollback database info</p>
        /// </summary>
        [JsonProperty("RollbackDatabases")]
        public RollbackDatabase[] RollbackDatabases{ get; set; }

        /// <summary>
        /// <p>Roll back table information</p>
        /// </summary>
        [JsonProperty("RollbackTables")]
        public RollbackTable[] RollbackTables{ get; set; }

        /// <summary>
        /// <p>Original ro instance information</p>
        /// </summary>
        [JsonProperty("OriginalROInstanceList")]
        public string[] OriginalROInstanceList{ get; set; }

        /// <summary>
        /// <p>Project ID.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Whether to enable archive. Optional range <li>yes</li><li>no</li> Default value: yes</p>
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// <p>Whether to restore from the saved backup</p>
        /// </summary>
        [JsonProperty("FromSaveBackup")]
        public bool? FromSaveBackup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "RollbackId", this.RollbackId);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyIds.", this.AlarmPolicyIds);
            this.SetParamArrayObj(map, prefix + "ClusterParams.", this.ClusterParams);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamArrayObj(map, prefix + "InstanceInitInfos.", this.InstanceInitInfos);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamArrayObj(map, prefix + "RollbackDatabases.", this.RollbackDatabases);
            this.SetParamArrayObj(map, prefix + "RollbackTables.", this.RollbackTables);
            this.SetParamArraySimple(map, prefix + "OriginalROInstanceList.", this.OriginalROInstanceList);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoArchive", this.AutoArchive);
            this.SetParamSimple(map, prefix + "FromSaveBackup", this.FromSaveBackup);
        }
    }
}


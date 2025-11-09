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
        /// AZ.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// During rollback, pass in the source cluster ID to find the source pool ID.
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// VPC ID.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// The cluster name should contain fewer than 64 characters. Valid values for each character: uppercase/lowercase letters, digits, and special characters ('-', '_', and '.').
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Rolls back by snapshot, which indicates snapshotId; rolls back by time point, which indicates queryId. When the value of queryId is 0, it indicates that the validity of the time point needs to be verified.
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// Rolls back by time point, which indicates the specified time; rolls back by snapshot, which indicates the snapshot time.
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// Whether to select promo vouchers automatically. 1: yes; 0: no. The default value is 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Information about the tag array to be bound during cluster creation.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// Database type. When the value of DbType is MYSQL, the valid values are NORMAL and SERVERLESS (the default value is NORMAL).
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// This parameter is required when the value of DbMode is SEVERLESS. For the settings of the minimum CPU value, refer to the value returned by the DescribeServerlessInstanceSpecs API for the valid value.
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// This parameter is required when the value of DbMode is SEVERLESS. For the settings of the maximum CPU value, refer to the value returned by the DescribeServerlessInstanceSpecs API for the valid value.
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// Specifies whether the cluster is automatically paused when the value of DbMode is SEVERLESS. Valid values: yes; no. The default value is yes.
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// Specifies the delay for automatic cluster pause (in seconds) when the value of DbMode is SEVERLESS. Value range: [600, 691200]. The default value is 600.
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// Security group ID array.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Alarm policy ID array.
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }

        /// <summary>
        /// Parameter array. The character_set_server (utf8 | latin1 | gbk | utf8mb4) is currently supported. lower_case_table_names: 1 - case-insensitive; 0 - case-sensitive.
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// Parameter template ID, which can be obtained through the DescribeParamTemplates API.
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// Instance initialization configuration information, which is mainly used for selecting different instance specifications during cluster purchase.
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public InstanceInitInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// 0 - place an order and pay; 1 - place an order.
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// Compute node billing mode: 0 - pay-as-you-go; 1 - prepaid.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Time.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Unit.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Rollback database information.
        /// </summary>
        [JsonProperty("RollbackDatabases")]
        public RollbackDatabase[] RollbackDatabases{ get; set; }

        /// <summary>
        /// Rollback table information.
        /// </summary>
        [JsonProperty("RollbackTables")]
        public RollbackTable[] RollbackTables{ get; set; }

        /// <summary>
        /// Source read-only instance information.
        /// </summary>
        [JsonProperty("OriginalROInstanceList")]
        public string[] OriginalROInstanceList{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Whether to enable archiving. Valid values: yes; no. The default value is yes.
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }


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
        }
    }
}


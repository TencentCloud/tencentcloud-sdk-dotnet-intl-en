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

    public class CreateIntegrateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Specifies the ID of the VPC network it belongs to.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Database version. valid values:. 
        /// <li>Specifies the available values for MYSQL: 5.7, 8.0.</li>.
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Cluster name, length less than 64 characters. each character value ranges from uppercase/lowercase letters, digits, special symbols ('-','_','.').
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Account password (8-64 characters, a combination of uppercase and lowercase letters, digits and symbols ~!@#$%^&*_-+=`|\(){}[]:;'<>,.?/ with any three types).
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// Port, default 3306, in the range of [0, 65535).
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Billing mode. 0: pay-as-you-go; 1: monthly subscription. default is pay-as-you-go.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Number of clusters to purchase. value range: [1,3]. default is 1.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// Maximum storage limit of a regular instance, in GB.
        /// When DbType is MYSQL and the storage billing mode is prepaid, this parameter should not exceed the maximum storage specification corresponding to cpu and memory.
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// Specifies the annual and monthly subscription duration.
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// Specifies the measurement unit for annual and monthly subscription duration. valid values: 's', 'd', 'm', 'y'.
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// Whether annual/monthly subscription is auto-renewed. default value is 0.
        /// 0 identifies the default renewal method, 1 means auto-renew, 2 indicates no auto-renewal.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Whether to automatically select a voucher. 1: yes; 0: no. default value: 0.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// Specifies the tag array information that needs to be bound during cluster creation.
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// Specifies the cluster storage billing mode. 0: pay-as-you-go; 1: monthly subscription. default is pay-as-you-go.
        /// When DbType is MYSQL and the cluster billing mode for computing is postpaid (including DbMode as SERVERLESS), the storage billing mode can only be pay-as-you-go.
        /// Rollback and clone do not support monthly subscription storage.
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// Security group id array.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Specifies the Alarm policy Id array.
        /// </summary>
        [JsonProperty("AlarmPolicyIds")]
        public string[] AlarmPolicyIds{ get; set; }

        /// <summary>
        /// Parameter array, temporarily supports character_set_server (utf8|latin1|gbk|utf8mb4), lower_case_table_names. valid values: 1 (case-insensitive), 0 (case-sensitive).
        /// </summary>
        [JsonProperty("ClusterParams")]
        public ParamItem[] ClusterParams{ get; set; }

        /// <summary>
        /// Transaction mode. valid values: 0 (place order and pay), 1 (place order).
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// Parameter template ID. can be obtained through querying parameter template information DescribeParamTemplates.
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// Multi-AZ address.
        /// </summary>
        [JsonProperty("SlaveZone")]
        public string SlaveZone{ get; set; }

        /// <summary>
        /// Initializes configuration information, mainly used to purchase clusters with different specification instances.
        /// </summary>
        [JsonProperty("InstanceInitInfos")]
        public IntegrateInstanceInfo[] InstanceInitInfos{ get; set; }

        /// <summary>
        /// Global database unique identifier.
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// Database proxy configuration.
        /// </summary>
        [JsonProperty("ProxyConfig")]
        public ProxyConfigInfo ProxyConfig{ get; set; }

        /// <summary>
        /// Specifies whether to automatically archive.
        /// </summary>
        [JsonProperty("AutoArchive")]
        public string AutoArchive{ get; set; }

        /// <summary>
        /// Processing time after pausing.
        /// </summary>
        [JsonProperty("AutoArchiveDelayHours")]
        public long? AutoArchiveDelayHours{ get; set; }

        /// <summary>
        /// Encryption method (consists of encryption algorithm and key pair version).
        /// </summary>
        [JsonProperty("EncryptMethod")]
        public string EncryptMethod{ get; set; }

        /// <summary>
        /// Describes the cluster configuration information.
        /// </summary>
        [JsonProperty("IntegrateCreateClusterConfig")]
        public IntegrateCreateClusterConfig IntegrateCreateClusterConfig{ get; set; }

        /// <summary>
        /// Storage architecture type. valid values: 1.0/2.0. default value: 1.0.
        /// </summary>
        [JsonProperty("StorageVersion")]
        public string StorageVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
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
            this.SetParamSimple(map, prefix + "EncryptMethod", this.EncryptMethod);
            this.SetParamObj(map, prefix + "IntegrateCreateClusterConfig.", this.IntegrateCreateClusterConfig);
            this.SetParamSimple(map, prefix + "StorageVersion", this.StorageVersion);
        }
    }
}


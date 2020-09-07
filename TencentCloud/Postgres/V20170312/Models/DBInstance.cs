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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DBInstance : AbstractModel
    {
        
        /// <summary>
        /// Instance region such as ap-guangzhou, which corresponds to the `Region` field of `RegionSet`
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Instance AZ such as ap-guangzhou-3, which corresponds to the `Zone` field of `ZoneSet`
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// SubnetId
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("DBInstanceName")]
        public string DBInstanceName{ get; set; }

        /// <summary>
        /// Instance status
        /// </summary>
        [JsonProperty("DBInstanceStatus")]
        public string DBInstanceStatus{ get; set; }

        /// <summary>
        /// Assigned instance memory size in GB
        /// </summary>
        [JsonProperty("DBInstanceMemory")]
        public ulong? DBInstanceMemory{ get; set; }

        /// <summary>
        /// Assigned instance storage capacity in GB
        /// </summary>
        [JsonProperty("DBInstanceStorage")]
        public ulong? DBInstanceStorage{ get; set; }

        /// <summary>
        /// Number of assigned CPUs
        /// </summary>
        [JsonProperty("DBInstanceCpu")]
        public ulong? DBInstanceCpu{ get; set; }

        /// <summary>
        /// Purchasable specification ID
        /// </summary>
        [JsonProperty("DBInstanceClass")]
        public string DBInstanceClass{ get; set; }

        /// <summary>
        /// Instance type. 1: primary (master instance), 2: readonly (read-only instance), 3: guard (disaster recovery instance), 4: temp (temp instance)
        /// </summary>
        [JsonProperty("DBInstanceType")]
        public string DBInstanceType{ get; set; }

        /// <summary>
        /// Instance edition. Currently, only `standard` edition (dual-server high-availability one-master-one-slave edition) is supported
        /// </summary>
        [JsonProperty("DBInstanceVersion")]
        public string DBInstanceVersion{ get; set; }

        /// <summary>
        /// Instance database character set
        /// </summary>
        [JsonProperty("DBCharset")]
        public string DBCharset{ get; set; }

        /// <summary>
        /// PostgreSQL kernel version
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// Instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Instance last modified time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Instance expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Instance isolation time
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// Billing mode. postpaid: pay-as-you-go
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// Whether to renew automatically. 1: yes, 0: no
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// Instance network connection information
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public DBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// Machine type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SupportIpv6")]
        public ulong? SupportIpv6{ get; set; }

        /// <summary>
        /// The information of tags associated with instances.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "DBInstanceName", this.DBInstanceName);
            this.SetParamSimple(map, prefix + "DBInstanceStatus", this.DBInstanceStatus);
            this.SetParamSimple(map, prefix + "DBInstanceMemory", this.DBInstanceMemory);
            this.SetParamSimple(map, prefix + "DBInstanceStorage", this.DBInstanceStorage);
            this.SetParamSimple(map, prefix + "DBInstanceCpu", this.DBInstanceCpu);
            this.SetParamSimple(map, prefix + "DBInstanceClass", this.DBInstanceClass);
            this.SetParamSimple(map, prefix + "DBInstanceType", this.DBInstanceType);
            this.SetParamSimple(map, prefix + "DBInstanceVersion", this.DBInstanceVersion);
            this.SetParamSimple(map, prefix + "DBCharset", this.DBCharset);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "SupportIpv6", this.SupportIpv6);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}


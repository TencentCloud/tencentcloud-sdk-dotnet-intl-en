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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndpointItem : AbstractModel
    {
        
        /// <summary>
        /// Region of the source database. If AccessType is ccn, please fill in the region where vpc is located because the region of the source database is unknown. For other access methods, please fill in the region where the subscription task is located, as ensuring the subscription task and the source database are in the same region is the optimal network solution.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseRegion")]
        public string DatabaseRegion{ get; set; }

        /// <summary>
        /// UsernameNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Password. It is required when used as an input parameter and empty when used as an output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Target instance ID. This field is required when AccessType is cdb. When configuring the InstanceId, the instance information is queried and checked. The mysql query interface has been authenticated. Please ensure that the sub-user has the cdb:DescribeDBInstances interface permission.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Cloud Virtual Machine ID. This field is required when AccessType is cvm.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CvmInstanceId")]
        public string CvmInstanceId{ get; set; }

        /// <summary>
        /// Direct Connect gateway ID. This field is required when AccessType is dcg.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqDcgId")]
        public string UniqDcgId{ get; set; }

        /// <summary>
        /// Cloud Connect Network ID. This field is required when AccessType is ccn.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// VPN gateway ID. This field is required when AccessType is vpncloud.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UniqVpnGwId")]
        public string UniqVpnGwId{ get; set; }

        /// <summary>
        /// VpcID. This field is required when AccessType is dcg\ccn\vpncloud\vpc.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID. This field is required when AccessType is dcg\ccn\vpncloud\vpc.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Database address, supports domain name and IP. This field is required when AccessType is dcg\ccn\vpncloud\vpc\extranet\intranet.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Database port. This field is required when AccessType is dcg\ccn\vpncloud\vpc\extranet\intranet\cvm.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// Whether to use encrypted transmission. Valid values: UnEncrypted; Encrypted. Only mysql supports it. If it is not filled in, it will not be encrypted by default. Other products do not need to fill in this.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EncryptConn")]
        public string EncryptConn{ get; set; }

        /// <summary>
        /// Database network environment. This field is required when AccessType is ccn. Valid values: UserIDC; TencentVPC; Aws; AliYun; Others.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseNetEnv")]
        public string DatabaseNetEnv{ get; set; }

        /// <summary>
        /// The UIN of the main account to which the Cloud Connect Network gateway belongs. It is required for cross-account CCN.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CcnOwnerUin")]
        public string CcnOwnerUin{ get; set; }

        /// <summary>
        /// Additional information added for the business. Parameter name is called key, parameter value is called value. Mandatory parameters for tdpg: PgDatabase (subscribed database name).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtraAttr")]
        public KeyValuePairOption[] ExtraAttr{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ChildInstanceId")]
        public string ChildInstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ChildInstanceType")]
        public string ChildInstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseRegion", this.DatabaseRegion);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CvmInstanceId", this.CvmInstanceId);
            this.SetParamSimple(map, prefix + "UniqDcgId", this.UniqDcgId);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "UniqVpnGwId", this.UniqVpnGwId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "EncryptConn", this.EncryptConn);
            this.SetParamSimple(map, prefix + "DatabaseNetEnv", this.DatabaseNetEnv);
            this.SetParamSimple(map, prefix + "CcnOwnerUin", this.CcnOwnerUin);
            this.SetParamArrayObj(map, prefix + "ExtraAttr.", this.ExtraAttr);
            this.SetParamSimple(map, prefix + "ChildInstanceId", this.ChildInstanceId);
            this.SetParamSimple(map, prefix + "ChildInstanceType", this.ChildInstanceType);
        }
    }
}


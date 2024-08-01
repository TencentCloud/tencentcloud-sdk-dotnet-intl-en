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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkConnection : AbstractModel
    {
        
        /// <summary>
        /// Network configuration ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Unique identifier of network configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssociateId")]
        public string AssociateId{ get; set; }

        /// <summary>
        /// Computing engine ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HouseId")]
        public string HouseId{ get; set; }

        /// <summary>
        /// Data source ID (discarded)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionId")]
        public string DatasourceConnectionId{ get; set; }

        /// <summary>
        /// Network configuration status (0 - initializing; 1 - normal)
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Modification time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Create user Appid.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Appid")]
        public long? Appid{ get; set; }

        /// <summary>
        /// Computing engine name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HouseName")]
        public string HouseName{ get; set; }

        /// <summary>
        /// Network configuration name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionName")]
        public string DatasourceConnectionName{ get; set; }

        /// <summary>
        /// Network configuration type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkConnectionType")]
        public long? NetworkConnectionType{ get; set; }

        /// <summary>
        /// Create user UIN.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Create user SubAccountUin.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// Network configuration description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkConnectionDesc")]
        public string NetworkConnectionDesc{ get; set; }

        /// <summary>
        /// Data source vpcid
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionVpcId")]
        public string DatasourceConnectionVpcId{ get; set; }

        /// <summary>
        /// Data source SubnetId
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionSubnetId")]
        public string DatasourceConnectionSubnetId{ get; set; }

        /// <summary>
        /// Data source SubnetId
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionCidrBlock")]
        public string DatasourceConnectionCidrBlock{ get; set; }

        /// <summary>
        /// Data source SubnetCidrBlock
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatasourceConnectionSubnetCidrBlock")]
        public string DatasourceConnectionSubnetCidrBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AssociateId", this.AssociateId);
            this.SetParamSimple(map, prefix + "HouseId", this.HouseId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionId", this.DatasourceConnectionId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "HouseName", this.HouseName);
            this.SetParamSimple(map, prefix + "DatasourceConnectionName", this.DatasourceConnectionName);
            this.SetParamSimple(map, prefix + "NetworkConnectionType", this.NetworkConnectionType);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "NetworkConnectionDesc", this.NetworkConnectionDesc);
            this.SetParamSimple(map, prefix + "DatasourceConnectionVpcId", this.DatasourceConnectionVpcId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionSubnetId", this.DatasourceConnectionSubnetId);
            this.SetParamSimple(map, prefix + "DatasourceConnectionCidrBlock", this.DatasourceConnectionCidrBlock);
            this.SetParamSimple(map, prefix + "DatasourceConnectionSubnetCidrBlock", this.DatasourceConnectionSubnetCidrBlock);
        }
    }
}


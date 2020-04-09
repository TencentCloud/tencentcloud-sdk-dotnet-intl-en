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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpnGateway : AbstractModel
    {
        
        /// <summary>
        /// Gateway instance ID.
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Gateway instance name.
        /// </summary>
        [JsonProperty("VpnGatewayName")]
        public string VpnGatewayName{ get; set; }

        /// <summary>
        /// Gateway instance type. Valid values: 'IPSEC', 'SSL', and 'CCN'.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Gateway instance status. 'PENDING': Creating; 'DELETING': Deleting; 'AVAILABLE': Running.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Gateway public IP.
        /// </summary>
        [JsonProperty("PublicIpAddress")]
        public string PublicIpAddress{ get; set; }

        /// <summary>
        /// Gateway renewal type: 'NOTIFY_AND_MANUAL_RENEW': Manual renewal. 'NOTIFY_AND_AUTO_RENEW': Automatic renewal. 'NOT_NOTIFY_AND_NOT_RENEW': No renewal after expiration.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Gateway billing type: POSTPAID_BY_HOUR: Postpaid by hour; PREPAID: Prepaid.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Outbound bandwidth of gateway.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Expiration time of the prepaid gateway.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Whether the public IP is blocked.
        /// </summary>
        [JsonProperty("IsAddressBlocked")]
        public bool? IsAddressBlocked{ get; set; }

        /// <summary>
        /// Change of billing method. PREPAID_TO_POSTPAID: Monthly subscription prepaid to postpaid by hour.
        /// </summary>
        [JsonProperty("NewPurchasePlan")]
        public string NewPurchasePlan{ get; set; }

        /// <summary>
        /// Gateway billing status. PROTECTIVELY_ISOLATED: Instance is isolated; NORMAL: Normal.
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// The availability zone, such as `ap-guangzhou-2`
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Gateway bandwidth quota information.
        /// </summary>
        [JsonProperty("VpnGatewayQuotaSet")]
        public VpnGatewayQuota[] VpnGatewayQuotaSet{ get; set; }

        /// <summary>
        /// Gateway instance version.
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// CCN instance ID when the value of Type is CCN.
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpnGatewayName", this.VpnGatewayName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PublicIpAddress", this.PublicIpAddress);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IsAddressBlocked", this.IsAddressBlocked);
            this.SetParamSimple(map, prefix + "NewPurchasePlan", this.NewPurchasePlan);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "VpnGatewayQuotaSet.", this.VpnGatewayQuotaSet);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
        }
    }
}


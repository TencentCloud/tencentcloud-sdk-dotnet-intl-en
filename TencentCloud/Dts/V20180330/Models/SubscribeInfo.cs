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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubscribeInfo : AbstractModel
    {
        
        /// <summary>
        /// Data subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Data subscription instance name
        /// </summary>
        [JsonProperty("SubscribeName")]
        public string SubscribeName{ get; set; }

        /// <summary>
        /// ID of channel bound to data subscription instance
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Name of product bound to data subscription instance
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// ID of database instance bound to data subscription instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Status of database instance bound to data subscription instance
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Data subscription instance configuration status. Valid values: unconfigure, configuring, configured
        /// </summary>
        [JsonProperty("SubsStatus")]
        public string SubsStatus{ get; set; }

        /// <summary>
        /// Last modified time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Isolation time
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Deactivation time
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// Last modified consumption starting time point. If it has never been modified, this field is 0
        /// </summary>
        [JsonProperty("ConsumeStartTime")]
        public string ConsumeStartTime{ get; set; }

        /// <summary>
        /// Data subscription instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Billing mode. 1: pay-as-you-go
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Data subscription instance VIP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Data subscription instance Vport
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// Unique ID of the VPC where the data subscription instance VIP resides
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Unique ID of the subnet where the data subscription instance VIP resides
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Data subscription instance status. Valid values: creating, normal, isolating, isolated, offlining, offline
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Timestamp of the last message confirmed by the SDK. If the SDK keeps consuming, this field can also be used as the current consumption time point of the SDK
        /// </summary>
        [JsonProperty("SdkConsumedTime")]
        public string SdkConsumedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeName", this.SubscribeName);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SubsStatus", this.SubsStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "ConsumeStartTime", this.ConsumeStartTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SdkConsumedTime", this.SdkConsumedTime);
        }
    }
}


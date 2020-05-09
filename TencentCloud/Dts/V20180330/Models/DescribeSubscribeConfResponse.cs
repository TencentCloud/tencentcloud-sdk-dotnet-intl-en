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

    public class DescribeSubscribeConfResponse : AbstractModel
    {
        
        /// <summary>
        /// Subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Subscription instance name
        /// </summary>
        [JsonProperty("SubscribeName")]
        public string SubscribeName{ get; set; }

        /// <summary>
        /// Subscription channel
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Subscribed database type
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Subscribed instance
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Subscribed instance status. Valid values: running, offline, isolate
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// Subscription instance status. Valid values: unconfigure, configuring, configured
        /// </summary>
        [JsonProperty("SubsStatus")]
        public string SubsStatus{ get; set; }

        /// <summary>
        /// Subscription instance lifecycle status. Valid values: normal, isolating, isolated, offlining
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Subscription instance creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Subscription instance isolation time
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// Subscription instance expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Subscription instance deactivation time
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// Consumption starting time point of subscription instance
        /// </summary>
        [JsonProperty("ConsumeStartTime")]
        public string ConsumeStartTime{ get; set; }

        /// <summary>
        /// Subscription instance billing mode. 1: hourly billing
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Subscription channel VIP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Subscription channel port
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// Subscription channel `VpcId`
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// Subscription channel `SubnetId`
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// Current SDK consumption time point
        /// </summary>
        [JsonProperty("SdkConsumedTime")]
        public string SdkConsumedTime{ get; set; }

        /// <summary>
        /// Subscription SDK IP address
        /// </summary>
        [JsonProperty("SdkHost")]
        public string SdkHost{ get; set; }

        /// <summary>
        /// Subscription object type. 0: full instance subscription, 1: DDL data subscription, 2: DML structure subscription, 3: DDL data subscription + DML structure subscription
        /// </summary>
        [JsonProperty("SubscribeObjectType")]
        public long? SubscribeObjectType{ get; set; }

        /// <summary>
        /// Subscription object, which is an empty array if `SubscribeObjectType` is 0
        /// </summary>
        [JsonProperty("SubscribeObjects")]
        public SubscribeObject[] SubscribeObjects{ get; set; }

        /// <summary>
        /// Modification time
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeName", this.SubscribeName);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "SubsStatus", this.SubsStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "ConsumeStartTime", this.ConsumeStartTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "SdkConsumedTime", this.SdkConsumedTime);
            this.SetParamSimple(map, prefix + "SdkHost", this.SdkHost);
            this.SetParamSimple(map, prefix + "SubscribeObjectType", this.SubscribeObjectType);
            this.SetParamArrayObj(map, prefix + "SubscribeObjects.", this.SubscribeObjects);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


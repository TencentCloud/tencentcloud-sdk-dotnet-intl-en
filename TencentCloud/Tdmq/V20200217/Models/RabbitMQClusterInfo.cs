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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Creation time in milliseconds. unix timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Cluster description information
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Vpcs")]
        public VpcEndpointInfo[] Vpcs{ get; set; }

        /// <summary>
        /// AZ information
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VirtualHostNumber")]
        public long? VirtualHostNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("QueueNumber")]
        public long? QueueNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MessagePublishRate")]
        public float? MessagePublishRate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MessageStackNumber")]
        public long? MessageStackNumber{ get; set; }

        /// <summary>
        /// Specifies the instance expiration time in milliseconds as a unix timestamp. the value is 0 for pay-as-you-go resources.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ChannelNumber")]
        public long? ChannelNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConnectionNumber")]
        public long? ConnectionNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConsumerNumber")]
        public long? ConsumerNumber{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExchangeNumber")]
        public long? ExchangeNumber{ get; set; }

        /// <summary>
        /// Cluster exception information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExceptionInformation")]
        public string ExceptionInformation{ get; set; }

        /// <summary>
        /// Instance status. 0: creating; 1: normal; 2: isolating; 3: terminated; 4: abnormal; 5: delivery failed.
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// Auto-renewal flag. 0 indicates the default status (If the default status is not configured, manual renewal is enabled), 1 indicates auto-renewal, and 2 indicates explicitly no auto-renewal (configured by the user).
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Whether the image queue policy is enabled. 1: enabled; 0: disabled.
        /// </summary>
        [JsonProperty("MirrorQueuePolicyFlag")]
        public long? MirrorQueuePolicyFlag{ get; set; }

        /// <summary>
        /// Number of messages consumed per second. Unit: messages/second.
        /// </summary>
        [JsonProperty("MessageConsumeRate")]
        public float? MessageConsumeRate{ get; set; }

        /// <summary>
        /// Cluster version information.
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Billing mode. 0: postpaid; 1: prepaid.
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Instance type. 0: Exclusive Edition; 1: Serverless Edition.
        /// </summary>
        [JsonProperty("InstanceType")]
        public ulong? InstanceType{ get; set; }

        /// <summary>
        /// Specifies the isolation time started. unix timestamp.
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public long? IsolatedTime{ get; set; }

        /// <summary>
        /// Whether it is a container instance. default true.
        /// </summary>
        [JsonProperty("Container")]
        public bool? Container{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether deletion protection is enabled.
        /// </summary>
        [JsonProperty("EnableDeletionProtection")]
        public bool? EnableDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Vpcs.", this.Vpcs);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "VirtualHostNumber", this.VirtualHostNumber);
            this.SetParamSimple(map, prefix + "QueueNumber", this.QueueNumber);
            this.SetParamSimple(map, prefix + "MessagePublishRate", this.MessagePublishRate);
            this.SetParamSimple(map, prefix + "MessageStackNumber", this.MessageStackNumber);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChannelNumber", this.ChannelNumber);
            this.SetParamSimple(map, prefix + "ConnectionNumber", this.ConnectionNumber);
            this.SetParamSimple(map, prefix + "ConsumerNumber", this.ConsumerNumber);
            this.SetParamSimple(map, prefix + "ExchangeNumber", this.ExchangeNumber);
            this.SetParamSimple(map, prefix + "ExceptionInformation", this.ExceptionInformation);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "MirrorQueuePolicyFlag", this.MirrorQueuePolicyFlag);
            this.SetParamSimple(map, prefix + "MessageConsumeRate", this.MessageConsumeRate);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "Container", this.Container);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "EnableDeletionProtection", this.EnableDeletionProtection);
        }
    }
}


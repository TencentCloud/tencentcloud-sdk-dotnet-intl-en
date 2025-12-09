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

    public class RabbitMQQueueListInfo : AbstractModel
    {
        
        /// <summary>
        /// Queue name
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Remarks
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Consumer information.
        /// </summary>
        [JsonProperty("ConsumerDetail")]
        public RabbitMQQueueListConsumerDetailInfo ConsumerDetail{ get; set; }

        /// <summary>
        /// Queue type. Valid values: "classic" and "quorum".
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// Number of retained messages
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageHeapCount")]
        public long? MessageHeapCount{ get; set; }

        /// <summary>
        /// Message production rate per second.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageRateIn")]
        public float? MessageRateIn{ get; set; }

        /// <summary>
        /// Message consumption rate per second.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageRateOut")]
        public float? MessageRateOut{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modification time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Whether the queue is durable. true: durable; false: non-durable.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Whether automatic deletion is set for the queue. true: automatic deletion set; false: automatic deletion not set.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Instance ID of the queue.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Vhost name of the queue.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Primary node name of the queue.
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// Indicates the name of the effective policy.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Extended parameters of the key-value object type.
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }

        /// <summary>
        /// Whether the queue is exclusive.
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool? Exclusive{ get; set; }

        /// <summary>
        /// Creation time timestamp.
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// Modification time timestamp.
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "ConsumerDetail.", this.ConsumerDetail);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "MessageHeapCount", this.MessageHeapCount);
            this.SetParamSimple(map, prefix + "MessageRateIn", this.MessageRateIn);
            this.SetParamSimple(map, prefix + "MessageRateOut", this.MessageRateOut);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Node", this.Node);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Arguments", this.Arguments);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}


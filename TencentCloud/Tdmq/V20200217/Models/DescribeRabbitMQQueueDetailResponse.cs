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

    public class DescribeRabbitMQQueueDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Vhost parameter.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Queue type. Valid values: classic and quorum.
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// The number of online consumers.
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Consumers")]
        public long? Consumers{ get; set; }

        /// <summary>
        /// Durable queue flag.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Automatic cleanup.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Remarks
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Messagettl parameter, specific to classic type.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageTTL")]
        public long? MessageTTL{ get; set; }

        /// <summary>
        /// Autoexpire parameter.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoExpire")]
        public long? AutoExpire{ get; set; }

        /// <summary>
        /// The maxlength parameter specifies the maximum length.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// The maxlengthbytes parameter specifies the maximum length in bytes.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxLengthBytes")]
        public long? MaxLengthBytes{ get; set; }

        /// <summary>
        /// The deliverylimit parameter is used for quorum type.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeliveryLimit")]
        public long? DeliveryLimit{ get; set; }

        /// <summary>
        /// The overflowbehaviour parameter specifies the behavior when overflow occurs. Valid values: drop-head, reject-publish, reject-publish-dlx.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OverflowBehaviour")]
        public string OverflowBehaviour{ get; set; }

        /// <summary>
        /// The deadletterexchange parameter specifies the dead letter exchange.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// The deadletterroutingkey parameter specifies the routing key for dead letters. Valid values: [value1, value2, value3].
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }

        /// <summary>
        /// The singleactiveconsumer parameter indicates whether only one consumer can be active at a time. Valid values: [true, false].
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SingleActiveConsumer")]
        public bool? SingleActiveConsumer{ get; set; }

        /// <summary>
        /// The maximumpriority parameter, for classic type only, specifies the maximum priority level. Value range: 1-30.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaximumPriority")]
        public long? MaximumPriority{ get; set; }

        /// <summary>
        /// The lazymode parameter, for classic type only, indicates whether lazy mode is enabled. Valid values: [true, false].
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LazyMode")]
        public bool? LazyMode{ get; set; }

        /// <summary>
        /// The masterlocator parameter, for classic type only, specifies the master locator strategy. Valid values: [strategy1, strategy2, strategy3].
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MasterLocator")]
        public string MasterLocator{ get; set; }

        /// <summary>
        /// The maxinmemorylength parameter, specific to quorum type.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxInMemoryLength")]
        public long? MaxInMemoryLength{ get; set; }

        /// <summary>
        /// The maxinmemorybytes parameter, specific to quorum type.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxInMemoryBytes")]
        public long? MaxInMemoryBytes{ get; set; }

        /// <summary>
        /// Creation timestamp. Unit: seconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Node
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// Quorum queue dead letter consistency policy.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterStrategy")]
        public string DeadLetterStrategy{ get; set; }

        /// <summary>
        /// Leader election policy for quorum queue.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueueLeaderLocator")]
        public string QueueLeaderLocator{ get; set; }

        /// <summary>
        /// Initial replica group size of arbitration queue.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QuorumInitialGroupSize")]
        public long? QuorumInitialGroupSize{ get; set; }

        /// <summary>
        /// Whether the queue is an exclusive queue.
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool? Exclusive{ get; set; }

        /// <summary>
        /// Effective policy name.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Extended parameters of the key-value type.
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// Modification timestamp.
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "Consumers", this.Consumers);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MessageTTL", this.MessageTTL);
            this.SetParamSimple(map, prefix + "AutoExpire", this.AutoExpire);
            this.SetParamSimple(map, prefix + "MaxLength", this.MaxLength);
            this.SetParamSimple(map, prefix + "MaxLengthBytes", this.MaxLengthBytes);
            this.SetParamSimple(map, prefix + "DeliveryLimit", this.DeliveryLimit);
            this.SetParamSimple(map, prefix + "OverflowBehaviour", this.OverflowBehaviour);
            this.SetParamSimple(map, prefix + "DeadLetterExchange", this.DeadLetterExchange);
            this.SetParamSimple(map, prefix + "DeadLetterRoutingKey", this.DeadLetterRoutingKey);
            this.SetParamSimple(map, prefix + "SingleActiveConsumer", this.SingleActiveConsumer);
            this.SetParamSimple(map, prefix + "MaximumPriority", this.MaximumPriority);
            this.SetParamSimple(map, prefix + "LazyMode", this.LazyMode);
            this.SetParamSimple(map, prefix + "MasterLocator", this.MasterLocator);
            this.SetParamSimple(map, prefix + "MaxInMemoryLength", this.MaxInMemoryLength);
            this.SetParamSimple(map, prefix + "MaxInMemoryBytes", this.MaxInMemoryBytes);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Node", this.Node);
            this.SetParamSimple(map, prefix + "DeadLetterStrategy", this.DeadLetterStrategy);
            this.SetParamSimple(map, prefix + "QueueLeaderLocator", this.QueueLeaderLocator);
            this.SetParamSimple(map, prefix + "QuorumInitialGroupSize", this.QuorumInitialGroupSize);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Arguments", this.Arguments);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


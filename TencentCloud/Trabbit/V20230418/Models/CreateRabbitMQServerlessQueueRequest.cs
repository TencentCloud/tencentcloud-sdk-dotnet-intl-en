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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQServerlessQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VHost parameter.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Supports only classic.
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// Durable flag. specifies that for the classic type, it must be passed in. for the quorum type, there is no need to pass it in and it is fixed as true.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Automatic cleanup. the classic type must be passed. the quorum type does not need to be passed and is fixed as false.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// The MessageTTL parameter specifies settings dedicated to the classic type.
        /// </summary>
        [JsonProperty("MessageTTL")]
        public long? MessageTTL{ get; set; }

        /// <summary>
        /// The AutoExpire parameter, in milliseconds, indicates that the queue will be deleted if it is not used within a specified time.
        /// </summary>
        [JsonProperty("AutoExpire")]
        public long? AutoExpire{ get; set; }

        /// <summary>
        /// MaxLength parameter. specifies the maximum number of entries the queue can hold. if the limit is exceeded, it will be handled according to the overview behavior.
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// The MaxLengthBytes parameter specifies the maximum length in bytes. if the value exceeds the limit, it will be handled according to the overview behavior.
        /// </summary>
        [JsonProperty("MaxLengthBytes")]
        public long? MaxLengthBytes{ get; set; }

        /// <summary>
        /// DeliveryLimit parameter. specifies the parameter dedicated to the quorum type.
        /// </summary>
        [JsonProperty("DeliveryLimit")]
        public long? DeliveryLimit{ get; set; }

        /// <summary>
        /// OverflowBehaviour parameter specifies a value of drop-head, reject-publish, or reject-publish-dlx.
        /// </summary>
        [JsonProperty("OverflowBehaviour")]
        public string OverflowBehaviour{ get; set; }

        /// <summary>
        /// The DeadLetterExchange parameter specifies that expired or rejected messages can be routed to a designated dead letter exchange.
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// The DeadLetterRoutingKey parameter specifies that it can only contain letters, digits, ".", "-", "@", and "_".
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }

        /// <summary>
        /// The SingleActiveConsumer parameter. if enabled, ensure that there is only one consumer consuming from the queue every time.
        /// </summary>
        [JsonProperty("SingleActiveConsumer")]
        public bool? SingleActiveConsumer{ get; set; }

        /// <summary>
        /// MaximumPriority parameter. specifies that it is dedicated for the classic type.
        /// </summary>
        [JsonProperty("MaximumPriority")]
        public long? MaximumPriority{ get; set; }

        /// <summary>
        /// LazyMode parameter. specifies that it is dedicated for the classic type.
        /// </summary>
        [JsonProperty("LazyMode")]
        public bool? LazyMode{ get; set; }

        /// <summary>
        /// The MasterLocator parameter, dedicated to the classic type, specifies a value of min-masters, client-local, or random.
        /// </summary>
        [JsonProperty("MasterLocator")]
        public string MasterLocator{ get; set; }

        /// <summary>
        /// MaxInMemoryLength parameter, dedicated for quorum type. specifies the maximum number of messages in memory for quorum queues.
        /// </summary>
        [JsonProperty("MaxInMemoryLength")]
        public long? MaxInMemoryLength{ get; set; }

        /// <summary>
        /// The MaxInMemoryBytes parameter is dedicated to the quorum type. it specifies the maximum total message size in memory for quorum queues.
        /// </summary>
        [JsonProperty("MaxInMemoryBytes")]
        public long? MaxInMemoryBytes{ get; set; }

        /// <summary>
        /// Node parameter. optional. specifies the node where the specified creation queue is located.
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// Consistency policy for dead-letter in arbitrating queues. specifies valid values: at-most-once, at-least-once. at-most-once is selected by default.
        /// </summary>
        [JsonProperty("DeadLetterStrategy")]
        public string DeadLetterStrategy{ get; set; }

        /// <summary>
        /// Specifies the leader election strategy for the arbitration queue. valid values are client-local and balanced. the default value is client-local.
        /// </summary>
        [JsonProperty("QueueLeaderLocator")]
        public string QueueLeaderLocator{ get; set; }

        /// <summary>
        /// Specifies the initial replica group size of the arbitration queue. the default value is 3.
        /// </summary>
        [JsonProperty("QuorumInitialGroupSize")]
        public long? QuorumInitialGroupSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
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
            this.SetParamSimple(map, prefix + "Node", this.Node);
            this.SetParamSimple(map, prefix + "DeadLetterStrategy", this.DeadLetterStrategy);
            this.SetParamSimple(map, prefix + "QueueLeaderLocator", this.QueueLeaderLocator);
            this.SetParamSimple(map, prefix + "QuorumInitialGroupSize", this.QuorumInitialGroupSize);
        }
    }
}


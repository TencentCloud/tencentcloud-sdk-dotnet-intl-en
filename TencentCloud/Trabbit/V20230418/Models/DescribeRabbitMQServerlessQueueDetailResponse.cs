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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRabbitMQServerlessQueueDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
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
        /// Specifies the queue type. the valid values are classic or quorum.
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// Number of online consumers.
        /// </summary>
        [JsonProperty("Consumers")]
        public long? Consumers{ get; set; }

        /// <summary>
        /// Durable flag.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Automatic cleanup.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// MessageTTL parameter, dedicated for classic type.
        /// </summary>
        [JsonProperty("MessageTTL")]
        public long? MessageTTL{ get; set; }

        /// <summary>
        /// AutoExpire parameter.
        /// </summary>
        [JsonProperty("AutoExpire")]
        public long? AutoExpire{ get; set; }

        /// <summary>
        /// MaxLength parameter.
        /// </summary>
        [JsonProperty("MaxLength")]
        public long? MaxLength{ get; set; }

        /// <summary>
        /// MaxLengthBytes parameter.
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
        /// DeadLetterExchange parameter.
        /// </summary>
        [JsonProperty("DeadLetterExchange")]
        public string DeadLetterExchange{ get; set; }

        /// <summary>
        /// The DeadLetterRoutingKey parameter.
        /// </summary>
        [JsonProperty("DeadLetterRoutingKey")]
        public string DeadLetterRoutingKey{ get; set; }

        /// <summary>
        /// SingleActiveConsumer parameter.
        /// </summary>
        [JsonProperty("SingleActiveConsumer")]
        public bool? SingleActiveConsumer{ get; set; }

        /// <summary>
        /// MaximumPriority parameter. specifies that it is dedicated for the classic type.
        /// </summary>
        [JsonProperty("MaximumPriority")]
        public long? MaximumPriority{ get; set; }

        /// <summary>
        /// LazyMode parameter, dedicated for classic type.
        /// </summary>
        [JsonProperty("LazyMode")]
        public bool? LazyMode{ get; set; }

        /// <summary>
        /// MasterLocator parameter, dedicated for classic type.
        /// </summary>
        [JsonProperty("MasterLocator")]
        public string MasterLocator{ get; set; }

        /// <summary>
        /// MaxInMemoryLength parameter, dedicated for quorum type.
        /// </summary>
        [JsonProperty("MaxInMemoryLength")]
        public long? MaxInMemoryLength{ get; set; }

        /// <summary>
        /// The MaxInMemoryBytes parameter is dedicated to the quorum type.
        /// </summary>
        [JsonProperty("MaxInMemoryBytes")]
        public long? MaxInMemoryBytes{ get; set; }

        /// <summary>
        /// Create timestamp, in seconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Node.
        /// </summary>
        [JsonProperty("Node")]
        public string Node{ get; set; }

        /// <summary>
        /// Arbitration queue dead letter consistency policy.
        /// </summary>
        [JsonProperty("DeadLetterStrategy")]
        public string DeadLetterStrategy{ get; set; }

        /// <summary>
        /// Leadership election policy for arbitration queue.
        /// </summary>
        [JsonProperty("QueueLeaderLocator")]
        public string QueueLeaderLocator{ get; set; }

        /// <summary>
        /// Specifies the initial replica group size of the arbitration queue.
        /// </summary>
        [JsonProperty("QuorumInitialGroupSize")]
        public long? QuorumInitialGroupSize{ get; set; }

        /// <summary>
        /// Whether it is an exclusive queue.
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool? Exclusive{ get; set; }

        /// <summary>
        /// The name of the policy that takes effect.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Additional parameters key-value.
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }

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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


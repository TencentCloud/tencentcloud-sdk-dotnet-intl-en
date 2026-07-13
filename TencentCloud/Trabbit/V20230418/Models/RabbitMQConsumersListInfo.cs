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

    public class RabbitMQConsumersListInfo : AbstractModel
    {
        
        /// <summary>
        /// Client Ip.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// Consumer Tag.
        /// </summary>
        [JsonProperty("ConsumerTag")]
        public string ConsumerTag{ get; set; }

        /// <summary>
        /// Consume target queue
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Whether required for the consumer to manually ack
        /// </summary>
        [JsonProperty("AckRequired")]
        public bool? AckRequired{ get; set; }

        /// <summary>
        /// Consumer qos value
        /// </summary>
        [JsonProperty("PrefetchCount")]
        public ulong? PrefetchCount{ get; set; }

        /// <summary>
        /// Consumer status
        /// </summary>
        [JsonProperty("Active")]
        public string Active{ get; set; }

        /// <summary>
        /// Time of the last message submission
        /// </summary>
        [JsonProperty("LastDeliveredTime")]
        public string LastDeliveredTime{ get; set; }

        /// <summary>
        /// Number of unconfirmed messages of the consumer
        /// </summary>
        [JsonProperty("UnAckMsgCount")]
        public long? UnAckMsgCount{ get; set; }

        /// <summary>
        /// channel belonging to the consumer
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ConsumerTag", this.ConsumerTag);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "AckRequired", this.AckRequired);
            this.SetParamSimple(map, prefix + "PrefetchCount", this.PrefetchCount);
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "LastDeliveredTime", this.LastDeliveredTime);
            this.SetParamSimple(map, prefix + "UnAckMsgCount", this.UnAckMsgCount);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
        }
    }
}


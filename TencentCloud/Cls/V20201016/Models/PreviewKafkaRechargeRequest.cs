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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PreviewKafkaRechargeRequest : AbstractModel
    {
        
        /// <summary>
        /// Preview type. 1: preview of source data; 2: preview of exported results.
        /// </summary>
        [JsonProperty("PreviewType")]
        public ulong? PreviewType{ get; set; }

        /// <summary>
        /// Import Kafka type. 0: Tencent Cloud CKafka; 1: user-built kafka.
        /// </summary>
        [JsonProperty("KafkaType")]
        public ulong? KafkaType{ get; set; }

        /// <summary>
        /// List of Kafka-related topics to be imported by the user, topics separated by commas.
        /// Supports up to 100.
        /// </summary>
        [JsonProperty("UserKafkaTopics")]
        public string UserKafkaTopics{ get; set; }

        /// <summary>
        /// Import data location. -2: earliest; -1: latest.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Tencent Cloud CKafka instance ID. The parameter KafkaInstance is valid and required when KafkaType is 0.
        /// -Get the instance id through [Get Instance List](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("KafkaInstance")]
        public string KafkaInstance{ get; set; }

        /// <summary>
        /// Service address.
        /// When KafkaType is 1, ServerAddr is required.
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// Whether ServerAddr is a secure connection.
        /// Valid when KafkaType is 1.
        /// </summary>
        [JsonProperty("IsEncryptionAddr")]
        public bool? IsEncryptionAddr{ get; set; }

        /// <summary>
        /// Encrypted Access Protocol.
        /// When KafkaType is 1 and IsEncryptionAddr is true, Protocol is required.
        /// </summary>
        [JsonProperty("Protocol")]
        public KafkaProtocolInfo Protocol{ get; set; }

        /// <summary>
        /// User Kafka consumer group.
        /// 
        /// -A consumption group is a scalable and fault-tolerant consumer mechanism provided by Kafka. Multiple consumers exist in a consumption group, and all consumers in the group consume subscribed data of messages in the Topic. A consumer can consume multiple partitions simultaneously, but one Partition can only be consumed by a single consumer in the group.
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// Log import rule
        /// </summary>
        [JsonProperty("LogRechargeRule")]
        public LogRechargeRuleInfo LogRechargeRule{ get; set; }

        /// <summary>
        /// User kafka extended information
        /// </summary>
        [JsonProperty("UserKafkaMeta")]
        public UserKafkaMeta UserKafkaMeta{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PreviewType", this.PreviewType);
            this.SetParamSimple(map, prefix + "KafkaType", this.KafkaType);
            this.SetParamSimple(map, prefix + "UserKafkaTopics", this.UserKafkaTopics);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "KafkaInstance", this.KafkaInstance);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "IsEncryptionAddr", this.IsEncryptionAddr);
            this.SetParamObj(map, prefix + "Protocol.", this.Protocol);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamObj(map, prefix + "LogRechargeRule.", this.LogRechargeRule);
            this.SetParamObj(map, prefix + "UserKafkaMeta.", this.UserKafkaMeta);
        }
    }
}


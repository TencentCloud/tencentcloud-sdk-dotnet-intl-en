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

    public class CheckRechargeKafkaServerRequest : AbstractModel
    {
        
        /// <summary>
        /// Import Kafka type. 0: Tencent Cloud CKafka; 1: user-built kafka.
        /// </summary>
        [JsonProperty("KafkaType")]
        public ulong? KafkaType{ get; set; }

        /// <summary>
        /// Tencent Cloud CKafka instance ID.
        /// When KafkaType is 0, KafkaInstance is required
        /// 
        /// - Obtain the instance id by searching the instance list information (https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("KafkaInstance")]
        public string KafkaInstance{ get; set; }

        /// <summary>
        /// Service AddressWhen KafkaType is 1, ServerAddr is required
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// Whether ServerAddr is an encrypted connection. The default value is false. It is valid when KafkaType is 1, indicating a user self-built Kafka.
        /// </summary>
        [JsonProperty("IsEncryptionAddr")]
        public bool? IsEncryptionAddr{ get; set; }

        /// <summary>
        /// Encrypted access protocol. It is required when the parameter KafkaType is 1 and the parameter IsEncryptionAddr is true.
        /// </summary>
        [JsonProperty("Protocol")]
        public KafkaProtocolInfo Protocol{ get; set; }

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
            this.SetParamSimple(map, prefix + "KafkaType", this.KafkaType);
            this.SetParamSimple(map, prefix + "KafkaInstance", this.KafkaInstance);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "IsEncryptionAddr", this.IsEncryptionAddr);
            this.SetParamObj(map, prefix + "Protocol.", this.Protocol);
            this.SetParamObj(map, prefix + "UserKafkaMeta.", this.UserKafkaMeta);
        }
    }
}


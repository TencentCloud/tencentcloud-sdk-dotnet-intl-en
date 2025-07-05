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

    public class ModifyKafkaConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// Log Topic ID
        /// </summary>
        [JsonProperty("FromTopicId")]
        public string FromTopicId{ get; set; }

        /// <summary>
        /// Compression mode [0: NONE; 2: SNAPPY; 3: LZ4]
        /// </summary>
        [JsonProperty("Compression")]
        public long? Compression{ get; set; }

        /// <summary>
        /// Kafka protocol consumer data format
        /// </summary>
        [JsonProperty("ConsumerContent")]
        public KafkaConsumerContent ConsumerContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromTopicId", this.FromTopicId);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamObj(map, prefix + "ConsumerContent.", this.ConsumerContent);
        }
    }
}


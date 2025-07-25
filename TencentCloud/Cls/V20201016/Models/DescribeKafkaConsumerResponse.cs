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

    public class DescribeKafkaConsumerResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether Kafka Protocol Consumption is enabled
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Topic Parameter used by KafkaConsumer during consumption
        /// </summary>
        [JsonProperty("TopicID")]
        public string TopicID{ get; set; }

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
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TopicID", this.TopicID);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamObj(map, prefix + "ConsumerContent.", this.ConsumerContent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


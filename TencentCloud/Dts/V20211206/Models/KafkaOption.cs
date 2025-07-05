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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaOption : AbstractModel
    {
        
        /// <summary>
        /// Data type delivered to Kafka, such as Avro, Json, canal-pb, canal-json
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// Topic sync policy, such as `Single` (deliver all data to a single topic), `Multi` (deliver data to multiple custom topics).
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// Topic for DDL storage
        /// </summary>
        [JsonProperty("DDLTopicName")]
        public string DDLTopicName{ get; set; }

        /// <summary>
        /// Topic description
        /// </summary>
        [JsonProperty("TopicRules")]
        public TopicRule[] TopicRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "DDLTopicName", this.DDLTopicName);
            this.SetParamArrayObj(map, prefix + "TopicRules.", this.TopicRules);
        }
    }
}


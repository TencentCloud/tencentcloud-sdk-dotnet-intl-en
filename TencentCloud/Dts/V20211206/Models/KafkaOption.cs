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
        /// <p>Data type delivered to kafka, such as Avro, Json, canal-pb, canal-Json, debezium</p>
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// <p>Synchronize topic policies, for example, Single (Deliver to a single topic), Multi (Custom topic name)</p>
        /// </summary>
        [JsonProperty("TopicType")]
        public string TopicType{ get; set; }

        /// <summary>
        /// <p>topic used to store ddl</p>
        /// </summary>
        [JsonProperty("DDLTopicName")]
        public string DDLTopicName{ get; set; }

        /// <summary>
        /// <p>Description of single topic and custom topic</p>
        /// </summary>
        [JsonProperty("TopicRules")]
        public TopicRule[] TopicRules{ get; set; }

        /// <summary>
        /// <p>Additional information, for specific data types, additional parameters can be set. For example, for Canal-compatible feature support: "canalOfficialFormat":"on" means to enable the Canal-compatible feature, not included by default. For large message skipping feature support: "skipLargeMessage":"on" means to enable skipping large messages, not included by default; when enabled, "maxMessageSizeMB" must be simultaneously set to a positive integer string from 1 to 100, representing the max message size threshold (MB), messages exceeding this size will be skipped, not included by default.</p>
        /// </summary>
        [JsonProperty("DataOption")]
        public KeyValuePairOption[] DataOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "DDLTopicName", this.DDLTopicName);
            this.SetParamArrayObj(map, prefix + "TopicRules.", this.TopicRules);
            this.SetParamArrayObj(map, prefix + "DataOption.", this.DataOption);
        }
    }
}


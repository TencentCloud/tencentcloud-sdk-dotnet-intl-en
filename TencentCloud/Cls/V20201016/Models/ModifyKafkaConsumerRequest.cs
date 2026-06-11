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
        /// <p>log topic id</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">Get Log Topic List</a>.</li><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56456?from_cn_redirect=1">Create Log Topic</a>.</li></ul>
        /// </summary>
        [JsonProperty("FromTopicId")]
        public string FromTopicId{ get; set; }

        /// <summary>
        /// <p>Compression mode. 0: No compression; 2: Use Snappy compression; 3: Use LZ4 compression</p>
        /// </summary>
        [JsonProperty("Compression")]
        public long? Compression{ get; set; }

        /// <summary>
        /// <p>kafka protocol consumption data format</p>
        /// </summary>
        [JsonProperty("ConsumerContent")]
        public KafkaConsumerContent ConsumerContent{ get; set; }

        /// <summary>
        /// <p>Whether to enable the delivery service log. 1: Disabled, 2: Enabled.</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>Range type of consumption, 0: latest, 1: history + latest</p>
        /// </summary>
        [JsonProperty("ScopeType")]
        public ulong? ScopeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FromTopicId", this.FromTopicId);
            this.SetParamSimple(map, prefix + "Compression", this.Compression);
            this.SetParamObj(map, prefix + "ConsumerContent.", this.ConsumerContent);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
        }
    }
}


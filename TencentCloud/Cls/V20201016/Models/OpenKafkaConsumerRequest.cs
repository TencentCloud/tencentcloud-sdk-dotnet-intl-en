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

    public class OpenKafkaConsumerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Log topic Id.</p><ul><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1">obtaining the log topic list</a>.</li><li>Obtain the log topic Id through <a href="https://www.tencentcloud.com/document/product/614/56456?from_cn_redirect=1">creating a log topic</a>.</li></ul>
        /// </summary>
        [JsonProperty("FromTopicId")]
        public string FromTopicId{ get; set; }

        /// <summary>
        /// <p>Compression type [0: NONE; 2: SNAPPY; 3: LZ4]. Default value: 0</p>
        /// </summary>
        [JsonProperty("Compression")]
        public long? Compression{ get; set; }

        /// <summary>
        /// <p>kafka consumption data format</p>
        /// </summary>
        [JsonProperty("ConsumerContent")]
        public KafkaConsumerContent ConsumerContent{ get; set; }

        /// <summary>
        /// <p>Whether to enable the delivery service log. 1: Disabled; 2: Enabled. Default value: 2</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>Public network consumption switch. Enabled by default</p>
        /// </summary>
        [JsonProperty("EnableInternetConsume")]
        public bool? EnableInternetConsume{ get; set; }

        /// <summary>
        /// <p>Private network consumption switch. Enabled by default</p>
        /// </summary>
        [JsonProperty("EnableIntranetConsume")]
        public bool? EnableIntranetConsume{ get; set; }

        /// <summary>
        /// <p>Consumption scope type. 0: Latest; 1: Historical + latest. Default value: 0</p>
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
            this.SetParamSimple(map, prefix + "EnableInternetConsume", this.EnableInternetConsume);
            this.SetParamSimple(map, prefix + "EnableIntranetConsume", this.EnableIntranetConsume);
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
        }
    }
}


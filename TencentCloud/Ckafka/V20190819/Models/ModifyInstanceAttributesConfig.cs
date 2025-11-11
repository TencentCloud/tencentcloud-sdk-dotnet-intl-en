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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAttributesConfig : AbstractModel
    {
        
        /// <summary>
        /// Automatic creation. true: enabled, false: not enabled
        /// </summary>
        [JsonProperty("AutoCreateTopicEnable")]
        public bool? AutoCreateTopicEnable{ get; set; }

        /// <summary>
        /// Default number of partitions for a newly created topic. if AutoCreateTopicEnable is set to true and no value is set, defaults to 3.
        /// </summary>
        [JsonProperty("DefaultNumPartitions")]
        public long? DefaultNumPartitions{ get; set; }

        /// <summary>
        /// Default number of replicas for a newly created topic. if AutoCreateTopicEnable is set to true and not specified, defaults to 2.
        /// </summary>
        [JsonProperty("DefaultReplicationFactor")]
        public long? DefaultReplicationFactor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoCreateTopicEnable", this.AutoCreateTopicEnable);
            this.SetParamSimple(map, prefix + "DefaultNumPartitions", this.DefaultNumPartitions);
            this.SetParamSimple(map, prefix + "DefaultReplicationFactor", this.DefaultReplicationFactor);
        }
    }
}


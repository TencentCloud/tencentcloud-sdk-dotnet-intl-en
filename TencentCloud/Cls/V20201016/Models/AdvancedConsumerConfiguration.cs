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

    public class AdvancedConsumerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// Kafka partition hash status. Default false.
        /// 
        /// -true: Enable sending messages with equal field Hash values to the same Kafka partition.
        /// -false: Disable sending messages with equivalent field Hash values to the same kafka partition.
        /// </summary>
        [JsonProperty("PartitionHashStatus")]
        public bool? PartitionHashStatus{ get; set; }

        /// <summary>
        /// Field list to calculate hash. Supports a maximum of 5 fields.
        /// </summary>
        [JsonProperty("PartitionFields")]
        public string[] PartitionFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionHashStatus", this.PartitionHashStatus);
            this.SetParamArraySimple(map, prefix + "PartitionFields.", this.PartitionFields);
        }
    }
}


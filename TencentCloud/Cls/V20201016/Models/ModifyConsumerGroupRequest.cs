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

    public class ModifyConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Consumer group flag to be updated.
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// Consumer heartbeat timeout (seconds).
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// List of log topics included in the updated consumer group.
        /// </summary>
        [JsonProperty("Topics")]
        public string[] Topics{ get; set; }

        /// <summary>
        /// Logset ID (the logset to which a log topic belongs).
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamArraySimple(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
        }
    }
}


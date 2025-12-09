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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CmqDeadLetterPolicy : AbstractModel
    {
        
        /// <summary>
        /// Dead letter queue.
        /// </summary>
        [JsonProperty("DeadLetterQueue")]
        public string DeadLetterQueue{ get; set; }

        /// <summary>
        /// Dead letter queue policy. 0: maximum number of receipt. 1: maximum unconsumed time.
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy{ get; set; }

        /// <summary>
        /// Maximum unconsumed expiration time. Required if policy is 1. Range: 300-43,200 seconds, must be less than the maximum message retention time MsgRetentionSeconds.
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive{ get; set; }

        /// <summary>
        /// Maximum number of receipt. required when Policy is 0. value range: 1 to 1000.
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeadLetterQueue", this.DeadLetterQueue);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "MaxTimeToLive", this.MaxTimeToLive);
            this.SetParamSimple(map, prefix + "MaxReceiveCount", this.MaxReceiveCount);
        }
    }
}


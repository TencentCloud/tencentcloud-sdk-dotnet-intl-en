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

    public class RocketMQMessageTrack : AbstractModel
    {
        
        /// <summary>
        /// Consumer group
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Consumption status.
        /// CONSUMED.
        /// CONSUMED BUT FILTERED.
        /// NOT_CONSUME: specifies unconsumed.
        /// ENTER_RETRY: specifies whether to enter the retry queue.
        /// ENTER_DLQ: specifies whether the message enters the dead letter queue.
        /// Consumption status UNKNOWN.
        /// </summary>
        [JsonProperty("ConsumeStatus")]
        public string ConsumeStatus{ get; set; }

        /// <summary>
        /// Message trace type
        /// </summary>
        [JsonProperty("TrackType")]
        public string TrackType{ get; set; }

        /// <summary>
        /// Exception information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExceptionDesc")]
        public string ExceptionDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "ConsumeStatus", this.ConsumeStatus);
            this.SetParamSimple(map, prefix + "TrackType", this.TrackType);
            this.SetParamSimple(map, prefix + "ExceptionDesc", this.ExceptionDesc);
        }
    }
}


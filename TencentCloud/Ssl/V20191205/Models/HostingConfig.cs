/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostingConfig : AbstractModel
    {
        
        /// <summary>
        /// Hosted resource replacement time, defaults to 30 days before the certificate expiration if there is a renewal certificate, then replace.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReplaceTime")]
        public long? ReplaceTime{ get; set; }

        /// <summary>
        /// Hosted send message type: 0, reminder message before hosted starts (you will receive this reminder message even if there is no renewal certificate); 1, reminder message when hosted starts (you will receive the message reminder only if there is a renewal certificate); 2, reminder message when hosted resource replacement fails; 3 reminder message when hosted resource replacement succeeds.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageTypes")]
        public long?[] MessageTypes{ get; set; }

        /// <summary>
        /// Resource replacement start time.
        /// </summary>
        [JsonProperty("ReplaceStartTime")]
        public string ReplaceStartTime{ get; set; }

        /// <summary>
        /// Resource replacement end time.
        /// </summary>
        [JsonProperty("ReplaceEndTime")]
        public string ReplaceEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReplaceTime", this.ReplaceTime);
            this.SetParamArraySimple(map, prefix + "MessageTypes.", this.MessageTypes);
            this.SetParamSimple(map, prefix + "ReplaceStartTime", this.ReplaceStartTime);
            this.SetParamSimple(map, prefix + "ReplaceEndTime", this.ReplaceEndTime);
        }
    }
}


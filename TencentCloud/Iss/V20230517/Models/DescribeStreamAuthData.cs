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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamAuthData : AbstractModel
    {
        
        /// <summary>
        /// Authentication configuration ID (uuid).
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Whether to enable playback authentication. Valid values: `1`: enable, `0`: disable.
        /// </summary>
        [JsonProperty("PullState")]
        public long? PullState{ get; set; }

        /// <summary>
        /// Playback key (alphanumeric only, length: 0-10 characters)
        /// </summary>
        [JsonProperty("PullSecret")]
        public string PullSecret{ get; set; }

        /// <summary>
        /// Playback expiration time (unit: minute)
        /// </summary>
        [JsonProperty("PullExpired")]
        public long? PullExpired{ get; set; }

        /// <summary>
        /// Whether to enable stream authentication (1: enable, 0: disable)
        /// </summary>
        [JsonProperty("PushState")]
        public long? PushState{ get; set; }

        /// <summary>
        /// Stream key (alphanumeric only, length 0-10 characters)
        /// </summary>
        [JsonProperty("PushSecret")]
        public string PushSecret{ get; set; }

        /// <summary>
        /// Push expiration time (unit: minute)
        /// </summary>
        [JsonProperty("PushExpired")]
        public long? PushExpired{ get; set; }

        /// <summary>
        /// User ID.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PullState", this.PullState);
            this.SetParamSimple(map, prefix + "PullSecret", this.PullSecret);
            this.SetParamSimple(map, prefix + "PullExpired", this.PullExpired);
            this.SetParamSimple(map, prefix + "PushState", this.PushState);
            this.SetParamSimple(map, prefix + "PushSecret", this.PushSecret);
            this.SetParamSimple(map, prefix + "PushExpired", this.PushExpired);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}


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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DelayInfo : AbstractModel
    {
        
        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Push path, which is the same as the 
        ///  `AppName` in push and playback addresses and is `live` by default.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Delay time in seconds.
        /// </summary>
        [JsonProperty("DelayInterval")]
        public ulong? DelayInterval{ get; set; }

        /// <summary>
        /// Creation time in UTC time.
        /// Note: the difference between UTC time and Beijing time is 8 hours.
        /// Example: 2019-06-18T12:00:00Z (i.e., June 18, 2019 20:00:00 Beijing time).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Expiration time in UTC time.
        /// Note: the difference between UTC time and Beijing time is 8 hours.
        /// Example: 2019-06-18T12:00:00Z (i.e., June 18, 2019 20:00:00 Beijing time).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Current status:
        /// -1: expired.
        /// 1: in effect.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "DelayInterval", this.DelayInterval);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


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

    public class AddDelayLiveStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// Push path, which is the same as the `AppName` in push and playback addresses and is `live` by default.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Push domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Stream name.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Delay time in seconds, up to 600s.
        /// </summary>
        [JsonProperty("DelayTime")]
        public ulong? DelayTime{ get; set; }

        /// <summary>
        /// Expiration time of the configured delayed playback in UTC format, such as 2018-11-29T19:00:00Z.
        /// Notes:
        /// 1. The configuration will expire after 7 days by default and can last up to 7 days.
        /// 2. The Beijing time is in UTC+8. This value should be in the format as required by ISO 8601. For more information, please see [ISO Date and Time Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}


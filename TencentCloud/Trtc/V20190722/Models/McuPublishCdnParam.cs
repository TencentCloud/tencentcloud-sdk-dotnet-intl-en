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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuPublishCdnParam : AbstractModel
    {
        
        /// <summary>
        /// The URLs of the CDNs to relay to.
        /// </summary>
        [JsonProperty("PublishCdnUrl")]
        public string PublishCdnUrl{ get; set; }

        /// <summary>
        /// Whether to relay to Tencent Cloud’s CDN. 0 (default): Third-party CDN; 1: Tencent Cloud’s CDN. Note: Relaying to a third-party CDN will incur fees. If you are relaying to Tencent Cloud’s CDN, to avoid incurring fees, be sure to set this parameter to `1`. For details, see the API document.
        /// </summary>
        [JsonProperty("IsTencentCdn")]
        public ulong? IsTencentCdn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublishCdnUrl", this.PublishCdnUrl);
            this.SetParamSimple(map, prefix + "IsTencentCdn", this.IsTencentCdn);
        }
    }
}


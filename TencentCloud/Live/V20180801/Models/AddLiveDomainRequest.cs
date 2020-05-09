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

    public class AddLiveDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Domain name type.
        /// 0: push domain name.
        /// 1: playback domain name.
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// Pull domain name type:
        /// 1: Mainland China.
        /// 2: global.
        /// 3: outside Mainland China.
        /// Default value: 1.
        /// </summary>
        [JsonProperty("PlayType")]
        public ulong? PlayType{ get; set; }

        /// <summary>
        /// Whether it is LCB:
        /// 0: LVB,
        /// 1: LCB.
        /// Default value: 0.
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }

        /// <summary>
        /// Whether it is LVB on Mini Program.
        /// 0: LVB.
        /// 1: LVB on Mini Program.
        /// Default value: 0.
        /// </summary>
        [JsonProperty("IsMiniProgramLive")]
        public long? IsMiniProgramLive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DomainType", this.DomainType);
            this.SetParamSimple(map, prefix + "PlayType", this.PlayType);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamSimple(map, prefix + "IsMiniProgramLive", this.IsMiniProgramLive);
        }
    }
}


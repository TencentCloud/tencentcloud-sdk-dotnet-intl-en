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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// LVB domain name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Domain name type:
        /// 0: push.
        /// 1: playback.
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Domain name status:
        /// 0: deactivated.
        /// 1: activated.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether there is a CNAME record pointing to a fixed rule domain name:
        /// 0: no.
        /// 1: yes.
        /// </summary>
        [JsonProperty("BCName")]
        public ulong? BCName{ get; set; }

        /// <summary>
        /// Domain name corresponding to CNAME record.
        /// </summary>
        [JsonProperty("TargetDomain")]
        public string TargetDomain{ get; set; }

        /// <summary>
        /// Playback region. This parameter is valid only if `Type` is 1.
        /// 1: in Mainland China.
        /// 2: global.
        /// 3: outside Mainland China.
        /// </summary>
        [JsonProperty("PlayType")]
        public long? PlayType{ get; set; }

        /// <summary>
        /// Whether it is LCB:
        /// 0: LVB.
        /// 1: LCB.
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public long? IsDelayLive{ get; set; }

        /// <summary>
        /// Information of currently used CNAME record.
        /// </summary>
        [JsonProperty("CurrentCName")]
        public string CurrentCName{ get; set; }

        /// <summary>
        /// Disused parameter, which can be ignored.
        /// </summary>
        [JsonProperty("RentTag")]
        public long? RentTag{ get; set; }

        /// <summary>
        /// Disused parameter, which can be ignored.
        /// </summary>
        [JsonProperty("RentExpireTime")]
        public string RentExpireTime{ get; set; }

        /// <summary>
        /// 0: LVB.
        /// 1: LVB on Mini Program.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsMiniProgramLive")]
        public long? IsMiniProgramLive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BCName", this.BCName);
            this.SetParamSimple(map, prefix + "TargetDomain", this.TargetDomain);
            this.SetParamSimple(map, prefix + "PlayType", this.PlayType);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamSimple(map, prefix + "CurrentCName", this.CurrentCName);
            this.SetParamSimple(map, prefix + "RentTag", this.RentTag);
            this.SetParamSimple(map, prefix + "RentExpireTime", this.RentExpireTime);
            this.SetParamSimple(map, prefix + "IsMiniProgramLive", this.IsMiniProgramLive);
        }
    }
}


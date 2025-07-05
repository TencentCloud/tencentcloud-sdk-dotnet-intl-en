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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyInternetAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// Mask length of a CIDR block
        /// </summary>
        [JsonProperty("MaskLen")]
        public long? MaskLen{ get; set; }

        /// <summary>
        /// Address type. Valid values: 0: BGP
        /// 1: China Telecom
        /// 2: China Mobile
        /// 3: China Unicom
        /// </summary>
        [JsonProperty("AddrType")]
        public long? AddrType{ get; set; }

        /// <summary>
        /// Address protocol. Valid values: 0: IPv4
        /// 1: IPv6
        /// </summary>
        [JsonProperty("AddrProto")]
        public long? AddrProto{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaskLen", this.MaskLen);
            this.SetParamSimple(map, prefix + "AddrType", this.AddrType);
            this.SetParamSimple(map, prefix + "AddrProto", this.AddrProto);
        }
    }
}


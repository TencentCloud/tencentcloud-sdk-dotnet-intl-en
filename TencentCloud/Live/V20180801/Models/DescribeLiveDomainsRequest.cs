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

    public class DescribeLiveDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter by domain name status. 0: disabled, 1: enabled.
        /// </summary>
        [JsonProperty("DomainStatus")]
        public ulong? DomainStatus{ get; set; }

        /// <summary>
        /// Filter by domain name type. 0: push. 1: playback
        /// </summary>
        [JsonProperty("DomainType")]
        public ulong? DomainType{ get; set; }

        /// <summary>
        /// Number of entries per page. Value range: 10-100. Default value: 10.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Page number to get. Value range: 1-100000. Default value: 1.
        /// </summary>
        [JsonProperty("PageNum")]
        public ulong? PageNum{ get; set; }

        /// <summary>
        /// 0: LVB, 1: LCB. Default value: 0.
        /// </summary>
        [JsonProperty("IsDelayLive")]
        public ulong? IsDelayLive{ get; set; }

        /// <summary>
        /// Domain name prefix.
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainStatus", this.DomainStatus);
            this.SetParamSimple(map, prefix + "DomainType", this.DomainType);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "IsDelayLive", this.IsDelayLive);
            this.SetParamSimple(map, prefix + "DomainPrefix", this.DomainPrefix);
        }
    }
}


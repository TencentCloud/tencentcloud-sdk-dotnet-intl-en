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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatFwInstance : AbstractModel
    {
        
        /// <summary>
        /// NAT instance ID
        /// </summary>
        [JsonProperty("NatinsId")]
        public string NatinsId{ get; set; }

        /// <summary>
        /// NAT instance name
        /// </summary>
        [JsonProperty("NatinsName")]
        public string NatinsName{ get; set; }

        /// <summary>
        /// Instance region
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 0: create new; 1: use existing
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// 0: normal; 1: creating
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// NAT public IP
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("NatIp")]
        public string NatIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatinsId", this.NatinsId);
            this.SetParamSimple(map, prefix + "NatinsName", this.NatinsName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "NatIp", this.NatIp);
        }
    }
}


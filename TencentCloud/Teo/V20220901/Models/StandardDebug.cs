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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandardDebug : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable standard debugging. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable </li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The client IP to allow. It can be an IPv4/IPv6 address or a CIDR block. If not specified, it means to allow any client IP
        /// </summary>
        [JsonProperty("AllowClientIPList")]
        public string[] AllowClientIPList{ get; set; }

        /// <summary>
        /// The time when the standard debugging setting expires. If it is exceeded, this feature becomes invalid.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "AllowClientIPList.", this.AllowClientIPList);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}


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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpUnBlockData : AbstractModel
    {
        
        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Blocked time
        /// </summary>
        [JsonProperty("BlockTime")]
        public string BlockTime{ get; set; }

        /// <summary>
        /// Unblocked time (actual)
        /// </summary>
        [JsonProperty("UnBlockTime")]
        public string UnBlockTime{ get; set; }

        /// <summary>
        /// Type of the unblocking action (`user`: self-service unblocking, `auto`: automatic unblocking, `update`: unblocking by service upgrading, `bind`: unblocking by binding Anti-DDoS Pro instance)
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "BlockTime", this.BlockTime);
            this.SetParamSimple(map, prefix + "UnBlockTime", this.UnBlockTime);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}


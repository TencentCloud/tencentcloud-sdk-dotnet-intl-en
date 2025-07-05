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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoOpenProVersionConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Set the auto-activation status.
        /// <li>CLOSE: off</li>
        /// <li>OPEN: on</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Automatic purchase/expansion authorization switch, 1 by default, 0 for OFF, 1 for ON.
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public ulong? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// Auto-renewal or not for auto-purchased orders, 0 by default, 0 for OFF, 1 for ON
        /// </summary>
        [JsonProperty("AutoRepurchaseRenewSwitch")]
        public ulong? AutoRepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// Whether the manually purchased order is automatically renewed (defaults to 0): 0 - off; 1 - on
        /// </summary>
        [JsonProperty("RepurchaseRenewSwitch")]
        public ulong? RepurchaseRenewSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "AutoRepurchaseRenewSwitch", this.AutoRepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "RepurchaseRenewSwitch", this.RepurchaseRenewSwitch);
        }
    }
}


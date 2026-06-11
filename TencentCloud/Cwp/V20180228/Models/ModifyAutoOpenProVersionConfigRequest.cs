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
        /// Strengthen protection mode
        /// PROVERSION_POSTPAY indicates the Pro Edition pay-as-you-go mode.
        /// PROVERSION_PREPAY Professional Edition - Subscription
        /// FLAGSHIP_PREPAY Flagship Edition - Subscription
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

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
        /// Automatically add machines and bind rasp. 0: Turn off. 1: Turn on.
        /// </summary>
        [JsonProperty("AutoBindRaspSwitch")]
        public ulong? AutoBindRaspSwitch{ get; set; }

        /// <summary>
        /// Automatically add machines with rasp protection enabled, off by default. 0: Off, 1: On
        /// </summary>
        [JsonProperty("AutoOpenRaspSwitch")]
        public ulong? AutoOpenRaspSwitch{ get; set; }

        /// <summary>
        /// Automatic scaling down switch, 0 for off and 1 for on
        /// </summary>
        [JsonProperty("AutoDowngradeSwitch")]
        public ulong? AutoDowngradeSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "AutoRepurchaseRenewSwitch", this.AutoRepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "RepurchaseRenewSwitch", this.RepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "AutoBindRaspSwitch", this.AutoBindRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoOpenRaspSwitch", this.AutoOpenRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoDowngradeSwitch", this.AutoDowngradeSwitch);
        }
    }
}


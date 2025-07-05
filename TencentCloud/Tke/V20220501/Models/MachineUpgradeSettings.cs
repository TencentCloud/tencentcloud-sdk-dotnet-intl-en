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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MachineUpgradeSettings : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable automatic upgrade
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AutoUpgrade")]
        public bool? AutoUpgrade{ get; set; }

        /// <summary>
        /// Ops window
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UpgradeOptions")]
        public AutoUpgradeOptions UpgradeOptions{ get; set; }

        /// <summary>
        /// Upgrade item
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// Maximum number of nodes that cannot be upgraded during upgrade
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MaxUnavailable")]
        public IntOrString MaxUnavailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoUpgrade", this.AutoUpgrade);
            this.SetParamObj(map, prefix + "UpgradeOptions.", this.UpgradeOptions);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamObj(map, prefix + "MaxUnavailable.", this.MaxUnavailable);
        }
    }
}


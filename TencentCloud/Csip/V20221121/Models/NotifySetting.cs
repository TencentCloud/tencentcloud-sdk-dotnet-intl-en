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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotifySetting : AbstractModel
    {
        
        /// <summary>
        /// <p>Notification module</p><p>Enumeration values:</p><ul><li>AkSk: Cloud API Risk Governance</li><li>Alert: Alert Center</li><li>Agent: Client</li></ul>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>Notification settings mode</p><p>Enumeration values:</p><ul><li>0: Standard mode</li><li>1: Advanced mode</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// <p>Notification status</p><p>Enumeration values:</p><ul><li>0: notification off</li><li>1: notification on</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Notification start time</p><p>Parameter format: hh:mm:ss</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>Notification end time</p><p>Parameter format: hh:mm:ss</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Asset scope</p><p>Enumeration values:</p><ul><li>1: All hosts</li><li>2: Selected hosts</li><li>3: Select by tag</li></ul>
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// <p>Notification option</p><p>Enumeration values:</p><ul><li>CRITICAL: Alarm level: critical</li><li>HIGH: Alarm level: high risk</li><li>MEDIUM: Alarm level: medium risk</li><li>LOW: Alarm level: low risk</li><li>INFO: Alarm level: reminder</li><li>AGENT_UNINSTALL: Client uninstallation</li><li>AGENT_OFFLINE: Client offline</li></ul>
        /// </summary>
        [JsonProperty("Option")]
        public string[] Option{ get; set; }

        /// <summary>
        /// <p>Notification module (secondary module)</p>
        /// </summary>
        [JsonProperty("SubModule")]
        public string SubModule{ get; set; }

        /// <summary>
        /// <p>Handling status</p>
        /// </summary>
        [JsonProperty("Item")]
        public string[] Item{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "Option.", this.Option);
            this.SetParamSimple(map, prefix + "SubModule", this.SubModule);
            this.SetParamArraySimple(map, prefix + "Item.", this.Item);
        }
    }
}


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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceUpgradeProgressItem : AbstractModel
    {
        
        /// <summary>
        /// Node instance ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Task lifecycle
        /// process: running
        /// paused: stopped
        /// pausing: stopping
        /// done: completed
        /// timeout: timed out
        /// aborted: canceled
        /// pending: not started
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// Upgrade start time
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }

        /// <summary>
        /// Upgrade end time
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("EndAt")]
        public string EndAt{ get; set; }

        /// <summary>
        /// Check result before upgrading
        /// </summary>
        [JsonProperty("CheckResult")]
        public InstanceUpgradePreCheckResult CheckResult{ get; set; }

        /// <summary>
        /// Upgrade steps details
        /// </summary>
        [JsonProperty("Detail")]
        public TaskStepInfo[] Detail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
            this.SetParamSimple(map, prefix + "EndAt", this.EndAt);
            this.SetParamObj(map, prefix + "CheckResult.", this.CheckResult);
            this.SetParamArrayObj(map, prefix + "Detail.", this.Detail);
        }
    }
}


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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FailOverSettings : AbstractModel
    {
        
        /// <summary>
        /// ID of the backup input
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("SecondaryInputId")]
        public string SecondaryInputId{ get; set; }

        /// <summary>
        /// The wait time (ms) for triggering failover after the primary input becomes unavailable. Value range: [1000, 86400000]. Default value: `3000`
        /// </summary>
        [JsonProperty("LossThreshold")]
        public long? LossThreshold{ get; set; }

        /// <summary>
        /// Failover policy. Valid values: `CURRENT_PREFERRED` (default), `PRIMARY_PREFERRED`
        /// </summary>
        [JsonProperty("RecoverBehavior")]
        public string RecoverBehavior{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecondaryInputId", this.SecondaryInputId);
            this.SetParamSimple(map, prefix + "LossThreshold", this.LossThreshold);
            this.SetParamSimple(map, prefix + "RecoverBehavior", this.RecoverBehavior);
        }
    }
}


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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeShiftSettingsInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable time shifting. Valid values: `OPEN`; `CLOSE`
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Domain name bound for time shifting
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PlayDomain")]
        public string PlayDomain{ get; set; }

        /// <summary>
        /// Allowable time-shift period (s). Value range: [300, 2592000]. Default value: 300Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("StartoverWindow")]
        public long? StartoverWindow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PlayDomain", this.PlayDomain);
            this.SetParamSimple(map, prefix + "StartoverWindow", this.StartoverWindow);
        }
    }
}


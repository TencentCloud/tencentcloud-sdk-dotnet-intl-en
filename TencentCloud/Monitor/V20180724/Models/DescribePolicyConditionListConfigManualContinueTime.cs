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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyConditionListConfigManualContinueTime : AbstractModel
    {
        
        /// <summary>
        /// Default duration in seconds.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Default")]
        public long? Default{ get; set; }

        /// <summary>
        /// Custom durations in seconds.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Keys")]
        public long?[] Keys{ get; set; }

        /// <summary>
        /// Required or not.
        /// </summary>
        [JsonProperty("Need")]
        public bool? Need{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "Need", this.Need);
        }
    }
}


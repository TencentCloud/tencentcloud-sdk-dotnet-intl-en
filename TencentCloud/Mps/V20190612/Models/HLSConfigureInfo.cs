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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HLSConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Duration of a single TS file in seconds. Value range: 5-30 seconds.
        /// 
        /// If this parameter is left empty, 30 seconds will be used by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ItemDuration")]
        public long? ItemDuration{ get; set; }

        /// <summary>
        /// Recording cycle in seconds. Value range: 10 minutes to 12 hours.
        /// 
        /// If this parameter is left empty, 10 minutes (3600 seconds) will be used by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// Resume recording waiting time, unit: seconds. Value range: 60-1800 seconds.
        /// If this parameter is left empty, 0 (resume recording not enabled) will be used by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ContinueTimeout")]
        public long? ContinueTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemDuration", this.ItemDuration);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "ContinueTimeout", this.ContinueTimeout);
        }
    }
}


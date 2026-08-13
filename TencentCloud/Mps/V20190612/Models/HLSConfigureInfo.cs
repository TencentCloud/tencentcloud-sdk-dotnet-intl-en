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
        /// Duration of TS file, unit: second, value ranges from 5 to 30 seconds.
        /// 
        /// Leave it blank and it defaults to 30 seconds.
        /// </summary>
        [JsonProperty("ItemDuration")]
        public long? ItemDuration{ get; set; }

        /// <summary>
        /// Recording period, unit: second, value ranges from 10 minutes to 12 hr.
        /// 
        /// Leave it blank defaults to 10 minutes (3600 seconds).
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// Continuation waiting time, unit: second. Value range: 60 seconds to 1800 seconds.
        /// Leave blank defaults to 0 (recording continuation disabled).
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


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

    public class AdBreakSetting : AbstractModel
    {
        
        /// <summary>
        /// Advertising type, currently supports L-SQUEEZE
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Duration, in milliseconds, requires 1000<duration<=600000. The current accuracy is seconds, which is a multiple of 1000
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// L-type compression recovery configuration
        /// </summary>
        [JsonProperty("LSqueezeSetting")]
        public LSqueezeSetting LSqueezeSetting{ get; set; }

        /// <summary>
        /// AdSource type, supports UPLOAD_CREATIVES
        /// </summary>
        [JsonProperty("AdSource")]
        public string AdSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "LSqueezeSetting.", this.LSqueezeSetting);
            this.SetParamSimple(map, prefix + "AdSource", this.AdSource);
        }
    }
}


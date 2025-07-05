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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CCReqLimitPolicyRecord : AbstractModel
    {
        
        /// <summary>
        /// Sampling interval (in seconds). Valid values: `1`, `10`, `30`, and `60`.
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// Number of requests. Value range: 1-2000.
        /// </summary>
        [JsonProperty("RequestNum")]
        public ulong? RequestNum{ get; set; }

        /// <summary>
        /// Action of limiting request frequency. Valid values: `alg` (limit request frequency via verification codes) and `drop`(drop requests).
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Sets an interval of the frequency limit policy. Value range: 1-86400 (in seconds).
        /// </summary>
        [JsonProperty("ExecuteDuration")]
        public ulong? ExecuteDuration{ get; set; }

        /// <summary>
        /// Filters values of configuration fields. `include`: The value is included. `equal`: The value matches the configuration field.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// URI, which cannot be used together with `User-Agent` and `Cookie`.
        /// </summary>
        [JsonProperty("Uri")]
        public string Uri{ get; set; }

        /// <summary>
        /// User-Agent, which cannot be used together with `Uri` and `Cookie`.
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// Cookie, which cannot be used together with `Uri` and `User-Agent`.
        /// </summary>
        [JsonProperty("Cookie")]
        public string Cookie{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RequestNum", this.RequestNum);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "ExecuteDuration", this.ExecuteDuration);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Uri", this.Uri);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "Cookie", this.Cookie);
        }
    }
}


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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionConfig : AbstractModel
    {
        
        /// <summary>
        /// session source. Valid values: 'HEADER', 'COOKIE', 'QUERY_STRING'
        /// </summary>
        [JsonProperty("SessionSource")]
        public string SessionSource{ get; set; }

        /// <summary>
        /// session name. It must start with a letter. Other characters can consist of digits, letters, underscores, and hyphens. Length: 5-40 characters.
        /// </summary>
        [JsonProperty("SessionName")]
        public string SessionName{ get; set; }

        /// <summary>
        /// Maximum concurrent sessions
        /// </summary>
        [JsonProperty("MaximumConcurrencySessionPerInstance")]
        public ulong? MaximumConcurrencySessionPerInstance{ get; set; }

        /// <summary>
        /// Lifecycle
        /// </summary>
        [JsonProperty("MaximumTTLInSeconds")]
        public ulong? MaximumTTLInSeconds{ get; set; }

        /// <summary>
        /// Idle duration
        /// </summary>
        [JsonProperty("MaximumIdleTimeInSeconds")]
        public ulong? MaximumIdleTimeInSeconds{ get; set; }

        /// <summary>
        /// Path information corresponding to the session
        /// </summary>
        [JsonProperty("SessionPath")]
        public string SessionPath{ get; set; }

        /// <summary>
        /// Automatically destroy FATAL and auto-pause PAUSE. This only occurs when security isolation is started.
        /// </summary>
        [JsonProperty("IdleTimeoutStrategy")]
        public string IdleTimeoutStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionSource", this.SessionSource);
            this.SetParamSimple(map, prefix + "SessionName", this.SessionName);
            this.SetParamSimple(map, prefix + "MaximumConcurrencySessionPerInstance", this.MaximumConcurrencySessionPerInstance);
            this.SetParamSimple(map, prefix + "MaximumTTLInSeconds", this.MaximumTTLInSeconds);
            this.SetParamSimple(map, prefix + "MaximumIdleTimeInSeconds", this.MaximumIdleTimeInSeconds);
            this.SetParamSimple(map, prefix + "SessionPath", this.SessionPath);
            this.SetParamSimple(map, prefix + "IdleTimeoutStrategy", this.IdleTimeoutStrategy);
        }
    }
}


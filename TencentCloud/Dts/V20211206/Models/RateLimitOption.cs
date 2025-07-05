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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RateLimitOption : AbstractModel
    {
        
        /// <summary>
        /// The number of full export threads currently in effect. The value of this field can be adjusted when configuring the task. Note: If it is not set or set to 0, it means the current value is maintained. The maximum value is 16.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentDumpThread")]
        public long? CurrentDumpThread{ get; set; }

        /// <summary>
        /// The default number of full export threads. This field is only meaningful in the output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultDumpThread")]
        public long? DefaultDumpThread{ get; set; }

        /// <summary>
        /// The full export Rps currently in effect. The value of this field can be adjusted when configuring the task. Note: If it is not set or set to 0, it means the current value is maintained. The maximum value is 50,000,000.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentDumpRps")]
        public long? CurrentDumpRps{ get; set; }

        /// <summary>
        /// The default full export Rps. This field is only meaningful in the output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultDumpRps")]
        public long? DefaultDumpRps{ get; set; }

        /// <summary>
        /// The number of full import threads currently in effect. The value of this field can be adjusted when configuring the task. Note: If it is not set or set to 0, it means the current value is maintained. The maximum value is 16.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentLoadThread")]
        public long? CurrentLoadThread{ get; set; }

        /// <summary>
        /// The default number of full import threads. This field is only meaningful in the output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultLoadThread")]
        public long? DefaultLoadThread{ get; set; }

        /// <summary>
        /// The full import Rps currently in effect. The value of this field can be adjusted when configuring the task. Note: If it is not set or set to 0, it means the current value is maintained. The maximum value is 50,000,000.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentLoadRps")]
        public long? CurrentLoadRps{ get; set; }

        /// <summary>
        /// The default full import Rps. This field is only meaningful in the output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultLoadRps")]
        public long? DefaultLoadRps{ get; set; }

        /// <summary>
        /// The number of incremental import threads currently in effect. The value of this field can be adjusted when configuring the task. Note: If it is not set or set to 0, it means the current value is maintained. The maximum value is 128.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrentSinkerThread")]
        public long? CurrentSinkerThread{ get; set; }

        /// <summary>
        /// The default number of incremental import threads. This field is only meaningful in the output parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DefaultSinkerThread")]
        public long? DefaultSinkerThread{ get; set; }

        /// <summary>
        /// enum:"no"/"yes", no: the user has not set a speed limit; yes: a speed limit has been set. This field is only meaningful in the output parameter.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HasUserSetRateLimit")]
        public string HasUserSetRateLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentDumpThread", this.CurrentDumpThread);
            this.SetParamSimple(map, prefix + "DefaultDumpThread", this.DefaultDumpThread);
            this.SetParamSimple(map, prefix + "CurrentDumpRps", this.CurrentDumpRps);
            this.SetParamSimple(map, prefix + "DefaultDumpRps", this.DefaultDumpRps);
            this.SetParamSimple(map, prefix + "CurrentLoadThread", this.CurrentLoadThread);
            this.SetParamSimple(map, prefix + "DefaultLoadThread", this.DefaultLoadThread);
            this.SetParamSimple(map, prefix + "CurrentLoadRps", this.CurrentLoadRps);
            this.SetParamSimple(map, prefix + "DefaultLoadRps", this.DefaultLoadRps);
            this.SetParamSimple(map, prefix + "CurrentSinkerThread", this.CurrentSinkerThread);
            this.SetParamSimple(map, prefix + "DefaultSinkerThread", this.DefaultSinkerThread);
            this.SetParamSimple(map, prefix + "HasUserSetRateLimit", this.HasUserSetRateLimit);
        }
    }
}


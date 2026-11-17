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
        /// Currently effective number of threads for full export. You can adjust this field value when the task is configured. Note: If it is not set or set to 0, the current value is kept. The maximum value is 16.
        /// </summary>
        [JsonProperty("CurrentDumpThread")]
        public long? CurrentDumpThread{ get; set; }

        /// <summary>
        /// The default number of threads for full export. This field is only meaningful in the output parameters.
        /// </summary>
        [JsonProperty("DefaultDumpThread")]
        public long? DefaultDumpThread{ get; set; }

        /// <summary>
        /// The currently effective Rps for full export. You can adjust this field value when configuring the task. Note: If not set or set to 0, it indicates to keep the current value. The maximum value is 50000000.
        /// </summary>
        [JsonProperty("CurrentDumpRps")]
        public long? CurrentDumpRps{ get; set; }

        /// <summary>
        /// The default Rps for full export. This field is only meaningful in the output parameters.
        /// </summary>
        [JsonProperty("DefaultDumpRps")]
        public long? DefaultDumpRps{ get; set; }

        /// <summary>
        /// Currently effective number of threads for full import. You can adjust this field value when the task is configured. Note: If it is not set or set to 0, the current value is kept. The maximum value is 16.
        /// </summary>
        [JsonProperty("CurrentLoadThread")]
        public long? CurrentLoadThread{ get; set; }

        /// <summary>
        /// The default number of threads for full import. This field is only meaningful in the output parameters.
        /// </summary>
        [JsonProperty("DefaultLoadThread")]
        public long? DefaultLoadThread{ get; set; }

        /// <summary>
        /// The currently effective Rps for full import. You can adjust this field value when configuring the task. Note: If not set or set to 0, it indicates to keep the current value. The maximum value is 50000000.	
        /// </summary>
        [JsonProperty("CurrentLoadRps")]
        public long? CurrentLoadRps{ get; set; }

        /// <summary>
        /// Default full import Rps. This field is only meaningful in the output parameter.	
        /// </summary>
        [JsonProperty("DefaultLoadRps")]
        public long? DefaultLoadRps{ get; set; }

        /// <summary>
        /// The currently effective number of threads for incremental import. You can adjust this field value when configuring the task. Note: If not set or set to 0, it indicates to keep the current value. The maximum value is 128.
        /// </summary>
        [JsonProperty("CurrentSinkerThread")]
        public long? CurrentSinkerThread{ get; set; }

        /// <summary>
        /// The default number of threads for incremental import. This field is only meaningful in the output parameters.
        /// </summary>
        [JsonProperty("DefaultSinkerThread")]
        public long? DefaultSinkerThread{ get; set; }

        /// <summary>
        /// enum: "no"/"yes". no indicates that the user has not set a speed limit, while yes indicates that a speed limit has been set. This field is only meaningful in the output parameters.
        /// </summary>
        [JsonProperty("HasUserSetRateLimit")]
        public string HasUserSetRateLimit{ get; set; }

        /// <summary>
        /// Default full export BPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("DefaultDumpBps")]
        public long? DefaultDumpBps{ get; set; }

        /// <summary>
        /// Incremental import RPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("CurrentSinkerRps")]
        public long? CurrentSinkerRps{ get; set; }

        /// <summary>
        /// Default incremental import RPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("DefaultSinkerRps")]
        public long? DefaultSinkerRps{ get; set; }

        /// <summary>
        /// Current import BPS. Currently, it is only used for Redis.
        /// </summary>
        [JsonProperty("CurrentLoadBps")]
        public long? CurrentLoadBps{ get; set; }

        /// <summary>
        /// Number of shards in the target database. Currently, only used for Redis.
        /// </summary>
        [JsonProperty("CurrentDstShardCount")]
        public long? CurrentDstShardCount{ get; set; }

        /// <summary>
        /// Full export BPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("CurrentDumpBps")]
        public long? CurrentDumpBps{ get; set; }

        /// <summary>
        /// Incremental import BPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("CurrentSinkerBps")]
        public long? CurrentSinkerBps{ get; set; }

        /// <summary>
        /// Default incremental import BPS, currently supported only for MongoDB links.
        /// </summary>
        [JsonProperty("DefaultSinkerBps")]
        public long? DefaultSinkerBps{ get; set; }


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
            this.SetParamSimple(map, prefix + "DefaultDumpBps", this.DefaultDumpBps);
            this.SetParamSimple(map, prefix + "CurrentSinkerRps", this.CurrentSinkerRps);
            this.SetParamSimple(map, prefix + "DefaultSinkerRps", this.DefaultSinkerRps);
            this.SetParamSimple(map, prefix + "CurrentLoadBps", this.CurrentLoadBps);
            this.SetParamSimple(map, prefix + "CurrentDstShardCount", this.CurrentDstShardCount);
            this.SetParamSimple(map, prefix + "CurrentDumpBps", this.CurrentDumpBps);
            this.SetParamSimple(map, prefix + "CurrentSinkerBps", this.CurrentSinkerBps);
            this.SetParamSimple(map, prefix + "DefaultSinkerBps", this.DefaultSinkerBps);
        }
    }
}


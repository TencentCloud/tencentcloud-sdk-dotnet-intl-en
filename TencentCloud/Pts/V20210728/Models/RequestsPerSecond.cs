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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestsPerSecond : AbstractModel
    {
        
        /// <summary>
        /// Maximum rps.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("MaxRequestsPerSecond")]
        public long? MaxRequestsPerSecond{ get; set; }

        /// <summary>
        /// Duration time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DurationSeconds")]
        public long? DurationSeconds{ get; set; }

        /// <summary>
        /// Deprecated.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("TargetVirtualUsers")]
        public long? TargetVirtualUsers{ get; set; }

        /// <summary>
        /// Number of resources.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("Resources")]
        public long? Resources{ get; set; }

        /// <summary>
        /// Initial rps.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("StartRequestsPerSecond")]
        public long? StartRequestsPerSecond{ get; set; }

        /// <summary>
        /// Target rps, invalid as an input parameter.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("TargetRequestsPerSecond")]
        public long? TargetRequestsPerSecond{ get; set; }

        /// <summary>
        /// Graceful shutdown waiting time.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("GracefulStopSeconds")]
        public long? GracefulStopSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxRequestsPerSecond", this.MaxRequestsPerSecond);
            this.SetParamSimple(map, prefix + "DurationSeconds", this.DurationSeconds);
            this.SetParamSimple(map, prefix + "TargetVirtualUsers", this.TargetVirtualUsers);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
            this.SetParamSimple(map, prefix + "StartRequestsPerSecond", this.StartRequestsPerSecond);
            this.SetParamSimple(map, prefix + "TargetRequestsPerSecond", this.TargetRequestsPerSecond);
            this.SetParamSimple(map, prefix + "GracefulStopSeconds", this.GracefulStopSeconds);
        }
    }
}


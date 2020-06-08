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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheckConf : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable health check.
        /// </summary>
        [JsonProperty("IsHealthCheck")]
        public bool? IsHealthCheck{ get; set; }

        /// <summary>
        /// Health check threshold.
        /// </summary>
        [JsonProperty("RequestVolumeThreshold")]
        public long? RequestVolumeThreshold{ get; set; }

        /// <summary>
        /// Window size.
        /// </summary>
        [JsonProperty("SleepWindowInMilliseconds")]
        public long? SleepWindowInMilliseconds{ get; set; }

        /// <summary>
        /// Threshold percentage.
        /// </summary>
        [JsonProperty("ErrorThresholdPercentage")]
        public long? ErrorThresholdPercentage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsHealthCheck", this.IsHealthCheck);
            this.SetParamSimple(map, prefix + "RequestVolumeThreshold", this.RequestVolumeThreshold);
            this.SetParamSimple(map, prefix + "SleepWindowInMilliseconds", this.SleepWindowInMilliseconds);
            this.SetParamSimple(map, prefix + "ErrorThresholdPercentage", this.ErrorThresholdPercentage);
        }
    }
}


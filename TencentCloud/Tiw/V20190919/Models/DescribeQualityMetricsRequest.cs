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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeQualityMetricsRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Start time, which is a Unix timestamp in seconds. The time length cannot exceed seven days.
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// End time, which is a Unix timestamp in seconds. The time length cannot exceed seven days.
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Metrics to be queried. Valid values:
        ///   - image_load_total_count: The number of image loads.
        ///   - image_load_fail_count: The number of image load failures.
        ///   - image_load_success_rate: The success rate of image loading, in percentage.
        ///   - ppt_load_total_count: The number of PowerPoint file loads.
        ///   - ppt_load_fail_count: The number of PowerPoint file load failures.
        ///   - ppt_load_success_rate: The success rate of PowerPoint file loading, in percentage.
        ///   - verify_sdk_total_count: The number of SDK verifications.
        ///   - verify_sdk_fail_count: The number of SDK verification failures.
        ///   - verify_sdk_success_rate: The success rate of SDK verification, in percentage.
        ///   - verify_sdk_in_one_second_rate: The rate of SDK verification completed within one second, in percentage.
        ///   - verify_sdk_cost_avg: The average time taken by each SDK verification, in milliseconds.
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// Aggregation interval. Valid value: `1h`.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}


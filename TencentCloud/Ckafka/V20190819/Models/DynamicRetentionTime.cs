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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DynamicRetentionTime : AbstractModel
    {
        
        /// <summary>
        /// Whether the dynamic message retention time configuration is enabled. 0: disabled; 1: enabled
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Disk quota threshold (in percentage) for triggering the message retention time change event
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskQuotaPercentage")]
        public long? DiskQuotaPercentage{ get; set; }

        /// <summary>
        /// Percentage by which the message retention time is shortened each time
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StepForwardPercentage")]
        public long? StepForwardPercentage{ get; set; }

        /// <summary>
        /// Minimum retention time, in minutes
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BottomRetention")]
        public long? BottomRetention{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "DiskQuotaPercentage", this.DiskQuotaPercentage);
            this.SetParamSimple(map, prefix + "StepForwardPercentage", this.StepForwardPercentage);
            this.SetParamSimple(map, prefix + "BottomRetention", this.BottomRetention);
        }
    }
}


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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperationDuration : AbstractModel
    {
        
        /// <summary>
        /// Maintenance period, which can be one or more days from Monday to Sunday. Valid values: [0, 6].
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Periods")]
        public ulong?[] Periods{ get; set; }

        /// <summary>
        /// The maintenance start time
        /// </summary>
        [JsonProperty("TimeStart")]
        public string TimeStart{ get; set; }

        /// <summary>
        /// The maintenance end time
        /// </summary>
        [JsonProperty("TimeEnd")]
        public string TimeEnd{ get; set; }

        /// <summary>
        /// The time zone expressed in UTC.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Periods.", this.Periods);
            this.SetParamSimple(map, prefix + "TimeStart", this.TimeStart);
            this.SetParamSimple(map, prefix + "TimeEnd", this.TimeEnd);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
        }
    }
}


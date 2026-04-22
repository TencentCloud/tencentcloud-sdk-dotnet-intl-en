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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VisitData : AbstractModel
    {
        
        /// <summary>
        /// Number of visits
        /// </summary>
        [JsonProperty("VisitCount")]
        public long? VisitCount{ get; set; }

        /// <summary>
        /// Average pages per device - visit_page_count / active_device_num
        /// </summary>
        [JsonProperty("AvgDeviceVisitDeep")]
        public string AvgDeviceVisitDeep{ get; set; }

        /// <summary>
        /// Pages per visit - visit_page_count / miniapp_open_num
        /// </summary>
        [JsonProperty("AvgCountVisitDeep")]
        public string AvgCountVisitDeep{ get; set; }

        /// <summary>
        /// Average visit duration - miniapp_total_duration / visit_page_count
        /// </summary>
        [JsonProperty("AvgPageVisitDuration")]
        public string AvgPageVisitDuration{ get; set; }

        /// <summary>
        /// Average visit duration per session
        /// miniapp_total_duration/miniapp_open_num
        /// </summary>
        [JsonProperty("AvgCountVisitDuration")]
        public string AvgCountVisitDuration{ get; set; }

        /// <summary>
        /// Refresh time in YYYYMMDD format
        /// </summary>
        [JsonProperty("DataTime")]
        public long? DataTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VisitCount", this.VisitCount);
            this.SetParamSimple(map, prefix + "AvgDeviceVisitDeep", this.AvgDeviceVisitDeep);
            this.SetParamSimple(map, prefix + "AvgCountVisitDeep", this.AvgCountVisitDeep);
            this.SetParamSimple(map, prefix + "AvgPageVisitDuration", this.AvgPageVisitDuration);
            this.SetParamSimple(map, prefix + "AvgCountVisitDuration", this.AvgCountVisitDuration);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
        }
    }
}


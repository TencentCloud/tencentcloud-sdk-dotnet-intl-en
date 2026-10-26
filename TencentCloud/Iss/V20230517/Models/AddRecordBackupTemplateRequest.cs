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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddRecordBackupTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Template name (supports only Chinese, English, number, _, -, length not exceeding 32 characters. Template name must be globally unique, cannot be empty, and must be unique)</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>Cloud Upload Time Period (settings can be done by week, supports setting multiple time periods per day, each time period not less than 10 minutes)</p>
        /// </summary>
        [JsonProperty("TimeSections")]
        public RecordTemplateTimeSections[] TimeSections{ get; set; }

        /// <summary>
        /// <p>Recording time period (settings can be done by week, support setting multiple time periods per day, each time period not less than 10 minutes)</p>
        /// </summary>
        [JsonProperty("DevTimeSections")]
        public RecordTemplateTimeSections[] DevTimeSections{ get; set; }

        /// <summary>
        /// <p>Speed multiplication for cloud migration (supports 1x, 2x, and 4x)</p>
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// <p>Cycle offset. Default: 1. It means to pull yesterday's video recording to the device. 0 means to pull today's video recording to the device. 3 means to pull the video recording to the device from the day before yesterday.</p><p>Value range: [0, 90]</p><p>Default value: 1</p>
        /// </summary>
        [JsonProperty("DayOffset")]
        public long? DayOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamArrayObj(map, prefix + "TimeSections.", this.TimeSections);
            this.SetParamArrayObj(map, prefix + "DevTimeSections.", this.DevTimeSections);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "DayOffset", this.DayOffset);
        }
    }
}


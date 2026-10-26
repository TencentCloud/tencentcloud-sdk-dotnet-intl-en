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

    public class AddRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name. It can contain only Chinese characters, letters, digits, underscores (_), and hyphens (-), with a length not exceeding 32 characters. The template name must be globally unique and cannot be empty or duplicated.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Cloud upload time period. Settings can be done by week. Multiple time periods can be set for each day, with each time period not less than 10 minutes.
        /// </summary>
        [JsonProperty("TimeSections")]
        public RecordTemplateTimeSections[] TimeSections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamArrayObj(map, prefix + "TimeSections.", this.TimeSections);
        }
    }
}


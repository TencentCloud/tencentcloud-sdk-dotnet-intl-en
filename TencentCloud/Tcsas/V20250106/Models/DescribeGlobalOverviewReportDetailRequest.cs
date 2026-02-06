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

    public class DescribeGlobalOverviewReportDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Parameter value: mnp_data_analysis
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// Parameter value: app_num|corp_num|miniapp_num|miniapp_visit_pv|minigame_num|minigame_visit_pv
        /// </summary>
        [JsonProperty("IndexId")]
        public string IndexId{ get; set; }

        /// <summary>
        /// Base64 string containing start and end time: {"BeginDate":20251111,"EndDate":20251125}
        /// </summary>
        [JsonProperty("QueryData")]
        public string QueryData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamSimple(map, prefix + "IndexId", this.IndexId);
            this.SetParamSimple(map, prefix + "QueryData", this.QueryData);
        }
    }
}


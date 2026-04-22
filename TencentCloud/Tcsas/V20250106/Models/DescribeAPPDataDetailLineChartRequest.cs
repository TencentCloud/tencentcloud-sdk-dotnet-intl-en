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

    public class DescribeAPPDataDetailLineChartRequest : AbstractModel
    {
        
        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Fixed value: mnp_data_analysis
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// IndexId (optional):
        /// app_minigame_num: Number of created mini games
        /// app_online_miniapp_num: Number of available mini programs
        /// app_miniapp_num: Number of created mini programs
        /// app_related_corp_num: Mini program team data
        /// app_online_minigame_num: Number of available mini games
        /// app_active_device_num: Number of active devices
        /// app_new_device_num: Number of new devices
        /// </summary>
        [JsonProperty("IndexIds")]
        public string[] IndexIds{ get; set; }

        /// <summary>
        /// Input parameter base64 string: {"BeginDate":"20251122","EndDate":"20251128"}
        /// </summary>
        [JsonProperty("QueryData")]
        public string QueryData{ get; set; }

        /// <summary>
        /// Superapp ID
        /// </summary>
        [JsonProperty("ApplicationIds")]
        public string[] ApplicationIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamArraySimple(map, prefix + "IndexIds.", this.IndexIds);
            this.SetParamSimple(map, prefix + "QueryData", this.QueryData);
            this.SetParamArraySimple(map, prefix + "ApplicationIds.", this.ApplicationIds);
        }
    }
}


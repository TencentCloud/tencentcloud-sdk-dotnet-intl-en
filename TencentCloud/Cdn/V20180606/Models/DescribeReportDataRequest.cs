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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReportDataRequest : AbstractModel
    {
        
        /// <summary>
        /// Query the start time in the format of `yyyy-MM-dd`
        /// If the report type is `daily`, the start time and end time must be of the same day.
        /// If the report type is `weekly`, the start time must be Monday and the end time must be the Sunday of the same week.
        /// If the report type is `monthly`, the start time must be the first day of the month and the end time must be the last day of the same month.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query the end time in the format of `yyyy-MM-dd`
        /// If the report type is `daily`, the start time and end time must be of the same day.
        /// If the report type is `weekly`, the start time must be Monday and the end time must be the Sunday of the same week.
        /// If the report type is `monthly`, the start time must be the first day of the month and the end time must be the last day of the same month.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Report type
        /// daily: daily report
        /// weekly: weekly report (Monday to Sunday)
        /// monthly: monthly report (calendar month)
        /// </summary>
        [JsonProperty("ReportType")]
        public string ReportType{ get; set; }

        /// <summary>
        /// Domain name acceleration region
        /// `mainland`: Regions within the Chinese mainland
        /// `overseas`: Regions outside the Chinese mainland
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of data entries. Default value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filters by project ID
        /// </summary>
        [JsonProperty("Project")]
        public long? Project{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Project", this.Project);
        }
    }
}


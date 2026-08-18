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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DashboardInfo : AbstractModel
    {
        
        /// <summary>
        /// Dashboard ID
        /// </summary>
        [JsonProperty("DashboardId")]
        public string DashboardId{ get; set; }

        /// <summary>
        /// Dashboard name
        /// </summary>
        [JsonProperty("DashboardName")]
        public string DashboardName{ get; set; }

        /// <summary>
        /// Dashboard data
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// Time when the dashboard was created. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// If AssumerUin is not empty, it indicates the UIN of the service party that created the log topic.
        /// </summary>
        [JsonProperty("AssumerUin")]
        public ulong? AssumerUin{ get; set; }

        /// <summary>
        /// If RoleName is not empty, it indicates the role of the service provider creating the log set.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// If AssumerName is not empty, it indicates the name of the service provider creating the log topic.
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// Information of tag bound to log topic
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Dashboard region: For compatibility with old regions.
        /// </summary>
        [JsonProperty("DashboardRegion")]
        public string DashboardRegion{ get; set; }

        /// <summary>
        /// Modify dashboard time. Format: YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Topic-related information corresponding to the dashboard
        /// </summary>
        [JsonProperty("DashboardTopicInfos")]
        public DashboardTopicInfo[] DashboardTopicInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DashboardId", this.DashboardId);
            this.SetParamSimple(map, prefix + "DashboardName", this.DashboardName);
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AssumerUin", this.AssumerUin);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DashboardRegion", this.DashboardRegion);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "DashboardTopicInfos.", this.DashboardTopicInfos);
        }
    }
}


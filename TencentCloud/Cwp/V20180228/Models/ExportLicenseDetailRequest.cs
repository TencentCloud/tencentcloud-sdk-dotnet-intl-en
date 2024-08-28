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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportLicenseDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// Take the intersection when filtering with multiple conditions: LicenseStatus, DeadlineStatus, ResourceId, and Keywords
        /// <li> LicenseType authorization type. 0: Pro Edition-pay-as-you-go; 1: Pro Edition-monthly subscription; 2: Ultimate Edition-monthly subscription</li>
        /// <li>ResourceId resource ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Whether to export all authorization details
        /// </summary>
        [JsonProperty("IsHistory")]
        public bool? IsHistory{ get; set; }

        /// <summary>
        /// Tag filtering; filter by the platform's tag capabilities. In this case, you should pass in the tag key and tag value as an object.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Export month, this parameter is optional only when IsHistory is active.
        /// </summary>
        [JsonProperty("ExportMonth")]
        public string ExportMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IsHistory", this.IsHistory);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ExportMonth", this.ExportMonth);
        }
    }
}


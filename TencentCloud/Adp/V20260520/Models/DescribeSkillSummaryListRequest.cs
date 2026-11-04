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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSkillSummaryListRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID. Required.
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// Query only the Skills favorited by the current user
        /// </summary>
        [JsonProperty("FavoriteOnly")]
        public bool? FavoriteOnly{ get; set; }

        /// <summary>
        /// Filter criteria (multiple Filters are in an AND relationship, while multiple Values within the same Filter are in an OR relationship):
        /// -SkillIdList: List of skill IDs, string array, exact match
        /// - ProviderType: Skill provider type, enumerated value array, exact match
        ///      (SKILL_PROVIDER_TYPE_OFFICIAL=1/SKILL_PROVIDER_TYPE_THIRD_PARTY=2/SKILL_PROVIDER_TYPE_CUSTOM=3/SKILL_PROVIDER_TYPE_CUSTOM_SHARED=4)
        /// -CategoryKey: Category identifier, string array, exact match.
        /// - AnalysisStatus: Security detection status, enumeration value array, exact match.
        ///      (SKILL_ANALYSIS_PENDING=0/SKILL_ANALYSIS_RUNNING=1/SKILL_ANALYSIS_AVAILABLE=2/SKILL_ANALYSIS_UNAVAILABLE=3/SKILL_ANALYSIS_FAILED=4)
        /// - RiskLevel: Risk level, enumerated value array, exact match
        ///      (SKILL_RISK_NONE=0/SKILL_RISK_LOW=1/SKILL_RISK_MEDIUM=2/SKILL_RISK_HIGH=3)
        /// - SkillStatus: Publishing status in the Skill dimension. Enumerated value array. Exact match. OR between multiple values. Only meaningful when Perspective is EDITOR or ALL.
        /// (SKILL_STATUS_INITIALIZED=0/SKILL_STATUS_AUDITING=1/SKILL_STATUS_PENDING_RELEASE=2/SKILL_STATUS_RELEASED=3)
        /// - ShareStatus: Shared status, enumeration value array, exact match. This parameter is valid only when ProviderType includes SKILL_PROVIDER_TYPE_CUSTOM/SKILL_PROVIDER_TYPE_CUSTOM_SHARED.
        ///      (SHARE_STATUS_UNSHARED=0/SHARE_STATUS_SHARED=1/SHARE_STATUS_APPROVING=2)
        /// -Perspective: Perspective enum, string single value. The length of Values must be 1. Multi-value is deemed as illegal. This parameter is valid only when ProviderType=SKILL_PROVIDER_TYPE_CUSTOM. Default if not passed: USER
        /// (USER=User perspective. Only Skills with usage permissions are returned / EDITOR=Editor perspective. Only Skills with edit permission are returned / ALL=Full perspective. Skills with any permission bit are returned)
        /// -Creator: Filter by creator. String single value. The length of Values must be 1. Multi-value is deemed as illegal. This parameter is valid only when ProviderType=SKILL_PROVIDER_TYPE_CUSTOM.
        /// Currently, only the placeholder "$self" is supported, which means only Skills created by the current caller are returned.
        /// To scale to a specified identity subsequently, add the agreement here if needed.
        /// </summary>
        [JsonProperty("FilterList")]
        public Filter[] FilterList{ get; set; }

        /// <summary>
        /// Page number, starting from 0
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page. Maximum value: 100.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// Fuzzy search by name/display name
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "FavoriteOnly", this.FavoriteOnly);
            this.SetParamArrayObj(map, prefix + "FilterList.", this.FilterList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Query", this.Query);
        }
    }
}


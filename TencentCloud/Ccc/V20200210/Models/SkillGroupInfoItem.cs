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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillGroupInfoItem : AbstractModel
    {
        
        /// <summary>
        /// Skill group ID.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// Skill group name.
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }

        /// <summary>
        /// (Deprecated) Type: IM, TEL, ALL (full media).
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Session allocation policy.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RoutePolicy")]
        public string RoutePolicy{ get; set; }

        /// <summary>
        /// Should the conversation allocation prioritize the last service seat?
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsingLastSeat")]
        public long? UsingLastSeat{ get; set; }

        /// <summary>
        /// Maximum concurrency number of single client service (default 1 for telephone type).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// Last modification time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastModifyTimestamp")]
        public long? LastModifyTimestamp{ get; set; }

        /// <summary>
        /// Skill group type 0-phone, 1-online, 3-audio, 4-video.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkillGroupType")]
        public long? SkillGroupType{ get; set; }

        /// <summary>
        /// Extension number within the skill group
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RoutePolicy", this.RoutePolicy);
            this.SetParamSimple(map, prefix + "UsingLastSeat", this.UsingLastSeat);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamSimple(map, prefix + "SkillGroupType", this.SkillGroupType);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}


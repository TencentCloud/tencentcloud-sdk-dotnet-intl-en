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

    public class CreateCCCSkillGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Skill group name.
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }

        /// <summary>
        /// Skill group type 0-cell phone, 1-online, 3-audio, 4-video.
        /// </summary>
        [JsonProperty("SkillGroupType")]
        public long? SkillGroupType{ get; set; }

        /// <summary>
        /// The maximum number of people received by the skill group (the maximum number of people that one agent in this skill group can receive) is set to 1 by default. if the skill group type is online, the maximum can be set to one or more.
        /// 2. if the skill group type is phone, audio, or video, then the reception limit must be 1.
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public ulong? MaxConcurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
            this.SetParamSimple(map, prefix + "SkillGroupType", this.SkillGroupType);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
        }
    }
}


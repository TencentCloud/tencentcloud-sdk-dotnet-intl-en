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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSkillGroupInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Page size, upper limit 100.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <Page number starting from 0.>.
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Using skill group id when querying a single skill group.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// Used when querying skill groups with a modified time greater or equal to modifiedtime.
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public long? ModifiedTime{ get; set; }

        /// <summary>
        /// Skill group name.
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
        }
    }
}


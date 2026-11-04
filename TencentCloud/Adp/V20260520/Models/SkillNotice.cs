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

    public class SkillNotice : AbstractModel
    {
        
        /// <summary>
        /// Notification level
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// | 0 | Placeholder |
        /// | 1 | Success, string literal: "success" |
        /// | 2 | Warning, string literal: "warning" |
        /// | 3 | Error, string literal: "error" |
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// Copywriting (post-i18n string)
        /// </summary>
        [JsonProperty("NoticeContent")]
        public string NoticeContent{ get; set; }

        /// <summary>
        /// Version ID of the Skill that triggers this notice
        /// </summary>
        [JsonProperty("TriggerVersionId")]
        public string TriggerVersionId{ get; set; }

        /// <summary>
        /// Notification type 
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// | 0 | Placeholder |
        /// | 1 | Release failure |
        /// | 2 | Shared approval rejected |
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "NoticeContent", this.NoticeContent);
            this.SetParamSimple(map, prefix + "TriggerVersionId", this.TriggerVersionId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}


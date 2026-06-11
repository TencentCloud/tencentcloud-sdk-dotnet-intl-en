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

    public class MonitorNoticeRule : AbstractModel
    {
        
        /// <summary>
        /// <p>Tencent Cloud observability platform notification template ID</p>
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }

        /// <summary>
        /// <p>ID of the Tencent Cloud observability platform content template. The default content template is used when empty.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContentTmplId")]
        public string ContentTmplId{ get; set; }

        /// <summary>
        /// <p>Alarm level. 0: Warn; 1: Information; 2: Critical</p>
        /// </summary>
        [JsonProperty("AlarmLevels")]
        public ulong?[] AlarmLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
            this.SetParamSimple(map, prefix + "ContentTmplId", this.ContentTmplId);
            this.SetParamArraySimple(map, prefix + "AlarmLevels.", this.AlarmLevels);
        }
    }
}


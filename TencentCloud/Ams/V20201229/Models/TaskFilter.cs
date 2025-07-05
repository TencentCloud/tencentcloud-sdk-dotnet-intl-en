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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFilter : AbstractModel
    {
        
        /// <summary>
        /// This field is used to pass in the business type of a task as a filter. `Biztype` is the specific number of the policy, which is used for API scheduling and can be configured in the CMS console. Different `Biztype` values are associated with different business scenarios and moderation policies, so you need to verify the `Biztype` before calling this API. `Biztype` can contain 3–32 digits, letters, and underscores.<br>Note: when this parameter is not passed in, tasks will not be filtered by business type by default.
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// This field is used to pass in the type of an audio moderation task as a filter. Valid values: **VIDEO** (video on demand moderation), **AUDIO** (audio on demand moderation), **LIVE_VIDEO** (video live streaming moderation), **LIVE_AUDIO** (audio live streaming moderation).<br>Note: when this parameter is not passed in, tasks will not be filtered by task type by default.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// This field is used to pass in the operation suggestion of an audio moderation task as a filter. Valid values: **Block**, **Review**, **Pass**.<br>Note: when this parameter is not passed in, tasks will not be filtered by operation suggestion by default.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// This field is used to pass in the status of a moderation task as a filter. Valid values: **FINISH** (task completed), **PENDING** (task pending), **RUNNING** (task in progress), **ERROR** (task error), **CANCELLED** (task canceled).<br>Note: when this parameter is not passed in, tasks will not be filtered by task status by default.
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
        }
    }
}


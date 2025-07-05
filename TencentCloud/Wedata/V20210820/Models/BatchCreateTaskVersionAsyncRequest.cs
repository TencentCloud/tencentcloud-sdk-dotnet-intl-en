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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchCreateTaskVersionAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// Task information
        /// </summary>
        [JsonProperty("Tasks")]
        public BatchCreateTaskVersionDTO[] Tasks{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Specifies whether to run automatically
        /// </summary>
        [JsonProperty("AutoRun")]
        public bool? AutoRun{ get; set; }

        /// <summary>
        /// Alert method: email-email; sms-sms; wecom-wecom
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string AlarmWays{ get; set; }

        /// <summary>
        /// Alarm object: 1. Project Administrator. 2. Task Owner
        /// </summary>
        [JsonProperty("AlarmRecipientTypes")]
        public string AlarmRecipientTypes{ get; set; }

        /// <summary>
        /// Whether validation is required to check if the parent task has been submitted to scheduling
        /// </summary>
        [JsonProperty("NeedCheckParentSubmitted")]
        public bool? NeedCheckParentSubmitted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRun", this.AutoRun);
            this.SetParamSimple(map, prefix + "AlarmWays", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientTypes", this.AlarmRecipientTypes);
            this.SetParamSimple(map, prefix + "NeedCheckParentSubmitted", this.NeedCheckParentSubmitted);
        }
    }
}


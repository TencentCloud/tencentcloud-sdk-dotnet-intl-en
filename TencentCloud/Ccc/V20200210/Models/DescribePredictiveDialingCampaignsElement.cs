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

    public class DescribePredictiveDialingCampaignsElement : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// Note: This field may return null if no valid value is obtained.
        /// </summary>
        [JsonProperty("CampaignId")]
        public long? CampaignId{ get; set; }

        /// <summary>
        /// Task Name
        /// Note: This field might return null if no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Task status 0 - Ready to start, 1 - In progress, 2 - Paused, 3 - Terminated, 4 - Completed.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Task status reasons 0 - Normal, 1 - Manually ended, 2 - Ended due to overtime.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusReason")]
        public long? StatusReason{ get; set; }

        /// <summary>
        /// Number of called numbers.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CalleeCount")]
        public long? CalleeCount{ get; set; }

        /// <summary>
        /// Number of completed calls.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FinishedCalleeCount")]
        public long? FinishedCalleeCount{ get; set; }

        /// <summary>
        /// Running priority of multiple tasks in the same application, from high to low 1 - 5.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// ID of the used skill group of agents.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CampaignId", this.CampaignId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "CalleeCount", this.CalleeCount);
            this.SetParamSimple(map, prefix + "FinishedCalleeCount", this.FinishedCalleeCount);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
        }
    }
}


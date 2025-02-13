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
        /// <Task id>.
        /// </summary>
        [JsonProperty("CampaignId")]
        public long? CampaignId{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Task status 0 - ready to start, 1 - in progress, 2 - paused, 3 - terminated, 4 - completed.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Task status reasons 0 - normal, 1 - manually ended, 2 - ended due to overtime.
        /// </summary>
        [JsonProperty("StatusReason")]
        public long? StatusReason{ get; set; }

        /// <summary>
        /// Number of called numbers.
        /// </summary>
        [JsonProperty("CalleeCount")]
        public long? CalleeCount{ get; set; }

        /// <summary>
        /// Number of completed calls.
        /// </summary>
        [JsonProperty("FinishedCalleeCount")]
        public long? FinishedCalleeCount{ get; set; }

        /// <summary>
        /// Running priority of multiple tasks in the same application, from high to low 1 - 5.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// ID of the used skill group of agents.
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


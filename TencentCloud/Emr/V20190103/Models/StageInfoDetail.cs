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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StageInfoDetail : AbstractModel
    {
        
        /// <summary>
        /// Steps.
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// Step name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Indicates whether to display
        /// </summary>
        [JsonProperty("IsShow")]
        public bool? IsShow{ get; set; }

        /// <summary>
        /// Whether it is a subprocess
        /// </summary>
        [JsonProperty("IsSubFlow")]
        public bool? IsSubFlow{ get; set; }

        /// <summary>
        /// Subprocess tag.
        /// </summary>
        [JsonProperty("SubFlowFlag")]
        public string SubFlowFlag{ get; set; }

        /// <summary>
        /// Step execution status. 0: not started, 1: in progress, 2: completed, 3: partially completed, -1: failed
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Step running status description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Running progress.
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// Start time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Starttime")]
        public string Starttime{ get; set; }

        /// <summary>
        /// End time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Endtime")]
        public string Endtime{ get; set; }

        /// <summary>
        /// Whether details are included.
        /// </summary>
        [JsonProperty("HadWoodDetail")]
        public bool? HadWoodDetail{ get; set; }

        /// <summary>
        /// Wood subprocess ID.
        /// </summary>
        [JsonProperty("WoodJobId")]
        public ulong? WoodJobId{ get; set; }

        /// <summary>
        /// Multi-language version key.
        /// </summary>
        [JsonProperty("LanguageKey")]
        public string LanguageKey{ get; set; }

        /// <summary>
        /// Reason for stage failure.
        /// </summary>
        [JsonProperty("FailedReason")]
        public string FailedReason{ get; set; }

        /// <summary>
        /// Step duration.
        /// </summary>
        [JsonProperty("TimeConsuming")]
        public string TimeConsuming{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsShow", this.IsShow);
            this.SetParamSimple(map, prefix + "IsSubFlow", this.IsSubFlow);
            this.SetParamSimple(map, prefix + "SubFlowFlag", this.SubFlowFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Starttime", this.Starttime);
            this.SetParamSimple(map, prefix + "Endtime", this.Endtime);
            this.SetParamSimple(map, prefix + "HadWoodDetail", this.HadWoodDetail);
            this.SetParamSimple(map, prefix + "WoodJobId", this.WoodJobId);
            this.SetParamSimple(map, prefix + "LanguageKey", this.LanguageKey);
            this.SetParamSimple(map, prefix + "FailedReason", this.FailedReason);
            this.SetParamSimple(map, prefix + "TimeConsuming", this.TimeConsuming);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}


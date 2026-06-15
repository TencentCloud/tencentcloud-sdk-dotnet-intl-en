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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateOnCallFormRequest : AbstractModel
    {
        
        /// <summary>
        /// The fixed value is monitor.
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// On-call schedule ID.
        /// </summary>
        [JsonProperty("OnCallFormID")]
        public string OnCallFormID{ get; set; }

        /// <summary>
        /// On-call schedule name.
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }

        /// <summary>
        /// On-call personnel ID group.
        /// </summary>
        [JsonProperty("StaffInfos")]
        public StaffInfo[] StaffInfos{ get; set; }

        /// <summary>
        /// Rotation type.
        /// </summary>
        [JsonProperty("RotationType")]
        public string RotationType{ get; set; }

        /// <summary>
        /// Shift change time.
        /// </summary>
        [JsonProperty("ShiftTime")]
        public string ShiftTime{ get; set; }

        /// <summary>
        /// Effect time. Unit: seconds.
        /// </summary>
        [JsonProperty("EffectiveStartTime")]
        public long? EffectiveStartTime{ get; set; }

        /// <summary>
        /// End time of the validity period (in seconds).
        /// </summary>
        [JsonProperty("EffectiveEndTime")]
        public long? EffectiveEndTime{ get; set; }

        /// <summary>
        /// Time zone (-12 to 12).
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// Description of the shift schedule.
        /// </summary>
        [JsonProperty("OnCallFormDesc")]
        public string OnCallFormDesc{ get; set; }

        /// <summary>
        /// Shift information.
        /// </summary>
        [JsonProperty("CoverStaffInfos")]
        public CoverStaffInfo[] CoverStaffInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "OnCallFormID", this.OnCallFormID);
            this.SetParamSimple(map, prefix + "OnCallFormName", this.OnCallFormName);
            this.SetParamArrayObj(map, prefix + "StaffInfos.", this.StaffInfos);
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "ShiftTime", this.ShiftTime);
            this.SetParamSimple(map, prefix + "EffectiveStartTime", this.EffectiveStartTime);
            this.SetParamSimple(map, prefix + "EffectiveEndTime", this.EffectiveEndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "OnCallFormDesc", this.OnCallFormDesc);
            this.SetParamArrayObj(map, prefix + "CoverStaffInfos.", this.CoverStaffInfos);
        }
    }
}


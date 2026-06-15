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

    public class OneOnCallForm : AbstractModel
    {
        
        /// <summary>
        /// Duty ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormID")]
        public string OnCallFormID{ get; set; }

        /// <summary>
        /// On-call name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }

        /// <summary>
        /// Shift description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormDesc")]
        public string OnCallFormDesc{ get; set; }

        /// <summary>
        /// On-duty personnel
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StaffInfos")]
        public StaffInfo[] StaffInfos{ get; set; }

        /// <summary>
        /// Rotation type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationType")]
        public string RotationType{ get; set; }

        /// <summary>
        /// Shift change time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ShiftTime")]
        public string ShiftTime{ get; set; }

        /// <summary>
        /// Start time of the on-call validity period
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EffectiveStartTime")]
        public long? EffectiveStartTime{ get; set; }

        /// <summary>
        /// End time of the on-call validity period
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EffectiveEndTime")]
        public long? EffectiveEndTime{ get; set; }

        /// <summary>
        /// Time zone
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeZone")]
        public float? TimeZone{ get; set; }

        /// <summary>
        /// Shift information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CoverStaffInfos")]
        public CoverStaffInfo[] CoverStaffInfos{ get; set; }

        /// <summary>
        /// Tag bound to the template
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OnCallFormID", this.OnCallFormID);
            this.SetParamSimple(map, prefix + "OnCallFormName", this.OnCallFormName);
            this.SetParamSimple(map, prefix + "OnCallFormDesc", this.OnCallFormDesc);
            this.SetParamArrayObj(map, prefix + "StaffInfos.", this.StaffInfos);
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "ShiftTime", this.ShiftTime);
            this.SetParamSimple(map, prefix + "EffectiveStartTime", this.EffectiveStartTime);
            this.SetParamSimple(map, prefix + "EffectiveEndTime", this.EffectiveEndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArrayObj(map, prefix + "CoverStaffInfos.", this.CoverStaffInfos);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}


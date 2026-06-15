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

    public class OnCallForm : AbstractModel
    {
        
        /// <summary>
        /// Schedule ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormID")]
        public string OnCallFormID{ get; set; }

        /// <summary>
        /// Shift name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }

        /// <summary>
        /// Schedule description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OnCallFormDesc")]
        public string OnCallFormDesc{ get; set; }

        /// <summary>
        /// Rotation type.
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
        /// Validity start time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EffectiveStartTime")]
        public long? EffectiveStartTime{ get; set; }

        /// <summary>
        /// Validity end time
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
        /// Current on-duty personnel
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CurrOnCallStaffs")]
        public string[] CurrOnCallStaffs{ get; set; }

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
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "ShiftTime", this.ShiftTime);
            this.SetParamSimple(map, prefix + "EffectiveStartTime", this.EffectiveStartTime);
            this.SetParamSimple(map, prefix + "EffectiveEndTime", this.EffectiveEndTime);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "CurrOnCallStaffs.", this.CurrOnCallStaffs);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}


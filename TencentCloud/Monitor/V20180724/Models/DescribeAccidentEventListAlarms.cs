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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccidentEventListAlarms : AbstractModel
    {
        
        /// <summary>
        /// Event type.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BusinessTypeDesc")]
        public string BusinessTypeDesc{ get; set; }

        /// <summary>
        /// Event type.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AccidentTypeDesc")]
        public string AccidentTypeDesc{ get; set; }

        /// <summary>
        /// ID of the event type. The value 1 indicates service issues. The value 2 indicates other subscriptions.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("BusinessID")]
        public long? BusinessID{ get; set; }

        /// <summary>
        /// Event status ID. The value 0 indicates that the event has been recovered. The value 1 indicates that the event has not been recovered.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventStatus")]
        public long? EventStatus{ get; set; }

        /// <summary>
        /// Affected object.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AffectResource")]
        public string AffectResource{ get; set; }

        /// <summary>
        /// Region where the event occurs.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Time when the event occurs.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OccurTime")]
        public string OccurTime{ get; set; }

        /// <summary>
        /// Update time.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessTypeDesc", this.BusinessTypeDesc);
            this.SetParamSimple(map, prefix + "AccidentTypeDesc", this.AccidentTypeDesc);
            this.SetParamSimple(map, prefix + "BusinessID", this.BusinessID);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "AffectResource", this.AffectResource);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "OccurTime", this.OccurTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}


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

    public class StaffStatusMetrics : AbstractModel
    {
        
        /// <summary>
        /// Agent email.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Agent status free Available | busy Busy | rest On Break | notReady Not Ready | afterCallWork Post-call Adjustment | offline Offline
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Supplementary Information on Agent Status
        /// </summary>
        [JsonProperty("StatusExtra")]
        public StaffStatusExtra StatusExtra{ get; set; }

        /// <summary>
        /// Total Online duration of the day.
        /// </summary>
        [JsonProperty("OnlineDuration")]
        public long? OnlineDuration{ get; set; }

        /// <summary>
        /// Total Available duration of the day.
        /// </summary>
        [JsonProperty("FreeDuration")]
        public long? FreeDuration{ get; set; }

        /// <summary>
        /// Total Busy duration of the day.
        /// </summary>
        [JsonProperty("BusyDuration")]
        public long? BusyDuration{ get; set; }

        /// <summary>
        /// Total Not Ready status duration of the day.
        /// </summary>
        [JsonProperty("NotReadyDuration")]
        public long? NotReadyDuration{ get; set; }

        /// <summary>
        /// Total Break duration of the day.
        /// </summary>
        [JsonProperty("RestDuration")]
        public long? RestDuration{ get; set; }

        /// <summary>
        /// Total After Call Work duration of the day.
        /// </summary>
        [JsonProperty("AfterCallWorkDuration")]
        public long? AfterCallWorkDuration{ get; set; }

        /// <summary>
        /// Reason for Break.
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// Whether to reserve Break status.
        /// </summary>
        [JsonProperty("ReserveRest")]
        public bool? ReserveRest{ get; set; }

        /// <summary>
        /// Whether to reserve Not Ready status.
        /// </summary>
        [JsonProperty("ReserveNotReady")]
        public bool? ReserveNotReady{ get; set; }

        /// <summary>
        /// Cell phone answering pattern: 0 - Off | 1 - Only when Offline | 2 - Always.
        /// </summary>
        [JsonProperty("UseMobileAccept")]
        public long? UseMobileAccept{ get; set; }

        /// <summary>
        /// Cell phone outbound call switch.
        /// </summary>
        [JsonProperty("UseMobileCallOut")]
        public bool? UseMobileCallOut{ get; set; }

        /// <summary>
        /// Last online timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastOnlineTimestamp")]
        public long? LastOnlineTimestamp{ get; set; }

        /// <summary>
        /// Last status timestamp.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastStatusTimestamp")]
        public long? LastStatusTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "StatusExtra.", this.StatusExtra);
            this.SetParamSimple(map, prefix + "OnlineDuration", this.OnlineDuration);
            this.SetParamSimple(map, prefix + "FreeDuration", this.FreeDuration);
            this.SetParamSimple(map, prefix + "BusyDuration", this.BusyDuration);
            this.SetParamSimple(map, prefix + "NotReadyDuration", this.NotReadyDuration);
            this.SetParamSimple(map, prefix + "RestDuration", this.RestDuration);
            this.SetParamSimple(map, prefix + "AfterCallWorkDuration", this.AfterCallWorkDuration);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ReserveRest", this.ReserveRest);
            this.SetParamSimple(map, prefix + "ReserveNotReady", this.ReserveNotReady);
            this.SetParamSimple(map, prefix + "UseMobileAccept", this.UseMobileAccept);
            this.SetParamSimple(map, prefix + "UseMobileCallOut", this.UseMobileCallOut);
            this.SetParamSimple(map, prefix + "LastOnlineTimestamp", this.LastOnlineTimestamp);
            this.SetParamSimple(map, prefix + "LastStatusTimestamp", this.LastStatusTimestamp);
        }
    }
}


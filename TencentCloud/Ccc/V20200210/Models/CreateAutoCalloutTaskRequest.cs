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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoCalloutTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Application id (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Task starting timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("NotBefore")]
        public long? NotBefore{ get; set; }

        /// <summary>
        /// List of called numbers.
        /// </summary>
        [JsonProperty("Callees")]
        public string[] Callees{ get; set; }

        /// <summary>
        /// List of calling numbers.
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// IVR Id used for calling. if not filled, AIAgentId needs to be filled.
        /// </summary>
        [JsonProperty("IvrId")]
        public ulong? IvrId{ get; set; }

        /// <summary>
        /// Task name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <Task description>.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Task stop timestamp. unix second-level timestamp.
        /// </summary>
        [JsonProperty("NotAfter")]
        public long? NotAfter{ get; set; }

        /// <summary>
        /// Maximum attempts, 1-3 times.
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// Custom variable (advanced edition support). using the same variable in the CalleeAttributes field will overwrite here.
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }

        /// <summary>
        /// User-Defined data. specifies that using UUI in the CalleeAttributes field will overwrite here.
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// Property of the called.
        /// </summary>
        [JsonProperty("CalleeAttributes")]
        public CalleeAttribute[] CalleeAttributes{ get; set; }

        /// <summary>
        /// IANA time zone name. see https://datatracker.ietf.org/doc/html/draft-ietf-netmod-iana-timezones.
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// Available time period.
        /// </summary>
        [JsonProperty("AvailableTime")]
        public TimeRange[] AvailableTime{ get; set; }

        /// <summary>
        /// Intelligent agent ID. if not filled, IvrId needs to be filled.
        /// </summary>
        [JsonProperty("AIAgentId")]
        public long? AIAgentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "NotBefore", this.NotBefore);
            this.SetParamArraySimple(map, prefix + "Callees.", this.Callees);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "IvrId", this.IvrId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "Variables.", this.Variables);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "CalleeAttributes.", this.CalleeAttributes);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArrayObj(map, prefix + "AvailableTime.", this.AvailableTime);
            this.SetParamSimple(map, prefix + "AIAgentId", this.AIAgentId);
        }
    }
}


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
        /// Retry interval for task failure. value range: 600-86400 seconds.
        /// </summary>
        [JsonProperty("RetryInterval")]
        public long? RetryInterval{ get; set; }

        /// <summary>
        /// Maximum ringing duration. auto hang up when the duration threshold is reached. only own number supports this parameter.
        /// </summary>
        [JsonProperty("MaxRingTimeoutSecond")]
        public long? MaxRingTimeoutSecond{ get; set; }

        /// <summary>
        /// <p>Retry according to the specified hang-up reasons (optional hang-up status codes: 202, 203, 204, 205, 206, 207, 208, 210, 212, 213, 215, 216, 217, 218, 219, 221, 222, 234). This only takes effect for tasks using AIAgentID. For the description of hang-up status codes</p>
        /// <p><a href="https://cloud.tencent.com/document/product/679/123938">see details</a></p>
        /// </summary>
        [JsonProperty("RetryHangupTypes")]
        public string[] RetryHangupTypes{ get; set; }

        /// <summary>
        /// Retry based on the specified post-dialogue tag. It only takes effect for AIAgentID tasks that use the dialogue model. Tag information can be queried in the agent configuration.
        /// </summary>
        [JsonProperty("RetryTags")]
        public RetryTagItem[] RetryTags{ get; set; }

        /// <summary>
        /// <p>Effective working time configuration. It is recommended to use this field instead of the AvailableTime field. If both are used simultaneously, AvailableTime takes priority.</p>
        /// </summary>
        [JsonProperty("AvailableWorkTimeConfig")]
        public AvailableTimeConfig[] AvailableWorkTimeConfig{ get; set; }

        /// <summary>
        /// <p>Trigger Strategy</p>
        /// </summary>
        [JsonProperty("TriggerStrategy")]
        public TriggerStrategyItem[] TriggerStrategy{ get; set; }


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
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "MaxRingTimeoutSecond", this.MaxRingTimeoutSecond);
            this.SetParamArraySimple(map, prefix + "RetryHangupTypes.", this.RetryHangupTypes);
            this.SetParamArrayObj(map, prefix + "RetryTags.", this.RetryTags);
            this.SetParamArrayObj(map, prefix + "AvailableWorkTimeConfig.", this.AvailableWorkTimeConfig);
            this.SetParamArrayObj(map, prefix + "TriggerStrategy.", this.TriggerStrategy);
        }
    }
}


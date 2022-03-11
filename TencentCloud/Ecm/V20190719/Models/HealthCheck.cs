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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthCheck : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable health check. Valid values: 1: enable; 0: disable
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// Health check response timeout period in seconds. Value range: 2–60. Default value: 2. The value of this parameter should be smaller than the check interval.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// Health check interval in seconds. Value range: 5–300. Default value: 5.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// Health threshold. Value range: 2–10. Default value: 3, indicating that if a forward is found healthy three consecutive times, it will be considered normal.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// Unhealthy threshold. Value range: 2–10. Default value: 3, indicating that if a forward is found unhealthy three consecutive times, it will be considered exceptional.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnHealthyNum")]
        public long? UnHealthyNum{ get; set; }

        /// <summary>
        /// Health check port (a custom check parameter), which is the port of the real server by default. Unless you want to specify a port, we recommend you leave it empty.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckPort")]
        public long? CheckPort{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of `CheckType` is `CUSTOM`. This parameter represents the input format of the health check. Valid values: HEX, TEXT. If the value is `HEX`, the characters of `SendContext` and `RecvContext` can only be selected from `0123456789ABCDEF`, and the length must be an even number.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of `CheckType` is `CUSTOM`. This parameter represents the content of the request sent by the health check. It can contain up to 500 visible ASCII characters.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter), which is required if the value of `CheckType` is `CUSTOM`. This parameter represents the result returned by the health check. It can contain up to 500 visible ASCII characters.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// Health check protocol (a custom check parameter). Valid values: TCP, CUSTOM (applicable only to UDP listeners. If custom health check is used, this parameter will be required).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnHealthyNum", this.UnHealthyNum);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
        }
    }
}


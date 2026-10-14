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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionLog : AbstractModel
    {
        
        /// <summary>
        /// Function name.
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Returned value after function execution
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// requestId for executing the function
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// Time point when the function starts execution
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Function execution result. 0 indicates successful execution, 2 indicates the function is running, 3 indicates an execution interrupt, and other values indicate failure.
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }

        /// <summary>
        /// Whether the function call ends. If so, 1 means execution ended, and additional values indicate a call exception.
        /// </summary>
        [JsonProperty("InvokeFinished")]
        public long? InvokeFinished{ get; set; }

        /// <summary>
        /// Function execution duration in milliseconds.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Billing duration of a function. It is rounded up to the nearest 100 ms based on the duration, in ms.
        /// </summary>
        [JsonProperty("BillDuration")]
        public long? BillDuration{ get; set; }

        /// <summary>
        /// Memory size actually consumed during function execution, in bytes.
        /// </summary>
        [JsonProperty("MemUsage")]
        public long? MemUsage{ get; set; }

        /// <summary>
        /// Log output during function execution
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// Log level.
        /// </summary>
        [JsonProperty("Level")]
        [System.Obsolete]
        public string Level{ get; set; }

        /// <summary>
        /// Log source
        /// </summary>
        [JsonProperty("Source")]
        [System.Obsolete]
        public string Source{ get; set; }

        /// <summary>
        /// Number of retries.
        /// </summary>
        [JsonProperty("RetryNum")]
        public ulong? RetryNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
            this.SetParamSimple(map, prefix + "InvokeFinished", this.InvokeFinished);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "BillDuration", this.BillDuration);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "RetryNum", this.RetryNum);
        }
    }
}


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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Result : AbstractModel
    {
        
        /// <summary>
        /// It indicates the log output during the function execution. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// It indicates the response from the executed function. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// It indicates the error message of the executed function. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// It indicates the memory size (in bytes) when the function is running. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("MemUsage")]
        public long? MemUsage{ get; set; }

        /// <summary>
        /// It indicates the duration (in milliseconds) required for running the function. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// It indicates the billing duration (in milliseconds) for the function. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("BillDuration")]
        public long? BillDuration{ get; set; }

        /// <summary>
        /// ID of the executed function
        /// </summary>
        [JsonProperty("FunctionRequestId")]
        public string FunctionRequestId{ get; set; }

        /// <summary>
        /// `0` indicates successful execution. Null is returned for asynchronous invocations.
        /// </summary>
        [JsonProperty("InvokeResult")]
        public long? InvokeResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "BillDuration", this.BillDuration);
            this.SetParamSimple(map, prefix + "FunctionRequestId", this.FunctionRequestId);
            this.SetParamSimple(map, prefix + "InvokeResult", this.InvokeResult);
        }
    }
}


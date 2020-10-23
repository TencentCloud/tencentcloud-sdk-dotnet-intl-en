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

namespace TencentCloud.Dts.V20180330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSyncCheckJobResponse : AbstractModel
    {
        
        /// <summary>
        /// Task check status: starting, running, finished
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Code of the task check result
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Prompt message
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// Description of a task execution step
        /// </summary>
        [JsonProperty("StepInfo")]
        public SyncCheckStepInfo[] StepInfo{ get; set; }

        /// <summary>
        /// Check flag. 0: checking; 1: successfully checked
        /// </summary>
        [JsonProperty("CheckFlag")]
        public long? CheckFlag{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamArrayObj(map, prefix + "StepInfo.", this.StepInfo);
            this.SetParamSimple(map, prefix + "CheckFlag", this.CheckFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


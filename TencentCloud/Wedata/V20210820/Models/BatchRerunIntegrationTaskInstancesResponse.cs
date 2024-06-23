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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchRerunIntegrationTaskInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of Successfully Operated Tasks
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// Number of Failed Tasks
        /// </summary>
        [JsonProperty("FailedCount")]
        public long? FailedCount{ get; set; }

        /// <summary>
        /// Total Number of Tasks
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// What is actually passed is taskId
        /// </summary>
        [JsonProperty("TaskNames")]
        public string[] TaskNames{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailedCount", this.FailedCount);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArraySimple(map, prefix + "TaskNames.", this.TaskNames);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


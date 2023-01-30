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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRiskSyscallDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Basic information of the event
        /// </summary>
        [JsonProperty("EventBaseInfo")]
        public RunTimeEventBaseInfo EventBaseInfo{ get; set; }

        /// <summary>
        /// Process information
        /// </summary>
        [JsonProperty("ProcessInfo")]
        public ProcessDetailInfo ProcessInfo{ get; set; }

        /// <summary>
        /// Parent process information
        /// </summary>
        [JsonProperty("ParentProcessInfo")]
        public ProcessDetailBaseInfo ParentProcessInfo{ get; set; }

        /// <summary>
        /// Event description
        /// </summary>
        [JsonProperty("EventDetail")]
        public RiskSyscallEventDescription EventDetail{ get; set; }

        /// <summary>
        /// Ancestor process information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AncestorProcessInfo")]
        public ProcessBaseInfo AncestorProcessInfo{ get; set; }

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
            this.SetParamObj(map, prefix + "EventBaseInfo.", this.EventBaseInfo);
            this.SetParamObj(map, prefix + "ProcessInfo.", this.ProcessInfo);
            this.SetParamObj(map, prefix + "ParentProcessInfo.", this.ParentProcessInfo);
            this.SetParamObj(map, prefix + "EventDetail.", this.EventDetail);
            this.SetParamObj(map, prefix + "AncestorProcessInfo.", this.AncestorProcessInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


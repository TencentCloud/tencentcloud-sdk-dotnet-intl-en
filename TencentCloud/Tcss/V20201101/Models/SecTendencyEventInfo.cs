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

    public class SecTendencyEventInfo : AbstractModel
    {
        
        /// <summary>
        /// List of trends
        /// </summary>
        [JsonProperty("EventSet")]
        public RunTimeTendencyInfo[] EventSet{ get; set; }

        /// <summary>
        /// Event type:
        /// ET_ESCAPE: Container escape
        /// ET_REVERSE_SHELL: Reverse shell
        /// ET_RISK_SYSCALL: High-risk system calls
        /// ET_ABNORMAL_PROCESS: Abnormal process
        /// ET_ACCESS_CONTROL: File tampering
        /// ET_VIRUS: Trojan event
        /// ET_MALICIOUS_CONNECTION: Malicious connection event
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "EventSet.", this.EventSet);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
        }
    }
}


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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRiskEventsStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Operations - 0: Mark as Handled, 1: Ignore, 2: Delete Record, 3: Trojan Isolation, 4: Isolated Trojan Resumption, 5: Trojan Trust, 6: Trojan Untrust, 7: Kill Exceptional Process.
        /// </summary>
        [JsonProperty("Operate")]
        public ulong? Operate{ get; set; }

        /// <summary>
        /// Operation event types, file scan: MALWARE, exceptional login: HOST_LOGIN, password brute attack: BRUTE_ATTACK, malicious request: MALICIOUS_REQUEST, high-risk command: BASH_EVENT, local privilege escalation: PRIVILEGE_EVENT, reverse shell: REVERSE_SHELL, exceptional process: PROCESS.
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// An array of event IDs that need to be modified, and batch operation is supported.
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// Whether to update all, i.e. whether to operate on all events; this parameter is invalid when IDs are not left blank.
        /// </summary>
        [JsonProperty("UpdateAll")]
        public bool? UpdateAll{ get; set; }

        /// <summary>
        /// Excluded event ID: When operating on all events, this ID needs to be excluded.
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }

        /// <summary>
        /// When Operate is Trojan isolation, it indicates whether to kill the process, other operations are invalid
        /// </summary>
        [JsonProperty("KillProcess")]
        public bool? KillProcess{ get; set; }

        /// <summary>
        /// When RiskType is cross-region log-in and IDs are left blank, you can modify the status of events from all source IPs.
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// Filtering criteria. When RiskType is MALWARE.
        /// 1. When RiskType is MALWARE:
        /// <li>IpOrAlias - String - required: no - filter by host IP or alias</li>
        /// <li>FilePath - String - required: no - filter by path</li>
        /// <li>VirusName - String - required: no - filter by description</li>
        /// <li>CreateBeginTime - String - required: no - filter by creation time - start time</li>
        /// <li>CreateEndTime - String - required: no - filter by creation time - end time</li>
        /// <li>Status - String - required: no - filter by status: 4 - pending; 5 -- trusted; 6 - isolated; 10 - isolation in progress; 11 - recovering from isolation</li>
        /// When RiskType is PROCESS:
        /// Filter criteria
        /// <li>IpOrName - String - required: no - host IP or host name</li>
        /// <li>VirusName - String - required: no - virus name</li>
        /// <li>BeginTime - String - required: no - process startup time - begin</li>
        /// <li>BeginTime - String - required: no - process startup time - end</li>
        /// <li>Status - String - required: no - filter by status: 0 - pending; 1 - under detection; 2 - detected; 3 - exited; 4 - trusted</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "UpdateAll", this.UpdateAll);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
            this.SetParamSimple(map, prefix + "KillProcess", this.KillProcess);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}


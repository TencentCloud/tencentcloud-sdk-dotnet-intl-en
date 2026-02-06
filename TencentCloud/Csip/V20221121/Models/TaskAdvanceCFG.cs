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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskAdvanceCFG : AbstractModel
    {
        
        /// <summary>
        /// Port Risk Advanced Configuration
        /// </summary>
        [JsonProperty("PortRisk")]
        public PortRiskAdvanceCFGParamItem[] PortRisk{ get; set; }

        /// <summary>
        /// Advanced vulnerability scan configuration
        /// </summary>
        [JsonProperty("VulRisk")]
        public TaskCenterVulRiskInputParam[] VulRisk{ get; set; }

        /// <summary>
        /// Advanced weak password check configuration
        /// </summary>
        [JsonProperty("WeakPwdRisk")]
        public TaskCenterWeakPwdRiskInputParam[] WeakPwdRisk{ get; set; }

        /// <summary>
        /// Advanced configuration risk scan configuration
        /// </summary>
        [JsonProperty("CFGRisk")]
        public TaskCenterCFGRiskInputParam[] CFGRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PortRisk.", this.PortRisk);
            this.SetParamArrayObj(map, prefix + "VulRisk.", this.VulRisk);
            this.SetParamArrayObj(map, prefix + "WeakPwdRisk.", this.WeakPwdRisk);
            this.SetParamArrayObj(map, prefix + "CFGRisk.", this.CFGRisk);
        }
    }
}


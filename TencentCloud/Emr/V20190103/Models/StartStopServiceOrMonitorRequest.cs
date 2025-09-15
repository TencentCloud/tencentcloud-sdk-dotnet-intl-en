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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartStopServiceOrMonitorRequest : AbstractModel
    {
        
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The operation type. Valid values:
        /// <li>StartService: Start service</li>
        /// <li>StopService: Stop service</li>
        /// <li>StartMonitor: Start maintenance</li>
        /// <li>StopMonitor: Stop maintenance</li>
        /// <li>RestartService: Restart service. If this type is selected, "StrategyConfig" is required.</li>
        /// </summary>
        [JsonProperty("OpType")]
        public string OpType{ get; set; }

        /// <summary>
        /// The operation scope.
        /// </summary>
        [JsonProperty("OpScope")]
        public OpScope OpScope{ get; set; }

        /// <summary>
        /// The operation policy.
        /// </summary>
        [JsonProperty("StrategyConfig")]
        public StrategyConfig StrategyConfig{ get; set; }

        /// <summary>
        /// Parameters used for suspending services.
        /// </summary>
        [JsonProperty("StopParams")]
        public StopParams StopParams{ get; set; }

        /// <summary>
        /// This parameter is available only when OpType is <li>StopMonitor</li>. True indicates that the system enters the maintenance mode but still monitors processes without starting them.
        /// </summary>
        [JsonProperty("KeepMonitorButNotRecoverProcess")]
        public bool? KeepMonitorButNotRecoverProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpType", this.OpType);
            this.SetParamObj(map, prefix + "OpScope.", this.OpScope);
            this.SetParamObj(map, prefix + "StrategyConfig.", this.StrategyConfig);
            this.SetParamObj(map, prefix + "StopParams.", this.StopParams);
            this.SetParamSimple(map, prefix + "KeepMonitorButNotRecoverProcess", this.KeepMonitorButNotRecoverProcess);
        }
    }
}


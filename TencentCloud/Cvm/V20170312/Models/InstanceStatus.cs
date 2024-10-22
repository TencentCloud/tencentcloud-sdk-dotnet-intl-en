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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceStatus : AbstractModel
    {
        
        /// <summary>
        /// Instance `ID`.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance status. Valid values:<br><li>PENDING: Creating.<br></li><li>LAUNCH_FAILED: Creation failed.<br></li><li>RUNNING: Running.<br></li><li>STOPPED: Shut down.<br></li><li>STARTING: Starting up.<br></li><li>STOPPING: Shutting down.<br></li><li>REBOOTING: Restarting.<br></li><li>SHUTDOWN: Shut down and to be terminated.<br></li><li>TERMINATING: Terminating.<br></li><li>ENTER_RESCUE_MODE: Entering the rescue mode.<br></li><li>RESCUE_MODE: In the rescue mode.<br></li><li>EXIT_RESCUE_MODE: Exiting the rescue mode.<br></li><li>ENTER_SERVICE_LIVE_MIGRATE: Entering online service migration.<br></li><li>SERVICE_LIVE_MIGRATE: In online service migration.<br></li><li>EXIT_SERVICE_LIVE_MIGRATE: Exiting online service migration.<br></li>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
        }
    }
}


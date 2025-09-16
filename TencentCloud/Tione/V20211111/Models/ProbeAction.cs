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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProbeAction : AbstractModel
    {
        
        /// <summary>
        /// HTTP GET action.
        /// </summary>
        [JsonProperty("HTTPGet")]
        public HTTPGetAction HTTPGet{ get; set; }

        /// <summary>
        /// Executes check command action.
        /// </summary>
        [JsonProperty("Exec")]
        public ExecAction Exec{ get; set; }

        /// <summary>
        /// TCP Socket check action.
        /// </summary>
        [JsonProperty("TCPSocket")]
        public TCPSocketAction TCPSocket{ get; set; }

        /// <summary>
        /// Probe type. The default value is HTTPGet. Valid values: HTTPGet, Exec, and TCPSocket.
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HTTPGet.", this.HTTPGet);
            this.SetParamObj(map, prefix + "Exec.", this.Exec);
            this.SetParamObj(map, prefix + "TCPSocket.", this.TCPSocket);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}


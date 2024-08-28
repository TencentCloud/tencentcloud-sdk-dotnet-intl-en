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

    public class VulDefencePluginDetail : AbstractModel
    {
        
        /// <summary>
        /// ID of the injected process
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// Main class name of the injected process
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// Plugin status. 0: injecting; 1: injection successful; 2: plugin timed out, 3: plugin exited; 4: injection failed; 5: logically deleted.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Error log
        /// </summary>
        [JsonProperty("ErrorLog")]
        public string ErrorLog{ get; set; }

        /// <summary>
        /// Injection log
        /// </summary>
        [JsonProperty("InjectLog")]
        public string InjectLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorLog", this.ErrorLog);
            this.SetParamSimple(map, prefix + "InjectLog", this.InjectLog);
        }
    }
}


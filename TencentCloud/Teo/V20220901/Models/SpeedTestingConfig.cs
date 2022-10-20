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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeedTestingConfig : AbstractModel
    {
        
        /// <summary>
        /// The task type. Values:
        /// <li>`1`: Page performance</li>
        /// <li>`2`: File uploads</li>
        /// <li>`3`: File downloads</li>
        /// <li>`4`: Port performance</li>
        /// <li>`5`: Network quality</li>
        /// <li>`6`: Audio/Video experience</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// The URL.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// The user agent.
        /// </summary>
        [JsonProperty("UA")]
        public string UA{ get; set; }

        /// <summary>
        /// The network type.
        /// </summary>
        [JsonProperty("Connectivity")]
        public string Connectivity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "UA", this.UA);
            this.SetParamSimple(map, prefix + "Connectivity", this.Connectivity);
        }
    }
}


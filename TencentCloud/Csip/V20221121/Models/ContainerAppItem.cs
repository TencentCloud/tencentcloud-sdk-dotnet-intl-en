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

    public class ContainerAppItem : AbstractModel
    {
        
        /// <summary>
        /// Application comprehensive type, for example, web, app, or db
        /// </summary>
        [JsonProperty("MainType")]
        public string MainType{ get; set; }

        /// <summary>
        /// Specific application types, such as nginx or redis
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Application version number
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Running username.
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// Executable file path
        /// </summary>
        [JsonProperty("ExePath")]
        public string ExePath{ get; set; }

        /// <summary>
        /// Configuration file path
        /// </summary>
        [JsonProperty("ConfigPath")]
        public string ConfigPath{ get; set; }

        /// <summary>
        /// Number of associated processes
        /// </summary>
        [JsonProperty("ProcessCnt")]
        public long? ProcessCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MainType", this.MainType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "ExePath", this.ExePath);
            this.SetParamSimple(map, prefix + "ConfigPath", this.ConfigPath);
            this.SetParamSimple(map, prefix + "ProcessCnt", this.ProcessCnt);
        }
    }
}


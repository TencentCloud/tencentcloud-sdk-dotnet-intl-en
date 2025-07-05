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

namespace TencentCloud.Tem.V20201221.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MountedSettingConf : AbstractModel
    {
        
        /// <summary>
        /// Configuration Name
        /// </summary>
        [JsonProperty("ConfigDataName")]
        public string ConfigDataName{ get; set; }

        /// <summary>
        /// Mount point path
        /// </summary>
        [JsonProperty("MountedPath")]
        public string MountedPath{ get; set; }

        /// <summary>
        /// Configuration Content
        /// </summary>
        [JsonProperty("Data")]
        public Pair[] Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigDataName", this.ConfigDataName);
            this.SetParamSimple(map, prefix + "MountedPath", this.MountedPath);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
        }
    }
}


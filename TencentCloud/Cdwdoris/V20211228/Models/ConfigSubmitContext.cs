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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigSubmitContext : AbstractModel
    {
        
        /// <summary>
        /// Configuration file's name
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// New Base64-encoded content of the configuration file
        /// </summary>
        [JsonProperty("NewConfValue")]
        public string NewConfValue{ get; set; }

        /// <summary>
        /// Original Base64-encoded content of the configuration file
        /// </summary>
        [JsonProperty("OldConfValue")]
        public string OldConfValue{ get; set; }

        /// <summary>
        /// File path
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "NewConfValue", this.NewConfValue);
            this.SetParamSimple(map, prefix + "OldConfValue", this.OldConfValue);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
        }
    }
}


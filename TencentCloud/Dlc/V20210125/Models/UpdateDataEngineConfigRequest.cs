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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateDataEngineConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// Engine ID
        /// </summary>
        [JsonProperty("DataEngineIds")]
        public string[] DataEngineIds{ get; set; }

        /// <summary>
        /// Commands of engine configuration. UpdateSparkSQLLakefsPath (updates the configuration of the native table) and UpdateSparkSQLResultPath (updates the configuration of the result path) are supported.
        /// </summary>
        [JsonProperty("DataEngineConfigCommand")]
        public string DataEngineConfigCommand{ get; set; }

        /// <summary>
        /// Whether to use lakeFS as result storage
        /// </summary>
        [JsonProperty("UseLakeFs")]
        public bool? UseLakeFs{ get; set; }

        /// <summary>
        /// User-defined result path
        /// </summary>
        [JsonProperty("CustomResultPath")]
        public string CustomResultPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DataEngineIds.", this.DataEngineIds);
            this.SetParamSimple(map, prefix + "DataEngineConfigCommand", this.DataEngineConfigCommand);
            this.SetParamSimple(map, prefix + "UseLakeFs", this.UseLakeFs);
            this.SetParamSimple(map, prefix + "CustomResultPath", this.CustomResultPath);
        }
    }
}


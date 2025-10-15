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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SQLScriptConfig : AbstractModel
    {
        
        /// <summary>
        /// Data source Id.
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// Specifies the data source environment.
        /// </summary>
        [JsonProperty("DatasourceEnv")]
        public string DatasourceEnv{ get; set; }

        /// <summary>
        /// Computational resource.
        /// </summary>
        [JsonProperty("ComputeResource")]
        public string ComputeResource{ get; set; }

        /// <summary>
        /// Specifies the execution resource group.
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// Advanced running parameter variable replacement map-json String,String.
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// Advanced setting. executes configuration parameters. map-json String,String. use Base64 encode.
        /// </summary>
        [JsonProperty("AdvanceConfig")]
        public string AdvanceConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatasourceEnv", this.DatasourceEnv);
            this.SetParamSimple(map, prefix + "ComputeResource", this.ComputeResource);
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "AdvanceConfig", this.AdvanceConfig);
        }
    }
}


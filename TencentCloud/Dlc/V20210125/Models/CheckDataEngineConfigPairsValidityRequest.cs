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

    public class CheckDataEngineConfigPairsValidityRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the minor version of the engine
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// User-defined parameters
        /// </summary>
        [JsonProperty("DataEngineConfigPairs")]
        public DataEngineConfigPair[] DataEngineConfigPairs{ get; set; }

        /// <summary>
        /// ID of the major version of the engine. If there is the ID of the minor version, only the ID of the minor version needs to be input. If not, the latest ID of the minor version under the major version will be acquired.
        /// </summary>
        [JsonProperty("ImageVersionId")]
        public string ImageVersionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamArrayObj(map, prefix + "DataEngineConfigPairs.", this.DataEngineConfigPairs);
            this.SetParamSimple(map, prefix + "ImageVersionId", this.ImageVersionId);
        }
    }
}


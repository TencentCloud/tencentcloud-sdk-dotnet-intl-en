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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBlueprintsRequest : AbstractModel
    {
        
        /// <summary>
        /// Image ID list.
        /// </summary>
        [JsonProperty("BlueprintIds")]
        public string[] BlueprintIds{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, please see the relevant section in [Overview](https://intl.cloud.tencent.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, please see the relevant section in the API [Overview](https://intl.cloud.tencent.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter list.
        /// <li>blueprint-id</li>Filter by the **image ID**.
        /// Type: String
        /// Required: no
        /// <li>blueprint-type</li>Filter by the **image type**.
        /// Valid values: `APP_OS` (application image), `PURE_OS` (system image), `DOCKER` (Docker container image), `PRIVATE` (custom image), `SHARED` (shared image)
        /// Type: String
        /// Required: no
        /// <li>platform-type</li>Filter by the **image operating system**.
        /// Valid values: `LINUX_UNIX` (Linux or Unix), `WINDOWS` (Windows)
        /// Type: String
        /// Required: no
        /// <li>blueprint-name</li>Filter by the **image name**.
        /// Type: String
        /// Required: no
        /// <li>blueprint-state</li>Filter by the **image status**.
        /// Type: String
        /// Required: no
        /// <li>scene-id</li>Filter by the **scene ID**.
        /// Type: String
        /// Required: no
        /// 
        /// Each request can contain up to 10 `Filters`, each of which can contain up to 100 `Filter.Values`. `BlueprintIds` and `Filters` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BlueprintIds.", this.BlueprintIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}


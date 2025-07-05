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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmMetricRecord : AbstractModel
    {
        
        /// <summary>
        /// Field array, used for the query result of indicators.
        /// </summary>
        [JsonProperty("Fields")]
        public ApmField[] Fields{ get; set; }

        /// <summary>
        /// Tag array, used to distinguish the objects of groupby.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}


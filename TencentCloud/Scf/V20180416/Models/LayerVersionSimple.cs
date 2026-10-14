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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LayerVersionSimple : AbstractModel
    {
        
        /// <summary>
        /// Name of the bound layer. Pass an empty string to unbind the layer.
        /// </summary>
        [JsonProperty("LayerName")]
        public string LayerName{ get; set; }

        /// <summary>
        /// Bind or unbind a layer version. To unbind the last layer version associated with a function version, set LayerVersion to 0.
        /// </summary>
        [JsonProperty("LayerVersion")]
        public long? LayerVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamSimple(map, prefix + "LayerVersion", this.LayerVersion);
        }
    }
}


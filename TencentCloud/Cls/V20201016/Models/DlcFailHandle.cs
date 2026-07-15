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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcFailHandle : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to store in DLC</p><p>Default value: false</p><p>Controls whether to enable storing delivery failure logs in DLC tables</p>
        /// </summary>
        [JsonProperty("StoreToDlc")]
        public bool? StoreToDlc{ get; set; }

        /// <summary>
        /// <p>DLC table information</p>
        /// </summary>
        [JsonProperty("DlcFailTableInfo")]
        public DlcFailTableInfo DlcFailTableInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StoreToDlc", this.StoreToDlc);
            this.SetParamObj(map, prefix + "DlcFailTableInfo.", this.DlcFailTableInfo);
        }
    }
}


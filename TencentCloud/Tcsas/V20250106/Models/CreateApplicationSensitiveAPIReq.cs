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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationSensitiveAPIReq : AbstractModel
    {
        
        /// <summary>
        /// <p>API name</p>
        /// </summary>
        [JsonProperty("APIName")]
        public string APIName{ get; set; }

        /// <summary>
        /// <p>API description</p>
        /// </summary>
        [JsonProperty("APIDesc")]
        public string APIDesc{ get; set; }

        /// <summary>
        /// <p>API type. Valid values: 1: System; 2: Custom</p>
        /// </summary>
        [JsonProperty("APIType")]
        public long? APIType{ get; set; }

        /// <summary>
        /// <p>Applicable scope: Valid values: 0: Mini program; 1: Mini game; 100: Universal</p>
        /// </summary>
        [JsonProperty("UseScope")]
        public ulong? UseScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "APIName", this.APIName);
            this.SetParamSimple(map, prefix + "APIDesc", this.APIDesc);
            this.SetParamSimple(map, prefix + "APIType", this.APIType);
            this.SetParamSimple(map, prefix + "UseScope", this.UseScope);
        }
    }
}


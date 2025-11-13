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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateSmartErasePrivacyConfig : AbstractModel
    {
        
        /// <summary>
        /// Erasing method of privacy protection.
        /// - blur
        /// - mosaic
        /// </summary>
        [JsonProperty("PrivacyModel")]
        public string PrivacyModel{ get; set; }

        /// <summary>
        /// Privacy protection target. (When API Explorer is used, it is not required to specify an array. Add the corresponding items and enter the corresponding values.)
        /// - face: human face.
        /// - plate: license plate.
        /// </summary>
        [JsonProperty("PrivacyTargets")]
        public string[] PrivacyTargets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PrivacyModel", this.PrivacyModel);
            this.SetParamArraySimple(map, prefix + "PrivacyTargets.", this.PrivacyTargets);
        }
    }
}


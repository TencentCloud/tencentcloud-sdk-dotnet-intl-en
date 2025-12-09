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

namespace TencentCloud.Controlcenter.V20230110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependsOnItem : AbstractModel
    {
        
        /// <summary>
        /// Dependency type. valid values: LandingZoneSetUp or AccountFactorySetUp. LandingZoneSetUp refers to the dependency of landingZone. AccountFactorySetUp refers to the dependency of account factory.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Specifies the unique identifier for the feature item, can only contain english letters, digits, and @, ,._[]-:()()[]+=., with a length of 2-128 characters.
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
        }
    }
}


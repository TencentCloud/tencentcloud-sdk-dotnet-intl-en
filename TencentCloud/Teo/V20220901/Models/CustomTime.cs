/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomTime : AbstractModel
    {
        
        /// <summary>
        /// Custom cache time switch. values:.
        /// <Li>`On`: enable;</li>
        /// .
        /// <Li>Off: disable.</li>.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Ignore origin server cachecontrol switch. values:.
        /// <Li>`On`: enable;</li>
        /// .
        /// <Li>Off: disable.</li> note: this field is required when `switch` is on. when `switch` is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("IgnoreCacheControl")]
        public string IgnoreCacheControl{ get; set; }

        /// <summary>
        /// Custom cache time value, unit: seconds. value range: 0-315360000.<br>note: this field is required when switch is on; when switch is off, this field is not required and will not take effect if filled.
        /// </summary>
        [JsonProperty("CacheTime")]
        public long? CacheTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "IgnoreCacheControl", this.IgnoreCacheControl);
            this.SetParamSimple(map, prefix + "CacheTime", this.CacheTime);
        }
    }
}


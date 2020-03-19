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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableZone : AbstractModel
    {
        
        /// <summary>
        /// AZ name
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// AZ ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Chinese name of an AZ
        /// </summary>
        [JsonProperty("ZoneCnName")]
        public string ZoneCnName{ get; set; }

        /// <summary>
        /// Array of classes
        /// </summary>
        [JsonProperty("Types")]
        public AvailableType[] Types{ get; set; }

        /// <summary>
        /// Chinese and English names of an AZ
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneCnName", this.ZoneCnName);
            this.SetParamArrayObj(map, prefix + "Types.", this.Types);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
        }
    }
}


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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetCptListRequest : AbstractModel
    {
        
        /// <summary>
        /// The start.
        /// </summary>
        [JsonProperty("DisplayStart")]
        public ulong? DisplayStart{ get; set; }

        /// <summary>
        /// The maximum number of records to return.
        /// </summary>
        [JsonProperty("DisplayLength")]
        public ulong? DisplayLength{ get; set; }

        /// <summary>
        /// The type. `0`: All CPTs; `1`: System CPTs; `2`: Authorization CPTs; `3`: General CPTs
        /// </summary>
        [JsonProperty("CptType")]
        public ulong? CptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplayStart", this.DisplayStart);
            this.SetParamSimple(map, prefix + "DisplayLength", this.DisplayLength);
            this.SetParamSimple(map, prefix + "CptType", this.CptType);
        }
    }
}


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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiPathGatewayOriginACLInfo : AbstractModel
    {
        
        /// <summary>
        /// Currently effective origin-pull IP range.
        /// </summary>
        [JsonProperty("MultiPathGatewayCurrentOriginACL")]
        public MultiPathGatewayCurrentOriginACL MultiPathGatewayCurrentOriginACL{ get; set; }

        /// <summary>
        /// When the origin-pull IP range is updated, this field will return the origin-pull IP range that will take effect in the next version, including a contrast with the current origin-pull IP range. If there is no update, this field is empty.
        /// </summary>
        [JsonProperty("MultiPathGatewayNextOriginACL")]
        public MultiPathGatewayNextOriginACL MultiPathGatewayNextOriginACL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MultiPathGatewayCurrentOriginACL.", this.MultiPathGatewayCurrentOriginACL);
            this.SetParamObj(map, prefix + "MultiPathGatewayNextOriginACL.", this.MultiPathGatewayNextOriginACL);
        }
    }
}


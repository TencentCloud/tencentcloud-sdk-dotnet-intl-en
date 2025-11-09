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
        /// Describes the currently effective IP range for origin servers.
        /// </summary>
        [JsonProperty("MultiPathGatewayCurrentOriginACL")]
        public MultiPathGatewayCurrentOriginACL MultiPathGatewayCurrentOriginACL{ get; set; }

        /// <summary>
        /// When the origin IP range is updated, this field will be returned with the next version's effective origin IP range, including a comparison with the current origin IP range. this field is empty if not updated.
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


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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FwCidrInfo : AbstractModel
    {
        
        /// <summary>
        /// The IP range type of the firewall. Values: `VpcSelf` (VPC IP range preferred); `Assis` (Secondary IP range preferred); `Custom` (Custom IP range)
        /// </summary>
        [JsonProperty("FwCidrType")]
        public string FwCidrType{ get; set; }

        /// <summary>
        /// The IP segment assigned for each VPC.
        /// </summary>
        [JsonProperty("FwCidrLst")]
        public FwVpcCidr[] FwCidrLst{ get; set; }

        /// <summary>
        /// The IP segment used by other firewalls. Specify this if you want to assign a dedicated segment for the firewall.
        /// </summary>
        [JsonProperty("ComFwCidr")]
        public string ComFwCidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwCidrType", this.FwCidrType);
            this.SetParamArrayObj(map, prefix + "FwCidrLst.", this.FwCidrLst);
            this.SetParamSimple(map, prefix + "ComFwCidr", this.ComFwCidr);
        }
    }
}


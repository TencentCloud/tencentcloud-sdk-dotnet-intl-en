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

    public class CreateSharedCNAMERequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site associated with the shared CNAME.	
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Share the CNAME prefix. Enter a valid domain name prefix, for example, "test-api" or "test-api.com", limited to 50 characters.
        /// 
        /// The full format of a shared CNAME is: `<custom prefix>+<12-bit random string in zoneid>+share.dnse[0-5].com`.
        /// 
        /// For example, if the prefix input is example.com, EdgeOne will create a shared CNAME for you: example.com.sai2ig51kaa5.share.dnse2.com.
        /// </summary>
        [JsonProperty("SharedCNAMEPrefix")]
        public string SharedCNAMEPrefix{ get; set; }

        /// <summary>
        /// Description. Enter 1-50 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "SharedCNAMEPrefix", this.SharedCNAMEPrefix);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


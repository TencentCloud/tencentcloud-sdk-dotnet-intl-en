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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DnsDataFilter : AbstractModel
    {
        
        /// <summary>
        /// Parameter name. Valid values:
        /// `zone`: Site name
        /// `host`: Domain name
        /// `type`: DNS resolution type
        /// `code`: DNS response code
        /// `area`: Region of the resolution server
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Parameter value
        /// When `Name=area`, valid values:
        /// `Asia`
        /// `Europe`
        /// `Africa`
        /// `Oceania`
        /// `Americas`
        /// 
        /// When `Name=code`, valid values:
        /// `NoError`: Successful response.
        /// `NXDomain`: Non-existent domain in the request. It is only valid when the response is from the authoritative name server.
        /// `NotImp`: Request type not supported.
        /// `Refused`: The name server refuses to perform the requested operation for policy reasons.
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// Parameter value
        /// When `Name=area`, valid values:
        /// `Asia`
        /// `Europe`
        /// `Africa`
        /// `Oceania`
        /// `Americas`
        /// 
        /// When `Name=code`, valid values:
        /// `NoError`: Successful response.
        /// `NXDomain`: Non-existent domain in the request. It is only valid when the response is from the authoritative name server.
        /// `NotImp`: Request type not supported.
        /// `Refused`: The name server refuses to perform the requested operation for policy reasons.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}


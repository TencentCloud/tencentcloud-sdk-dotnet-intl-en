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

    public class Identification : AbstractModel
    {
        
        /// <summary>
        /// The site name.
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// The subdomain name to be verified. To verify the ownership of a site, leave it blank.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// The verification status. Values:
        /// <li>`pending`: The verification is ongoing.</li>
        /// <li>`finished`: The verification completed.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Details of the DNS record.
        /// </summary>
        [JsonProperty("Ascription")]
        public AscriptionInfo Ascription{ get; set; }

        /// <summary>
        /// The NS record of the domain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// Details of the verification file.
        /// </summary>
        [JsonProperty("FileAscription")]
        public FileAscriptionInfo FileAscription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Ascription.", this.Ascription);
            this.SetParamArraySimple(map, prefix + "OriginalNameServers.", this.OriginalNameServers);
            this.SetParamObj(map, prefix + "FileAscription.", this.FileAscription);
        }
    }
}


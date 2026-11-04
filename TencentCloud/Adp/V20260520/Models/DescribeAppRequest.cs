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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAppRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Application ID.</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>Application domain: ADP_DOMAIN_DEV(1)=development domain, ADP_DOMAIN_PROD(2)=release domain. Enumeration values: 1: development domain, 2: production domain</p>
        /// </summary>
        [JsonProperty("Domain")]
        public long? Domain{ get; set; }

        /// <summary>
        /// <p>Field mask, specify the fields to return (return all fields if Paths is empty). Paths enumeration values: AppConfig (application configuration), SecretInfo (application key info), ShareUrlInfo (sharing link information), SpecialStatusInfo (special status information), SearchResourceStatus (search resource status), SharedKbList (list of shared knowledge bases referenced by the application), CorpShareConfig (corporate shared configuration), FileVolumeMountList (cloud disk mount list)</p>
        /// </summary>
        [JsonProperty("FieldMask")]
        public FieldMask FieldMask{ get; set; }

        /// <summary>
        /// <p>Specific status type (required when FieldMask includes SpecialStatusInfo). Enumeration values: 1: rollback status, 2: first-time import status</p>
        /// </summary>
        [JsonProperty("StatusType")]
        public long? StatusType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "FieldMask.", this.FieldMask);
            this.SetParamSimple(map, prefix + "StatusType", this.StatusType);
        }
    }
}


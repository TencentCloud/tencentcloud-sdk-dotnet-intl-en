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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryT1IndirectCustomersDetailResponseData : AbstractModel
    {
        
        /// <summary>
        /// Customer uin.
        /// </summary>
        [JsonProperty("ClientUin")]
        public long? ClientUin{ get; set; }

        /// <summary>
        /// Customer name.
        /// </summary>
        [JsonProperty("ClientName")]
        public string ClientName{ get; set; }

        /// <summary>
        /// The time when a sub-customer binds a second-level reseller, time zone: UTC+08:00.
        /// </summary>
        [JsonProperty("ClientBindTime")]
        public string ClientBindTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ClientName", this.ClientName);
            this.SetParamSimple(map, prefix + "ClientBindTime", this.ClientBindTime);
        }
    }
}


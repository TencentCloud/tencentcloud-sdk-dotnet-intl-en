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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloseDBExtranetAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID in the format of postgres-6r233v55
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// Whether to disable public network access over IPv6 address. Valid values: 1 (yes), 0 (no)
        /// </summary>
        [JsonProperty("IsIpv6")]
        public long? IsIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "IsIpv6", this.IsIpv6);
        }
    }
}


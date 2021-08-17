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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApiAppRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique application ID.
        /// </summary>
        [JsonProperty("ApiAppId")]
        public string ApiAppId{ get; set; }

        /// <summary>
        /// Modified application name
        /// </summary>
        [JsonProperty("ApiAppName")]
        public string ApiAppName{ get; set; }

        /// <summary>
        /// Modified application description
        /// </summary>
        [JsonProperty("ApiAppDesc")]
        public string ApiAppDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiAppId", this.ApiAppId);
            this.SetParamSimple(map, prefix + "ApiAppName", this.ApiAppName);
            this.SetParamSimple(map, prefix + "ApiAppDesc", this.ApiAppDesc);
        }
    }
}


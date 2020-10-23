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

    public class ReleaseServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of the service to be published.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Name of the environment to be published. Valid values: test (test environment), prepub (pre-release environment), release (release environment).
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// Release description.
        /// </summary>
        [JsonProperty("ReleaseDesc")]
        public string ReleaseDesc{ get; set; }

        /// <summary>
        /// `apiId` list, which is reserved. Full API release is used by default.
        /// </summary>
        [JsonProperty("ApiIds")]
        public string[] ApiIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "ReleaseDesc", this.ReleaseDesc);
            this.SetParamArraySimple(map, prefix + "ApiIds.", this.ApiIds);
        }
    }
}

